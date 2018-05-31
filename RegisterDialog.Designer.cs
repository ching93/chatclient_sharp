namespace chatclient
{
    partial class RegisterDialog
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
            this.loginBox = new System.Windows.Forms.TextBox();
            this.firstnameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lastnameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordRepeatBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.messageLogLbl = new System.Windows.Forms.Label();
            this.roleListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(15, 44);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(181, 20);
            this.loginBox.TabIndex = 1;
            // 
            // firstnameBox
            // 
            this.firstnameBox.Location = new System.Drawing.Point(15, 88);
            this.firstnameBox.Name = "firstnameBox";
            this.firstnameBox.Size = new System.Drawing.Size(181, 20);
            this.firstnameBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя:";
            // 
            // lastnameBox
            // 
            this.lastnameBox.Location = new System.Drawing.Point(15, 133);
            this.lastnameBox.Name = "lastnameBox";
            this.lastnameBox.Size = new System.Drawing.Size(181, 20);
            this.lastnameBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Фамилия";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(15, 179);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(181, 20);
            this.emailBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "email:";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(15, 226);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(181, 20);
            this.passwordBox.TabIndex = 9;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Пароль:";
            // 
            // passwordRepeatBox
            // 
            this.passwordRepeatBox.Location = new System.Drawing.Point(15, 271);
            this.passwordRepeatBox.Name = "passwordRepeatBox";
            this.passwordRepeatBox.PasswordChar = '*';
            this.passwordRepeatBox.Size = new System.Drawing.Size(181, 20);
            this.passwordRepeatBox.TabIndex = 11;
            this.passwordRepeatBox.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Повторите пароль:";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(33, 297);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(130, 23);
            this.okBtn.TabIndex = 12;
            this.okBtn.Text = "Зарегистрироваться";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // messageLogLbl
            // 
            this.messageLogLbl.AutoSize = true;
            this.messageLogLbl.Location = new System.Drawing.Point(15, 5);
            this.messageLogLbl.Name = "messageLogLbl";
            this.messageLogLbl.Size = new System.Drawing.Size(0, 13);
            this.messageLogLbl.TabIndex = 13;
            // 
            // roleListBox
            // 
            this.roleListBox.FormattingEnabled = true;
            this.roleListBox.Location = new System.Drawing.Point(12, 326);
            this.roleListBox.Name = "roleListBox";
            this.roleListBox.Size = new System.Drawing.Size(182, 30);
            this.roleListBox.TabIndex = 16;
            // 
            // RegisterDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 366);
            this.Controls.Add(this.roleListBox);
            this.Controls.Add(this.messageLogLbl);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.passwordRepeatBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastnameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.firstnameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.label1);
            this.Name = "RegisterDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Регистрация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterDialog_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.TextBox firstnameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastnameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordRepeatBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label messageLogLbl;
        private System.Windows.Forms.ListBox roleListBox;
    }
}