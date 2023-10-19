using AutoRepairShop.Core.dtos;
using AutoRepairShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRepairShop.App.View.Forms
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
            this.Init();
        }

        private string[] _headers = new string[]
        { "Id", "Артикул", "Наименование", "Описание", "Картинка",
        "Категория", "Производитель", "Мера", "Колличество", "Скидка", "Цена" };
        private int _countRows = 5;
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

        public class ProductFull
        {
            public int Id { get; set; }
            public string Article { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public Image Picture { get; set; }
            public int CategoryId { get; set; }
            public int ManufacturerId { get; set; }
            public int UnitId { get; set; }
            public int Count { get; set; }
            public double Discount { get; set; }
            public string Price { get; set; }
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
            
            var productTable = new List<Product>(Services.ProductSelectService.Select(dto, _countRows, _page * _countRows));


            dataGridView.Columns.Clear();
            dataGridView.DataSource = productTable.ConvertAll<ProductFull>(product =>
            {
                var tryPath = Environment.CurrentDirectory + "//images//" + product.Picture;
                Image picture = File.Exists(tryPath) ? Image.FromFile(tryPath) : Properties.Resources.picture;
                var resize = new Bitmap(100, 90);
                Graphics.FromImage(resize).DrawImage(picture, 0, 0, 100, 90);
                picture = resize;
                return new ProductFull
                {
                    Id = product.Id,
                    Description = product.Description,
                    Discount = Math.Round(product.Discount * 100),
                    Article = product.Article,
                    CategoryId = product.CategoryId,
                    Count = product.Count,
                    ManufacturerId = product.ManufacturerId,
                    Name = product.Name,
                    Price = "(" + Math.Round(product.Price, 2) + ") -> " + Math.Round(product.Price * (1 - product.Discount), 2),
                    UnitId = product.UnitId,
                    Picture = picture,
                };
             });
            dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            for (int i = 0; i < _headers.Length; i++)
                dataGridView.Columns[i].HeaderText = _headers[i];
            if (State.UserRole == Roles.Manager || State.UserRole == Roles.Admin)
            {
                var editButton = new DataGridViewImageColumn
                {
                    Image = Properties.Resources.edit,
                    ImageLayout = DataGridViewImageCellLayout.Zoom
                };
                dataGridView.Columns.Add(editButton);
                var deleteButton = new DataGridViewImageColumn
                {
                    Image = Properties.Resources.delete,
                    ImageLayout = DataGridViewImageCellLayout.Zoom
                };
                dataGridView.Columns.Add(deleteButton);
            }
            

            counterRowsLabel.Text = Services.ProductSelectService.Count.ToString();
            _maxPage = Services.ProductSelectService.Count / _countRows;
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

        private void Form_Load(object sender, EventArgs e)
        {
            if (State.UserRole == Roles.User || State.UserRole == Roles.NoAuth)
                addButton.Visible = false;
            else addButton.Visible = true;

            searchField.Items.AddRange(_headers);
            searchField.SelectedIndex = 0;
            sortField.Items.AddRange(_headers);
            sortField.SelectedIndex = 0;
            sortBox.SelectedIndex = 0;
            filterField.Items.AddRange(_headers);
            filterField.SelectedIndex = 0;
            Services.ProductSelectService.UpdateData();
            smartSelect_Action();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView.Columns[9].Index && e.RowIndex >= 0)
            {
                /*var date = (string)dataGridView.Rows[e.RowIndex].Cells[4].Value;
                var user = new UserFull
                {
                    Id = (int)dataGridView.Rows[e.RowIndex].Cells[0].Value,
                    Name = (string)dataGridView.Rows[e.RowIndex].Cells[1].Value,
                    Surname = (string)dataGridView.Rows[e.RowIndex].Cells[2].Value,
                    Patronomic = (string)dataGridView.Rows[e.RowIndex].Cells[3].Value,
                    DateOfBirth = date,
                    Phone = (string)dataGridView.Rows[e.RowIndex].Cells[5].Value,
                    Role = (int)dataGridView.Rows[e.RowIndex].Cells[6].Value,
                    Login = (string)dataGridView.Rows[e.RowIndex].Cells[7].Value,
                    Hash = (string)dataGridView.Rows[e.RowIndex].Cells[8].Value,
                };
                this.SwitchFormTo(new EditUserForm(user));*/
            }

            if (e.ColumnIndex == dataGridView.Columns[10].Index && e.RowIndex >= 0)
            {
                /*int id = (int)dataGridView.Rows[e.RowIndex].Cells["Article"].Value;
                string uname = (string)dataGridView.Rows[e.RowIndex].Cells["Article"].Value;
                var act = MessageBox.Show(
                    "Вы точно хотите product с артикулом: " + id + " и именем: " + uname,
                    "Внимание", MessageBoxButtons.YesNo);
                if (act == DialogResult.Yes)
                {
                    Services.UserService.DeleteUser(id, uname);
                    Services.UserInfoSelectService.UpdateData();
                    Services.UserSelectService.UpdateData();
                    smartSelect_Action();
                }*/

            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.SwitchFormTo(new AddUserForm());
        }

        private void UsersForm_VisibleChanged(object sender, EventArgs e)
        {
            Services.ProductSelectService.UpdateData();
            smartSelect_Action(sender, e);
        }
    }
}
