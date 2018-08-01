using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller /*: BaseController*/
    {
        //public IActionResult Index()
        //{

        //    return View();
        //}

        //public HomeController(IAuth authUtil) : base(authUtil)
        //{
        //}

        public ActionResult Index()
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
    }
}
