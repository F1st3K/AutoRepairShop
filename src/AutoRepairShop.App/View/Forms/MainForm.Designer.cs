
namespace AutoRepairShop.App.View.Forms
{
    partial class MainForm
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
            this.roleText = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usersButton = new System.Windows.Forms.Button();
            this.ordersButton = new System.Windows.Forms.Button();
            this.productsButton = new System.Windows.Forms.Button();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.otherButton = new System.Windows.Forms.Button();
            this.specialButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вы вошли как:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // roleText
            // 
            this.roleText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roleText.Location = new System.Drawing.Point(12, 60);
            this.roleText.Name = "roleText";
            this.roleText.Size = new System.Drawing.Size(460, 23);
            this.roleText.TabIndex = 1;
            this.roleText.Text = "Гость";
            this.roleText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nameText
            // 
            this.nameText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameText.Location = new System.Drawing.Point(12, 83);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(460, 23);
            this.nameText.TabIndex = 2;
            this.nameText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(460, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Меню";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // usersButton
            // 
            this.usersButton.Location = new System.Drawing.Point(81, 117);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(320, 37);
            this.usersButton.TabIndex = 5;
            this.usersButton.Text = "Пользователи";
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.Visible = false;
            // 
            // ordersButton
            // 
            this.ordersButton.Location = new System.Drawing.Point(81, 160);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(320, 37);
            this.ordersButton.TabIndex = 6;
            this.ordersButton.Text = "Продажи";
            this.ordersButton.UseVisualStyleBackColor = true;
            this.ordersButton.Visible = false;
            // 
            // productsButton
            // 
            this.productsButton.Location = new System.Drawing.Point(81, 203);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(320, 37);
            this.productsButton.TabIndex = 7;
            this.productsButton.Text = "Товары";
            this.productsButton.UseVisualStyleBackColor = true;
            // 
            // createOrderButton
            // 
            this.createOrderButton.Location = new System.Drawing.Point(81, 246);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(320, 37);
            this.createOrderButton.TabIndex = 8;
            this.createOrderButton.Text = "Оформить покупку";
            this.createOrderButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(81, 412);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(320, 37);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // otherButton
            // 
            this.otherButton.Location = new System.Drawing.Point(81, 289);
            this.otherButton.Name = "otherButton";
            this.otherButton.Size = new System.Drawing.Size(320, 37);
            this.otherButton.TabIndex = 10;
            this.otherButton.Text = "Справочники";
            this.otherButton.UseVisualStyleBackColor = true;
            this.otherButton.Visible = false;
            // 
            // specialButton
            // 
            this.specialButton.Location = new System.Drawing.Point(81, 332);
            this.specialButton.Name = "specialButton";
            this.specialButton.Size = new System.Drawing.Size(320, 37);
            this.specialButton.TabIndex = 11;
            this.specialButton.Text = "Специальные возможности";
            this.specialButton.UseVisualStyleBackColor = true;
            this.specialButton.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.specialButton);
            this.Controls.Add(this.otherButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.createOrderButton);
            this.Controls.Add(this.productsButton);
            this.Controls.Add(this.ordersButton);
            this.Controls.Add(this.usersButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.roleText);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label roleText;
        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button ordersButton;
        private System.Windows.Forms.Button productsButton;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button otherButton;
        private System.Windows.Forms.Button specialButton;
    }
}