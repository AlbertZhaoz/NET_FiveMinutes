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
    public partial class DencryptVideoForm : Form
    {
        private readonly ISqlServerService _iServerService;
        private string _playOriginVideoPath;
        private string _playDestinationVideoPath;
        public DencryptVideoForm(ISqlServerService iServerService)
        {
            this._iServerService = iServerService;
            InitializeComponent();
        }

        private void button_OriginVidePath_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog() { Title = "Open Video File", Filter = "VideoFile|*.*", CheckFileExists = true })
            {
                if (dlg.ShowDialog() != DialogResult.OK) return;
                this.textBox_OriginVideoPath.Text = dlg.FileName;
                _playOriginVideoPath = dlg.FileName;
            }
        }

        private void button_DestinationVideoPath_Click(object sender, EventArgs e)
        {
            using (var folder = new FolderBrowserDialog(){Description = "Choose folder"})
            {
                if (folder.ShowDialog() != DialogResult.OK) return; 
                this.textBox_DestinationVideoPath.Text = folder.SelectedPath;
                _playDestinationVideoPath = folder.SelectedPath;
            }
        }

        private void button_Denctpy_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this.textBox_OriginVideoPath.Text))
            {
                MessageBox.Show("Please input your origin video path");
                return;
            }

            // 如果不是加密视频则直接播放
            if(!this.textBox_OriginVideoPath.Text.Contains(".enc"))
            {
                _playDestinationVideoPath = this.textBox_OriginVideoPath.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                // 解密
                if(!string.IsNullOrEmpty(this.textBox_DencryptPassword.Text))
                {
                    // 对加密文件进行MD5运算，看是否存在数据库中
                    var fileEncryptList = _iServerService
                        .GetSqlClient()
                        .Queryable<FileEncrypt>().Where(f=>Md5Encrypt.AbstractFile(_playOriginVideoPath)==f.FileDesctionMd5).ToList();

                    if(fileEncryptList!=null)
                    {
                        
                        // 比较密码是否正确
                        var fileEncrypt = fileEncryptList.First(f=>f.FileSaltKeyMd5 == Md5Encrypt.Encrypt(textBox_DencryptPassword.Text));
                        if(fileEncrypt != null)
                        {
                            // 判断本地文件是否存在，如果不存在，仍然进行解密操作
                            if(!File.Exists(_playDestinationVideoPath))
                            {
                                _playDestinationVideoPath =_playDestinationVideoPath +"\\"+ Path.GetFileNameWithoutExtension(_playOriginVideoPath);
                                AESEncrypt.DecryptFile(_playOriginVideoPath
                                    , _playDestinationVideoPath
                                    ,textBox_DencryptPassword.Text
                                    ,UpdateProgress);   
                            }
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
                        if(!Directory.Exists(_playDestinationVideoPath))
                        {
                            Directory.CreateDirectory(_playDestinationVideoPath);
                        }
                        _playDestinationVideoPath =_playDestinationVideoPath +"\\"+ Path.GetFileNameWithoutExtension(_playOriginVideoPath);
                        AESEncrypt.DecryptFile(_playOriginVideoPath
                            , _playDestinationVideoPath
                            ,textBox_DencryptPassword.Text
                            ,UpdateProgress);   
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    MessageBox.Show("Please input your dencrypt password");
                }
            }
        }

        private void UpdateProgress(int min, int max, int value)
        {
            try
            {
                this.button_Progress.Invoke(new Action(()=>
                    {this.button_Progress.Text = ((value-min)/(max-min)).ToString()+"%";}));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public string GetPlayDestinationVideoPath()
        {
            return _playDestinationVideoPath;
        }
    }
}
