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
            this.SwitchFormTo(new MainForm());
        }

        private void regLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

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
            UserState.ClearState();
        }
    }
}
