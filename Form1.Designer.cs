namespace chatclient
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.SendButton = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.messageLog = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.logInBtn = new System.Windows.Forms.Button();
            this.signInBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(390, 415);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(12, 417);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(259, 20);
            this.messageBox.TabIndex = 1;
            this.messageBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.messageBox_KeyUp);
            // 
            // messageLog
            // 
            this.messageLog.Location = new System.Drawing.Point(12, 12);
            this.messageLog.Multiline = true;
            this.messageLog.Name = "messageLog";
            this.messageLog.ReadOnly = true;
            this.messageLog.Size = new System.Drawing.Size(452, 394);
            this.messageLog.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logInBtn
            // 
            this.logInBtn.Location = new System.Drawing.Point(540, 32);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(127, 23);
            this.logInBtn.TabIndex = 4;
            this.logInBtn.Text = "Войти";
            this.logInBtn.UseVisualStyleBackColor = true;
            // 
            // signInBtn
            // 
            this.signInBtn.Location = new System.Drawing.Point(540, 62);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(127, 23);
            this.signInBtn.TabIndex = 5;
            this.signInBtn.Text = "Зарегистрироваться";
            this.signInBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 450);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.messageLog);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.SendButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.TextBox messageLog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.Button signInBtn;
    }
}

