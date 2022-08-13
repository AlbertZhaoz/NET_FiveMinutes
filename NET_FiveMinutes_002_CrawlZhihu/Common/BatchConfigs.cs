using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NET_FiveMinutes_002_CrawlZhihu.Interfaces;
using NET_FiveMinutes_002_CrawlZhiHu.Models;
using NET_FiveMinutes_002_CrawlZhihu.Services;
using Scrutor;

namespace NET_FiveMinutes_002_CrawlZhihu.Common
{
    public static class BatchConfigs
    {

        public static void InitConfigs()
        {
            // 创建配置文件读取项
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("CfgFiles\\HttpHeaderConfig.json",false,true)
                .Build(); 

            // 将Json文件绑定到类中
            var Service = new ServiceCollection();
            Service.AddOptions().Configure<Root>(e => configuration.Bind(e))
                .Configure<ZhiHuConfigModel>(e => configuration.GetSection("ZhiHuConfigModel").Bind(e));

            Service.AddScoped<IZhiHuService,ZhiHuService>();
            // 批量注册DI服务
            //Service.Scan(scan => scan
            //    .FromAssembliesOf(typeof(ZhiHuService))
            //    .AddClasses(classes =>
            //        classes.Where(t => t.Name.EndsWith("Service", StringComparison.OrdinalIgnoreCase))) // 批量增加
            //    .UsingRegistrationStrategy(RegistrationStrategy.Skip) // 当重复添加则跳过
            //    .AsMatchingInterface()
            //    .WithScopedLifetime()
            //);

            var test = Service.BuildServiceProvider().GetRequiredService<IZhiHuService>();
            test.CrawlHot();

        }
    }
}
