using System.Windows.Forms;

namespace AutoRepairShop.App.View.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Init();
            switch (State.UserRole)
            {
                case Roles.NoAuth:
                    return;
                case Roles.Admin: AdminMode();
                    break;
                case Roles.Manager: ManagerMode();
                    break;
                case Roles.User: UserMode();
                    break;
            }
            if (State.UserInfo == null) return;
            nameText.Text = State.UserInfo.Surname + 
                " " + State.UserInfo.Name + 
                " " + State.UserInfo.Patronomic;
        }

        private void UserMode()
        {
            roleText.Text = "Пользователь";
        }

        public void ManagerMode()
        {
            roleText.Text = "Менеджер";
            ordersButton.Visible = true;
        }

        public void AdminMode()
        {
            roleText.Text = "Администратор";
            ordersButton.Visible = true;
            usersButton.Visible = true;
            otherButton.Visible = true;
            specialButton.Visible = true;
        }

        private void exitButton_Click(object sender, System.EventArgs e)
        {
            this.SwitchToBackForm();
            State.ClearUserState();
        }

        private void usersButton_Click(object sender, System.EventArgs e)
        {
            this.SwitchFormTo(new UsersForm());
        }

        private void productsButton_Click(object sender, System.EventArgs e)
        {
            this.SwitchFormTo(new ProductsForm());
        }
    }
}
