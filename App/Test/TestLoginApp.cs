using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure;
using NUnit.Framework;

namespace App.Test
{
    public class TestLoginApp: TestBase
    {
        [Test]
        public void GetUserInfoByUserIdTest(LoginApp app)
        {


            var response=app.GetUserInfoByUserId("yangyang");


            Console.WriteLine(JsonHelper.Instance.Serialize(response));


        }

    }
}
