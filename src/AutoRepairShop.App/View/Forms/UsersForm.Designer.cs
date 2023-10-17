
namespace AutoRepairShop.App.View.Forms
{
    partial class UsersForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            this.sortBox = new System.Windows.Forms.ComboBox();
            this.filterBox = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.counterRowsLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.startPaggination = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.backPaggination = new System.Windows.Forms.LinkLabel();
            this.currentPaggination = new System.Windows.Forms.LinkLabel();
            this.nextPaggination = new System.Windows.Forms.LinkLabel();
            this.endPaggination = new System.Windows.Forms.LinkLabel();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Поиск";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(398, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сортировка";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(784, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фильтрация";
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(16, 43);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(376, 31);
            this.searchText.TabIndex = 3;
            // 
            // sortBox
            // 
            this.sortBox.FormattingEnabled = true;
            this.sortBox.Location = new System.Drawing.Point(402, 43);
            this.sortBox.Name = "sortBox";
            this.sortBox.Size = new System.Drawing.Size(376, 32);
            this.sortBox.TabIndex = 4;
            // 
            // filterBox
            // 
            this.filterBox.FormattingEnabled = true;
            this.filterBox.Location = new System.Drawing.Point(788, 43);
            this.filterBox.Name = "filterBox";
            this.filterBox.Size = new System.Drawing.Size(376, 32);
            this.filterBox.TabIndex = 5;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(16, 100);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1156, 458);
            this.dataGridView.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 561);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Колличество записей:";
            // 
            // counterRowsLabel
            // 
            this.counterRowsLabel.Location = new System.Drawing.Point(248, 561);
            this.counterRowsLabel.Name = "counterRowsLabel";
            this.counterRowsLabel.Size = new System.Drawing.Size(144, 30);
            this.counterRowsLabel.TabIndex = 8;
            this.counterRowsLabel.Text = "0";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(16, 607);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(376, 42);
            this.backButton.TabIndex = 20;
            this.backButton.Text = "В меню";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // startPaggination
            // 
            this.startPaggination.AutoSize = true;
            this.startPaggination.Location = new System.Drawing.Point(881, 561);
            this.startPaggination.Name = "startPaggination";
            this.startPaggination.Size = new System.Drawing.Size(42, 24);
            this.startPaggination.TabIndex = 12;
            this.startPaggination.TabStop = true;
            this.startPaggination.Text = "<<";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(784, 561);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 30);
            this.label6.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(1069, 561);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 30);
            this.label7.TabIndex = 14;
            // 
            // backPaggination
            // 
            this.backPaggination.AutoSize = true;
            this.backPaggination.Location = new System.Drawing.Point(929, 561);
            this.backPaggination.Name = "backPaggination";
            this.backPaggination.Size = new System.Drawing.Size(26, 24);
            this.backPaggination.TabIndex = 15;
            this.backPaggination.TabStop = true;
            this.backPaggination.Text = "<";
            // 
            // currentPaggination
            // 
            this.currentPaggination.AutoSize = true;
            this.currentPaggination.Location = new System.Drawing.Point(961, 561);
            this.currentPaggination.Name = "currentPaggination";
            this.currentPaggination.Size = new System.Drawing.Size(22, 24);
            this.currentPaggination.TabIndex = 16;
            this.currentPaggination.TabStop = true;
            this.currentPaggination.Text = "0";
            this.currentPaggination.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nextPaggination
            // 
            this.nextPaggination.AutoSize = true;
            this.nextPaggination.Location = new System.Drawing.Point(989, 561);
            this.nextPaggination.Name = "nextPaggination";
            this.nextPaggination.Size = new System.Drawing.Size(26, 24);
            this.nextPaggination.TabIndex = 17;
            this.nextPaggination.TabStop = true;
            this.nextPaggination.Text = ">";
            this.nextPaggination.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // endPaggination
            // 
            this.endPaggination.AutoSize = true;
            this.endPaggination.Location = new System.Drawing.Point(1021, 561);
            this.endPaggination.Name = "endPaggination";
            this.endPaggination.Size = new System.Drawing.Size(42, 24);
            this.endPaggination.TabIndex = 18;
            this.endPaggination.TabStop = true;
            this.endPaggination.Text = ">>";
            this.endPaggination.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(788, 607);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(376, 42);
            this.addButton.TabIndex = 19;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
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
            this.Controls.Add(this.filterBox);
            this.Controls.Add(this.sortBox);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UsersForm";
            this.Text = "Пользователи";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.ComboBox sortBox;
        private System.Windows.Forms.ComboBox filterBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label counterRowsLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.LinkLabel startPaggination;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel backPaggination;
        private System.Windows.Forms.LinkLabel currentPaggination;
        private System.Windows.Forms.LinkLabel nextPaggination;
        private System.Windows.Forms.LinkLabel endPaggination;
        private System.Windows.Forms.Button addButton;
    }
}