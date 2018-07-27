using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;
using Repository;

namespace App.Test
{
    public class TestBase
    {
        protected AutofacServiceProvider _autofacServiceProvider;

        [SetUp]
        public void Init()
        {
            var serviceCollection = GetService();
            serviceCollection.AddMemoryCache();
            serviceCollection.AddOptions();

            serviceCollection.AddDbContext<XgossContext>(options =>
                options.UseSqlServer("Data Source=117.27.89.185,60012;Database=xgoss_netcore;Uid=sa;Pwd=Dongri_123456"));

            var container = AutofacExt.InitAutofac(serviceCollection);
            _autofacServiceProvider = new AutofacServiceProvider(container);
        }

        /// <summary>
        /// 测试框架默认只注入了缓存Cache，配置Option；
        /// 如果在测试的过程中需要模拟登录用户，cookie等信息，需要重写该方法，可以参考TestFlow的写法
        /// </summary>
        public virtual ServiceCollection GetService()
        {
            return new ServiceCollection();
        }
    }
}
