using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using ChatDbObjects;
using System.Threading;

namespace chatclient
{
    public partial class chatWindow : Form
    {
        ChatApplication app;
        Task refreshTask;
        public int refreshDelay = 2000;

        public chatWindow()
        {
            InitializeComponent();
            this.app = new ChatApplication(true, this);
            app.messageIncome += acceptMessage;
            refreshTask = new Task(RefreshData);

        }
        public void acceptMessage(dbResult result)
        {
            Console.WriteLine("сообщение из главного окна");
            if (result.isSuccessful)
                switch (result.selectAction)
                {
                    case dbSelectAction.SELECT_ALL_USERS:
                        fillUserList(result.objects);
                        break;
                }
        }
        void fillUserList(IEnumerable<object> users)
        {
            usersList.Items.Clear();
            foreach (User user in users)
            {
                var item = new ListViewItem(new string[] { user.login });
                usersList.Items.Add(item);
            }
        }
        DialogResult ShowVerifyDialog()
        {
            var verWnd = new VerifyDialog(app);
            DialogResult res = verWnd.ShowDialog(this);
            app.setForm(this);
            if (res == DialogResult.OK)
            {
                User cuser = app.getCurrentUser();
                var now = DateTime.Now;
                String msg;
                if (now.Hour < 12)
                    msg = "Доброе утро";
                else if (now.Hour < 18)
                    msg = "Добрый день";
                else
                    msg = "Добрый вечер";
                this.welcomeLbl.Text = msg+", " + cuser.firstname + " " + cuser.lastname + "!";
                if (cuser.role.id == 1)
                {
                    signInBtn.Visible = true;
                    adminPanelBtn.Visible = true;
                    showUsersBtn.Visible = true;
                }
                StartRefresh();
            }
            return res;
        }
        DialogResult showRegisterDialog()
        {
            RegisterDialog dialog = new RegisterDialog(app);
            app.setForm(this);
            return dialog.ShowDialog(this);
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            messageBox.Text = "";
            messageBox.Focus();
        }

        private void messageBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //app.sendMessage(messageBox.Text);
                messageBox.Text = "dick";
            }
                
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            if (showRegisterDialog() == DialogResult.OK)
                MessageBox.Show("Пользователь успешно добавлен");
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            if (ShowVerifyDialog() == DialogResult.OK)
            {
                
            }
        }

        private void adminPanelBtn_Click(object sender, EventArgs e)
        {

        }

        private void showUsersBtn_Click(object sender, EventArgs e)
        {
            userSelectDialog dialog = new userSelectDialog(app);
            String msg = "";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                List<User> users = dialog.selectedUsers;
                foreach (User u in users)
                    msg += u.login + ", " + u.firstname + " " + u.lastname+";";
                MessageBox.Show(msg);
            }

        }
        void StartRefresh()
        {
            refreshTask.Start();
        }
        void RefreshData()
        {
            while (true)
            {
                try
                {
                    if (app.isVerified)
                    {
                        app.getAllUsers();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Thread.Sleep(refreshDelay);
            }
        }
    }
}
