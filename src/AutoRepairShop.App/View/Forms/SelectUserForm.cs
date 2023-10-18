﻿using AutoRepairShop.Core.dtos;
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
    public partial class SelectUserForm : Form
    {
        public SelectUserForm()
        {
            InitializeComponent();
        }

        private string[] _headers = new string[]
       { "Id", "Имя", "Фамилия", "Отчество", "Дата Рождения", "Телефон" };
        private int _countRows = 19;
        private int _page;
        private int _maxPage;

        private void backButton_Click(object sender, EventArgs e)
        {
            this.SwitchToBackForm();
        }

        private void smartSelect_Action(object sender, EventArgs e)
        {
            if (searchField.SelectedIndex == -1 ||
                sortField.SelectedIndex == -1 ||
                sortBox.SelectedIndex == -1 ||
                filterField.SelectedIndex == -1)
                return;
            smartSelect_Action();
        }

        private void smartSelect_Action()
        {
            var dto = new SelectDto
            {
                Filter = filterBox.Text,
                FilterColumn = filterField.SelectedIndex,
                Sort = (SelectDto.TypeSort)sortBox.SelectedIndex,
                SortColumn = sortField.SelectedIndex,
                Search = searchText.Text,
                SearchColumn = searchField.SelectedIndex,
            };
            
            var userTable = new List<UserInfo>(Services.UserInfoSelectService.Select(dto, _countRows, _page * _countRows));

            dataGridView.Columns.Clear();
            dataGridView.DataSource = userTable;
            for (int i = 0; i < _headers.Length; i++)
                dataGridView.Columns[i].HeaderText = _headers[i];

            counterRowsLabel.Text = Services.UserInfoSelectService.Count.ToString();
            _maxPage = Services.UserInfoSelectService.Count / _countRows;
            currentPaggination.Text = (_page + 1).ToString();
        }

        private void startPaggination_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _page = 0;
            smartSelect_Action();
        }

        private void backPaggination_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _page = _page - 1 < 0 ? _page : _page - 1;
            smartSelect_Action();
        }

        private void nextPaggination_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _page = _page + 1 > _maxPage ? _page : _page + 1;
            smartSelect_Action();
        }

        private void endPaggination_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _page = _maxPage;
            smartSelect_Action();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            searchField.Items.AddRange(_headers);
            searchField.SelectedIndex = 0;
            sortField.Items.AddRange(_headers);
            sortField.SelectedIndex = 0;
            sortBox.SelectedIndex = 0;
            filterField.Items.AddRange(_headers);
            filterField.SelectedIndex = 0;
            Services.UserInfoSelectService.UpdateData();
            Services.UserSelectService.UpdateData();
            smartSelect_Action();
        }

        private void UsersForm_VisibleChanged(object sender, EventArgs e)
        {
            Services.UserInfoSelectService.UpdateData();
            Services.UserSelectService.UpdateData();
            smartSelect_Action(sender, e);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            this.SwitchFormTo(new NewUserInfoForm(), () => this.SwitchToBackForm());
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var user = new UserInfo
                {
                    Id = (int)dataGridView.Rows[e.RowIndex].Cells[0].Value,
                    Name = (string)dataGridView.Rows[e.RowIndex].Cells[1].Value,
                    Surname = (string)dataGridView.Rows[e.RowIndex].Cells[2].Value,
                    Patronomic = (string)dataGridView.Rows[e.RowIndex].Cells[3].Value,
                    DOB = (string)dataGridView.Rows[e.RowIndex].Cells[4].Value,
                    Phone = (string)dataGridView.Rows[e.RowIndex].Cells[5].Value,
                };
                State.OrderUserInfo = user;
                this.SwitchToBackForm();
            }
        }
    }
}
