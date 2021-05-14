using ADT.Models;
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
    public class CourseController : BaseController
    {
        private ICurrencyService _currencyService;
        public CourseController(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
        }
        protected override void Init()
        {
            this.MenuID = "A-105";
        }
        // GET: /<controller>/
        [UsersRoleAuthFilter("A-105", FunctionEnum.Have)]
        public IActionResult Index() 
        {
           
            return View();
        }

        [UsersRoleAuthFilter("A-105", FunctionEnum.Have)]
        public IActionResult GetDataSource(string title, int page = 1, int limit = 10)
        {
            int total = 0;
            PageList<YNK_Course> pageModel = new PageList<YNK_Course>();
            var list = _currencyService.DbAccess().Queryable<YNK_Course>().WhereIF(!string.IsNullOrEmpty(title), n => n.CourseName.Contains(title)).ToPageList(page, limit, ref total);
            pageModel.msg = "获取成功";
            pageModel.code = 0;
            pageModel.count = total;
            pageModel.data = list;
            return Json(pageModel);
        }


        [UsersRoleAuthFilter("A-105", FunctionEnum.Add)]
        public IActionResult Add()
        {
            ViewBag.ID = 0;
            return View();
        }

        [UsersRoleAuthFilter("A-105", FunctionEnum.Edit)]
        public IActionResult Edit(int ID)
        {
            ViewBag.ID = ID;
            return View("Add");
        }

        [UsersRoleAuthFilter("A-105", "Add,Edit")]
        public IActionResult Find(int ID)
        {
            dynamic list;
            if (ID > 0)
            {
                list = _currencyService.DbAccess().Queryable<YNK_Course>().Where(f => f.Id == ID).First();
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
        [UsersRoleAuthFilter("A-105", "Add,Edit")]
        public IActionResult SaveInfo(YNK_Course vmodel)
        {
            int code = 0;
            string msg = string.Empty;
            if (vmodel != null)
            {
                if (string.IsNullOrEmpty(vmodel.CourseName))
                    return Json(new { code = 0, msg = "课程名称不能为空" });
                if (vmodel.Id > 0)
                {
                    YNK_Course banner = _currencyService.DbAccess().Queryable<YNK_Course>().Where(f => f.Id == vmodel.Id).First();
                    banner.ImgUrl = vmodel.ImgUrl;
                    banner.CourseTitle = vmodel.CourseTitle;
                    banner.CourseName = vmodel.CourseName;
                    banner.Content = vmodel.Content;
                    banner.CreateTime = DateTime.Now;
                    var result = _currencyService.DbAccess().Updateable<YNK_Course>(banner).ExecuteCommand();
                    if (result > 0)
                    {
                        code = 200;
                        msg = "更新成功";
                    }
                }
                else
                {
                    vmodel.CreateTime = DateTime.Now;
                    var result = _currencyService.DbAccess().Insertable<YNK_Course>(vmodel).ExecuteCommand();
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
        [UsersRoleAuthFilter("A-105", FunctionEnum.Delete)]
        public IActionResult Delete(int Id)
        {
            var result = _currencyService.DbAccess().Deleteable<YNK_Course>().Where(p => p.Id == Id).ExecuteCommand();
            if (result > 0)
                return Json(new { code = 200, msg = "删除成功" });
            else
                return Json(new { code = 0, msg = "删除失败" });
        }
    }
}
