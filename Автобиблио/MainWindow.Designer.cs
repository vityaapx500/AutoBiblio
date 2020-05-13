namespace Автобиблио
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.IssuedBook = new System.Windows.Forms.TabPage();
            this.ReadersFormulars = new System.Windows.Forms.TabPage();
            this.pnManipulationFormular = new System.Windows.Forms.Panel();
            this.btnNewFormular = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dgvFormulars = new System.Windows.Forms.DataGridView();
            this.BooksJournal = new System.Windows.Forms.TabPage();
            this.pnManipulationJournal = new System.Windows.Forms.Panel();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnInsertBook = new System.Windows.Forms.Button();
            this.dgvJournal = new System.Windows.Forms.DataGridView();
            this.Settings = new System.Windows.Forms.TabPage();
            this.Roles = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Userss = new System.Windows.Forms.TabPage();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.pnSearch = new System.Windows.Forms.GroupBox();
            this.btnFiltration = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.gbManipulation = new System.Windows.Forms.GroupBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pbButtons = new System.Windows.Forms.Panel();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnInsertUser = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbPantronymic = new System.Windows.Forms.TextBox();
            this.lblPantronymic = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbSurName = new System.Windows.Forms.TextBox();
            this.lblSurName = new System.Windows.Forms.Label();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.ReadersFormulars.SuspendLayout();
            this.pnManipulationFormular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormulars)).BeginInit();
            this.BooksJournal.SuspendLayout();
            this.pnManipulationJournal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).BeginInit();
            this.Roles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Userss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.pnSearch.SuspendLayout();
            this.gbManipulation.SuspendLayout();
            this.pbButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.IssuedBook);
            this.tabControl1.Controls.Add(this.ReadersFormulars);
            this.tabControl1.Controls.Add(this.BooksJournal);
            this.tabControl1.Controls.Add(this.Settings);
            this.tabControl1.Controls.Add(this.Roles);
            this.tabControl1.Controls.Add(this.Userss);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1090, 487);
            this.tabControl1.TabIndex = 0;
            // 
            // IssuedBook
            // 
            this.IssuedBook.Location = new System.Drawing.Point(4, 22);
            this.IssuedBook.Name = "IssuedBook";
            this.IssuedBook.Padding = new System.Windows.Forms.Padding(3);
            this.IssuedBook.Size = new System.Drawing.Size(1082, 461);
            this.IssuedBook.TabIndex = 0;
            this.IssuedBook.Text = "Выдача книги";
            this.IssuedBook.UseVisualStyleBackColor = true;
            // 
            // ReadersFormulars
            // 
            this.ReadersFormulars.Controls.Add(this.pnManipulationFormular);
            this.ReadersFormulars.Controls.Add(this.dgvFormulars);
            this.ReadersFormulars.Location = new System.Drawing.Point(4, 22);
            this.ReadersFormulars.Name = "ReadersFormulars";
            this.ReadersFormulars.Size = new System.Drawing.Size(1082, 461);
            this.ReadersFormulars.TabIndex = 2;
            this.ReadersFormulars.Text = "Формуляры читателей";
            this.ReadersFormulars.UseVisualStyleBackColor = true;
            // 
            // pnManipulationFormular
            // 
            this.pnManipulationFormular.Controls.Add(this.btnNewFormular);
            this.pnManipulationFormular.Controls.Add(this.button5);
            this.pnManipulationFormular.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnManipulationFormular.Location = new System.Drawing.Point(0, 0);
            this.pnManipulationFormular.Name = "pnManipulationFormular";
            this.pnManipulationFormular.Size = new System.Drawing.Size(1082, 29);
            this.pnManipulationFormular.TabIndex = 4;
            // 
            // btnNewFormular
            // 
            this.btnNewFormular.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNewFormular.Location = new System.Drawing.Point(743, 0);
            this.btnNewFormular.Name = "btnNewFormular";
            this.btnNewFormular.Size = new System.Drawing.Size(168, 29);
            this.btnNewFormular.TabIndex = 6;
            this.btnNewFormular.Text = "Записать нового читателя";
            this.btnNewFormular.UseVisualStyleBackColor = true;
            this.btnNewFormular.Click += new System.EventHandler(this.btnNewFormular_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.Location = new System.Drawing.Point(911, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 29);
            this.button5.TabIndex = 5;
            this.button5.Text = "Удалить формуляр читателя";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // dgvFormulars
            // 
            this.dgvFormulars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormulars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFormulars.Location = new System.Drawing.Point(0, 0);
            this.dgvFormulars.Name = "dgvFormulars";
            this.dgvFormulars.Size = new System.Drawing.Size(1082, 461);
            this.dgvFormulars.TabIndex = 3;
            // 
            // BooksJournal
            // 
            this.BooksJournal.Controls.Add(this.pnManipulationJournal);
            this.BooksJournal.Controls.Add(this.dgvJournal);
            this.BooksJournal.Location = new System.Drawing.Point(4, 22);
            this.BooksJournal.Name = "BooksJournal";
            this.BooksJournal.Padding = new System.Windows.Forms.Padding(3);
            this.BooksJournal.Size = new System.Drawing.Size(1082, 461);
            this.BooksJournal.TabIndex = 1;
            this.BooksJournal.Text = "Журнал фонда";
            this.BooksJournal.UseVisualStyleBackColor = true;
            // 
            // pnManipulationJournal
            // 
            this.pnManipulationJournal.Controls.Add(this.btnDeleteBook);
            this.pnManipulationJournal.Controls.Add(this.btnUpdateBook);
            this.pnManipulationJournal.Controls.Add(this.btnInsertBook);
            this.pnManipulationJournal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnManipulationJournal.Location = new System.Drawing.Point(3, 401);
            this.pnManipulationJournal.Name = "pnManipulationJournal";
            this.pnManipulationJournal.Size = new System.Drawing.Size(1076, 57);
            this.pnManipulationJournal.TabIndex = 1;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteBook.Location = new System.Drawing.Point(704, 0);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(372, 57);
            this.btnDeleteBook.TabIndex = 2;
            this.btnDeleteBook.Text = "Списать экземпляр";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUpdateBook.Location = new System.Drawing.Point(340, 0);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(364, 57);
            this.btnUpdateBook.TabIndex = 1;
            this.btnUpdateBook.Text = "Внести изменения данных о книге";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            // 
            // btnInsertBook
            // 
            this.btnInsertBook.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInsertBook.Location = new System.Drawing.Point(0, 0);
            this.btnInsertBook.Name = "btnInsertBook";
            this.btnInsertBook.Size = new System.Drawing.Size(340, 57);
            this.btnInsertBook.TabIndex = 0;
            this.btnInsertBook.Text = "Внести новую книгу в фонд";
            this.btnInsertBook.UseVisualStyleBackColor = true;
            // 
            // dgvJournal
            // 
            this.dgvJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJournal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJournal.Location = new System.Drawing.Point(3, 3);
            this.dgvJournal.Name = "dgvJournal";
            this.dgvJournal.Size = new System.Drawing.Size(1076, 455);
            this.dgvJournal.TabIndex = 0;
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(1082, 461);
            this.Settings.TabIndex = 5;
            this.Settings.Text = "Настройки";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // Roles
            // 
            this.Roles.Controls.Add(this.groupBox1);
            this.Roles.Controls.Add(this.dgvRoles);
            this.Roles.Controls.Add(this.groupBox4);
            this.Roles.Location = new System.Drawing.Point(4, 22);
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(1082, 461);
            this.Roles.TabIndex = 3;
            this.Roles.Text = "Роли";
            this.Roles.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(252, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 40);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск/фильтрация";
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.Location = new System.Drawing.Point(721, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 21);
            this.button4.TabIndex = 9;
            this.button4.Text = "Отфильтровать";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(824, 20);
            this.textBox1.TabIndex = 5;
            // 
            // dgvRoles
            // 
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoles.Location = new System.Drawing.Point(252, 0);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.Size = new System.Drawing.Size(830, 461);
            this.dgvRoles.TabIndex = 22;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox10);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.panel2);
            this.groupBox4.Controls.Add(this.textBox11);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBox12);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.textBox13);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.textBox14);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(252, 461);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Манипуляция данными";
            // 
            // textBox10
            // 
            this.textBox10.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox10.Location = new System.Drawing.Point(3, 195);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(246, 20);
            this.textBox10.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(3, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "label7";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 364);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 94);
            this.panel2.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "button4";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "button3";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(246, 31);
            this.button3.TabIndex = 3;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox11
            // 
            this.textBox11.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox11.Location = new System.Drawing.Point(3, 162);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(246, 20);
            this.textBox11.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(3, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "label8";
            // 
            // textBox12
            // 
            this.textBox12.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox12.Location = new System.Drawing.Point(3, 129);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(246, 20);
            this.textBox12.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(3, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "label9";
            // 
            // textBox13
            // 
            this.textBox13.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox13.Location = new System.Drawing.Point(3, 96);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(246, 20);
            this.textBox13.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Location = new System.Drawing.Point(3, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "label10";
            // 
            // textBox14
            // 
            this.textBox14.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox14.Location = new System.Drawing.Point(3, 63);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(246, 20);
            this.textBox14.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Location = new System.Drawing.Point(3, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "label11";
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(246, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Location = new System.Drawing.Point(3, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "label12";
            // 
            // Userss
            // 
            this.Userss.Controls.Add(this.dgvUsers);
            this.Userss.Controls.Add(this.pnSearch);
            this.Userss.Controls.Add(this.gbManipulation);
            this.Userss.Location = new System.Drawing.Point(4, 22);
            this.Userss.Name = "Userss";
            this.Userss.Size = new System.Drawing.Size(1082, 461);
            this.Userss.TabIndex = 4;
            this.Userss.Text = "Пользователи";
            this.Userss.UseVisualStyleBackColor = true;
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(252, 40);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.Size = new System.Drawing.Size(830, 421);
            this.dgvUsers.TabIndex = 19;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.btnFiltration);
            this.pnSearch.Controls.Add(this.tbSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearch.Location = new System.Drawing.Point(252, 0);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(830, 40);
            this.pnSearch.TabIndex = 18;
            this.pnSearch.TabStop = false;
            this.pnSearch.Text = "Поиск/фильтрация";
            // 
            // btnFiltration
            // 
            this.btnFiltration.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFiltration.Location = new System.Drawing.Point(721, 16);
            this.btnFiltration.Name = "btnFiltration";
            this.btnFiltration.Size = new System.Drawing.Size(106, 21);
            this.btnFiltration.TabIndex = 9;
            this.btnFiltration.Text = "Отфильтровать";
            this.btnFiltration.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSearch.Location = new System.Drawing.Point(3, 16);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(824, 20);
            this.tbSearch.TabIndex = 5;
            // 
            // gbManipulation
            // 
            this.gbManipulation.Controls.Add(this.tbPassword);
            this.gbManipulation.Controls.Add(this.lblPassword);
            this.gbManipulation.Controls.Add(this.pbButtons);
            this.gbManipulation.Controls.Add(this.tbLogin);
            this.gbManipulation.Controls.Add(this.lblLogin);
            this.gbManipulation.Controls.Add(this.tbPantronymic);
            this.gbManipulation.Controls.Add(this.lblPantronymic);
            this.gbManipulation.Controls.Add(this.tbName);
            this.gbManipulation.Controls.Add(this.lblName);
            this.gbManipulation.Controls.Add(this.tbSurName);
            this.gbManipulation.Controls.Add(this.lblSurName);
            this.gbManipulation.Controls.Add(this.cbRole);
            this.gbManipulation.Controls.Add(this.lblRole);
            this.gbManipulation.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbManipulation.Location = new System.Drawing.Point(0, 0);
            this.gbManipulation.Name = "gbManipulation";
            this.gbManipulation.Size = new System.Drawing.Size(252, 461);
            this.gbManipulation.TabIndex = 17;
            this.gbManipulation.TabStop = false;
            this.gbManipulation.Text = "Манипуляция данными";
            // 
            // tbPassword
            // 
            this.tbPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPassword.Location = new System.Drawing.Point(3, 195);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(246, 20);
            this.tbPassword.TabIndex = 6;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPassword.Location = new System.Drawing.Point(3, 182);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(45, 13);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Пароль";
            // 
            // pbButtons
            // 
            this.pbButtons.Controls.Add(this.btnDeleteUser);
            this.pbButtons.Controls.Add(this.btnUpdateUser);
            this.pbButtons.Controls.Add(this.btnInsertUser);
            this.pbButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbButtons.Location = new System.Drawing.Point(3, 364);
            this.pbButtons.Name = "pbButtons";
            this.pbButtons.Size = new System.Drawing.Size(246, 94);
            this.pbButtons.TabIndex = 14;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteUser.Location = new System.Drawing.Point(0, 62);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(246, 31);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "Удалить пользователя";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateUser.Location = new System.Drawing.Point(0, 31);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(246, 31);
            this.btnUpdateUser.TabIndex = 1;
            this.btnUpdateUser.Text = "Изменить данные пользователя";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            // 
            // btnInsertUser
            // 
            this.btnInsertUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsertUser.Location = new System.Drawing.Point(0, 0);
            this.btnInsertUser.Name = "btnInsertUser";
            this.btnInsertUser.Size = new System.Drawing.Size(246, 31);
            this.btnInsertUser.TabIndex = 0;
            this.btnInsertUser.Text = "Добавить пользователя";
            this.btnInsertUser.UseVisualStyleBackColor = true;
            // 
            // tbLogin
            // 
            this.tbLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbLogin.Location = new System.Drawing.Point(3, 162);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(246, 20);
            this.tbLogin.TabIndex = 5;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogin.Location = new System.Drawing.Point(3, 149);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Логин";
            // 
            // tbPantronymic
            // 
            this.tbPantronymic.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPantronymic.Location = new System.Drawing.Point(3, 129);
            this.tbPantronymic.Name = "tbPantronymic";
            this.tbPantronymic.Size = new System.Drawing.Size(246, 20);
            this.tbPantronymic.TabIndex = 4;
            // 
            // lblPantronymic
            // 
            this.lblPantronymic.AutoSize = true;
            this.lblPantronymic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPantronymic.Location = new System.Drawing.Point(3, 116);
            this.lblPantronymic.Name = "lblPantronymic";
            this.lblPantronymic.Size = new System.Drawing.Size(54, 13);
            this.lblPantronymic.TabIndex = 0;
            this.lblPantronymic.Text = "Отчество";
            // 
            // tbName
            // 
            this.tbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbName.Location = new System.Drawing.Point(3, 96);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(246, 20);
            this.tbName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Location = new System.Drawing.Point(3, 83);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Имя";
            // 
            // tbSurName
            // 
            this.tbSurName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSurName.Location = new System.Drawing.Point(3, 63);
            this.tbSurName.Name = "tbSurName";
            this.tbSurName.Size = new System.Drawing.Size(246, 20);
            this.tbSurName.TabIndex = 2;
            // 
            // lblSurName
            // 
            this.lblSurName.AutoSize = true;
            this.lblSurName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSurName.Location = new System.Drawing.Point(3, 50);
            this.lblSurName.Name = "lblSurName";
            this.lblSurName.Size = new System.Drawing.Size(56, 13);
            this.lblSurName.TabIndex = 0;
            this.lblSurName.Text = "Фамилия";
            // 
            // cbRole
            // 
            this.cbRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(3, 29);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(246, 21);
            this.cbRole.TabIndex = 1;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRole.Location = new System.Drawing.Point(3, 16);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(32, 13);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "Роль";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 487);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автобиблио";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControl1.ResumeLayout(false);
            this.ReadersFormulars.ResumeLayout(false);
            this.pnManipulationFormular.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormulars)).EndInit();
            this.BooksJournal.ResumeLayout(false);
            this.pnManipulationJournal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).EndInit();
            this.Roles.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.Userss.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            this.gbManipulation.ResumeLayout(false);
            this.gbManipulation.PerformLayout();
            this.pbButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage IssuedBook;
        private System.Windows.Forms.TabPage BooksJournal;
        private System.Windows.Forms.TabPage ReadersFormulars;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.TabPage Roles;
        private System.Windows.Forms.TabPage Userss;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox pnSearch;
        private System.Windows.Forms.Button btnFiltration;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.GroupBox gbManipulation;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pbButtons;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnInsertUser;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbPantronymic;
        private System.Windows.Forms.Label lblPantronymic;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbSurName;
        private System.Windows.Forms.Label lblSurName;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnManipulationJournal;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnInsertBook;
        private System.Windows.Forms.DataGridView dgvJournal;
        private System.Windows.Forms.DataGridView dgvFormulars;
        private System.Windows.Forms.Panel pnManipulationFormular;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnNewFormular;
    }
}

