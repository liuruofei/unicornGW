using log4net;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;
using WebManager.Models;

namespace WebManager.Filter
{
    public class UsersAuthFilterAttribute : Attribute, IActionFilter
    {
        private ILog log = LogManager.GetLogger(Startup.repository.Name, typeof(UsersAuthFilterAttribute));
        public string Realm { get; set; }
        public bool AllowMultiple => false;

        /// <summary>
        /// Action之前发生
        /// </summary>
        /// <param name="context"></param>
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //var token = filterContext.HttpContext.Request.Headers["token"].FirstOrDefault();
            //if (!string.IsNullOrEmpty(token))
            //{
            //    var handers = new JwtSecurityTokenHandler().ReadJwtToken(token.Replace("Bearer ", ""));
            //    Dictionary<string, object> dic = new Dictionary<string, object>();
            //    foreach (var item in handers.Claims)
            //    {
            //        dic.Add(item.Type, item.Value);
            //        Console.WriteLine($"{item.Type}>>>>>{item.Value}");
            //    }
            //    UserInfoAuth userInfoAuth = new UserInfoAuth();
            //    userInfoAuth.UserId = "1";
            //    filterContext.ActionArguments["UserData"] = userInfoAuth;
            //}
           
            UserInfoAuth userInfoAuth = new UserInfoAuth();
            userInfoAuth.UserId = "1";
            filterContext.ActionArguments["UserData"] = userInfoAuth;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
        }
    }
}
