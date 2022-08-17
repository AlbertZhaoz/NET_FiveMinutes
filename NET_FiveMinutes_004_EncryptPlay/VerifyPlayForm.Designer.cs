namespace NET_FiveMinutes_004_EncryptPlay
{
    partial class VerifyPlayForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_EncryptPassword = new System.Windows.Forms.TextBox();
            this.button_Enctpy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 22F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(27, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Encrypt Password:";
            // 
            // textBox_EncryptPassword
            // 
            this.textBox_EncryptPassword.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_EncryptPassword.Location = new System.Drawing.Point(243, 39);
            this.textBox_EncryptPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_EncryptPassword.Name = "textBox_EncryptPassword";
            this.textBox_EncryptPassword.PasswordChar = '*';
            this.textBox_EncryptPassword.Size = new System.Drawing.Size(457, 33);
            this.textBox_EncryptPassword.TabIndex = 17;
            // 
            // button_Enctpy
            // 
            this.button_Enctpy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.button_Enctpy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Enctpy.FlatAppearance.BorderSize = 0;
            this.button_Enctpy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Enctpy.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.button_Enctpy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Enctpy.Location = new System.Drawing.Point(0, 103);
            this.button_Enctpy.Margin = new System.Windows.Forms.Padding(2);
            this.button_Enctpy.Name = "button_Enctpy";
            this.button_Enctpy.Size = new System.Drawing.Size(730, 54);
            this.button_Enctpy.TabIndex = 18;
            this.button_Enctpy.Text = "DENCRYPT";
            this.button_Enctpy.UseVisualStyleBackColor = false;
            this.button_Enctpy.Click += new System.EventHandler(this.button_Enctpy_Click);
            // 
            // VerifyPlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(730, 157);
            this.Controls.Add(this.button_Enctpy);
            this.Controls.Add(this.textBox_EncryptPassword);
            this.Controls.Add(this.label4);
            this.Name = "VerifyPlayForm";
            this.Text = "VerifyPlayForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_EncryptPassword;
        private System.Windows.Forms.Button button_Enctpy;
    }
}