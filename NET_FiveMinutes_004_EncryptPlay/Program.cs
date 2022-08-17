using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using NET_FiveMinutes_005_SqlSugarHelper.Common;
using NET_FiveMinutes_005_SqlSugarHelper.Interfaces;

namespace NET_FiveMinutes_004_EncryptPlay
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 批量注册服务
            BatchConfigs.InitConfigs();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new PlayVideoForm());
            Application.Run(new MainForm(BatchConfigs
                .Services
                .BuildServiceProvider()
                .GetRequiredService<ISqlServerService>()));
        }
    }
}
