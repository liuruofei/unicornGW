﻿using ADT.Models;
using ADT.Service.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebManager.Areas.Admin.Filter;
using WebManager.Areas.Admin.Models;

namespace WebManager.Areas.Admin.Controllers.Manage
{
    [Authorize]
    public class YaseController : BaseController
    {
        private ICurrencyService _currencyService;
        public YaseController(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
        }
        protected override void Init()
        {
            this.MenuID = "A-109";
        }
        // GET: /<controller>/
        [UsersRoleAuthFilter("A-109", FunctionEnum.Have)]
        public IActionResult Index()
        {
            return View();
        }

        [UsersRoleAuthFilter("A-109", FunctionEnum.Have)]
        public IActionResult GetDataSource(string title, int page = 1, int limit = 10)
        {
            int total = 0;
            PageList<YNK_Case> pageModel = new PageList<YNK_Case>();
            var list = _currencyService.DbAccess().Queryable<YNK_Case>().Where(n => n.Type == 2).WhereIF(!string.IsNullOrEmpty(title), n => n.Title.Contains(title)).ToPageList(page, limit, ref total);
            pageModel.msg = "获取成功";
            pageModel.code = 0;
            pageModel.count = total;
            pageModel.data = list;
            return Json(pageModel);
        }


        [UsersRoleAuthFilter("A-109", FunctionEnum.Add)]
        public IActionResult Add()
        {
            ViewBag.ID = 0;
            return View();
        }

        [UsersRoleAuthFilter("A-109", FunctionEnum.Edit)]
        public IActionResult Edit(int ID)
        {
            ViewBag.ID = ID;
            return View("Add");
        }

        [UsersRoleAuthFilter("A-109", "Add,Edit")]
        public IActionResult Find(int ID)
        {
            dynamic list;
            if (ID > 0)
            {
                list = _currencyService.DbAccess().Queryable<YNK_Case>().Where(f => f.Id == ID).First();
            }
            else
            {
                list = new { };
            }
            return Json(list);
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="vmodel"></param>
        /// <returns></returns>
        [UsersRoleAuthFilter("A-109", "Add,Edit")]
        public IActionResult SaveInfo(YNK_Case vmodel)
        {
            int code = 0;
            string msg = string.Empty;
            if (vmodel != null)
            {
                if (string.IsNullOrEmpty(vmodel.Title))
                    return Json(new { code = 0, msg = "标题不能为空" });
                if (vmodel.Id > 0)
                {
                    YNK_Case banner = _currencyService.DbAccess().Queryable<YNK_Case>().Where(f => f.Id == vmodel.Id).First();
                    banner.ImgUrl = vmodel.ImgUrl;
                    banner.MobileImgUrl = vmodel.MobileImgUrl;
                    banner.Title = vmodel.Title;
                    banner.Type = 2;
                    banner.Subtitle = vmodel.Subtitle;
                    banner.Content = vmodel.Content;
                    banner.CreateTime = DateTime.Now;
                    var result = _currencyService.DbAccess().Updateable<YNK_Case>(banner).ExecuteCommand();
                    if (result > 0)
                    {
                        code = 200;
                        msg = "更新成功";
                    }
                }
                else
                {
                    vmodel.CreateTime = DateTime.Now;
                    vmodel.Type = 2;
                    var result = _currencyService.DbAccess().Insertable<YNK_Case>(vmodel).ExecuteCommand();
                    if (result > 0)
                    {
                        code = 200;
                        msg = "保存成功";
                    }

                }
            }
            else
            {
                return Json(new { code = code, msg = "缺少参数" });
            }
            return Json(new { code = code, msg = msg });
        }


        /// <summary>
        /// 删除banner
        /// </summary>
        /// <param name="id">id集合</param>
        /// <returns></returns>
        [UsersRoleAuthFilter("A-109", FunctionEnum.Delete)]
        public IActionResult Delete(int Id)
        {
            var result = _currencyService.DbAccess().Deleteable<YNK_Case>().Where(p => p.Id == Id).ExecuteCommand();
            if (result > 0)
                return Json(new { code = 200, msg = "删除成功" });
            else
                return Json(new { code = 0, msg = "删除失败" });
        }
    }
}
