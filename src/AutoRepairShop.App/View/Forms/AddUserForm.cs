using AutoRepairShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRepairShop.App.View.Forms
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
            this.Init();
            roleBox.SelectedIndex = 0;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.SwitchToBackForm();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Services.UserService.CreateUser(new UserFull
            {
                Name = nameText.Text,
                Surname = surnameText.Text,
                Patronomic = patronomicText.Text,
                DateOfBirth = dobText.Text,
                Phone = phoneText.Text,
                Role = roleBox.SelectedIndex,
                Login = loginText.Text,
                Hash = Services.HashService.Hash(passwordText.Text),
            });
            this.SwitchToBackForm();
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {
            if (roleBox.SelectedIndex == 0)
            {
                loginText.Visible = false;
                loginLabel.Visible = false;
                passwordText.Visible = false;
                pwdLabel.Visible = false;
                rememberPaswordText.Visible = false;
                rememberPwdLabel.Visible = false;
            }
            else
            {
                loginText.Visible = true;
                loginLabel.Visible = true;
                passwordText.Visible = true;
                pwdLabel.Visible = true;
                rememberPaswordText.Visible = true;
                rememberPwdLabel.Visible = true;
            }

            addButton.Enabled = (passwordText.Visible == false || passwordText.Text == rememberPaswordText.Text)
                && (DateTime.TryParse(dobText.Text, out _) || dobText.Text == "  .  .")
                && (loginText.Text != string.Empty || loginText.Visible == false)
                && nameText.Text != string.Empty
                && surnameText.Text != string.Empty;
        }
    }
}
