namespace chatclient
{
    partial class VerifyDialog
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
            this.senBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.messageLogLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // senBtn
            // 
            this.senBtn.Location = new System.Drawing.Point(12, 130);
            this.senBtn.Name = "senBtn";
            this.senBtn.Size = new System.Drawing.Size(117, 23);
            this.senBtn.TabIndex = 0;
            this.senBtn.Text = "Войти";
            this.senBtn.UseVisualStyleBackColor = true;
            this.senBtn.Click += new System.EventHandler(this.senBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль:";
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(12, 35);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(117, 20);
            this.loginBox.TabIndex = 3;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(12, 94);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(117, 20);
            this.passwordBox.TabIndex = 4;
            // 
            // messageLogLabel
            // 
            this.messageLogLabel.AutoSize = true;
            this.messageLogLabel.Location = new System.Drawing.Point(12, 167);
            this.messageLogLabel.Name = "messageLogLabel";
            this.messageLogLabel.Size = new System.Drawing.Size(0, 13);
            this.messageLogLabel.TabIndex = 5;
            // 
            // VerifyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(151, 192);
            this.Controls.Add(this.messageLogLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.senBtn);
            this.Name = "VerifyDialog";
            this.Text = "VerifyDialog";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VerifyDialog_FormClosing);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.VerifyDialog_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button senBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label messageLogLabel;
    }
}