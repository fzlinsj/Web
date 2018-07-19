using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Interface;
using App.SSO;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Reflection;
using Web.Models;

namespace Web.Controllers
{
    public class BaseController : SSOController
    {
        protected Response Result = new Response();
        protected string Controllername;   //当前控制器小写名称
        protected string Actionname;        //当前Action小写名称

        public BaseController(IAuth authUtil) : base(authUtil)
        {
        }


        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            if (!_authUtil.CheckLogin()) return;

            var description =
                (Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor)filterContext.ActionDescriptor;

            Controllername = description.ControllerName.ToLower();
            Actionname = description.ActionName.ToLower();

            var function = ((TypeInfo)GetType()).DeclaredMethods.FirstOrDefault(u => u.Name.ToLower() == Actionname);

            if (function == null)
                throw new Exception("未能找到Action");
            //权限验证标识
            var authorize = function.GetCustomAttribute(typeof(AuthenticateAttribute));
            if (authorize == null)
            {
                return;
            }
            var currentModule = _authUtil.GetCurrentUser().Modules.FirstOrDefault(u => u.Url.ToLower().Contains(Controllername));
            //当前登录用户没有Action记录&&Action有authenticate标识
            if (currentModule == null)
            {
                filterContext.Result = new RedirectResult("/Login/Index");
                return;
            }

            //var version = ConfigurationManager<>.AppSettings["version"];
            //if (version == "demo" && Request.HttpMethod == "POST")
            //{
            //    throw new HttpException(400, "演示版本，不能进行该操作，当前模块:" + Controllername + "/" + Actionname);
            //}

        }


    }
}
