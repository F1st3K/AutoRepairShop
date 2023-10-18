
namespace AutoRepairShop.App.View.Forms
{
    partial class NewUserInfoForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.phoneText = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dobText = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.patronomicText = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.surnameText = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(369, 408);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(265, 38);
            this.addButton.TabIndex = 53;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(51, 408);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(269, 38);
            this.backButton.TabIndex = 55;
            this.backButton.Text = "В меню";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(207, 293);
            this.phoneText.Mask = "+7(999) 000-0000";
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(269, 31);
            this.phoneText.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 24);
            this.label5.TabIndex = 43;
            this.label5.Text = "Номер телефона:";
            // 
            // dobText
            // 
            this.dobText.Location = new System.Drawing.Point(207, 235);
            this.dobText.Mask = "00/00/0000";
            this.dobText.Name = "dobText";
            this.dobText.Size = new System.Drawing.Size(269, 31);
            this.dobText.TabIndex = 42;
            this.dobText.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "Дата рождения:";
            // 
            // patronomicText
            // 
            this.patronomicText.Location = new System.Drawing.Point(207, 174);
            this.patronomicText.Mask = ">L<???????????????????????????????????????????????????????????";
            this.patronomicText.Name = "patronomicText";
            this.patronomicText.Size = new System.Drawing.Size(269, 31);
            this.patronomicText.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Отчество:";
            // 
            // surnameText
            // 
            this.surnameText.Location = new System.Drawing.Point(207, 113);
            this.surnameText.Mask = ">L<???????????????????????????????????????????????????????????";
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(269, 31);
            this.surnameText.TabIndex = 38;
            this.surnameText.TextChanged += new System.EventHandler(this.nameText_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Фамилия:";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(207, 52);
            this.nameText.Mask = ">L<???????????????????????????????????????????????????????????";
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(269, 31);
            this.nameText.TabIndex = 36;
            this.nameText.TextChanged += new System.EventHandler(this.nameText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Имя:";
            // 
            // NewUserInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dobText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.patronomicText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surnameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "NewUserInfoForm";
            this.Text = "Внесение информации о пользователе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.MaskedTextBox phoneText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox dobText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox patronomicText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox surnameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox nameText;
        private System.Windows.Forms.Label label1;
    }
}