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
    public partial class CreateOrderForm : Form
    {
        public CreateOrderForm()
        {
            InitializeComponent();
            this.Init();
        }
        private string[] _headers = new string[]
        { "Id", "Артикул", "Наименование", "Описание", "Картинка",
        "Категория", "Производитель", "Мера", "Колличество", "Цена",  "Скидка", "Итого" };
        private int _countRows = 3;
        private int _page;
        private int _maxPage;
        private List<Cart> _cart = new List<Cart>();


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
            public double Price { get; set; }
            public double Discount { get; set; }
            public double EndPrice { get; set; }
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
                    Discount = Math.Round(product.Discount * 100, 2),
                    Article = product.Article,
                    CategoryId = product.CategoryId,
                    Count = product.Count,
                    ManufacturerId = product.ManufacturerId,
                    Name = product.Name,
                    Price = Math.Round(product.Price, 2),
                    EndPrice = Math.Round(product.Price * (1 - product.Discount), 2),
                    UnitId = product.UnitId,
                    Picture = picture,
                };
            });
            dataGridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            var columnPlus = new DataGridViewImageColumn 
            { Image = Properties.Resources.plus, ImageLayout = DataGridViewImageCellLayout.Zoom };
            dataGridView.Columns.Add(columnPlus);

            for (int i = 0; i < _headers.Length; i++)
                dataGridView.Columns[i].HeaderText = _headers[i];
            

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

            searchField.Items.AddRange(_headers);
            searchField.SelectedIndex = 0;
            sortField.Items.AddRange(_headers);
            sortField.SelectedIndex = 0;
            sortBox.SelectedIndex = 0;
            filterField.Items.AddRange(_headers);
            filterField.SelectedIndex = 0;
            Services.ProductSelectService.UpdateData();
            var user = State.OrderUserInfo;
            nameLabel.Text = user.Surname + " " + user.Name + " " + user.Patronomic;
            dobLabel.Text = user.DOB;
            phoneLabel.Text = user.Phone;
            
            
            smartSelect_Action();
        }

        public class Cart
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Image Picture { get; set; }
            public double Price { get; set; }
            public int Count { get; set; }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != dataGridView.Columns[12].Index && e.RowIndex < 0)
                return;
            var row = dataGridView.Rows[e.RowIndex].Cells;
            int id = (int)row[0].Value;
            int count = (int)row[8].Value;
            if (_cart.Any(r => r.Id == id))
            {
                var cartRow = _cart.Find(r => r.Id == id);
                if (cartRow.Count < count)
                    cartRow.Count++;
            }
                
            else
                _cart.Add(new Cart
                {
                    Id = id,
                    Name = (string)row[2].Value,
                    Picture = (Image)row[4].Value,
                    Price = (double)row[11].Value,
                    Count = 1
                }) ;
            dataGridViewCart.Columns.Clear();
            dataGridViewCart.DataSource = new List<Cart>(_cart);

            var columnMinus = new DataGridViewImageColumn
            { Image = Properties.Resources.minus, ImageLayout = DataGridViewImageCellLayout.Zoom };
            dataGridViewCart.Columns.Add(columnMinus);

            priceLabel.Text = Math.Round(_cart.Sum(r => r.Count * r.Price), 2).ToString();
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

        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dataGridViewCart.Rows[e.RowIndex].Cells;
                int id = (int)row[0].Value;
                var cartRow = _cart.Find(r => r.Id == id);
                if (e.ColumnIndex == dataGridViewCart.Columns[5].Index && e.RowIndex >= 0)
                {
                    cartRow.Count--;
                    if (cartRow.Count <= 0)
                        _cart.Remove(cartRow);

                    dataGridViewCart.Columns.Clear();
                    dataGridViewCart.DataSource = new List<Cart>(_cart);

                    var columnMinus = new DataGridViewImageColumn
                    { Image = Properties.Resources.minus, ImageLayout = DataGridViewImageCellLayout.Zoom };
                    dataGridViewCart.Columns.Add(columnMinus);
                    priceLabel.Text = Math.Round(_cart.Sum(r => r.Count * r.Price), 2).ToString();
                }
            }
            catch { };
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Вы точно хотите оформить заказ:" + nameLabel.Text + "" +
                " на сумму: " + priceLabel.Text + " рублей?",
                "Внимание!", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;

            var dto = new OrderDto
            {
                Price = float.Parse(priceLabel.Text),
                UserInfoId = State.OrderUserInfo.Id,
                Products = _cart.ConvertAll(p => new OrderDto.ProductDto
                {
                    ProductId = p.Id,
                    Count = p.Count
                }).ToArray()
            };

            Services.OrderService.CreateOrder(dto);
        }
    }
}
