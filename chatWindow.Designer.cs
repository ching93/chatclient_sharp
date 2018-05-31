namespace chatclient
{
    partial class chatWindow
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
            this.SendBtn = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.logInBtn = new System.Windows.Forms.Button();
            this.signInBtn = new System.Windows.Forms.Button();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.adminPanelBtn = new System.Windows.Forms.Button();
            this.showUsersBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.usersList = new System.Windows.Forms.ListView();
            this.addFileBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(699, 593);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(75, 44);
            this.SendBtn.TabIndex = 0;
            this.SendBtn.Text = "Отправить";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(259, 593);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(430, 44);
            this.messageBox.TabIndex = 1;
            this.messageBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.messageBox_KeyUp);
            // 
            // logInBtn
            // 
            this.logInBtn.Location = new System.Drawing.Point(514, 7);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(127, 35);
            this.logInBtn.TabIndex = 4;
            this.logInBtn.Text = "Войти";
            this.logInBtn.UseVisualStyleBackColor = true;
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // signInBtn
            // 
            this.signInBtn.Location = new System.Drawing.Point(381, 7);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(127, 35);
            this.signInBtn.TabIndex = 5;
            this.signInBtn.Text = "Зарегистрировать пользователя";
            this.signInBtn.UseVisualStyleBackColor = true;
            this.signInBtn.Visible = false;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Location = new System.Drawing.Point(317, 7);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(0, 13);
            this.welcomeLbl.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(647, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Профиль";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // adminPanelBtn
            // 
            this.adminPanelBtn.Location = new System.Drawing.Point(270, 7);
            this.adminPanelBtn.Name = "adminPanelBtn";
            this.adminPanelBtn.Size = new System.Drawing.Size(105, 35);
            this.adminPanelBtn.TabIndex = 9;
            this.adminPanelBtn.Text = "Панель администратора";
            this.adminPanelBtn.UseVisualStyleBackColor = true;
            this.adminPanelBtn.Visible = false;
            this.adminPanelBtn.Click += new System.EventHandler(this.adminPanelBtn_Click);
            // 
            // showUsersBtn
            // 
            this.showUsersBtn.Location = new System.Drawing.Point(12, 7);
            this.showUsersBtn.Name = "showUsersBtn";
            this.showUsersBtn.Size = new System.Drawing.Size(118, 35);
            this.showUsersBtn.TabIndex = 10;
            this.showUsersBtn.Text = "Пользователи";
            this.showUsersBtn.UseVisualStyleBackColor = true;
            this.showUsersBtn.Visible = false;
            this.showUsersBtn.Click += new System.EventHandler(this.showUsersBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(195, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(583, 527);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(575, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Публичный чат";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(575, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Чаты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // usersList
            // 
            this.usersList.FullRowSelect = true;
            this.usersList.Location = new System.Drawing.Point(12, 60);
            this.usersList.Name = "usersList";
            this.usersList.Size = new System.Drawing.Size(177, 577);
            this.usersList.TabIndex = 12;
            this.usersList.UseCompatibleStateImageBehavior = false;
            this.usersList.View = System.Windows.Forms.View.Details;
            // 
            // addFileBtn
            // 
            this.addFileBtn.Location = new System.Drawing.Point(195, 593);
            this.addFileBtn.Name = "addFileBtn";
            this.addFileBtn.Size = new System.Drawing.Size(55, 43);
            this.addFileBtn.TabIndex = 13;
            this.addFileBtn.Text = "Файл..";
            this.addFileBtn.UseVisualStyleBackColor = true;
            // 
            // chatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 649);
            this.Controls.Add(this.addFileBtn);
            this.Controls.Add(this.usersList);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.showUsersBtn);
            this.Controls.Add(this.adminPanelBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.SendBtn);
            this.Name = "chatWindow";
            this.Text = "Чат";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button logInBtn;
        private System.Windows.Forms.Button signInBtn;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button adminPanelBtn;
        private System.Windows.Forms.Button showUsersBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView usersList;
        private System.Windows.Forms.Button addFileBtn;
    }
}

