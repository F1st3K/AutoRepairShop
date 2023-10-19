
namespace AutoRepairShop.App.View.Forms
{
    partial class CreateOrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.filterBox = new System.Windows.Forms.TextBox();
            this.filterField = new System.Windows.Forms.ComboBox();
            this.sortField = new System.Windows.Forms.ComboBox();
            this.searchField = new System.Windows.Forms.ComboBox();
            this.endPaggination = new System.Windows.Forms.LinkLabel();
            this.nextPaggination = new System.Windows.Forms.LinkLabel();
            this.currentPaggination = new System.Windows.Forms.LinkLabel();
            this.backPaggination = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.startPaggination = new System.Windows.Forms.LinkLabel();
            this.backButton = new System.Windows.Forms.Button();
            this.counterRowsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.sortBox = new System.Windows.Forms.ComboBox();
            this.searchText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.createButton = new System.Windows.Forms.Button();
            this.dobLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.SuspendLayout();
            // 
            // filterBox
            // 
            this.filterBox.Location = new System.Drawing.Point(788, 43);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(227, 31);
            this.filterBox.TabIndex = 51;
            this.filterBox.TextChanged += new System.EventHandler(this.smartSelect_Action);
            // 
            // filterField
            // 
            this.filterField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterField.FormattingEnabled = true;
            this.filterField.Location = new System.Drawing.Point(1024, 43);
            this.filterField.Name = "filterField";
            this.filterField.Size = new System.Drawing.Size(140, 32);
            this.filterField.TabIndex = 53;
            this.filterField.SelectedIndexChanged += new System.EventHandler(this.smartSelect_Action);
            // 
            // sortField
            // 
            this.sortField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortField.FormattingEnabled = true;
            this.sortField.Location = new System.Drawing.Point(638, 43);
            this.sortField.Name = "sortField";
            this.sortField.Size = new System.Drawing.Size(140, 32);
            this.sortField.TabIndex = 48;
            this.sortField.SelectedIndexChanged += new System.EventHandler(this.smartSelect_Action);
            // 
            // searchField
            // 
            this.searchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchField.FormattingEnabled = true;
            this.searchField.Location = new System.Drawing.Point(248, 43);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(140, 32);
            this.searchField.TabIndex = 46;
            this.searchField.SelectedIndexChanged += new System.EventHandler(this.smartSelect_Action);
            // 
            // endPaggination
            // 
            this.endPaggination.AutoSize = true;
            this.endPaggination.Location = new System.Drawing.Point(1130, 399);
            this.endPaggination.Name = "endPaggination";
            this.endPaggination.Size = new System.Drawing.Size(42, 24);
            this.endPaggination.TabIndex = 60;
            this.endPaggination.TabStop = true;
            this.endPaggination.Text = ">>";
            this.endPaggination.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.endPaggination.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.endPaggination_LinkClicked);
            // 
            // nextPaggination
            // 
            this.nextPaggination.AutoSize = true;
            this.nextPaggination.Location = new System.Drawing.Point(1098, 399);
            this.nextPaggination.Name = "nextPaggination";
            this.nextPaggination.Size = new System.Drawing.Size(26, 24);
            this.nextPaggination.TabIndex = 59;
            this.nextPaggination.TabStop = true;
            this.nextPaggination.Text = ">";
            this.nextPaggination.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.nextPaggination.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nextPaggination_LinkClicked);
            // 
            // currentPaggination
            // 
            this.currentPaggination.AutoSize = true;
            this.currentPaggination.Location = new System.Drawing.Point(1070, 399);
            this.currentPaggination.Name = "currentPaggination";
            this.currentPaggination.Size = new System.Drawing.Size(22, 24);
            this.currentPaggination.TabIndex = 58;
            this.currentPaggination.TabStop = true;
            this.currentPaggination.Text = "0";
            this.currentPaggination.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // backPaggination
            // 
            this.backPaggination.AutoSize = true;
            this.backPaggination.Location = new System.Drawing.Point(1038, 399);
            this.backPaggination.Name = "backPaggination";
            this.backPaggination.Size = new System.Drawing.Size(26, 24);
            this.backPaggination.TabIndex = 57;
            this.backPaggination.TabStop = true;
            this.backPaggination.Text = "<";
            this.backPaggination.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backPaggination_LinkClicked);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(893, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 30);
            this.label6.TabIndex = 55;
            // 
            // startPaggination
            // 
            this.startPaggination.AutoSize = true;
            this.startPaggination.Location = new System.Drawing.Point(990, 399);
            this.startPaggination.Name = "startPaggination";
            this.startPaggination.Size = new System.Drawing.Size(42, 24);
            this.startPaggination.TabIndex = 54;
            this.startPaggination.TabStop = true;
            this.startPaggination.Text = "<<";
            this.startPaggination.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.startPaggination_LinkClicked);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(608, 607);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(226, 42);
            this.backButton.TabIndex = 62;
            this.backButton.Text = "В меню";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // counterRowsLabel
            // 
            this.counterRowsLabel.Location = new System.Drawing.Point(840, 399);
            this.counterRowsLabel.Name = "counterRowsLabel";
            this.counterRowsLabel.Size = new System.Drawing.Size(144, 30);
            this.counterRowsLabel.TabIndex = 52;
            this.counterRowsLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(604, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 30);
            this.label4.TabIndex = 50;
            this.label4.Text = "Колличество записей:";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(16, 80);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1156, 310);
            this.dataGridView.TabIndex = 49;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // sortBox
            // 
            this.sortBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortBox.FormattingEnabled = true;
            this.sortBox.Items.AddRange(new object[] {
            "Нет",
            "По возврастанию",
            "По убыванию"});
            this.sortBox.Location = new System.Drawing.Point(402, 43);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(230, 32);
            this.sortBox.TabIndex = 47;
            this.sortBox.SelectedIndexChanged += new System.EventHandler(this.smartSelect_Action);
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(16, 43);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(226, 31);
            this.searchText.TabIndex = 45;
            this.searchText.TextChanged += new System.EventHandler(this.smartSelect_Action);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(784, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 58);
            this.label3.TabIndex = 44;
            this.label3.Text = "Фильтрация";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(398, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 58);
            this.label2.TabIndex = 43;
            this.label2.Text = "Сортировка";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 58);
            this.label1.TabIndex = 42;
            this.label1.Text = "Поиск";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 24);
            this.label5.TabIndex = 63;
            this.label5.Text = "Оформление продажи для:";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(608, 476);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(564, 24);
            this.nameLabel.TabIndex = 64;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 24);
            this.label7.TabIndex = 65;
            this.label7.Text = "Корзина:";
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.AllowUserToAddRows = false;
            this.dataGridViewCart.AllowUserToDeleteRows = false;
            this.dataGridViewCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Location = new System.Drawing.Point(16, 426);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.ReadOnly = true;
            this.dataGridViewCart.Size = new System.Drawing.Size(578, 223);
            this.dataGridViewCart.TabIndex = 66;
            this.dataGridViewCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCart_CellContentClick);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(844, 607);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(328, 42);
            this.createButton.TabIndex = 67;
            this.createButton.Text = "Оформить";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // dobLabel
            // 
            this.dobLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.Location = new System.Drawing.Point(608, 514);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(284, 24);
            this.dobLabel.TabIndex = 68;
            this.dobLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // phoneLabel
            // 
            this.phoneLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(898, 514);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(266, 24);
            this.phoneLabel.TabIndex = 69;
            this.phoneLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(840, 580);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 24);
            this.label8.TabIndex = 70;
            this.label8.Text = "Итого:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(921, 580);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(22, 24);
            this.priceLabel.TabIndex = 71;
            this.priceLabel.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1092, 580);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 24);
            this.label9.TabIndex = 72;
            this.label9.Text = "рублей";
            // 
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.dataGridViewCart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.filterField);
            this.Controls.Add(this.sortField);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.endPaggination);
            this.Controls.Add(this.nextPaggination);
            this.Controls.Add(this.currentPaggination);
            this.Controls.Add(this.backPaggination);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.startPaggination);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.counterRowsLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.sortBox);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateOrderForm";
            this.Text = "Оформление продажи";
            this.Load += new System.EventHandler(this.Form_Load);
            this.VisibleChanged += new System.EventHandler(this.UsersForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filterBox;
        private System.Windows.Forms.ComboBox filterField;
        private System.Windows.Forms.ComboBox sortField;
        private System.Windows.Forms.ComboBox searchField;
        private System.Windows.Forms.LinkLabel endPaggination;
        private System.Windows.Forms.LinkLabel nextPaggination;
        private System.Windows.Forms.LinkLabel currentPaggination;
        private System.Windows.Forms.LinkLabel backPaggination;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel startPaggination;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label counterRowsLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox sortBox;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label label9;
    }
}