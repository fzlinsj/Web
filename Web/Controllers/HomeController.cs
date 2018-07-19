using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using App.Interface;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {

            return View();
        }

        public HomeController(IAuth authUtil) : base(authUtil)
        {
        }
    }
}
