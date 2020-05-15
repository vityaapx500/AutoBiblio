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
            this.tcMainControl = new System.Windows.Forms.TabControl();
            this.IssuedBook = new System.Windows.Forms.TabPage();
            this.ReadersFormulars = new System.Windows.Forms.TabPage();
            this.pnManipulationFormular = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.dgvFormulars = new System.Windows.Forms.DataGridView();
            this.BooksJournal = new System.Windows.Forms.TabPage();
            this.dgvBookJournal = new System.Windows.Forms.DataGridView();
            this.gbManipulationData = new System.Windows.Forms.GroupBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbDateAcceptance = new System.Windows.Forms.TextBox();
            this.lbDateAcceptance = new System.Windows.Forms.Label();
            this.tbYearPublish = new System.Windows.Forms.TextBox();
            this.lblYearPublish = new System.Windows.Forms.Label();
            this.btnAddPublishing = new System.Windows.Forms.Button();
            this.cbPublisher = new System.Windows.Forms.ComboBox();
            this.lbPublisher = new System.Windows.Forms.Label();
            this.tbBookAuthor = new System.Windows.Forms.TextBox();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.tbBookTitle = new System.Windows.Forms.TextBox();
            this.lbBookTitle = new System.Windows.Forms.Label();
            this.pnComboBox = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsertBook = new System.Windows.Forms.Button();
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
            this.btnNewFormular = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tcMainControl.SuspendLayout();
            this.IssuedBook.SuspendLayout();
            this.ReadersFormulars.SuspendLayout();
            this.pnManipulationFormular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormulars)).BeginInit();
            this.BooksJournal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookJournal)).BeginInit();
            this.gbManipulationData.SuspendLayout();
            this.pnComboBox.SuspendLayout();
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
            // tcMainControl
            // 
            this.tcMainControl.Controls.Add(this.IssuedBook);
            this.tcMainControl.Controls.Add(this.ReadersFormulars);
            this.tcMainControl.Controls.Add(this.BooksJournal);
            this.tcMainControl.Controls.Add(this.Settings);
            this.tcMainControl.Controls.Add(this.Roles);
            this.tcMainControl.Controls.Add(this.Userss);
            this.tcMainControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMainControl.Location = new System.Drawing.Point(0, 0);
            this.tcMainControl.Name = "tcMainControl";
            this.tcMainControl.SelectedIndex = 0;
            this.tcMainControl.Size = new System.Drawing.Size(1070, 581);
            this.tcMainControl.TabIndex = 0;
            this.tcMainControl.Click += new System.EventHandler(this.btnNewFormular_Click);
            // 
            // IssuedBook
            // 
            this.IssuedBook.Controls.Add(this.btnNewFormular);
            this.IssuedBook.Location = new System.Drawing.Point(4, 22);
            this.IssuedBook.Name = "IssuedBook";
            this.IssuedBook.Padding = new System.Windows.Forms.Padding(3);
            this.IssuedBook.Size = new System.Drawing.Size(1062, 555);
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
            this.ReadersFormulars.Size = new System.Drawing.Size(1062, 555);
            this.ReadersFormulars.TabIndex = 2;
            this.ReadersFormulars.Text = "Формуляры читателей";
            this.ReadersFormulars.UseVisualStyleBackColor = true;
            // 
            // pnManipulationFormular
            // 
            this.pnManipulationFormular.Controls.Add(this.button6);
            this.pnManipulationFormular.Controls.Add(this.button5);
            this.pnManipulationFormular.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnManipulationFormular.Location = new System.Drawing.Point(0, 0);
            this.pnManipulationFormular.Name = "pnManipulationFormular";
            this.pnManipulationFormular.Size = new System.Drawing.Size(1062, 29);
            this.pnManipulationFormular.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.Location = new System.Drawing.Point(891, 0);
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
            this.dgvFormulars.Size = new System.Drawing.Size(1062, 555);
            this.dgvFormulars.TabIndex = 3;
            // 
            // BooksJournal
            // 
            this.BooksJournal.Controls.Add(this.dgvBookJournal);
            this.BooksJournal.Controls.Add(this.gbManipulationData);
            this.BooksJournal.Location = new System.Drawing.Point(4, 22);
            this.BooksJournal.Name = "BooksJournal";
            this.BooksJournal.Padding = new System.Windows.Forms.Padding(3);
            this.BooksJournal.Size = new System.Drawing.Size(1062, 555);
            this.BooksJournal.TabIndex = 1;
            this.BooksJournal.Text = "Журнал фонда";
            this.BooksJournal.UseVisualStyleBackColor = true;
            // 
            // dgvBookJournal
            // 
            this.dgvBookJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookJournal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookJournal.Location = new System.Drawing.Point(188, 3);
            this.dgvBookJournal.Name = "dgvBookJournal";
            this.dgvBookJournal.Size = new System.Drawing.Size(871, 549);
            this.dgvBookJournal.TabIndex = 21;
            // 
            // gbManipulationData
            // 
            this.gbManipulationData.Controls.Add(this.tbPrice);
            this.gbManipulationData.Controls.Add(this.lblPrice);
            this.gbManipulationData.Controls.Add(this.tbDateAcceptance);
            this.gbManipulationData.Controls.Add(this.lbDateAcceptance);
            this.gbManipulationData.Controls.Add(this.tbYearPublish);
            this.gbManipulationData.Controls.Add(this.lblYearPublish);
            this.gbManipulationData.Controls.Add(this.btnAddPublishing);
            this.gbManipulationData.Controls.Add(this.cbPublisher);
            this.gbManipulationData.Controls.Add(this.lbPublisher);
            this.gbManipulationData.Controls.Add(this.tbBookAuthor);
            this.gbManipulationData.Controls.Add(this.lblBookAuthor);
            this.gbManipulationData.Controls.Add(this.tbBookTitle);
            this.gbManipulationData.Controls.Add(this.lbBookTitle);
            this.gbManipulationData.Controls.Add(this.pnComboBox);
            this.gbManipulationData.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbManipulationData.Location = new System.Drawing.Point(3, 3);
            this.gbManipulationData.Name = "gbManipulationData";
            this.gbManipulationData.Size = new System.Drawing.Size(185, 549);
            this.gbManipulationData.TabIndex = 20;
            this.gbManipulationData.TabStop = false;
            this.gbManipulationData.Text = "Манипулирование даннными:";
            // 
            // tbPrice
            // 
            this.tbPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPrice.Location = new System.Drawing.Point(3, 226);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(179, 20);
            this.tbPrice.TabIndex = 55;
            this.tbPrice.Text = "123";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPrice.Location = new System.Drawing.Point(3, 213);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(150, 13);
            this.lblPrice.TabIndex = 56;
            this.lblPrice.Text = "Стоимость экземпляра, руб";
            // 
            // tbDateAcceptance
            // 
            this.tbDateAcceptance.BackColor = System.Drawing.SystemColors.Control;
            this.tbDateAcceptance.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbDateAcceptance.Location = new System.Drawing.Point(3, 193);
            this.tbDateAcceptance.Name = "tbDateAcceptance";
            this.tbDateAcceptance.ReadOnly = true;
            this.tbDateAcceptance.Size = new System.Drawing.Size(179, 20);
            this.tbDateAcceptance.TabIndex = 53;
            // 
            // lbDateAcceptance
            // 
            this.lbDateAcceptance.AutoSize = true;
            this.lbDateAcceptance.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDateAcceptance.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbDateAcceptance.Location = new System.Drawing.Point(3, 180);
            this.lbDateAcceptance.Name = "lbDateAcceptance";
            this.lbDateAcceptance.Size = new System.Drawing.Size(132, 13);
            this.lbDateAcceptance.TabIndex = 54;
            this.lbDateAcceptance.Text = "Дата регистрации книги";
            // 
            // tbYearPublish
            // 
            this.tbYearPublish.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbYearPublish.Location = new System.Drawing.Point(3, 160);
            this.tbYearPublish.Name = "tbYearPublish";
            this.tbYearPublish.Size = new System.Drawing.Size(179, 20);
            this.tbYearPublish.TabIndex = 51;
            this.tbYearPublish.Text = "1234";
            // 
            // lblYearPublish
            // 
            this.lblYearPublish.AutoSize = true;
            this.lblYearPublish.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblYearPublish.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblYearPublish.Location = new System.Drawing.Point(3, 147);
            this.lblYearPublish.Name = "lblYearPublish";
            this.lblYearPublish.Size = new System.Drawing.Size(70, 13);
            this.lblYearPublish.TabIndex = 52;
            this.lblYearPublish.Text = "Год издания";
            // 
            // btnAddPublishing
            // 
            this.btnAddPublishing.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddPublishing.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddPublishing.Location = new System.Drawing.Point(3, 116);
            this.btnAddPublishing.Name = "btnAddPublishing";
            this.btnAddPublishing.Size = new System.Drawing.Size(179, 31);
            this.btnAddPublishing.TabIndex = 46;
            this.btnAddPublishing.Text = "Новое издательство";
            this.btnAddPublishing.UseVisualStyleBackColor = true;
            // 
            // cbPublisher
            // 
            this.cbPublisher.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPublisher.FormattingEnabled = true;
            this.cbPublisher.Location = new System.Drawing.Point(3, 95);
            this.cbPublisher.Name = "cbPublisher";
            this.cbPublisher.Size = new System.Drawing.Size(179, 21);
            this.cbPublisher.TabIndex = 49;
            // 
            // lbPublisher
            // 
            this.lbPublisher.AutoSize = true;
            this.lbPublisher.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPublisher.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbPublisher.Location = new System.Drawing.Point(3, 82);
            this.lbPublisher.Name = "lbPublisher";
            this.lbPublisher.Size = new System.Drawing.Size(79, 13);
            this.lbPublisher.TabIndex = 50;
            this.lbPublisher.Text = "Издательство";
            // 
            // tbBookAuthor
            // 
            this.tbBookAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbBookAuthor.Location = new System.Drawing.Point(3, 62);
            this.tbBookAuthor.Name = "tbBookAuthor";
            this.tbBookAuthor.Size = new System.Drawing.Size(179, 20);
            this.tbBookAuthor.TabIndex = 47;
            this.tbBookAuthor.Text = "asdf";
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBookAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBookAuthor.Location = new System.Drawing.Point(3, 49);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(69, 13);
            this.lblBookAuthor.TabIndex = 48;
            this.lblBookAuthor.Text = "Автор книги";
            // 
            // tbBookTitle
            // 
            this.tbBookTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbBookTitle.Location = new System.Drawing.Point(3, 29);
            this.tbBookTitle.Name = "tbBookTitle";
            this.tbBookTitle.Size = new System.Drawing.Size(179, 20);
            this.tbBookTitle.TabIndex = 44;
            this.tbBookTitle.Text = "asdf";
            // 
            // lbBookTitle
            // 
            this.lbBookTitle.AutoSize = true;
            this.lbBookTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbBookTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbBookTitle.Location = new System.Drawing.Point(3, 16);
            this.lbBookTitle.Name = "lbBookTitle";
            this.lbBookTitle.Size = new System.Drawing.Size(89, 13);
            this.lbBookTitle.TabIndex = 45;
            this.lbBookTitle.Text = "Название книги";
            // 
            // pnComboBox
            // 
            this.pnComboBox.Controls.Add(this.btnDelete);
            this.pnComboBox.Controls.Add(this.btnInsertBook);
            this.pnComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnComboBox.Location = new System.Drawing.Point(3, 461);
            this.pnComboBox.Name = "pnComboBox";
            this.pnComboBox.Size = new System.Drawing.Size(179, 85);
            this.pnComboBox.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelete.Location = new System.Drawing.Point(0, 42);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(179, 42);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Списать книгу";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsertBook
            // 
            this.btnInsertBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsertBook.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInsertBook.Location = new System.Drawing.Point(0, 0);
            this.btnInsertBook.Name = "btnInsertBook";
            this.btnInsertBook.Size = new System.Drawing.Size(179, 42);
            this.btnInsertBook.TabIndex = 19;
            this.btnInsertBook.Text = "Внести новую книгу";
            this.btnInsertBook.UseVisualStyleBackColor = true;
            this.btnInsertBook.Click += new System.EventHandler(this.btnInsertBook_Click);
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(1062, 555);
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
            this.Roles.Size = new System.Drawing.Size(1062, 555);
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
            this.groupBox1.Size = new System.Drawing.Size(810, 40);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск/фильтрация";
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.Location = new System.Drawing.Point(701, 16);
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
            this.textBox1.Size = new System.Drawing.Size(804, 20);
            this.textBox1.TabIndex = 5;
            // 
            // dgvRoles
            // 
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoles.Location = new System.Drawing.Point(252, 0);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.Size = new System.Drawing.Size(810, 555);
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
            this.groupBox4.Size = new System.Drawing.Size(252, 555);
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
            this.panel2.Location = new System.Drawing.Point(3, 458);
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
            this.Userss.Size = new System.Drawing.Size(1062, 555);
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
            this.dgvUsers.Size = new System.Drawing.Size(810, 515);
            this.dgvUsers.TabIndex = 19;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.btnFiltration);
            this.pnSearch.Controls.Add(this.tbSearch);
            this.pnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSearch.Location = new System.Drawing.Point(252, 0);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(810, 40);
            this.pnSearch.TabIndex = 18;
            this.pnSearch.TabStop = false;
            this.pnSearch.Text = "Поиск/фильтрация";
            // 
            // btnFiltration
            // 
            this.btnFiltration.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFiltration.Location = new System.Drawing.Point(701, 16);
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
            this.tbSearch.Size = new System.Drawing.Size(804, 20);
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
            this.gbManipulation.Size = new System.Drawing.Size(252, 555);
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
            this.pbButtons.Location = new System.Drawing.Point(3, 458);
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
            // btnNewFormular
            // 
            this.btnNewFormular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewFormular.Location = new System.Drawing.Point(3, 3);
            this.btnNewFormular.Name = "btnNewFormular";
            this.btnNewFormular.Size = new System.Drawing.Size(1056, 549);
            this.btnNewFormular.TabIndex = 7;
            this.btnNewFormular.Text = "Записать нового читателя";
            this.btnNewFormular.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.Location = new System.Drawing.Point(723, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 29);
            this.button6.TabIndex = 7;
            this.button6.Text = "Записать нового читателя";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 581);
            this.Controls.Add(this.tcMainControl);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автобиблио";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tcMainControl.ResumeLayout(false);
            this.IssuedBook.ResumeLayout(false);
            this.ReadersFormulars.ResumeLayout(false);
            this.pnManipulationFormular.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormulars)).EndInit();
            this.BooksJournal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookJournal)).EndInit();
            this.gbManipulationData.ResumeLayout(false);
            this.gbManipulationData.PerformLayout();
            this.pnComboBox.ResumeLayout(false);
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

        private System.Windows.Forms.TabControl tcMainControl;
        private System.Windows.Forms.TabPage IssuedBook;
        private System.Windows.Forms.TabPage BooksJournal;
        private System.Windows.Forms.TabPage ReadersFormulars;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.TabPage Roles;
        private System.Windows.Forms.TabPage Userss;
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
        private System.Windows.Forms.Panel pnManipulationFormular;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.DataGridView dgvUsers;
        public System.Windows.Forms.DataGridView dgvFormulars;
        private System.Windows.Forms.GroupBox gbManipulationData;
        private System.Windows.Forms.Panel pnComboBox;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnInsertBook;
        public System.Windows.Forms.DataGridView dgvBookJournal;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbDateAcceptance;
        private System.Windows.Forms.Label lbDateAcceptance;
        private System.Windows.Forms.TextBox tbYearPublish;
        private System.Windows.Forms.Label lblYearPublish;
        public System.Windows.Forms.Button btnAddPublishing;
        private System.Windows.Forms.ComboBox cbPublisher;
        private System.Windows.Forms.Label lbPublisher;
        private System.Windows.Forms.TextBox tbBookAuthor;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.TextBox tbBookTitle;
        private System.Windows.Forms.Label lbBookTitle;
        private System.Windows.Forms.Button btnNewFormular;
        private System.Windows.Forms.Button button6;
    }
}

