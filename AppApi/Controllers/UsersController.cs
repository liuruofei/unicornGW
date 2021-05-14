using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ADT.Common;
using Microsoft.AspNetCore.Mvc;
using ADT.Service.IService;
using ADT.Models;
using AppApi.Models;
using AppApi.Filter;
using Microsoft.AspNetCore.Authorization;
using log4net;
using AppApi.Models.Req;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using System.IO;
using System.Security.Claims;

namespace AppApi.Controllers
{
    [Route("api/")]
    [Authorize]
    [HttpGlobalException]
    public class UsersController : Controller
    {
        private ILog log = LogManager.GetLogger(Startup.repository.Name, "RollingLogFileAppender");
        private ICurrencyService _currencyService;
        public UsersController(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
        }
        #region 获取用户信息
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("getuserinfo")]
        public IActionResult GetUserInfo()
        {
            YS_User_Enter info = null;
            string accountName = string.Empty;
            int accountId = 0;
            List<Claim> list = this.User.Claims.ToList();
            if (list != null && list.Count > 0)
            {
                accountId = list[0].Value.ToInt32();
                accountName = list[1].Value.ToString();
            }
            MessageDataResult _json = new MessageDataResult();
            var accountUser = _currencyService.DbAccess().Queryable<YS_Account_User>().Where(y => y.Account_Name.Equals(accountName) && y.Status == 0).First();
            if (accountUser != null && !string.IsNullOrEmpty(accountUser.Mobile))
            {
                info = _currencyService.DbAccess().Queryable<YS_User_Enter>().Where(p => p.Mobile == accountUser.Mobile && p.Status == 0).First();
            }
            _json.status = 200;
            _json.msg = "操作成功";
            _json.data = info;
            return Json(_json);
        }
        #endregion 



        #region 用户报名
        /// <summary>
        ///用户报名
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("saveysuser")]
        public IActionResult SaveYSUser([FromBody] EnterYsUserQuery data)
        {
            string accountName = string.Empty;
            int accountId = 0;
            List<Claim> list = this.User.Claims.ToList();
            if (list != null && list.Count > 0)
            {
                accountId = list[0].Value.ToInt32();
                accountName = list[1].Value.ToString();
            }
            MessageDataResult _json = new MessageDataResult();
            if (data != null)
            {
                var accountUser = _currencyService.DbAccess().Queryable<YS_Account_User>().Where(y => y.Account_Name.Equals(accountName) && y.Status == 0).First();
                if (accountUser != null && !string.IsNullOrEmpty(accountUser.Mobile))
                {
                    var userinfo = _currencyService.DbAccess().Queryable<YS_User_Enter>().Where(p => p.Mobile == accountUser.Mobile && p.Status == 0).First();
                    //如果初级驳回则重新更新
                    if (userinfo.AuditStatus == (int)ApiUserAuditEnum.AuditFaill)
                    {
                        if (!accountUser.Mobile.Equals(data.Mobile))
                        {
                            _json.status = 0;
                            _json.msg = "输入手机号码请和原来保持一致";
                            return Json(_json);
                        }
                        //获取验证码
                        var verifyCodeInfo = _currencyService.DbAccess().Queryable<YS_VerifyCode_Record>().Where(p => p.Mobile == data.Mobile && p.Status == 0).OrderBy(x => x.CreateTime, SqlSugar.OrderByType.Desc).First();
                        if (verifyCodeInfo == null || string.IsNullOrEmpty(data.VerifyCode))
                        {
                            _json.status = 0;
                            _json.msg = "验证码不能为空";
                            return Json(_json);
                        }
                        if (verifyCodeInfo != null && !verifyCodeInfo.VerifyCode.Equals(data.VerifyCode))
                        {
                            _json.status = 0;
                            _json.msg = "验证码不正确！请重新输入";
                            return Json(_json);
                        }
                        int result = _currencyService.DbAccess().Updateable<YS_User_Enter>(item => new YS_User_Enter()
                        {
                            UpdateTime = DateTime.Now,
                            UserName = data.UserName,
                            AuditStatus = (int)ApiUserAuditEnum.WatingAudit,
                            Enter_OrganIzation = data.Enter_OrganIzation,
                            History_Max_Listen = data.History_Max_Listen,
                            History_Max_Reder = data.History_Max_Reder,
                            History_Max_Talk = data.History_Max_Talk,
                            History_Max_Total = data.History_Max_Total,
                            History_Max_Write = data.History_Max_Write,
                            Last_Max_Total = data.Last_Max_Total,
                            Last_Max_Listen = data.Last_Max_Listen,
                            Last_Max_Reder = data.Last_Max_Reder,
                            Last_Max_Talk = data.Last_Max_Talk,
                            Last_Max_Write = data.Last_Max_Write,
                            ID_Card_Back = data.ID_Card_Back,
                            ID_Card_Front = data.ID_Card_Front,
                            IsChecked = data.IsChecked
                        }).Where(y => y.UsersID == userinfo.UsersID).ExecuteCommand();
                        if (result > 0)
                        {
                            _json.status = 200;
                            _json.msg = "提交数据成功，请等待后台再次确认";
                        }
                        else
                        {
                            _json.status = 0;
                            _json.msg = "提交数据失败!数据异常";
                        }

                    }
                    //初级审核通过或者终极审核被驳回则更新第二段数据
                    if (userinfo.AuditStatus == (int)ApiUserAuditEnum.AuditSuccess || userinfo.AuditStatus == (int)ApiUserAuditEnum.AuditUltimateFaill)
                    {
                        int result = _currencyService.DbAccess().Updateable<YS_User_Enter>()
                            .SetColumns(item => new YS_User_Enter()
                            {
                                IsFirst = data.IsFirst,
                                Last_Score_Img_Url = data.Last_Score_Img_Url,
                                Last_Join_Time = data.Last_Join_Time,
                                Sign_Contract = data.Sign_Contract,
                                Join_Address = data.Join_Address,
                                Join_date = data.Join_date,
                                ScoreRange=data.ScoreRange,
                                ExaminationPlace=data.ExaminationPlace,
                                Certificate_Img_Url = data.Certificate_Img_Url,
                                UpdateTime = DateTime.Now,
                                AuditStatus = (int)ApiUserAuditEnum.UploadSuccess
                            }).Where(c => c.UsersID == userinfo.UsersID).ExecuteCommand();
                        if (result > 0)
                        {
                            _json.status = 200;
                            _json.msg = "上传数据成功，请等待后台再次确认";
                        }
                        else
                        {
                            _json.status = 0;
                            _json.msg = "上传数据失败!数据异常";
                        }
                    }
                }
                else
                {
                    //获取验证码
                    var verifyCodeInfo = _currencyService.DbAccess().Queryable<YS_VerifyCode_Record>().Where(p => p.Mobile == data.Mobile && p.Status == 0).OrderBy(x => x.CreateTime, SqlSugar.OrderByType.Desc).First();
                    var userinfo = _currencyService.DbAccess().Queryable<YS_User_Enter>().Where(p => p.Mobile == data.Mobile && p.Status == 0).First();
                    if (userinfo != null)
                    {
                        _json.status = 0;
                        _json.msg = "该手机号码已注册！请更换手机号码";
                        return Json(_json);
                    }
                    if (verifyCodeInfo == null || string.IsNullOrEmpty(data.VerifyCode))
                    {
                        _json.status = 0;
                        _json.msg = "验证码不能为空";
                        return Json(_json);
                    }
                    if (verifyCodeInfo != null && !verifyCodeInfo.VerifyCode.Equals(data.VerifyCode))
                    {
                        _json.status = 0;
                        _json.msg = "验证码不正确！请重新输入";
                        return Json(_json);
                    }
                    var result = _currencyService.DbAccess().UseTran(() =>
                    {
                        YS_User_Enter model = new YS_User_Enter();
                        model.CreateTime = DateTime.Now;
                        model.UpdateTime = DateTime.Now;
                        model.Mobile = data.Mobile;
                        model.UserName = data.UserName;
                        model.AuditStatus = (int)ApiUserAuditEnum.WatingAudit;
                        model.Enter_OrganIzation = data.Enter_OrganIzation;
                        model.History_Max_Listen = data.History_Max_Listen;
                        model.History_Max_Reder = data.History_Max_Reder;
                        model.History_Max_Talk = data.History_Max_Talk;
                        model.History_Max_Total = data.History_Max_Total;
                        model.History_Max_Write = data.History_Max_Write;
                        model.Last_Max_Total = data.Last_Max_Total;
                        model.Last_Max_Listen = data.Last_Max_Listen;
                        model.Last_Max_Reder = data.Last_Max_Reder;
                        model.Last_Max_Talk = data.Last_Max_Talk;
                        model.Last_Max_Write = data.Last_Max_Write;
                        model.ID_Card_Back = data.ID_Card_Back;
                        model.ID_Card_Front = data.ID_Card_Front;
                        model.IsChecked = data.IsChecked;
                        _currencyService.DbAccess().Insertable<YS_User_Enter>(model).ExecuteCommand();
                        //注册并绑定手机
                        _currencyService.DbAccess().Updateable<YS_Account_User>().SetColumns(item => new YS_Account_User()
                        {
                            Mobile = data.Mobile,
                            IsUseed = 1

                        }).Where(y => y.Account_Name.Equals(accountName)).ExecuteCommand();
                    });
                    if (result.IsSuccess)
                    {
                        _json.status = 200;
                        _json.msg = "保存成功!请等待后台审核";
                    }

                }
            }
            else
            {
                _json.status = 0;
                _json.msg = "请把报名相关信息填写完整。";
            }
            return Json(_json);
        }
        #endregion

        #region
        /// <summary>
        /// 发送验证码
        /// </summary>
        /// <param name="mobile"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("sendverifycode")]
        public IActionResult SendVerifyCode(string mobile)
        {
            MessageDataResult _json = new MessageDataResult();
            if (string.IsNullOrEmpty(mobile))
                return Json(new { status = 0, msg = "请输入手机号！" });
            var time = DateTime.Now;
            Random rd = new Random();
            string verifycode = Convert.ToString(rd.Next(1000, 9999));
            //发送验证码
            bool result = SMSHelper.SendSmsVerfiyCode(mobile, verifycode);
            if (result)
            {
                YS_VerifyCode_Record model = new YS_VerifyCode_Record()
                {
                    CreateTime = time,
                    Mobile = mobile,
                    Status = 0,
                    SendDateTime = time,
                    VerifyStatus = 0,
                    VerifyCode = verifycode,
                    VerifyDateTime = time.AddMinutes(1)
                };
                _currencyService.DbAccess().Insertable<YS_VerifyCode_Record>(model).ExecuteCommand();
                _json.status = 200;
                _json.msg = "发送短信成功!";
            }
            else
            {
                _json.status = 0;
                _json.msg = "短信发送失败";
            }
            return Json(_json);
        }
        #endregion



        #region  上传图片
        [HttpPost]
        [RequestSizeLimit(9999_000_000)]
        [Route("uploadfile")]
        public IActionResult UpLoadFile([FromForm] IFormCollection formCollection, string exits = ".jpg|.png|.gif|.jpeg")
        {
            string path = "";
            if (string.IsNullOrEmpty(exits))
                return Json(new { code = 1, msg = "无效扩展名" });
            FormFileCollection filelist = (FormFileCollection)formCollection.Files;
            ContentResult errResult = new ContentResult();
            foreach (IFormFile file in filelist)
            {
                HandleUpFile(file, exits.Split('|'), (files) =>
                {
                    string ExtensionName = Path.GetExtension(files.FileName).ToLower().Trim();//获取后缀名
                    if (exits.Split('|') != null && !exits.Split('|').Contains(ExtensionName.ToLower()))
                    {
                        errResult = new ContentResult()
                        {
                            StatusCode = 200,
                            Content = "{\"code\":1,\"msg\":\"请上传后缀名为：" + string.Join("、", exits.Split('|')) + " 格式的文件\"}",
                            ContentType = "application/json"
                        };
                        //throw new MessageBox("请上传后缀名为：" + string.Join("、", Format) + " 格式的文件");
                    }
                }, (_Path) =>
                {
                    path = _Path;
                });
            }
            if (errResult != null && !string.IsNullOrEmpty(errResult.Content))
            {
                return errResult;
            }
            return Json(new { code = 0, data = path });
        }


        /// <summary>
        /// 处理上传文件
        /// </summary>
        /// <param name="_HttpPostedFileBase"></param>
        /// <param name="Format">文件格式</param>
        /// <param name="Check">执行前 验证回调</param>
        /// <param name="CallBack">如果有回调则保存 否则不保存</param>
        public void HandleUpFile(IFormFile _IFormFile, string[] Format, Action<IFormFile> Check = null, Action<string> CallBack = null)
        {
            var _webRootPath = ConfigHelper.GetConfig("FilePath");
            if (Check != null) Check(_IFormFile);

            string ExtensionName = Path.GetExtension(_IFormFile.FileName).ToLower().Trim();//获取后缀名

            if (Format != null && !Format.Contains(ExtensionName.ToLower()))
            {
                new ContentResult()
                {
                    StatusCode = 200,
                    Content = "{\"code\":1,\"msg\":\"请上传后缀名为：" + string.Join("、", Format) + " 格式的文件\"}",
                    ContentType = "application/json"
                };
                //throw new MessageBox("请上传后缀名为：" + string.Join("、", Format) + " 格式的文件");
            }

            if (CallBack != null)
            {
                var catalog = DateTime.Now.ToString("yyyyMMdd");
                var path = $"{_webRootPath}\\file\\{catalog}\\";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                string filePath = $"/file/{catalog}/{Guid.NewGuid() + ExtensionName}";
                // 创建新文件
                using (FileStream fs = System.IO.File.Create(_webRootPath + filePath))
                {
                    _IFormFile.CopyTo(fs);
                    // 清空缓冲区数据
                    fs.Flush();
                }

                CallBack($"/upload{filePath}");
            }
        }

        #endregion


    }
}
