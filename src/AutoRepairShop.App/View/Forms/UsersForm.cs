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
    public partial class UsersForm : Form
    {
        private string[] _headers = new string[] 
        { "Id", "Имя", "Фамилия", "Отчество", "Дата Рождения", "Телефон" };
        private int _countRows = 20;
        private int _page;
        private int _maxPage;

        public UsersForm()
        {
            InitializeComponent();
            this.Init();
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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.SwitchToBackForm();
        }

        private void smartSelect_Action(object sender, EventArgs e)
        {
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
            var userInfos = new List<UserInfo>(Services.UserInfoSelectService.Select(dto, _countRows, _page * _countRows));
            var users = new List<User>(Services.UserSelectService.Select(Services.UserSelectService.Count));
            var userTable = userInfos.ConvertAll<UserTable>(ui =>
            {

                User u = users.Find(user => ui.Id == user.InfoId);
                return new UserTable
                {
                    Id = ui.Id.ToString(),
                    Name = ui.Name,
                    SurName = ui.Surname,
                    Patronomic = ui.Patronomic,
                    DateOfBirth = ui.DOB,
                    Phone = ui.Phone,
                    Role = u != null ? u.RoleId.ToString() : "No auth",
                    Login = u != null ? u.UniqName : "",
                    Hash = u != null ? u.Hash : ""
                };
            });

            dataGridView.DataSource = userTable;
            counterRowsLabel.Text = Services.UserInfoSelectService.Count.ToString();
            _maxPage = Services.UserInfoSelectService.Count / _countRows;
            currentPaggination.Text = (_page + 1).ToString();
        }

        class UserTable
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string SurName { get; set; }
            public string Patronomic { get; set; }
            public string DateOfBirth { get; set; }
            public string Phone { get; set; }
            public string Role { get; set; }
            public string Login { get; set; }
            public string Hash { get; set; }
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
    }
}
