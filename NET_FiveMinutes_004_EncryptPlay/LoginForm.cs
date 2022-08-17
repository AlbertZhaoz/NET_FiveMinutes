using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using NET_FiveMinutes_004_EncryptPlay.Common;
using NET_FiveMinutes_004_EncryptPlay.Models;
using NET_FiveMinutes_005_SqlSugarHelper.Interfaces;

namespace NET_FiveMinutes_004_EncryptPlay
{
    public partial class LoginForm : Form
    {
        private readonly ISqlServerService _iServerService; 
        public LoginForm(ISqlServerService iServerService)
        {
            this._iServerService = iServerService;
            InitializeComponent();
        }


        private void button_Login_Click(object sender, EventArgs e)
        {
            _iServerService.CreateTableByModels(Assembly.GetExecutingAssembly());

            if(this.textBox_Username.Text==null||this.textBox_Password.Text==null)
            {
                MessageBox.Show("请输入用户名和密码");
                return;
            }

            var user = _iServerService
                .GetSqlClient()
                .Queryable<UserInformation>()
                .First(u=>string.Equals(u.Name ,this.textBox_Username.Text,StringComparison.OrdinalIgnoreCase));
            
            if(user==null)
            {
                ;
                MessageBox.Show("用户不存在,请向szdxzhy@outlook.com申请权限");
            }
            else
            {
                if(user.Password == Md5Encrypt.Encrypt(this.textBox_Password.Text))
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("密码不正确");
                }
            }
        }
    }
}
