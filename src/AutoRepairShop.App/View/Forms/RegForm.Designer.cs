
namespace AutoRepairShop.App.View.Forms
{
    partial class RegForm
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
            this.nameText = new System.Windows.Forms.MaskedTextBox();
            this.surnameText = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.patronomicText = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dobText = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.loginText = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rememberPaswordText = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.registrationButton = new System.Windows.Forms.Button();
            this.loginLink = new System.Windows.Forms.LinkLabel();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(32, 31);
            this.nameText.Mask = ">L<???????????????????????????????????????????????????????????";
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(203, 31);
            this.nameText.TabIndex = 1;
            // 
            // surnameText
            // 
            this.surnameText.Location = new System.Drawing.Point(32, 92);
            this.surnameText.Mask = ">L<???????????????????????????????????????????????????????????";
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(203, 31);
            this.surnameText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия:";
            // 
            // patronomicText
            // 
            this.patronomicText.Location = new System.Drawing.Point(32, 153);
            this.patronomicText.Mask = ">L<???????????????????????????????????????????????????????????";
            this.patronomicText.Name = "patronomicText";
            this.patronomicText.Size = new System.Drawing.Size(203, 31);
            this.patronomicText.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество:";
            // 
            // dobText
            // 
            this.dobText.Location = new System.Drawing.Point(32, 214);
            this.dobText.Mask = "00/00/0000";
            this.dobText.Name = "dobText";
            this.dobText.Size = new System.Drawing.Size(203, 31);
            this.dobText.TabIndex = 7;
            this.dobText.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата рождения:";
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(255, 31);
            this.phoneText.Mask = "+7(999) 000-0000";
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(203, 31);
            this.phoneText.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Номер телефона:";
            // 
            // loginText
            // 
            this.loginText.Location = new System.Drawing.Point(255, 92);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(203, 31);
            this.loginText.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Логин:";
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(255, 153);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '●';
            this.passwordText.Size = new System.Drawing.Size(203, 31);
            this.passwordText.TabIndex = 13;
            this.passwordText.TextChanged += new System.EventHandler(this.passwordText_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Пароль:";
            // 
            // rememberPaswordText
            // 
            this.rememberPaswordText.Location = new System.Drawing.Point(255, 214);
            this.rememberPaswordText.Name = "rememberPaswordText";
            this.rememberPaswordText.PasswordChar = '●';
            this.rememberPaswordText.Size = new System.Drawing.Size(203, 31);
            this.rememberPaswordText.TabIndex = 15;
            this.rememberPaswordText.TextChanged += new System.EventHandler(this.passwordText_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 24);
            this.label8.TabIndex = 14;
            this.label8.Text = "Повторите пароль:";
            // 
            // registrationButton
            // 
            this.registrationButton.Enabled = false;
            this.registrationButton.Location = new System.Drawing.Point(137, 251);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(217, 39);
            this.registrationButton.TabIndex = 16;
            this.registrationButton.Text = "Зарегистрироваться";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.registrationButton_Click);
            // 
            // loginLink
            // 
            this.loginLink.AutoSize = true;
            this.loginLink.Location = new System.Drawing.Point(212, 293);
            this.loginLink.Name = "loginLink";
            this.loginLink.Size = new System.Drawing.Size(68, 24);
            this.loginLink.TabIndex = 17;
            this.loginLink.TabStop = true;
            this.loginLink.Text = "Войти";
            this.loginLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginLink_LinkClicked);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(137, 320);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(217, 39);
            this.exitButton.TabIndex = 18;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loginLink);
            this.Controls.Add(this.registrationButton);
            this.Controls.Add(this.rememberPaswordText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.loginText);
            this.Controls.Add(this.label6);
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
            this.Name = "RegForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox nameText;
        private System.Windows.Forms.MaskedTextBox surnameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox patronomicText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox dobText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox phoneText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox loginText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox passwordText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox rememberPaswordText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.LinkLabel loginLink;
        private System.Windows.Forms.Button exitButton;
    }
}