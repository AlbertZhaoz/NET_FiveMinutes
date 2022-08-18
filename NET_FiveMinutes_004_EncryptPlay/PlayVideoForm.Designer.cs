namespace NET_FiveMinutes_004_EncryptPlay
{
    partial class PlayVideoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.uiSymbolButton_ChooseFile = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton_Forw = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton_Back = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton_Pause = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton_Play = new Sunny.UI.UISymbolButton();
            this.trackBar_Volume = new System.Windows.Forms.TrackBar();
            this.label_X = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.trackBar_Progress = new System.Windows.Forms.TrackBar();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Volume)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Progress)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.uiSymbolButton_ChooseFile);
            this.panel1.Controls.Add(this.uiSymbolButton_Forw);
            this.panel1.Controls.Add(this.uiSymbolButton_Back);
            this.panel1.Controls.Add(this.uiSymbolButton_Pause);
            this.panel1.Controls.Add(this.uiSymbolButton_Play);
            this.panel1.Controls.Add(this.trackBar_Volume);
            this.panel1.Controls.Add(this.label_X);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 475);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 56);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(680, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 122;
            this.label2.Text = "音量：";
            // 
            // uiSymbolButton_ChooseFile
            // 
            this.uiSymbolButton_ChooseFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_ChooseFile.FillColor = System.Drawing.Color.Azure;
            this.uiSymbolButton_ChooseFile.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolButton_ChooseFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolButton_ChooseFile.Location = new System.Drawing.Point(308, 16);
            this.uiSymbolButton_ChooseFile.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_ChooseFile.Name = "uiSymbolButton_ChooseFile";
            this.uiSymbolButton_ChooseFile.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.uiSymbolButton_ChooseFile.Size = new System.Drawing.Size(32, 29);
            this.uiSymbolButton_ChooseFile.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton_ChooseFile.StyleCustomMode = true;
            this.uiSymbolButton_ChooseFile.Symbol = 61564;
            this.uiSymbolButton_ChooseFile.SymbolColor = System.Drawing.Color.DodgerBlue;
            this.uiSymbolButton_ChooseFile.SymbolSize = 25;
            this.uiSymbolButton_ChooseFile.TabIndex = 121;
            this.uiSymbolButton_ChooseFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiSymbolButton_ChooseFile.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton_ChooseFile.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiSymbolButton_ChooseFile.Click += new System.EventHandler(this.uiSymbolButton_ChooseFile_Click);
            // 
            // uiSymbolButton_Forw
            // 
            this.uiSymbolButton_Forw.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_Forw.FillColor = System.Drawing.Color.Azure;
            this.uiSymbolButton_Forw.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolButton_Forw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolButton_Forw.Location = new System.Drawing.Point(499, 15);
            this.uiSymbolButton_Forw.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_Forw.Name = "uiSymbolButton_Forw";
            this.uiSymbolButton_Forw.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.uiSymbolButton_Forw.Size = new System.Drawing.Size(32, 29);
            this.uiSymbolButton_Forw.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton_Forw.StyleCustomMode = true;
            this.uiSymbolButton_Forw.Symbol = 61520;
            this.uiSymbolButton_Forw.SymbolColor = System.Drawing.Color.DodgerBlue;
            this.uiSymbolButton_Forw.SymbolSize = 25;
            this.uiSymbolButton_Forw.TabIndex = 120;
            this.uiSymbolButton_Forw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiSymbolButton_Forw.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton_Forw.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiSymbolButton_Forw.Click += new System.EventHandler(this.uiSymbolButton_Forw_Click);
            // 
            // uiSymbolButton_Back
            // 
            this.uiSymbolButton_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_Back.FillColor = System.Drawing.Color.Azure;
            this.uiSymbolButton_Back.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolButton_Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolButton_Back.Location = new System.Drawing.Point(355, 16);
            this.uiSymbolButton_Back.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_Back.Name = "uiSymbolButton_Back";
            this.uiSymbolButton_Back.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.uiSymbolButton_Back.Size = new System.Drawing.Size(32, 29);
            this.uiSymbolButton_Back.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton_Back.StyleCustomMode = true;
            this.uiSymbolButton_Back.Symbol = 61513;
            this.uiSymbolButton_Back.SymbolColor = System.Drawing.Color.DodgerBlue;
            this.uiSymbolButton_Back.SymbolSize = 25;
            this.uiSymbolButton_Back.TabIndex = 119;
            this.uiSymbolButton_Back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiSymbolButton_Back.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton_Back.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiSymbolButton_Back.Click += new System.EventHandler(this.uiSymbolButton_Back_Click);
            // 
            // uiSymbolButton_Pause
            // 
            this.uiSymbolButton_Pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_Pause.FillColor = System.Drawing.Color.Azure;
            this.uiSymbolButton_Pause.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolButton_Pause.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolButton_Pause.Location = new System.Drawing.Point(451, 16);
            this.uiSymbolButton_Pause.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_Pause.Name = "uiSymbolButton_Pause";
            this.uiSymbolButton_Pause.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.uiSymbolButton_Pause.Size = new System.Drawing.Size(32, 29);
            this.uiSymbolButton_Pause.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton_Pause.StyleCustomMode = true;
            this.uiSymbolButton_Pause.Symbol = 61516;
            this.uiSymbolButton_Pause.SymbolColor = System.Drawing.Color.DodgerBlue;
            this.uiSymbolButton_Pause.SymbolSize = 25;
            this.uiSymbolButton_Pause.TabIndex = 118;
            this.uiSymbolButton_Pause.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiSymbolButton_Pause.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton_Pause.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiSymbolButton_Pause.Click += new System.EventHandler(this.uiSymbolButton_Pause_Click);
            // 
            // uiSymbolButton_Play
            // 
            this.uiSymbolButton_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton_Play.FillColor = System.Drawing.Color.Azure;
            this.uiSymbolButton_Play.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiSymbolButton_Play.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSymbolButton_Play.Location = new System.Drawing.Point(404, 16);
            this.uiSymbolButton_Play.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton_Play.Name = "uiSymbolButton_Play";
            this.uiSymbolButton_Play.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.uiSymbolButton_Play.Size = new System.Drawing.Size(32, 29);
            this.uiSymbolButton_Play.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton_Play.StyleCustomMode = true;
            this.uiSymbolButton_Play.Symbol = 61515;
            this.uiSymbolButton_Play.SymbolColor = System.Drawing.Color.DodgerBlue;
            this.uiSymbolButton_Play.SymbolSize = 25;
            this.uiSymbolButton_Play.TabIndex = 116;
            this.uiSymbolButton_Play.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiSymbolButton_Play.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiSymbolButton_Play.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiSymbolButton_Play.Click += new System.EventHandler(this.uiSymbolButton_Play_Click);
            // 
            // trackBar_Volume
            // 
            this.trackBar_Volume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar_Volume.AutoSize = false;
            this.trackBar_Volume.Location = new System.Drawing.Point(727, 28);
            this.trackBar_Volume.Maximum = 120;
            this.trackBar_Volume.Name = "trackBar_Volume";
            this.trackBar_Volume.Size = new System.Drawing.Size(126, 16);
            this.trackBar_Volume.TabIndex = 6;
            this.trackBar_Volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_Volume.Value = 100;
            this.trackBar_Volume.Scroll += new System.EventHandler(this.trackBar_Volume_Scroll);
            // 
            // label_X
            // 
            this.label_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_X.AutoSize = true;
            this.label_X.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_X.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.label_X.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_X.Location = new System.Drawing.Point(6, 28);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(45, 17);
            this.label_X.TabIndex = 3;
            this.label_X.Text = "倍数X1";
            this.label_X.Click += new System.EventHandler(this.label_X_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.trackBar_Progress);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.lblTime);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(865, 16);
            this.panel3.TabIndex = 5;
            // 
            // trackBar_Progress
            // 
            this.trackBar_Progress.AutoSize = false;
            this.trackBar_Progress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar_Progress.Enabled = false;
            this.trackBar_Progress.Location = new System.Drawing.Point(60, 0);
            this.trackBar_Progress.Maximum = 100;
            this.trackBar_Progress.Name = "trackBar_Progress";
            this.trackBar_Progress.Size = new System.Drawing.Size(745, 16);
            this.trackBar_Progress.TabIndex = 1;
            this.trackBar_Progress.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_Progress.ValueChanged += new System.EventHandler(this.trackBar_Progress_ValueChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotal.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotal.Location = new System.Drawing.Point(805, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 16);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "00:00:00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTime.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(0, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(60, 16);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.vlcControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(865, 475);
            this.panel2.TabIndex = 5;
            // 
            // vlcControl1
            // 
            this.vlcControl1.BackColor = System.Drawing.Color.Black;
            this.vlcControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vlcControl1.Location = new System.Drawing.Point(0, 0);
            this.vlcControl1.Name = "vlcControl1";
            this.vlcControl1.Size = new System.Drawing.Size(865, 475);
            this.vlcControl1.Spu = -1;
            this.vlcControl1.TabIndex = 0;
            this.vlcControl1.Text = "vlcControl1";
            this.vlcControl1.VlcLibDirectory = null;
            this.vlcControl1.VlcMediaplayerOptions = null;
            this.vlcControl1.VlcLibDirectoryNeeded += new System.EventHandler<Vlc.DotNet.Forms.VlcLibDirectoryNeededEventArgs>(this.vlcControl1_VlcLibDirectoryNeeded);
            this.vlcControl1.Playing += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerPlayingEventArgs>(this.vlcControl1_Playing);
            this.vlcControl1.PositionChanged += new System.EventHandler<Vlc.DotNet.Core.VlcMediaPlayerPositionChangedEventArgs>(this.vlcControl1_PositionChanged);
            // 
            // PlayVideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(865, 531);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PlayVideoForm";
            this.Text = "PlayVideoForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayVideoForm_FormClosing);
            this.Load += new System.EventHandler(this.PlayVideoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Volume)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Progress)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBar_Volume;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TrackBar trackBar_Progress;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTime;
        private Sunny.UI.UISymbolButton uiSymbolButton_Play;
        private Sunny.UI.UISymbolButton uiSymbolButton_Forw;
        private Sunny.UI.UISymbolButton uiSymbolButton_Back;
        private Sunny.UI.UISymbolButton uiSymbolButton_Pause;
        private System.Windows.Forms.Panel panel2;
        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private Sunny.UI.UISymbolButton uiSymbolButton_ChooseFile;
        private System.Windows.Forms.Label label2;
    }
}