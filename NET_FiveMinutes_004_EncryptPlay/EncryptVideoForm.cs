using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NET_FiveMinutes_004_EncryptPlay.Common;
using NET_FiveMinutes_004_EncryptPlay.Models;
using NET_FiveMinutes_005_SqlSugarHelper.Interfaces;

namespace NET_FiveMinutes_004_EncryptPlay
{
    public partial class EncryptVideoForm : Form
    {
        private readonly ISqlServerService _iServerService; 
        public EncryptVideoForm(ISqlServerService iServerService)
        {
            this._iServerService = iServerService;
            InitializeComponent();
            this.textBox_DestinationVideoPath.ReadOnly = true;
        }

        private void button_OriginVidePath_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog() { Title = "Open Origin Video File", Filter = "VideoFile|*.*", CheckFileExists = true })
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;

                //判断文件是否已经是加密文件
                if(dlg.FileName.Contains(".enc"))
                {
                    MessageBox.Show("File already Encrypted");
                }
                else
                {
                    this.textBox_OriginVideoPath.Text = dlg.FileName;
                    this.textBox_DestinationVideoPath.Text = dlg.FileName+".enc";
                }
            }
        }

        private void textBox_EncryptPassword_TextChanged(object sender, EventArgs e)
        {
            this.button_Showbit.Text = (16-this.textBox_EncryptPassword.Text.Length).ToString();
        }

        private void button_Enctpy_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.textBox_OriginVideoPath.Text)||string.IsNullOrEmpty(this.textBox_EncryptPassword.Text))
            {
                MessageBox.Show("Please input your origin video path or your encrypt password");
            }
            else
            {
                // 加密
                try
                {
                    // 执行加密操作
                    AESEncrypt.EncryptFile(this.textBox_OriginVideoPath.Text
                        ,this.textBox_DestinationVideoPath.Text
                        ,this.textBox_EncryptPassword.Text
                        ,(a,b,c)=>{});

                    // 先对该文件进行运算，执行MD5，存入数据库中
                    // 当解密的时候从数据库获取加密文件的MD5值，取出其中的原始路径，判断路径存在则直接播放，实现快速解密
                    var fileEncrypt = new FileEncrypt()
                    {
                        FileOrigin =  this.textBox_OriginVideoPath.Text,
                        FileDesctionMd5 =  Md5Encrypt.AbstractFile(this.textBox_DestinationVideoPath.Text),
                        FileSaltKeyMd5 = Md5Encrypt.Encrypt(this.textBox_EncryptPassword.Text)
                    };
                    _iServerService.GetSqlClient().Insertable(fileEncrypt).ExecuteCommand();
                    MessageBox.Show("Encrypt Successfully");

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
