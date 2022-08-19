using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Cells;
using MiniExcelLibs;
using NET_FiveMinutes_005_SqlSugarHelper.Interfaces;
using NET_FiveMinutes_006_AlbertToolHelperDesktop.Models;
using Sunny.UI;

namespace NET_FiveMinutes_006_AlbertToolHelperDesktop
{
    public partial class MainFrm : Form
    {
        private readonly ISqlServerService _iServerService; 
        private DataTable dtSource = null;
        public MainFrm(ISqlServerService iServerService)
        {
            this._iServerService = iServerService;
            _iServerService.CreateTableByModels(Assembly.GetExecutingAssembly());
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        
        private void uiTabControl_AlbertToolHelper_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dtView = (UIDataGridView)this.uiTabControl_AlbertToolHelper.SelectedTab.Controls[0];
            dtSource = _iServerService
                .GetSqlClient()
                .Queryable<AlbertToolHelperModel>()
                .Where(a=>a.Sort==this.uiTabControl_AlbertToolHelper.SelectedTab.Text)
                .IgnoreColumns(a=>a.Id)
                .IgnoreColumns(a=>a.Sort)
                .ToDataTable();
            dtView.DataSource = dtSource;
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
           
        }

        private void uiAvatar1_Click(object sender, EventArgs e)
        {
            // 先将Datatable中数据生成每一个excel
            // 将excel导出为markdown文件
            // 将多个markdown拼接为一个大的markdown
            foreach (TabPage tabPage in this.uiTabControl_AlbertToolHelper.TabPages)
            {
                var dtSource = _iServerService
                    .GetSqlClient()
                    .Queryable<AlbertToolHelperModel>()
                    .Where(a=>a.Sort==tabPage.Text)
                    .IgnoreColumns(a=>a.Id)
                    .IgnoreColumns(a=>a.Sort)
                    .ToDataTable();
                var excelPath = AppDomain.CurrentDomain.BaseDirectory+$"TempExcel\\{tabPage.Text}.xlsx";
                var mdPath =  AppDomain.CurrentDomain.BaseDirectory+$"TempExcel\\{tabPage.Text}.md";
                MiniExcel.SaveAs(excelPath, dtSource);
                var workbook = new Workbook(excelPath);
                workbook.Save(mdPath);
            }
        }

        private void uiAvatar2_Click(object sender, EventArgs e)
        {
            dtSource = (((UIDataGridView)this.uiTabControl_AlbertToolHelper.SelectedTab.Controls[0])).DataSource as DataTable;
            _iServerService
                .GetSqlClient()
                .Fastest<System.Data.DataTable>()
                .AS(typeof(AlbertToolHelperModel).Name)
                .BulkCopy(dtSource);
        }
    }
}