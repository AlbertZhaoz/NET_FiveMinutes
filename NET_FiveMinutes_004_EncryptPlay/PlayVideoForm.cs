using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NET_FiveMinutes_004_EncryptPlay.Common;
using NET_FiveMinutes_004_EncryptPlay.Models;
using NET_FiveMinutes_005_SqlSugarHelper.Interfaces;

namespace NET_FiveMinutes_004_EncryptPlay
{
    public partial class PlayVideoForm : Form
    {
        private readonly ISqlServerService _iServerService; 
        private string _playOriginVideoPath;
        private string _playDestinationVideoPath;
        public PlayVideoForm(ISqlServerService iServerServic)
        {
            this._iServerService = iServerServic;
            InitializeComponent();
        }

        private void vlcControl1_VlcLibDirectoryNeeded(object sender, Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs e)
        {
            var currentAssembly = Assembly.GetEntryAssembly();
            var currentDirectory = new FileInfo(currentAssembly.Location).DirectoryName;

            if(currentDirectory == null) return;

            if(IntPtr.Size == 4)
            {
                e.VlcLibDirectory = new DirectoryInfo(Path.GetFullPath(@".\libvlc\win-x86\"));
            }
            else
            {
                e.VlcLibDirectory = new DirectoryInfo(Path.GetFullPath(@".\libvlc\win-x64\"));
            }
        }

        private void uiSymbolButton_Play_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(this._playDestinationVideoPath))
            {
                ShowDencryptVideForm();
            }
            //播放
            this.vlcControl1.Play(new FileInfo(_playDestinationVideoPath));
        }

        private void uiSymbolButton_Pause_Click(object sender, EventArgs e)
        {
            if(this.uiSymbolButton_Pause.Symbol == 61516)
            {
                this.uiSymbolButton_Pause.Symbol = 61517;
                this.uiSymbolButton_Pause.SymbolColor = Color.Brown;
                this.vlcControl1.SetPause(true);
            }
            else
            {
                this.uiSymbolButton_Pause.Symbol = 61516;
                this.uiSymbolButton_Pause.SymbolColor = Color.DodgerBlue;
                this.vlcControl1.SetPause(false);
            }
        }

        private void uiSymbolButton_ChooseFile_Click(object sender, EventArgs e)
        {
            ShowDencryptVideForm();
            //播放
            this.vlcControl1.Play(new FileInfo(_playDestinationVideoPath));
        }

        private void PlayVideoForm_Load(object sender, EventArgs e)
        {
            ShowDencryptVideForm();
            //播放
            this.vlcControl1.Play(new FileInfo(_playDestinationVideoPath));
        }

        private void ShowDencryptVideForm()
        {
            DencryptVideoForm dencryptVideoForm = new DencryptVideoForm(_iServerService);
            dencryptVideoForm.StartPosition = FormStartPosition.CenterScreen;
            dencryptVideoForm.ShowDialog();
            if(dencryptVideoForm.DialogResult == DialogResult.OK)
            {
                _playDestinationVideoPath = dencryptVideoForm.GetPlayDestinationVideoPath();
                dencryptVideoForm.Close();
                dencryptVideoForm.Dispose();
            }
        }
    }
}
