using App.AuthStrategies;
using App.Interface;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class HomeController : BaseController
    {

        private readonly AuthStrategyContext _authStrategyContext;

        public HomeController(IAuth authUtil) : base(authUtil)
        {
            _authStrategyContext = _authUtil.GetCurrentUser();
        }

        public IActionResult Index()
        {

            return View();
        }


       

        public ActionResult Main()
        {
            return View();
        }



        public ActionResult Git()
        {
            return View();
        }
        ///// <summary>
        ///// 获取登录用户可访问的所有模块，及模块的操作菜单
        ///// </summary>
        public string GetModulesTree()
        {
            var moduleTree = _authStrategyContext.Modules.GenerateTree(u => u.ModuleID, u => u.ParentID);

            var ret= JsonHelper.Instance.Serialize(moduleTree);

            return ret;
        }

    }
}
