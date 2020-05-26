namespace Автобиблио
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.pnSearch = new System.Windows.Forms.GroupBox();
            this.btnFiltration = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.gbManipulation = new System.Windows.Forms.GroupBox();
            this.pbButtons = new System.Windows.Forms.Panel();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnInsertUser = new System.Windows.Forms.Button();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cbOffice = new System.Windows.Forms.ComboBox();
            this.lblOffice = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.pnSearch.SuspendLayout();
            this.gbManipulation.SuspendLayout();
            this.pbButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(336, 49);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(867, 460);
            this.dgvUsers.TabIndex = 22;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.btnFiltration);
            this.pnSearch.Controls.Add(this.tbSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearch.Location = new System.Drawing.Point(336, 0);
            this.pnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Padding = new System.Windows.Forms.Padding(4);
            this.pnSearch.Size = new System.Drawing.Size(867, 49);
            this.pnSearch.TabIndex = 21;
            this.pnSearch.TabStop = false;
            this.pnSearch.Text = "Поиск/фильтрация";
            // 
            // btnFiltration
            // 
            this.btnFiltration.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFiltration.Location = new System.Drawing.Point(722, 19);
            this.btnFiltration.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltration.Name = "btnFiltration";
            this.btnFiltration.Size = new System.Drawing.Size(141, 26);
            this.btnFiltration.TabIndex = 9;
            this.btnFiltration.Text = "Отфильтровать";
            this.btnFiltration.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSearch.Location = new System.Drawing.Point(4, 19);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(859, 22);
            this.tbSearch.TabIndex = 5;
            // 
            // gbManipulation
            // 
            this.gbManipulation.Controls.Add(this.tbPassword);
            this.gbManipulation.Controls.Add(this.lblPassword);
            this.gbManipulation.Controls.Add(this.tbLogin);
            this.gbManipulation.Controls.Add(this.lblLogin);
            this.gbManipulation.Controls.Add(this.tbPantronymic);
            this.gbManipulation.Controls.Add(this.lblPantronymic);
            this.gbManipulation.Controls.Add(this.tbName);
            this.gbManipulation.Controls.Add(this.lblName);
            this.gbManipulation.Controls.Add(this.tbSurName);
            this.gbManipulation.Controls.Add(this.lblSurName);
            this.gbManipulation.Controls.Add(this.cbOffice);
            this.gbManipulation.Controls.Add(this.lblOffice);
            this.gbManipulation.Controls.Add(this.pbButtons);
            this.gbManipulation.Controls.Add(this.cbRole);
            this.gbManipulation.Controls.Add(this.lblRole);
            this.gbManipulation.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbManipulation.Location = new System.Drawing.Point(0, 0);
            this.gbManipulation.Margin = new System.Windows.Forms.Padding(4);
            this.gbManipulation.Name = "gbManipulation";
            this.gbManipulation.Padding = new System.Windows.Forms.Padding(4);
            this.gbManipulation.Size = new System.Drawing.Size(336, 509);
            this.gbManipulation.TabIndex = 20;
            this.gbManipulation.TabStop = false;
            this.gbManipulation.Text = "Манипуляция данными";
            // 
            // pbButtons
            // 
            this.pbButtons.Controls.Add(this.btnDeleteUser);
            this.pbButtons.Controls.Add(this.btnUpdateUser);
            this.pbButtons.Controls.Add(this.btnInsertUser);
            this.pbButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbButtons.Location = new System.Drawing.Point(4, 389);
            this.pbButtons.Margin = new System.Windows.Forms.Padding(4);
            this.pbButtons.Name = "pbButtons";
            this.pbButtons.Size = new System.Drawing.Size(328, 116);
            this.pbButtons.TabIndex = 14;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteUser.Location = new System.Drawing.Point(0, 76);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(328, 38);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "Удалить пользователя";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateUser.Location = new System.Drawing.Point(0, 38);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(328, 38);
            this.btnUpdateUser.TabIndex = 1;
            this.btnUpdateUser.Text = "Изменить данные пользователя";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            // 
            // btnInsertUser
            // 
            this.btnInsertUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsertUser.Location = new System.Drawing.Point(0, 0);
            this.btnInsertUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertUser.Name = "btnInsertUser";
            this.btnInsertUser.Size = new System.Drawing.Size(328, 38);
            this.btnInsertUser.TabIndex = 0;
            this.btnInsertUser.Text = "Добавить пользователя";
            this.btnInsertUser.UseVisualStyleBackColor = true;
            // 
            // cbRole
            // 
            this.cbRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(4, 36);
            this.cbRole.Margin = new System.Windows.Forms.Padding(4);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(328, 24);
            this.cbRole.TabIndex = 1;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRole.Location = new System.Drawing.Point(4, 19);
            this.lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(40, 17);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "Роль";
            // 
            // cbOffice
            // 
            this.cbOffice.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbOffice.FormattingEnabled = true;
            this.cbOffice.Location = new System.Drawing.Point(4, 77);
            this.cbOffice.Margin = new System.Windows.Forms.Padding(4);
            this.cbOffice.Name = "cbOffice";
            this.cbOffice.Size = new System.Drawing.Size(328, 24);
            this.cbOffice.TabIndex = 16;
            // 
            // lblOffice
            // 
            this.lblOffice.AutoSize = true;
            this.lblOffice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOffice.Location = new System.Drawing.Point(4, 60);
            this.lblOffice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOffice.Name = "lblOffice";
            this.lblOffice.Size = new System.Drawing.Size(82, 17);
            this.lblOffice.TabIndex = 15;
            this.lblOffice.Text = "Отделение";
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassword.Location = new System.Drawing.Point(4, 274);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(328, 22);
            this.tbPassword.TabIndex = 26;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPassword.Location = new System.Drawing.Point(4, 257);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 17);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "Пароль";
            // 
            // tbLogin
            // 
            this.tbLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLogin.Location = new System.Drawing.Point(4, 235);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(4);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(328, 22);
            this.tbLogin.TabIndex = 25;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogin.Location = new System.Drawing.Point(4, 218);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(47, 17);
            this.lblLogin.TabIndex = 18;
            this.lblLogin.Text = "Логин";
            // 
            // tbPantronymic
            // 
            this.tbPantronymic.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPantronymic.Location = new System.Drawing.Point(4, 196);
            this.tbPantronymic.Margin = new System.Windows.Forms.Padding(4);
            this.tbPantronymic.Name = "tbPantronymic";
            this.tbPantronymic.Size = new System.Drawing.Size(328, 22);
            this.tbPantronymic.TabIndex = 24;
            // 
            // lblPantronymic
            // 
            this.lblPantronymic.AutoSize = true;
            this.lblPantronymic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPantronymic.Location = new System.Drawing.Point(4, 179);
            this.lblPantronymic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPantronymic.Name = "lblPantronymic";
            this.lblPantronymic.Size = new System.Drawing.Size(71, 17);
            this.lblPantronymic.TabIndex = 19;
            this.lblPantronymic.Text = "Отчество";
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbName.Location = new System.Drawing.Point(4, 157);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(328, 22);
            this.tbName.TabIndex = 23;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Location = new System.Drawing.Point(4, 140);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 17);
            this.lblName.TabIndex = 20;
            this.lblName.Text = "Имя";
            // 
            // tbSurName
            // 
            this.tbSurName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSurName.Location = new System.Drawing.Point(4, 118);
            this.tbSurName.Margin = new System.Windows.Forms.Padding(4);
            this.tbSurName.Name = "tbSurName";
            this.tbSurName.Size = new System.Drawing.Size(328, 22);
            this.tbSurName.TabIndex = 22;
            // 
            // lblSurName
            // 
            this.lblSurName.AutoSize = true;
            this.lblSurName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSurName.Location = new System.Drawing.Point(4, 101);
            this.lblSurName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurName.Name = "lblSurName";
            this.lblSurName.Size = new System.Drawing.Size(70, 17);
            this.lblSurName.TabIndex = 21;
            this.lblSurName.Text = "Фамилия";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 509);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.pnSearch);
            this.Controls.Add(this.gbManipulation);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.gbManipulation.ResumeLayout(false);
            this.gbManipulation.PerformLayout();
            this.pbButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox pnSearch;
        private System.Windows.Forms.Button btnFiltration;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.GroupBox gbManipulation;
        private System.Windows.Forms.Panel pbButtons;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnInsertUser;
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