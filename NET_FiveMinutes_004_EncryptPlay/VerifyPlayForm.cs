using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NET_FiveMinutes_004_EncryptPlay.Common;
using NET_FiveMinutes_004_EncryptPlay.Models;
using NET_FiveMinutes_005_SqlSugarHelper.Interfaces;

namespace NET_FiveMinutes_004_EncryptPlay
{
    public partial class VerifyPlayForm : Form
    {
        private readonly ISqlServerService _iServerService;
        private string fileSaltKeyMd5 = "";
        private string _playOriginVideoPath = "";
        private string _playDestinationVideoPath = "";
        public VerifyPlayForm(ISqlServerService iServerService,string playOriginVideoPath)
        {
            _iServerService = iServerService;
            _playOriginVideoPath =  playOriginVideoPath;
            InitializeComponent();
        }

        private void button_Enctpy_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(this.textBox_EncryptPassword.Text))
            {
                // 对加密文件进行MD5运算，看是否存在数据库中
                var fileEncrypt = _iServerService
                    .GetSqlClient()
                    .Queryable<FileEncrypt>()
                    .First(f=>Md5Encrypt.AbstractFile(_playOriginVideoPath)==f.FileDesctionMd5);
                if(fileEncrypt!=null)
                {
                    // 比较密码是否正确
                    if(fileEncrypt.FileSaltKeyMd5 ==  this.textBox_EncryptPassword.Text)
                    {
                        _playDestinationVideoPath = fileEncrypt.FileOrigin;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Password Error");
                    }
                }
                else //进行解密操作
                {
                    if(!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory+"ConvertFile\\"))
                    {
                        Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory+"ConvertFile\\");
                    }
                    _playDestinationVideoPath = AppDomain.CurrentDomain.BaseDirectory+"ConvertFile\\"+ Path.GetFileNameWithoutExtension(_playOriginVideoPath);
                    AESEncrypt.DecryptFile(_playOriginVideoPath
                        , _playDestinationVideoPath
                        ,textBox_EncryptPassword.Text
                        ,(a,b,c)=>{});   
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        public string GetPlayDestinationVideoPath()
        {
            return _playDestinationVideoPath;
        }
    }
}
