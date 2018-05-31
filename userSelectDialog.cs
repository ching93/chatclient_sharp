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
    public partial class userSelectDialog : Form
    {
        ChatApplication app;
        List<User> users;
        public List<User> selectedUsers { get {
                List<User> selected = new List<User>();
                foreach (ListViewItem item in usersListView.Items)
                    if (item.Checked)
                        foreach (User user in users)
                        {
                            if (item.SubItems[0].Text == user.login)
                                selected.Add(user);
                        }
                return selected;
            }
            private set {

            }
        }
        public userSelectDialog(ChatApplication app)
        {
            InitializeComponent();
            users = new List<User>();
            this.app = app;
            this.app.setForm(this);
            this.app.messageIncome += acceptMessage;
            usersListView.Columns.Add("Логин");
            usersListView.Columns.Add("Имя");
            usersListView.Columns.Add("Фамилия");
            usersListView.Columns.Add("email");
            usersListView.Columns.Add("Время регистрации");
            usersListView.Columns.Add("Роль");
            app.getAllUsers();
        }
        void acceptMessage (dbResult result)
        {
            Console.WriteLine("Принято сообщение");
            if (result.isSuccessful && result.selectAction == dbSelectAction.SELECT_ALL_USERS)
            {
                usersListView.Items.Clear();
                foreach (User user in result.objects)
                {
                    users.Add(user);
                    var subitems = new String[6];
                    subitems[0] = user.login;
                    subitems[1] = user.firstname;
                    subitems[2] = user.lastname;
                    subitems[3] = user.email;
                    subitems[4] = user.registerTime.ToShortDateString();
                    subitems[5] = user.role.Name;
                    ListViewItem item = new ListViewItem(subitems);
                    item.Checked = true;
                    usersListView.Items.Add(item);
                    
                }
            }
            else
                MessageBox.Show(result.message);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in usersListView.Items)
            {
                item.Checked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in usersListView.Items)
            {
                item.Checked = false;
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void userSelectDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            app.messageIncome -= acceptMessage;
        }
    }
}
