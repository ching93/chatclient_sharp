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
    public partial class RegisterDialog : Form
    {
        ChatApplication app;
        public RegisterDialog(ChatApplication newApp)
        {
            InitializeComponent();
            this.app = newApp;
            app.setForm(this);
            app.messageIncome += this.AcceptMessage;
            // запрашиваем существующие роли
            app.requestRoles();
        }
        void ShowInfo(String msg,Color color)
        {
            this.messageLogLbl.Text = msg;
            this.messageLogLbl.ForeColor = color;
        }
        void AcceptMessage(dbResult result)
        {
            if (result.isSuccessful)
                if (result.selectAction == dbSelectAction.SELECT_ROLES)
                {
                    roleListBox.Items.Clear();
                    foreach (Entity ent in result.objects)
                    {
                        Role role = (Role)ent;
                        roleListBox.Items.Add(role.Name);
                    }
                }
                else if (result.action == dbAction.ADD_USER)
                {
                    ShowInfo("Успешно допавлен пользователь", Color.Green);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    ShowInfo(result.message, Color.Red);
                    DialogResult = DialogResult.Cancel;
                }
        }
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text != passwordRepeatBox.Text)
            {
                ShowInfo("Пароли не совпадают",Color.Red);
                return;
            }
            User newUser = new User();
            newUser.login = this.loginBox.Text;
            newUser.firstname = this.firstnameBox.Text;
            newUser.lastname = this.lastnameBox.Text;
            newUser.email = this.emailBox.Text;
            newUser.password = this.passwordBox.Text;
            Role userRole = new Role();
            userRole.Name = roleListBox.GetItemText(roleListBox.SelectedItem);
            newUser.role = userRole;
            Console.WriteLine("role: " + userRole.Name);
            app.signUpUser(newUser);
            ShowInfo("Запрос к серверу...",Color.Black);
        }

        private void RegisterDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            app.messageIncome -= AcceptMessage;
        }
    }
}
