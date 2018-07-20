using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Interface;
using Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        private IAuth _authUtil;

        public LoginController(IAuth authUtil)
        {
            _authUtil = authUtil;
        }

        /// <summary>
        /// 数字验证码
        /// </summary>
        /// <returns></returns>
        public FileContentResult NumberVerifyCode()
        {
            var code = VerifyCodeHelper.GetSingleObj().CreateVerifyCode(VerifyCodeHelper.VerifyCodeType.NumberVerifyCode);

            HttpContext.Session.SetString("CheckCode",code);

            var codeImage = VerifyCodeHelper.GetSingleObj().CreateByteByImgVerifyCode(code, 70, 36);
            return File(codeImage, @"image/jpeg");
        }


        public string Login(string password, string username,string verifycode)
        {
            var resp = new Response();
            try
            {
                var result = _authUtil.Login("", username, password);
                if (result.Code == 200)
                {
                    Response.Cookies.Append("Token", result.Token);
                }
                else
                {
                    resp.Code = 500;
                    resp.Message = result.Message;
                }

            }
            catch (Exception e)
            {
                resp.Code = 500;
                resp.Message = e.Message;
            }

            return JsonHelper.Instance.Serialize(resp);
        }
    }
}