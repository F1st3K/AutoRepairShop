﻿using AutoRepairShop.Core.dtos;
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
        public EditUserForm(UserDto user)
        {
            InitializeComponent();
            this.Init();
        }
    }
}
