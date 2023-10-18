
namespace AutoRepairShop.App.View.Forms
{
    partial class EditUserForm
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
            this.editButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.roleBox = new System.Windows.Forms.ComboBox();
            this.rememberPaswordText = new System.Windows.Forms.MaskedTextBox();
            this.rememberPwdLabel = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.MaskedTextBox();
            this.pwdLable = new System.Windows.Forms.Label();
            this.loginText = new System.Windows.Forms.MaskedTextBox();
            this.loginLabel = new System.Windows.Forms.Label();
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
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(369, 408);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(265, 38);
            this.editButton.TabIndex = 53;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(51, 408);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(269, 38);
            this.backButton.TabIndex = 55;
            this.backButton.Text = "В пользователи";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(361, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(226, 24);
            this.label10.TabIndex = 54;
            this.label10.Text = "Данные авторизации:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(365, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 24);
            this.label9.TabIndex = 52;
            this.label9.Text = "Роль:";
            // 
            // roleBox
            // 
            this.roleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleBox.FormattingEnabled = true;
            this.roleBox.Items.AddRange(new object[] {
            "Гость",
            "Администратор",
            "Менеджер",
            "Пользователь"});
            this.roleBox.Location = new System.Drawing.Point(365, 100);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(269, 32);
            this.roleBox.TabIndex = 46;
            this.roleBox.SelectedIndexChanged += new System.EventHandler(this.roleBox_SelectedIndexChanged);
            // 
            // rememberPaswordText
            // 
            this.rememberPaswordText.Location = new System.Drawing.Point(365, 283);
            this.rememberPaswordText.Name = "rememberPaswordText";
            this.rememberPaswordText.PasswordChar = '●';
            this.rememberPaswordText.Size = new System.Drawing.Size(269, 31);
            this.rememberPaswordText.TabIndex = 51;
            this.rememberPaswordText.TextChanged += new System.EventHandler(this.roleBox_SelectedIndexChanged);
            // 
            // rememberPwdLabel
            // 
            this.rememberPwdLabel.AutoSize = true;
            this.rememberPwdLabel.Location = new System.Drawing.Point(361, 257);
            this.rememberPwdLabel.Name = "rememberPwdLabel";
            this.rememberPwdLabel.Size = new System.Drawing.Size(198, 24);
            this.rememberPwdLabel.TabIndex = 50;
            this.rememberPwdLabel.Text = "Повторите пароль:";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(365, 222);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '●';
            this.passwordText.Size = new System.Drawing.Size(269, 31);
            this.passwordText.TabIndex = 49;
            this.passwordText.TextChanged += new System.EventHandler(this.roleBox_SelectedIndexChanged);
            // 
            // pwdLable
            // 
            this.pwdLable.AutoSize = true;
            this.pwdLable.Location = new System.Drawing.Point(361, 196);
            this.pwdLable.Name = "pwdLable";
            this.pwdLable.Size = new System.Drawing.Size(91, 24);
            this.pwdLable.TabIndex = 48;
            this.pwdLable.Text = "Пароль:";
            // 
            // loginText
            // 
            this.loginText.Location = new System.Drawing.Point(365, 161);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(269, 31);
            this.loginText.TabIndex = 47;
            this.loginText.TextChanged += new System.EventHandler(this.roleBox_SelectedIndexChanged);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(361, 135);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(78, 24);
            this.loginLabel.TabIndex = 45;
            this.loginLabel.Text = "Логин:";
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(51, 283);
            this.phoneText.Mask = "+7(999) 000-0000";
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(269, 31);
            this.phoneText.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 24);
            this.label5.TabIndex = 43;
            this.label5.Text = "Номер телефона:";
            // 
            // dobText
            // 
            this.dobText.Location = new System.Drawing.Point(51, 225);
            this.dobText.Mask = "00/00/0000";
            this.dobText.Name = "dobText";
            this.dobText.Size = new System.Drawing.Size(269, 31);
            this.dobText.TabIndex = 42;
            this.dobText.ValidatingType = typeof(System.DateTime);
            this.dobText.TextChanged += new System.EventHandler(this.roleBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 24);
            this.label4.TabIndex = 41;
            this.label4.Text = "Дата рождения:";
            // 
            // patronomicText
            // 
            this.patronomicText.Location = new System.Drawing.Point(51, 164);
            this.patronomicText.Mask = ">L<???????????????????????????????????????????????????????????";
            this.patronomicText.Name = "patronomicText";
            this.patronomicText.Size = new System.Drawing.Size(269, 31);
            this.patronomicText.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Отчество:";
            // 
            // surnameText
            // 
            this.surnameText.Location = new System.Drawing.Point(51, 103);
            this.surnameText.Mask = ">L<???????????????????????????????????????????????????????????";
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(269, 31);
            this.surnameText.TabIndex = 38;
            this.surnameText.TextChanged += new System.EventHandler(this.roleBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Фамилия:";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(51, 42);
            this.nameText.Mask = ">L<???????????????????????????????????????????????????????????";
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(269, 31);
            this.nameText.TabIndex = 36;
            this.nameText.TextChanged += new System.EventHandler(this.roleBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 35;
            this.label1.Text = "Имя:";
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.roleBox);
            this.Controls.Add(this.rememberPaswordText);
            this.Controls.Add(this.rememberPwdLabel);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.pwdLable);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.loginLabel);
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
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EditUserForm";
            this.Text = "Редактирование пользователя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox roleBox;
        private System.Windows.Forms.MaskedTextBox rememberPaswordText;
        private System.Windows.Forms.Label rememberPwdLabel;
        private System.Windows.Forms.MaskedTextBox passwordText;
        private System.Windows.Forms.Label pwdLable;
        private System.Windows.Forms.MaskedTextBox loginText;
        private System.Windows.Forms.Label loginLabel;
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