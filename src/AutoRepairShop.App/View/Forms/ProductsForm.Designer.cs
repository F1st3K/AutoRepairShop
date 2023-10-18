
namespace AutoRepairShop.App.View.Forms
{
    partial class ProductsForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.endPaggination = new System.Windows.Forms.LinkLabel();
            this.nextPaggination = new System.Windows.Forms.LinkLabel();
            this.currentPaggination = new System.Windows.Forms.LinkLabel();
            this.backPaggination = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // filterBox
            // 
            this.filterBox.Location = new System.Drawing.Point(788, 44);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(227, 31);
            this.filterBox.TabIndex = 30;
            this.filterBox.TextChanged += new System.EventHandler(this.smartSelect_Action);
            // 
            // filterField
            // 
            this.filterField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterField.FormattingEnabled = true;
            this.filterField.Location = new System.Drawing.Point(1024, 44);
            this.filterField.Name = "filterField";
            this.filterField.Size = new System.Drawing.Size(140, 32);
            this.filterField.TabIndex = 32;
            this.filterField.SelectedIndexChanged += new System.EventHandler(this.smartSelect_Action);
            // 
            // sortField
            // 
            this.sortField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortField.FormattingEnabled = true;
            this.sortField.Location = new System.Drawing.Point(638, 44);
            this.sortField.Name = "sortField";
            this.sortField.Size = new System.Drawing.Size(140, 32);
            this.sortField.TabIndex = 27;
            this.sortField.SelectedIndexChanged += new System.EventHandler(this.smartSelect_Action);
            // 
            // searchField
            // 
            this.searchField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchField.FormattingEnabled = true;
            this.searchField.Location = new System.Drawing.Point(248, 44);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(140, 32);
            this.searchField.TabIndex = 25;
            this.searchField.SelectedIndexChanged += new System.EventHandler(this.smartSelect_Action);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(788, 608);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(376, 42);
            this.addButton.TabIndex = 40;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // endPaggination
            // 
            this.endPaggination.AutoSize = true;
            this.endPaggination.Location = new System.Drawing.Point(1021, 577);
            this.endPaggination.Name = "endPaggination";
            this.endPaggination.Size = new System.Drawing.Size(42, 24);
            this.endPaggination.TabIndex = 39;
            this.endPaggination.TabStop = true;
            this.endPaggination.Text = ">>";
            this.endPaggination.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.endPaggination.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.endPaggination_LinkClicked);
            // 
            // nextPaggination
            // 
            this.nextPaggination.AutoSize = true;
            this.nextPaggination.Location = new System.Drawing.Point(989, 577);
            this.nextPaggination.Name = "nextPaggination";
            this.nextPaggination.Size = new System.Drawing.Size(26, 24);
            this.nextPaggination.TabIndex = 38;
            this.nextPaggination.TabStop = true;
            this.nextPaggination.Text = ">";
            this.nextPaggination.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.nextPaggination.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.nextPaggination_LinkClicked);
            // 
            // currentPaggination
            // 
            this.currentPaggination.AutoSize = true;
            this.currentPaggination.Location = new System.Drawing.Point(961, 577);
            this.currentPaggination.Name = "currentPaggination";
            this.currentPaggination.Size = new System.Drawing.Size(22, 24);
            this.currentPaggination.TabIndex = 37;
            this.currentPaggination.TabStop = true;
            this.currentPaggination.Text = "0";
            this.currentPaggination.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // backPaggination
            // 
            this.backPaggination.AutoSize = true;
            this.backPaggination.Location = new System.Drawing.Point(929, 577);
            this.backPaggination.Name = "backPaggination";
            this.backPaggination.Size = new System.Drawing.Size(26, 24);
            this.backPaggination.TabIndex = 36;
            this.backPaggination.TabStop = true;
            this.backPaggination.Text = "<";
            this.backPaggination.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.backPaggination_LinkClicked);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(1069, 577);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 30);
            this.label7.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(784, 577);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 30);
            this.label6.TabIndex = 34;
            // 
            // startPaggination
            // 
            this.startPaggination.AutoSize = true;
            this.startPaggination.Location = new System.Drawing.Point(881, 577);
            this.startPaggination.Name = "startPaggination";
            this.startPaggination.Size = new System.Drawing.Size(42, 24);
            this.startPaggination.TabIndex = 33;
            this.startPaggination.TabStop = true;
            this.startPaggination.Text = "<<";
            this.startPaggination.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.startPaggination_LinkClicked);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(16, 608);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(376, 42);
            this.backButton.TabIndex = 41;
            this.backButton.Text = "В меню";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // counterRowsLabel
            // 
            this.counterRowsLabel.Location = new System.Drawing.Point(248, 577);
            this.counterRowsLabel.Name = "counterRowsLabel";
            this.counterRowsLabel.Size = new System.Drawing.Size(144, 30);
            this.counterRowsLabel.TabIndex = 31;
            this.counterRowsLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 577);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 30);
            this.label4.TabIndex = 29;
            this.label4.Text = "Колличество записей:";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(16, 81);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1156, 493);
            this.dataGridView.TabIndex = 28;
            // 
            // sortBox
            // 
            this.sortBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortBox.FormattingEnabled = true;
            this.sortBox.Items.AddRange(new object[] {
            "Нет",
            "По возврастанию",
            "По убыванию"});
            this.sortBox.Location = new System.Drawing.Point(402, 44);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(230, 32);
            this.sortBox.TabIndex = 26;
            this.sortBox.SelectedIndexChanged += new System.EventHandler(this.smartSelect_Action);
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(16, 44);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(226, 31);
            this.searchText.TabIndex = 24;
            this.searchText.TextChanged += new System.EventHandler(this.smartSelect_Action);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(784, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 30);
            this.label3.TabIndex = 23;
            this.label3.Text = "Фильтрация";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(398, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "Сортировка";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "Поиск";
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.filterField);
            this.Controls.Add(this.sortField);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.endPaggination);
            this.Controls.Add(this.nextPaggination);
            this.Controls.Add(this.currentPaggination);
            this.Controls.Add(this.backPaggination);
            this.Controls.Add(this.label7);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.Load += new System.EventHandler(this.Form_Load);
            this.VisibleChanged += new System.EventHandler(this.UsersForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filterBox;
        private System.Windows.Forms.ComboBox filterField;
        private System.Windows.Forms.ComboBox sortField;
        private System.Windows.Forms.ComboBox searchField;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.LinkLabel endPaggination;
        private System.Windows.Forms.LinkLabel nextPaggination;
        private System.Windows.Forms.LinkLabel currentPaggination;
        private System.Windows.Forms.LinkLabel backPaggination;
        private System.Windows.Forms.Label label7;
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
    }
}