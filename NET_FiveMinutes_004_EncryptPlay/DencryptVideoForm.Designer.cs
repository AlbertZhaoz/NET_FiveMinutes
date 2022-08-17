namespace NET_FiveMinutes_004_EncryptPlay
{
    partial class DencryptVideoForm
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
            this.textBox_DencryptPassword = new System.Windows.Forms.TextBox();
            this.button_OriginVidePath = new System.Windows.Forms.Button();
            this.button_Denctpy = new System.Windows.Forms.Button();
            this.textBox_DestinationVideoPath = new System.Windows.Forms.TextBox();
            this.textBox_OriginVideoPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_DestinationVideoPath = new System.Windows.Forms.Button();
            this.button_Progress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_DencryptPassword
            // 
            this.textBox_DencryptPassword.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DencryptPassword.Location = new System.Drawing.Point(287, 151);
            this.textBox_DencryptPassword.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_DencryptPassword.Name = "textBox_DencryptPassword";
            this.textBox_DencryptPassword.PasswordChar = '*';
            this.textBox_DencryptPassword.Size = new System.Drawing.Size(719, 33);
            this.textBox_DencryptPassword.TabIndex = 26;
            // 
            // button_OriginVidePath
            // 
            this.button_OriginVidePath.Location = new System.Drawing.Point(1020, 13);
            this.button_OriginVidePath.Name = "button_OriginVidePath";
            this.button_OriginVidePath.Size = new System.Drawing.Size(33, 33);
            this.button_OriginVidePath.TabIndex = 24;
            this.button_OriginVidePath.Text = "…";
            this.button_OriginVidePath.UseVisualStyleBackColor = true;
            this.button_OriginVidePath.Click += new System.EventHandler(this.button_OriginVidePath_Click);
            // 
            // button_Denctpy
            // 
            this.button_Denctpy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(65)))), ((int)(((byte)(24)))));
            this.button_Denctpy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Denctpy.FlatAppearance.BorderSize = 0;
            this.button_Denctpy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Denctpy.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.button_Denctpy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Denctpy.Location = new System.Drawing.Point(0, 216);
            this.button_Denctpy.Margin = new System.Windows.Forms.Padding(2);
            this.button_Denctpy.Name = "button_Denctpy";
            this.button_Denctpy.Size = new System.Drawing.Size(1074, 72);
            this.button_Denctpy.TabIndex = 23;
            this.button_Denctpy.Text = "DENCRYPT";
            this.button_Denctpy.UseVisualStyleBackColor = false;
            this.button_Denctpy.Click += new System.EventHandler(this.button_Denctpy_Click);
            // 
            // textBox_DestinationVideoPath
            // 
            this.textBox_DestinationVideoPath.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_DestinationVideoPath.Location = new System.Drawing.Point(287, 84);
            this.textBox_DestinationVideoPath.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_DestinationVideoPath.Name = "textBox_DestinationVideoPath";
            this.textBox_DestinationVideoPath.Size = new System.Drawing.Size(719, 33);
            this.textBox_DestinationVideoPath.TabIndex = 22;
            // 
            // textBox_OriginVideoPath
            // 
            this.textBox_OriginVideoPath.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_OriginVideoPath.Location = new System.Drawing.Point(287, 13);
            this.textBox_OriginVideoPath.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_OriginVideoPath.Name = "textBox_OriginVideoPath";
            this.textBox_OriginVideoPath.Size = new System.Drawing.Size(719, 33);
            this.textBox_OriginVideoPath.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 22F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(11, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 36);
            this.label4.TabIndex = 20;
            this.label4.Text = "Dencrypt Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 22F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 36);
            this.label3.TabIndex = 19;
            this.label3.Text = "Destination Video Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 22F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "Origin Video Path:";
            // 
            // button_DestinationVideoPath
            // 
            this.button_DestinationVideoPath.Location = new System.Drawing.Point(1020, 84);
            this.button_DestinationVideoPath.Name = "button_DestinationVideoPath";
            this.button_DestinationVideoPath.Size = new System.Drawing.Size(33, 33);
            this.button_DestinationVideoPath.TabIndex = 27;
            this.button_DestinationVideoPath.Text = "…";
            this.button_DestinationVideoPath.UseVisualStyleBackColor = true;
            this.button_DestinationVideoPath.Click += new System.EventHandler(this.button_DestinationVideoPath_Click);
            // 
            // button_Progress
            // 
            this.button_Progress.Location = new System.Drawing.Point(1020, 151);
            this.button_Progress.Name = "button_Progress";
            this.button_Progress.Size = new System.Drawing.Size(33, 33);
            this.button_Progress.TabIndex = 28;
            this.button_Progress.Text = "0%";
            this.button_Progress.UseVisualStyleBackColor = true;
            // 
            // DencryptVideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(59)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1074, 288);
            this.Controls.Add(this.button_Progress);
            this.Controls.Add(this.button_DestinationVideoPath);
            this.Controls.Add(this.textBox_DencryptPassword);
            this.Controls.Add(this.button_OriginVidePath);
            this.Controls.Add(this.button_Denctpy);
            this.Controls.Add(this.textBox_DestinationVideoPath);
            this.Controls.Add(this.textBox_OriginVideoPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DencryptVideoForm";
            this.Text = "DencryptVideoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_DencryptPassword;
        private System.Windows.Forms.Button button_OriginVidePath;
        private System.Windows.Forms.Button button_Denctpy;
        private System.Windows.Forms.TextBox textBox_DestinationVideoPath;
        private System.Windows.Forms.TextBox textBox_OriginVideoPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_DestinationVideoPath;
        private System.Windows.Forms.Button button_Progress;
    }
}