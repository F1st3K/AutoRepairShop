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
    public partial class MainForm : Form
    {
        private Roles _role = Roles.NoAuth;

        public MainForm()
        {
            InitializeComponent();
            this.Init();
        }

        public MainForm(Roles role, int uid) : this()
        {
            _role = role;
            if (_role == Roles.NoAuth) return;
            
        }
    }
}
