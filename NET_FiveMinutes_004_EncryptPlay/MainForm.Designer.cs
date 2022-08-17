namespace NET_FiveMinutes_004_EncryptPlay
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_PlayEncVideo = new System.Windows.Forms.Button();
            this.button_EncryptVideo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_PlayEncVideo
            // 
            this.button_PlayEncVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.button_PlayEncVideo.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_PlayEncVideo.FlatAppearance.BorderSize = 0;
            this.button_PlayEncVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PlayEncVideo.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PlayEncVideo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_PlayEncVideo.Location = new System.Drawing.Point(288, 0);
            this.button_PlayEncVideo.Margin = new System.Windows.Forms.Padding(2);
            this.button_PlayEncVideo.Name = "button_PlayEncVideo";
            this.button_PlayEncVideo.Size = new System.Drawing.Size(303, 378);
            this.button_PlayEncVideo.TabIndex = 2;
            this.button_PlayEncVideo.Text = "PLAY ENC VIDEO";
            this.button_PlayEncVideo.UseVisualStyleBackColor = false;
            this.button_PlayEncVideo.Click += new System.EventHandler(this.button_PlayEncVideo_Click);
            // 
            // button_EncryptVideo
            // 
            this.button_EncryptVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.button_EncryptVideo.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_EncryptVideo.FlatAppearance.BorderSize = 0;
            this.button_EncryptVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EncryptVideo.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EncryptVideo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_EncryptVideo.Location = new System.Drawing.Point(0, 0);
            this.button_EncryptVideo.Margin = new System.Windows.Forms.Padding(2);
            this.button_EncryptVideo.Name = "button_EncryptVideo";
            this.button_EncryptVideo.Size = new System.Drawing.Size(292, 378);
            this.button_EncryptVideo.TabIndex = 1;
            this.button_EncryptVideo.Text = "ENCRYPT VIDEO";
            this.button_EncryptVideo.UseVisualStyleBackColor = false;
            this.button_EncryptVideo.Click += new System.EventHandler(this.button_EncryptVideo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_EncryptVideo);
            this.panel1.Controls.Add(this.button_PlayEncVideo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(591, 378);
            this.panel1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 378);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_PlayEncVideo;
        private System.Windows.Forms.Button button_EncryptVideo;
        private System.Windows.Forms.Panel panel1;
    }
}

