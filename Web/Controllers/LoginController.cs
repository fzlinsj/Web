using System;
using App;
using App.Interface;
using Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

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

            try
            {
                HttpContext.Session.SetString("CheckCode", code);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }

            var codeImage = VerifyCodeHelper.GetSingleObj().CreateByteByImgVerifyCode(code, 70, 36);
            return File(codeImage, @"image/jpeg");
        }


        public string Login(string password, string username,string verifycode)
        {
            var resp = new Response();

            var checkCode=HttpContext.Session.GetString("CheckCode");

            if (checkCode==null||!checkCode.Equals(verifycode))
            {

                resp.Code = 500;
                resp.Message = "验证码不正确!";

            }
            else
            {
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
            }


          

            return JsonHelper.Instance.Serialize(resp);
        }
    }
}