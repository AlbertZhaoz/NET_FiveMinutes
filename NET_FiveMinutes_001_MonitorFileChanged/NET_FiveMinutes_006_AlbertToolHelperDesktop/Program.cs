using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using NET_FiveMinutes_005_SqlSugarHelper.Common;
using NET_FiveMinutes_005_SqlSugarHelper.Interfaces;

namespace NET_FiveMinutes_006_AlbertToolHelperDesktop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 批量注册服务
            BatchConfigs.InitConfigs();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Application.Run(new MainFrm(BatchConfigs
                .Services
                .BuildServiceProvider()
                .GetRequiredService<ISqlServerService>()));
        }
    }
}