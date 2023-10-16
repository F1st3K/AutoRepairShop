using AutoRepairShop.Core.dtos;
using System;
using System.Windows.Forms;

namespace AutoRepairShop.App.View.Forms
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            this.Init();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var dto = new AuthDto
            {
                Login = loginText.Text,
                Password = passwordText.Text,
            };
            if (Services.AuthService.TrySignIn(dto, out var userInfo, out var roleId) == false)
            {
                MessageBox.Show("Неверный логин и/или пароль!");
                return;
            }
            State.UserInfo = userInfo;
            State.UserRole = (Roles)roleId;
            this.SwitchFormTo(new MainForm());
        }

        private void regLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.SwitchFormTo(new RegForm());
        }

        private void loginNoAuthLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.SwitchFormTo(new MainForm());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void AuthForm_Shown(object sender, EventArgs e)
        {
        }
    }
}
