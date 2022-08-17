namespace NET_FiveMinutes_004_EncryptPlay
{
    partial class EncryptVideoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_OriginVideoPath = new System.Windows.Forms.TextBox();
            this.textBox_DestinationVideoPath = new System.Windows.Forms.TextBox();
            this.button_Enctpy = new System.Windows.Forms.Button();
            this.button_OriginVidePath = new System.Windows.Forms.Button();
            this.button_Showbit = new System.Windows.Forms.Button();
            this.textBox_EncryptPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 22F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origin Video Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 22F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Destination Video Path:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 22F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(11, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Encrypt Password(16 bit):";
            // 
            // textBox_OriginVideoPath
            // 
            this.textBox_OriginVideoPath.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_OriginVideoPath.Location = new System.Drawing.Point(287, 22);
            this.textBox_OriginVideoPath.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_OriginVideoPath.Name = "textBox_OriginVideoPath";
            this.textBox_OriginVideoPath.Size = new System.Drawing.Size(719, 33);
            this.textBox_OriginVideoPath.TabIndex = 9;
            // 
            // textBox_DestinationVideoPath
            // 
            this.textBox_DestinationVideoPath.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DestinationVideoPath.Location = new System.Drawing.Point(287, 93);
            this.textBox_DestinationVideoPath.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_DestinationVideoPath.Name = "textBox_DestinationVideoPath";
            this.textBox_DestinationVideoPath.Size = new System.Drawing.Size(719, 33);
            this.textBox_DestinationVideoPath.TabIndex = 10;
            // 
            // button_Enctpy
            // 
            this.button_Enctpy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.button_Enctpy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Enctpy.FlatAppearance.BorderSize = 0;
            this.button_Enctpy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Enctpy.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.button_Enctpy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Enctpy.Location = new System.Drawing.Point(0, 218);
            this.button_Enctpy.Margin = new System.Windows.Forms.Padding(2);
            this.button_Enctpy.Name = "button_Enctpy";
            this.button_Enctpy.Size = new System.Drawing.Size(1070, 72);
            this.button_Enctpy.TabIndex = 12;
            this.button_Enctpy.Text = "ENCRYPT";
            this.button_Enctpy.UseVisualStyleBackColor = false;
            this.button_Enctpy.Click += new System.EventHandler(this.button_Enctpy_Click);
            // 
            // button_OriginVidePath
            // 
            this.button_OriginVidePath.Location = new System.Drawing.Point(1020, 22);
            this.button_OriginVidePath.Name = "button_OriginVidePath";
            this.button_OriginVidePath.Size = new System.Drawing.Size(33, 33);
            this.button_OriginVidePath.TabIndex = 13;
            this.button_OriginVidePath.Text = "…";
            this.button_OriginVidePath.UseVisualStyleBackColor = true;
            this.button_OriginVidePath.Click += new System.EventHandler(this.button_OriginVidePath_Click);
            // 
            // button_Showbit
            // 
            this.button_Showbit.Location = new System.Drawing.Point(1020, 157);
            this.button_Showbit.Name = "button_Showbit";
            this.button_Showbit.Size = new System.Drawing.Size(33, 33);
            this.button_Showbit.TabIndex = 15;
            this.button_Showbit.Text = "16";
            this.button_Showbit.UseVisualStyleBackColor = true;
            // 
            // textBox_EncryptPassword
            // 
            this.textBox_EncryptPassword.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EncryptPassword.Location = new System.Drawing.Point(287, 160);
            this.textBox_EncryptPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_EncryptPassword.Name = "textBox_EncryptPassword";
            this.textBox_EncryptPassword.PasswordChar = '*';
            this.textBox_EncryptPassword.Size = new System.Drawing.Size(719, 33);
            this.textBox_EncryptPassword.TabIndex = 16;
            this.textBox_EncryptPassword.TextChanged += new System.EventHandler(this.textBox_EncryptPassword_TextChanged);
            // 
            // EncryptVideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1070, 290);
            this.Controls.Add(this.textBox_EncryptPassword);
            this.Controls.Add(this.button_Showbit);
            this.Controls.Add(this.button_OriginVidePath);
            this.Controls.Add(this.button_Enctpy);
            this.Controls.Add(this.textBox_DestinationVideoPath);
            this.Controls.Add(this.textBox_OriginVideoPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EncryptVideoForm";
            this.Text = "EncryptVideoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_OriginVideoPath;
        private System.Windows.Forms.TextBox textBox_DestinationVideoPath;
        private System.Windows.Forms.Button button_Enctpy;
        private System.Windows.Forms.Button button_OriginVidePath;
        private System.Windows.Forms.Button button_Showbit;
        private System.Windows.Forms.TextBox textBox_EncryptPassword;
    }
}