using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NET_FiveMinutes_005_SqlSugarHelper.Interfaces;

namespace NET_FiveMinutes_004_EncryptPlay
{
    public partial class MainForm : Form
    {
        private readonly ISqlServerService _iServerService; 
        public MainForm(ISqlServerService iServerService)
        {
            this._iServerService = iServerService;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(_iServerService);
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            loginForm.ShowDialog();
            if(loginForm.DialogResult == DialogResult.OK)
            {
                loginForm.Close();
                loginForm.Dispose();
            }
        }

        private void button_EncryptVideo_Click(object sender, EventArgs e)
        {
            // 加密视频
            EncryptVideoForm encryptVideoForm = new EncryptVideoForm(this._iServerService);
            encryptVideoForm.StartPosition = FormStartPosition.CenterScreen;
            encryptVideoForm.ShowDialog();
        }

        private void button_PlayEncVideo_Click(object sender, EventArgs e)
        {
            // 启动视频播放功能
            PlayVideoForm video = new PlayVideoForm(this._iServerService);
            video.StartPosition = FormStartPosition.CenterScreen;
            video.ShowDialog();
        }
    }
}
