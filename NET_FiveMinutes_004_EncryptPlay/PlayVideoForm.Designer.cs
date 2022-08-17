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
            this.uiSymbolButton_ChooseFile = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton_Forw = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton_Back = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton_Pause = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton_Play = new Sunny.UI.UISymbolButton();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vlcControl1 = new Vlc.DotNet.Forms.VlcControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uiSymbolButton_ChooseFile);
            this.panel1.Controls.Add(this.uiSymbolButton_Forw);
            this.panel1.Controls.Add(this.uiSymbolButton_Back);
            this.panel1.Controls.Add(this.uiSymbolButton_Pause);
            this.panel1.Controls.Add(this.uiSymbolButton_Play);
            this.panel1.Controls.Add(this.trackBar2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 475);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 56);
            this.panel1.TabIndex = 4;
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
            // trackBar2
            // 
            this.trackBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar2.AutoSize = false;
            this.trackBar2.Location = new System.Drawing.Point(727, 28);
            this.trackBar2.Maximum = 120;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(126, 16);
            this.trackBar2.TabIndex = 6;
            this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar2.Value = 100;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(667, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "倍速：1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.lblTime);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(865, 16);
            this.panel3.TabIndex = 5;
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.Enabled = false;
            this.trackBar1.Location = new System.Drawing.Point(60, 0);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(745, 16);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
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
            this.Load += new System.EventHandler(this.PlayVideoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vlcControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTime;
        private Sunny.UI.UISymbolButton uiSymbolButton_Play;
        private Sunny.UI.UISymbolButton uiSymbolButton_Forw;
        private Sunny.UI.UISymbolButton uiSymbolButton_Back;
        private Sunny.UI.UISymbolButton uiSymbolButton_Pause;
        private System.Windows.Forms.Panel panel2;
        private Vlc.DotNet.Forms.VlcControl vlcControl1;
        private Sunny.UI.UISymbolButton uiSymbolButton_ChooseFile;
    }
}