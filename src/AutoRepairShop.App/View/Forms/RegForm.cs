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
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
            this.Init();
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {

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
            registrationButton.Enabled = passwordText.Text == rememberPaswordText.Text;
        }
    }
}
