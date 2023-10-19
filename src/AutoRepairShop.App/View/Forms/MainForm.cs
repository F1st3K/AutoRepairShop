using System;
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

        private void ordersButton_Click(object sender, System.EventArgs e)
        {
            this.SwitchFormTo(new OrdersForm());
        }

        private void createOrderButton_Click(object sender, System.EventArgs e)
        {
            Action action = () => {
                if (State.OrderUserInfo != null)
                    this.SwitchFormTo(new CreateOrderForm());
                else Show();
            };
            Action retryAction = () => {
                if (State.OrderUserInfo != null)
                    this.SwitchFormTo(new CreateOrderForm(), () => {
                        State.OrderUserInfo = null;
                        Show();
                    });
                else Show();
            };
            if (State.OrderUserInfo == null)
                switch (State.UserRole)
                {
                    case Roles.NoAuth: this.SwitchFormTo(new NewUserInfoForm(), action);
                        break;
                    case Roles.Admin:
                    case Roles.Manager: this.SwitchFormTo(new SelectUserForm(), retryAction);
                        break;
                    case Roles.User:
                        State.OrderUserInfo = State.UserInfo;
                        break;
                }
            else this.SwitchFormTo(new CreateOrderForm());
        }
    }
}
