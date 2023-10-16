using AutoRepairShop.Core.dtos;
using System;
using System.Windows.Forms;

namespace AutoRepairShop.App.View.Forms
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
            this.Init();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            string dateOfBirth = String.Empty;
            if (DateTime.TryParse(dobText.Text, out var dob ))
                dateOfBirth = dob.ToString("yyyy-MM-dd");

            var dto = new RegDto
            { 
                Name = nameText.Text,
                Surname = surnameText.Text,
                Patronomic = patronomicText.Text,
                DOB = dateOfBirth,
                Phone = phoneText.Text,
                UniqName = loginText.Text,
                Password = passwordText.Text,
                RoleId = (int)Roles.User
            };
            if (Services.AuthService.TrySignUp(dto) == false)
            {
                MessageBox.Show("Логин не уникален!");
                return;
            }
            this.SwitchToBackForm();
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.SwitchToBackForm();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {
            registrationButton.Enabled = passwordText.Text == rememberPaswordText.Text
                && (DateTime.TryParse(dobText.Text, out _) || dobText.Text == "  .  .");
        }
    }
}
