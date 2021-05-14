﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ADT.Models;
using ADT.Service.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebManager.Areas.Admin.Filter;
using WebManager.Areas.Admin.Models;
using ADT.Common;
using System.Data;
using SqlSugar;
using System.Drawing;
using ADT.Models.ResModel;

namespace WebManager.Areas.Admin.Controllers.Manage
{
    [Authorize]
    public class UsersController : BaseController
    {
        private ICurrencyService _currencyService;
        public UsersController( ICurrencyService currencyService)
        {
            _currencyService = currencyService;

        }
        protected override void Init()
        {
            this.MenuID = "A-107";
        }
        // GET: /<controller>/
        [UsersRoleAuthFilter("A-107", FunctionEnum.Have)]
        public IActionResult Index()
        {
            return View();
        }

        [UsersRoleAuthFilter("A-107", FunctionEnum.Have)]
        public IActionResult GetDataSource(string title, int page = 1, int limit = 10)
        {
            int total = 0;
            PageList<RegionUserRes> pageModel = new PageList<RegionUserRes>();
            var list = _currencyService.DbAccess().Queryable<YNK_Region,YNK_Materia>((r,m)=>new object[]{JoinType.Left,r.MaterialId==m.MaterialId}).WhereIF(!string.IsNullOrEmpty(title), r => r.UserName.Contains(title)).Select<RegionUserRes>((r,m)=>new RegionUserRes{Id=r.Id,UserName=r.UserName,Mobile=r.Mobile,CreateTime=r.CreateTime,MateriaName=m.MateriaName}).ToPageList(page, limit, ref total);
            pageModel.msg = "获取成功";
            pageModel.code = 0;
            pageModel.count = total;
            pageModel.data = list;
            return Json(pageModel);
        }

        /// <summary>
        /// 注销用户
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>

        [UsersRoleAuthFilter("A-107", FunctionEnum.Delete)]
        public IActionResult Delete(int Id)
        {
            var result = _currencyService.DbAccess().Deleteable<YNK_Region>().Where(p => p.Id == Id).ExecuteCommand();
            if (result > 0)
                return Json(new { code = 200, msg = "删除成功" });
            else
                return Json(new { code = 0, msg = "删除失败" });
        }

        /// <summary>
        /// 导出用户
        /// </summary>
        /// <param name="txtphone"></param>
        /// <param name="txtnickname"></param>
        /// <param name="ids"></param>
        /// <returns></returns>
        [UsersRoleAuthFilter("A-107", FunctionEnum.GetExcel)]
        public virtual IActionResult ExportExcel(string txtphone, string txtnickname, string ids)
        {
            Expression<Func<YS_User_Enter, bool>> exp = p => true;
            if (!string.IsNullOrEmpty(txtphone))
                exp = exp.And(p => p.Mobile.Contains(txtphone));
            if (!string.IsNullOrEmpty(txtnickname))
                exp = exp.And(p => p.UserName.Contains(txtnickname));
            DataTable dt = _currencyService.DbAccess().Queryable<YS_User_Enter>().Where(exp).Select(p => new {
                p.Mobile,
                p.UserName,
                p.ID_Card_Front,
                p.ID_Card_Back,
                p.Enter_OrganIzation,
                p.History_Max_Total,
                p.History_Max_Write,
                p.History_Max_Talk,
                p.History_Max_Listen,
                p.History_Max_Reder,
                p.Last_Max_Total,
                p.Last_Max_Write,
                p.Last_Max_Talk,
                p.Last_Max_Listen,
                p.Last_Max_Reder,
                IsChecked = p.IsChecked > 0 ? "是" : "否",
                p.Join_Address,
                p.Join_date,
                p.Certificate_Img_Url,
                Sign_Contract = p.Sign_Contract > 0 ? "是" : "否",
                AuditStatus = p.AuditStatus.ToString(),//转换成字符串类型
                p.CreateTime
            }).ToDataTable();
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["AuditStatus"] != null && !string.IsNullOrEmpty(dt.Rows[i]["AuditStatus"].ToString()))
                    dt.Rows[i]["AuditStatus"] = EnumHelper.GetDescription<ApiUserAuditEnum>((ApiUserAuditEnum)int.Parse(dt.Rows[i]["AuditStatus"].ToString()));
            }
            string[] reportFile = new string[] { "手机号码", "用户姓名", "身份证正面", "身份证背面", "报名机构", "历史最高总分", "历史最高分(写)", "历史最高分(说)", "历史最高分(听)", "历史最高分(读)", "最近最高总分", "最近最高分(写)", "最近最高分(说)", "最近最高分(听)", "最近最高分(读)", "是否被抽查", "参加报名地点", "参加报名时间", "报名凭证", "是否鉴定协议", "审核状态", "创建时间" };
            return File(DBToExcel(dt, reportFile, new string[] { }), "application/vnd.ms-excel", "用户报名_" + DateTime.Now.ToString("yyyyMMddHHmmssss") + ".xls");
        }


    }
}
