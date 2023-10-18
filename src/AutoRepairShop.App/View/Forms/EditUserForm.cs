using AutoRepairShop.Core.dtos;
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
    public partial class EditUserForm : Form
    {
        private UserFull _fillUser;

        public EditUserForm(UserFull user)
        {
            _fillUser = user;
            InitializeComponent();
            this.Init();
            var date = user.DateOfBirth;
            if (DateTime.TryParse(date, out var d))
                date = d.ToString("MM.dd.yyyy");
            nameText.Text = user.Name;
            surnameText.Text = user.Surname;
            patronomicText.Text = user.Patronomic;
            dobText.Text = date;
            phoneText.Text = user.Phone;
            roleBox.SelectedIndex = user.Role;
            loginText.Text = user.Login;

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.SwitchToBackForm();
        }

        private void roleBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roleBox.SelectedIndex == 0)
            {
                loginText.Visible = false;
                loginLabel.Visible = false;
                passwordText.Visible = false;
                pwdLable.Visible = false;
                rememberPwdLabel.Visible = false;
                rememberPaswordText.Visible = false;
            }
            else
            {
                loginText.Visible = true;
                loginLabel.Visible = true;
                passwordText.Visible = true;
                pwdLable.Visible = true;
                rememberPaswordText.Visible = passwordText.Text != string.Empty;
                rememberPwdLabel.Visible = passwordText.Text != string.Empty;
            }
            

            editButton.Enabled = (passwordText.Text == string.Empty
                || passwordText.Visible == false || passwordText.Text == rememberPaswordText.Text)
                && (DateTime.TryParse(dobText.Text, out _) || dobText.Text == "  .  .")
                && (loginText.Text != string.Empty || loginText.Visible == false)
                && nameText.Text != string.Empty
                && surnameText.Text != string.Empty;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Services.UserService.EditUser(new UserFull
            {
                Id = _fillUser.Id,
                Name = nameText.Text,
                Surname = surnameText.Text,
                Patronomic = patronomicText.Text,
                DateOfBirth = dobText.Text,
                Phone = phoneText.Text,
                Role = roleBox.SelectedIndex,
                Login = loginText.Text,
                Hash = passwordText.Text != string.Empty
                ? Services.HashService.Hash(passwordText.Text)
                : _fillUser.Hash,
            }) ;
            Services.UserInfoSelectService.UpdateData();
            Services.UserSelectService.UpdateData();
            this.SwitchToBackForm();
        }
    }
}
