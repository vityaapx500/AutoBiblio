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
            this.sstMain = new System.Windows.Forms.StatusStrip();
            this.lbsstConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ролиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMainControl = new System.Windows.Forms.TabControl();
            this.ReadersFormulars = new System.Windows.Forms.TabPage();
            this.dgvFormulars = new System.Windows.Forms.DataGridView();
            this.pnManipulationFormular = new System.Windows.Forms.Panel();
            this.btnDeleteFormular = new System.Windows.Forms.Button();
            this.btnInsertNewReader = new System.Windows.Forms.Button();
            this.BooksJournal = new System.Windows.Forms.TabPage();
            this.dgvBookJournal = new System.Windows.Forms.DataGridView();
            this.gbManipulationData = new System.Windows.Forms.GroupBox();
            this.btnCreateQRCode = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cbOffice = new System.Windows.Forms.ComboBox();
            this.lblOffice = new System.Windows.Forms.Label();
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
            this.sstMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tcMainControl.SuspendLayout();
            this.ReadersFormulars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormulars)).BeginInit();
            this.pnManipulationFormular.SuspendLayout();
            this.BooksJournal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookJournal)).BeginInit();
            this.gbManipulationData.SuspendLayout();
            this.pnComboBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sstMain
            // 
            this.sstMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sstMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbsstConnection});
            this.sstMain.Location = new System.Drawing.Point(0, 690);
            this.sstMain.Name = "sstMain";
            this.sstMain.Size = new System.Drawing.Size(1427, 25);
            this.sstMain.TabIndex = 1;
            this.sstMain.Text = "statusStrip1";
            // 
            // lbsstConnection
            // 
            this.lbsstConnection.Name = "lbsstConnection";
            this.lbsstConnection.Size = new System.Drawing.Size(15, 20);
            this.lbsstConnection.Text = "-";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.администрированиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1427, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // администрированиеToolStripMenuItem
            // 
            this.администрированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользователиToolStripMenuItem,
            this.ролиToolStripMenuItem});
            this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.администрированиеToolStripMenuItem.Text = "Администрирование";
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.пользователиToolStripMenuItem.Text = "Учетный записи пользователей";
            // 
            // ролиToolStripMenuItem
            // 
            this.ролиToolStripMenuItem.Name = "ролиToolStripMenuItem";
            this.ролиToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.ролиToolStripMenuItem.Text = "Роли";
            // 
            // tcMainControl
            // 
            this.tcMainControl.Controls.Add(this.ReadersFormulars);
            this.tcMainControl.Controls.Add(this.BooksJournal);
            this.tcMainControl.Controls.Add(this.Settings);
            this.tcMainControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMainControl.Location = new System.Drawing.Point(0, 28);
            this.tcMainControl.Margin = new System.Windows.Forms.Padding(4);
            this.tcMainControl.Name = "tcMainControl";
            this.tcMainControl.SelectedIndex = 0;
            this.tcMainControl.Size = new System.Drawing.Size(1427, 662);
            this.tcMainControl.TabIndex = 3;
            // 
            // ReadersFormulars
            // 
            this.ReadersFormulars.Controls.Add(this.dgvFormulars);
            this.ReadersFormulars.Controls.Add(this.pnManipulationFormular);
            this.ReadersFormulars.Location = new System.Drawing.Point(4, 25);
            this.ReadersFormulars.Margin = new System.Windows.Forms.Padding(4);
            this.ReadersFormulars.Name = "ReadersFormulars";
            this.ReadersFormulars.Size = new System.Drawing.Size(1419, 633);
            this.ReadersFormulars.TabIndex = 2;
            this.ReadersFormulars.Text = "Формуляры читателей";
            this.ReadersFormulars.UseVisualStyleBackColor = true;
            // 
            // dgvFormulars
            // 
            this.dgvFormulars.AllowUserToAddRows = false;
            this.dgvFormulars.AllowUserToDeleteRows = false;
            this.dgvFormulars.BackgroundColor = System.Drawing.Color.White;
            this.dgvFormulars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormulars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFormulars.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFormulars.Location = new System.Drawing.Point(0, 36);
            this.dgvFormulars.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFormulars.Name = "dgvFormulars";
            this.dgvFormulars.ReadOnly = true;
            this.dgvFormulars.Size = new System.Drawing.Size(1419, 597);
            this.dgvFormulars.TabIndex = 5;
            this.dgvFormulars.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFormulars_CellDoubleClick);
            // 
            // pnManipulationFormular
            // 
            this.pnManipulationFormular.Controls.Add(this.btnDeleteFormular);
            this.pnManipulationFormular.Controls.Add(this.btnInsertNewReader);
            this.pnManipulationFormular.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnManipulationFormular.Location = new System.Drawing.Point(0, 0);
            this.pnManipulationFormular.Margin = new System.Windows.Forms.Padding(4);
            this.pnManipulationFormular.Name = "pnManipulationFormular";
            this.pnManipulationFormular.Size = new System.Drawing.Size(1419, 36);
            this.pnManipulationFormular.TabIndex = 4;
            // 
            // btnDeleteFormular
            // 
            this.btnDeleteFormular.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeleteFormular.Location = new System.Drawing.Point(224, 0);
            this.btnDeleteFormular.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteFormular.Name = "btnDeleteFormular";
            this.btnDeleteFormular.Size = new System.Drawing.Size(224, 36);
            this.btnDeleteFormular.TabIndex = 8;
            this.btnDeleteFormular.Text = "Удалить формуляр читателя";
            this.btnDeleteFormular.UseVisualStyleBackColor = true;
            this.btnDeleteFormular.Click += new System.EventHandler(this.btnDeleteFormular_Click);
            // 
            // btnInsertNewReader
            // 
            this.btnInsertNewReader.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInsertNewReader.Location = new System.Drawing.Point(0, 0);
            this.btnInsertNewReader.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertNewReader.Name = "btnInsertNewReader";
            this.btnInsertNewReader.Size = new System.Drawing.Size(224, 36);
            this.btnInsertNewReader.TabIndex = 7;
            this.btnInsertNewReader.Text = "Записать нового читателя";
            this.btnInsertNewReader.UseVisualStyleBackColor = true;
            this.btnInsertNewReader.Click += new System.EventHandler(this.btnInsertNewReader_Click);
            // 
            // BooksJournal
            // 
            this.BooksJournal.Controls.Add(this.dgvBookJournal);
            this.BooksJournal.Controls.Add(this.gbManipulationData);
            this.BooksJournal.Location = new System.Drawing.Point(4, 25);
            this.BooksJournal.Margin = new System.Windows.Forms.Padding(4);
            this.BooksJournal.Name = "BooksJournal";
            this.BooksJournal.Padding = new System.Windows.Forms.Padding(4);
            this.BooksJournal.Size = new System.Drawing.Size(1419, 633);
            this.BooksJournal.TabIndex = 1;
            this.BooksJournal.Text = "Журнал фонда";
            this.BooksJournal.UseVisualStyleBackColor = true;
            // 
            // dgvBookJournal
            // 
            this.dgvBookJournal.AllowUserToAddRows = false;
            this.dgvBookJournal.AllowUserToDeleteRows = false;
            this.dgvBookJournal.BackgroundColor = System.Drawing.Color.White;
            this.dgvBookJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookJournal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookJournal.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBookJournal.Location = new System.Drawing.Point(251, 4);
            this.dgvBookJournal.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBookJournal.Name = "dgvBookJournal";
            this.dgvBookJournal.Size = new System.Drawing.Size(1164, 625);
            this.dgvBookJournal.TabIndex = 21;
            // 
            // gbManipulationData
            // 
            this.gbManipulationData.Controls.Add(this.btnCreateQRCode);
            this.gbManipulationData.Controls.Add(this.tbPrice);
            this.gbManipulationData.Controls.Add(this.lblPrice);
            this.gbManipulationData.Controls.Add(this.cbOffice);
            this.gbManipulationData.Controls.Add(this.lblOffice);
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
            this.gbManipulationData.Location = new System.Drawing.Point(4, 4);
            this.gbManipulationData.Margin = new System.Windows.Forms.Padding(4);
            this.gbManipulationData.Name = "gbManipulationData";
            this.gbManipulationData.Padding = new System.Windows.Forms.Padding(4);
            this.gbManipulationData.Size = new System.Drawing.Size(247, 625);
            this.gbManipulationData.TabIndex = 20;
            this.gbManipulationData.TabStop = false;
            this.gbManipulationData.Text = "Манипулирование даннными:";
            // 
            // btnCreateQRCode
            // 
            this.btnCreateQRCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateQRCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCreateQRCode.Location = new System.Drawing.Point(4, 334);
            this.btnCreateQRCode.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateQRCode.Name = "btnCreateQRCode";
            this.btnCreateQRCode.Size = new System.Drawing.Size(239, 38);
            this.btnCreateQRCode.TabIndex = 61;
            this.btnCreateQRCode.Text = "Создать QR-код для книги";
            this.btnCreateQRCode.UseVisualStyleBackColor = true;
            this.btnCreateQRCode.Click += new System.EventHandler(this.btnCreateQRCode_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPrice.Location = new System.Drawing.Point(4, 312);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(239, 22);
            this.tbPrice.TabIndex = 59;
            this.tbPrice.Text = "150";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPrice.Location = new System.Drawing.Point(4, 295);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(191, 17);
            this.lblPrice.TabIndex = 60;
            this.lblPrice.Text = "Стоимость экземпляра, руб";
            // 
            // cbOffice
            // 
            this.cbOffice.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbOffice.FormattingEnabled = true;
            this.cbOffice.Location = new System.Drawing.Point(4, 271);
            this.cbOffice.Margin = new System.Windows.Forms.Padding(4);
            this.cbOffice.Name = "cbOffice";
            this.cbOffice.Size = new System.Drawing.Size(239, 24);
            this.cbOffice.TabIndex = 57;
            // 
            // lblOffice
            // 
            this.lblOffice.AutoSize = true;
            this.lblOffice.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOffice.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblOffice.Location = new System.Drawing.Point(4, 254);
            this.lblOffice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOffice.Name = "lblOffice";
            this.lblOffice.Size = new System.Drawing.Size(130, 17);
            this.lblOffice.TabIndex = 58;
            this.lblOffice.Text = "Отделение школы";
            // 
            // tbDateAcceptance
            // 
            this.tbDateAcceptance.BackColor = System.Drawing.SystemColors.Control;
            this.tbDateAcceptance.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbDateAcceptance.Location = new System.Drawing.Point(4, 232);
            this.tbDateAcceptance.Margin = new System.Windows.Forms.Padding(4);
            this.tbDateAcceptance.Name = "tbDateAcceptance";
            this.tbDateAcceptance.ReadOnly = true;
            this.tbDateAcceptance.Size = new System.Drawing.Size(239, 22);
            this.tbDateAcceptance.TabIndex = 53;
            // 
            // lbDateAcceptance
            // 
            this.lbDateAcceptance.AutoSize = true;
            this.lbDateAcceptance.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbDateAcceptance.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbDateAcceptance.Location = new System.Drawing.Point(4, 215);
            this.lbDateAcceptance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDateAcceptance.Name = "lbDateAcceptance";
            this.lbDateAcceptance.Size = new System.Drawing.Size(169, 17);
            this.lbDateAcceptance.TabIndex = 54;
            this.lbDateAcceptance.Text = "Дата регистрации книги";
            // 
            // tbYearPublish
            // 
            this.tbYearPublish.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbYearPublish.Location = new System.Drawing.Point(4, 193);
            this.tbYearPublish.Margin = new System.Windows.Forms.Padding(4);
            this.tbYearPublish.Name = "tbYearPublish";
            this.tbYearPublish.Size = new System.Drawing.Size(239, 22);
            this.tbYearPublish.TabIndex = 51;
            this.tbYearPublish.Text = "2001";
            // 
            // lblYearPublish
            // 
            this.lblYearPublish.AutoSize = true;
            this.lblYearPublish.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblYearPublish.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblYearPublish.Location = new System.Drawing.Point(4, 176);
            this.lblYearPublish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYearPublish.Name = "lblYearPublish";
            this.lblYearPublish.Size = new System.Drawing.Size(91, 17);
            this.lblYearPublish.TabIndex = 52;
            this.lblYearPublish.Text = "Год издания";
            // 
            // btnAddPublishing
            // 
            this.btnAddPublishing.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddPublishing.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddPublishing.Location = new System.Drawing.Point(4, 138);
            this.btnAddPublishing.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPublishing.Name = "btnAddPublishing";
            this.btnAddPublishing.Size = new System.Drawing.Size(239, 38);
            this.btnAddPublishing.TabIndex = 46;
            this.btnAddPublishing.Text = "Новое издательство";
            this.btnAddPublishing.UseVisualStyleBackColor = true;
            // 
            // cbPublisher
            // 
            this.cbPublisher.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbPublisher.FormattingEnabled = true;
            this.cbPublisher.Location = new System.Drawing.Point(4, 114);
            this.cbPublisher.Margin = new System.Windows.Forms.Padding(4);
            this.cbPublisher.Name = "cbPublisher";
            this.cbPublisher.Size = new System.Drawing.Size(239, 24);
            this.cbPublisher.TabIndex = 49;
            // 
            // lbPublisher
            // 
            this.lbPublisher.AutoSize = true;
            this.lbPublisher.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPublisher.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbPublisher.Location = new System.Drawing.Point(4, 97);
            this.lbPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPublisher.Name = "lbPublisher";
            this.lbPublisher.Size = new System.Drawing.Size(100, 17);
            this.lbPublisher.TabIndex = 50;
            this.lbPublisher.Text = "Издательство";
            // 
            // tbBookAuthor
            // 
            this.tbBookAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbBookAuthor.Location = new System.Drawing.Point(4, 75);
            this.tbBookAuthor.Margin = new System.Windows.Forms.Padding(4);
            this.tbBookAuthor.Name = "tbBookAuthor";
            this.tbBookAuthor.Size = new System.Drawing.Size(239, 22);
            this.tbBookAuthor.TabIndex = 47;
            this.tbBookAuthor.Text = "Лев Никовалевич Толстой";
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBookAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBookAuthor.Location = new System.Drawing.Point(4, 58);
            this.lblBookAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(87, 17);
            this.lblBookAuthor.TabIndex = 48;
            this.lblBookAuthor.Text = "Автор книги";
            // 
            // tbBookTitle
            // 
            this.tbBookTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbBookTitle.Location = new System.Drawing.Point(4, 36);
            this.tbBookTitle.Margin = new System.Windows.Forms.Padding(4);
            this.tbBookTitle.Name = "tbBookTitle";
            this.tbBookTitle.Size = new System.Drawing.Size(239, 22);
            this.tbBookTitle.TabIndex = 44;
            this.tbBookTitle.Text = "Война и мир";
            // 
            // lbBookTitle
            // 
            this.lbBookTitle.AutoSize = true;
            this.lbBookTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbBookTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbBookTitle.Location = new System.Drawing.Point(4, 19);
            this.lbBookTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBookTitle.Name = "lbBookTitle";
            this.lbBookTitle.Size = new System.Drawing.Size(112, 17);
            this.lbBookTitle.TabIndex = 45;
            this.lbBookTitle.Text = "Название книги";
            // 
            // pnComboBox
            // 
            this.pnComboBox.Controls.Add(this.btnDelete);
            this.pnComboBox.Controls.Add(this.btnInsertBook);
            this.pnComboBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnComboBox.Location = new System.Drawing.Point(4, 516);
            this.pnComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.pnComboBox.Name = "pnComboBox";
            this.pnComboBox.Size = new System.Drawing.Size(239, 105);
            this.pnComboBox.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelete.Location = new System.Drawing.Point(0, 52);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(239, 52);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Списать книгу";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnInsertBook
            // 
            this.btnInsertBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInsertBook.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnInsertBook.Location = new System.Drawing.Point(0, 0);
            this.btnInsertBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertBook.Name = "btnInsertBook";
            this.btnInsertBook.Size = new System.Drawing.Size(239, 52);
            this.btnInsertBook.TabIndex = 19;
            this.btnInsertBook.Text = "Внести новую книгу";
            this.btnInsertBook.UseVisualStyleBackColor = true;
            this.btnInsertBook.Click += new System.EventHandler(this.btnNewBook_Click);
            // 
            // Settings
            // 
            this.Settings.Location = new System.Drawing.Point(4, 25);
            this.Settings.Margin = new System.Windows.Forms.Padding(4);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(1419, 633);
            this.Settings.TabIndex = 5;
            this.Settings.Text = "Настройки";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 715);
            this.Controls.Add(this.tcMainControl);
            this.Controls.Add(this.sstMain);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автобиблио";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.sstMain.ResumeLayout(false);
            this.sstMain.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tcMainControl.ResumeLayout(false);
            this.ReadersFormulars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormulars)).EndInit();
            this.pnManipulationFormular.ResumeLayout(false);
            this.BooksJournal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookJournal)).EndInit();
            this.gbManipulationData.ResumeLayout(false);
            this.gbManipulationData.PerformLayout();
            this.pnComboBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip sstMain;
        public System.Windows.Forms.ToolStripStatusLabel lbsstConnection;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ролиToolStripMenuItem;
        private System.Windows.Forms.TabControl tcMainControl;
        private System.Windows.Forms.TabPage ReadersFormulars;
        private System.Windows.Forms.Panel pnManipulationFormular;
        private System.Windows.Forms.Button btnInsertNewReader;
        private System.Windows.Forms.TabPage BooksJournal;
        public System.Windows.Forms.DataGridView dgvBookJournal;
        private System.Windows.Forms.GroupBox gbManipulationData;
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
        private System.Windows.Forms.Panel pnComboBox;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnInsertBook;
        private System.Windows.Forms.TabPage Settings;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ComboBox cbOffice;
        private System.Windows.Forms.Label lblOffice;
        public System.Windows.Forms.DataGridView dgvFormulars;
        private System.Windows.Forms.Button btnDeleteFormular;
        public System.Windows.Forms.Button btnCreateQRCode;
    }
}

