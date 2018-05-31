using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatDbObjects;

namespace chatclient
{
    public partial class VerifyDialog : Form
    {
        ChatApplication app;
        public VerifyDialog(ChatApplication app)
        {
            InitializeComponent();
            this.app = app;
            app.messageIncome += AcceptMessage;
        }
        public VerifyDialog()
        {
            InitializeComponent();
            try
            {
                this.app = new ChatApplication(true,this);
            }
            catch (Exception e)
            {
                ShowInfo("Не удалось подключиться к серверу: "+e.Message,Color.Red);
            }
            app.messageIncome += AcceptMessage;
        }
        void ShowInfo(String msg, Color color)
        {
            this.messageLogLabel.Text = msg;
            this.messageLogLabel.ForeColor = color;
        }
        void AcceptMessage(dbResult result)
        {
            if (result.action == dbAction.VERIFY_USER && result.isSuccessful)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                messageLogLabel.Text = result.message;
            }
        }
        private void senBtn_Click(object sender, EventArgs e)
        {
            verify_user();
        }
        void verify_user()
        {
            messageLogLabel.Text = "Запрос к серверу...";
            User cuser = new User();
            cuser.login = this.loginBox.Text;
            cuser.password = this.passwordBox.Text;
            app.setCurrentUser(cuser);
        }

        private void VerifyDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            app.messageIncome -= AcceptMessage;
            Console.WriteLine("cosing verify wnd");
        }

        private void VerifyDialog_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                verify_user();
        }
    }
}
