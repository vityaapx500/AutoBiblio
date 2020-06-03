namespace Автобиблио
{
    partial class RegistrationForm
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
            this.btnRegistration = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbPantronymic = new System.Windows.Forms.TextBox();
            this.lblPantronymic = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbSurName = new System.Windows.Forms.TextBox();
            this.lblSurName = new System.Windows.Forms.Label();
            this.cbOffice = new System.Windows.Forms.ComboBox();
            this.lblOffice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistration
            // 
            this.btnRegistration.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRegistration.Location = new System.Drawing.Point(0, 443);
            this.btnRegistration.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(312, 53);
            this.btnRegistration.TabIndex = 14;
            this.btnRegistration.Text = "Зарегистрироваться";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(312, 52);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Регистрация";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbRole
            // 
            this.cbRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(0, 77);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(312, 33);
            this.cbRole.TabIndex = 1;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRole.Location = new System.Drawing.Point(0, 52);
            this.lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(200, 25);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "Укажите вашу роль:";
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.Location = new System.Drawing.Point(0, 413);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(312, 30);
            this.tbPassword.TabIndex = 13;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.Location = new System.Drawing.Point(0, 388);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(167, 25);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Введете пароль:";
            // 
            // tbLogin
            // 
            this.tbLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.Location = new System.Drawing.Point(0, 358);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(4);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(312, 30);
            this.tbLogin.TabIndex = 11;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.Location = new System.Drawing.Point(0, 333);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(155, 25);
            this.lblLogin.TabIndex = 10;
            this.lblLogin.Text = "Введите логин:";
            // 
            // tbPantronymic
            // 
            this.tbPantronymic.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPantronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPantronymic.Location = new System.Drawing.Point(0, 303);
            this.tbPantronymic.Margin = new System.Windows.Forms.Padding(4);
            this.tbPantronymic.Name = "tbPantronymic";
            this.tbPantronymic.Size = new System.Drawing.Size(312, 30);
            this.tbPantronymic.TabIndex = 9;
            // 
            // lblPantronymic
            // 
            this.lblPantronymic.AutoSize = true;
            this.lblPantronymic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPantronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPantronymic.Location = new System.Drawing.Point(0, 278);
            this.lblPantronymic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPantronymic.Name = "lblPantronymic";
            this.lblPantronymic.Size = new System.Drawing.Size(190, 25);
            this.lblPantronymic.TabIndex = 8;
            this.lblPantronymic.Text = "Введите отчество:";
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(0, 248);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(312, 30);
            this.tbName.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(0, 223);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(141, 25);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Введите имя:";
            // 
            // tbSurName
            // 
            this.tbSurName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSurName.Location = new System.Drawing.Point(0, 193);
            this.tbSurName.Margin = new System.Windows.Forms.Padding(4);
            this.tbSurName.Name = "tbSurName";
            this.tbSurName.Size = new System.Drawing.Size(312, 30);
            this.tbSurName.TabIndex = 5;
            // 
            // lblSurName
            // 
            this.lblSurName.AutoSize = true;
            this.lblSurName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSurName.Location = new System.Drawing.Point(0, 168);
            this.lblSurName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurName.Name = "lblSurName";
            this.lblSurName.Size = new System.Drawing.Size(197, 25);
            this.lblSurName.TabIndex = 4;
            this.lblSurName.Text = "Введите фамилию:";
            // 
            // cbOffice
            // 
            this.cbOffice.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbOffice.FormattingEnabled = true;
            this.cbOffice.Location = new System.Drawing.Point(0, 135);
            this.cbOffice.Name = "cbOffice";
            this.cbOffice.Size = new System.Drawing.Size(312, 33);
            this.cbOffice.TabIndex = 3;
            // 
            // lblOffice
            // 
            this.lblOffice.AutoSize = true;
            this.lblOffice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOffice.Location = new System.Drawing.Point(0, 110);
            this.lblOffice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOffice.Name = "lblOffice";
            this.lblOffice.Size = new System.Drawing.Size(260, 25);
            this.lblOffice.TabIndex = 2;
            this.lblOffice.Text = "Укажите ваше отделение:";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 496);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.tbPantronymic);
            this.Controls.Add(this.lblPantronymic);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbSurName);
            this.Controls.Add(this.lblSurName);
            this.Controls.Add(this.cbOffice);
            this.Controls.Add(this.lblOffice);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbPantronymic;
        private System.Windows.Forms.Label lblPantronymic;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbSurName;
        private System.Windows.Forms.Label lblSurName;
        private System.Windows.Forms.ComboBox cbOffice;
        private System.Windows.Forms.Label lblOffice;
    }
}