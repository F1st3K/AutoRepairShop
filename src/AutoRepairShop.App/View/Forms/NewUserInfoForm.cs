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
    public partial class NewUserInfoForm : Form
    {
        public NewUserInfoForm()
        {
            InitializeComponent();
            this.Init();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.SwitchToBackForm();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            State.OrderUserInfo = new Core.Entities.UserInfo
            {
                Name = nameText.Text,
                Surname = surnameText.Text,
                Patronomic = patronomicText.Text,
                DOB = dobText.Text,
                Phone = phoneText.Text,
            };
            Services.UserService.CreateUser(new Core.dtos.UserDto
            {
                Name = nameText.Text,
                Surname = surnameText.Text,
                Patronomic = patronomicText.Text,
                DateOfBirth = dobText.Text,
                Phone = phoneText.Text,
                Role = 0
            }) ;
            this.SwitchToBackForm();
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {
            addButton.Enabled = nameText.Text != string.Empty
                && surnameText.Text != string.Empty;
        }
    }
}
