using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace Автобиблио
{
    public partial class MainWindow : Form
    {
        private DBConnection dbConnection = new DBConnection();
        private DBStoredProcedures storedProcedures = new DBStoredProcedures();
        private Thread threadConnection;
        private static DateTime dateToday = DateTime.Now;
        public string today = dateToday.Date.ToString("dd-MM--yyyy");
                    
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            Thread threadBookJournalFill = new Thread(BookJournalFill);
            threadBookJournalFill.Start();
            Thread threadPublishersFill = new Thread(PublishersFill);
            threadPublishersFill.Start();
            Thread threadOfficeFill = new Thread(OfficesFill);
            threadOfficeFill.Start();
            Thread threadFormularsFill = new Thread(ReadersFormularsFill);
            threadFormularsFill.Start();
            tbDateAcceptance.Text = today;
            
        }
        private void btnNewFormular_Click(object sender, EventArgs e)
        {
            ReadersFormularForm RF = new ReadersFormularForm();
            RF.Show();

        }
        private void InformationConnection(bool value)  //проверка подключения к базе данных
        {
            try
            {
                Action action = () =>
                {
                    switch (value)
                    {
                        case (true):
                            //lbsstConnection.Text = Registry_Class.DataSource + "\\" + Registry_Class.DSServerName + " - " + Registry_Class.InitialCatalog;
                            AuthorizationForm authorizationForm = new AuthorizationForm();
                            authorizationForm.Show();
                            break;
                        case (false):
                            //lbsstConnection.Text = MessageUser.NoConnection;

                            foreach (Form f in Application.OpenForms)
                            {
                                if (f.Name == "ConnectionForm")
                                    return;
                            }

                            ConnectionForm connectionForm = new ConnectionForm();
                            connectionForm.Show(this);
                            break;
                    }
                };
                Invoke(action);
            }
            catch
            {
                threadConnection.Abort();
            }
        }
        //Окно Журнал фонда. НАЧАЛО
        private void BookJournalFill() //Заполнение DataGrid данными из БД
        {
            DBTables dBTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dBTables.DTBookJournal.Clear();
                    dBTables.DTBookJournalFill();
                    dBTables.dependency.OnChange += ChangeBookJournal;

                    dgvBookJournal.DataSource = dBTables.DTBookJournal;
                    dgvBookJournal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvBookJournal.Columns[0].HeaderText = "№ п/п";
                    dgvBookJournal.Columns[1].HeaderText = "Название книги";
                    dgvBookJournal.Columns[2].HeaderText = "Автор книги";
                    dgvBookJournal.Columns[3].Visible = false;
                    dgvBookJournal.Columns[4].HeaderText = "Издатель";
                    dgvBookJournal.Columns[5].HeaderText = "Год издания";
                    dgvBookJournal.Columns[6].HeaderText = "Дата принятия в фонд";
                    dgvBookJournal.Columns[7].HeaderText = "Цена";
                    dgvBookJournal.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            Invoke(action);
        }
        private void ChangeBookJournal(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                BookJournalFill();
        }
        
        private void PublishersFill()   //заполнение combo box данными из базы данных
        {
            DBTables dbTables = new DBTables();

            Action action = () =>
            {
                try
                {
                    dbTables.DTPublishers.Clear();
                    dbTables.DTCBPublishersFill();
                    dbTables.dependency.OnChange += ChangePublishers;

                    cbPublisher.DataSource = dbTables.DTPublishers;
                    cbPublisher.ValueMember = "ID_Publisher";
                    cbPublisher.DisplayMember = "Name_Publisher";
                    cbPublisher.SelectedValue = -1;
                }
                catch
                {
                    MessageBox.Show("Ошибка заполнения списка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }
        private void ChangePublishers (object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                PublishersFill();
        }
        private void OfficesFill()   //заполнение combo box данными из базы данных
        {
            DBTables dbTables = new DBTables();

            Action action = () =>
            {
                try
                {
                    dbTables.DTOffices.Clear();
                    dbTables.DTCBOfficeFill();
                    dbTables.dependency.OnChange += ChangeOffices;

                    cbOffice.DataSource = dbTables.DTOffices;
                    cbOffice.ValueMember = "ID_Office";
                    cbOffice.DisplayMember = "Office_Address";
                    cbOffice.SelectedValue = -1;
                }
                catch
                {
                    MessageBox.Show("Ошибка заполнения списка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }
        private void ChangeOffices(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                OfficesFill();
        }
        private void btnInsertBook_Click(object sender, EventArgs e) //Кнопка Внесение книги в фодн
        {
            try
            {
                storedProcedures.SPBooksJournalInsert(tbBookTitle.Text, tbBookAuthor.Text, Convert.ToInt32(cbPublisher.SelectedValue.ToString()),
                    Convert.ToInt32(tbYearPublish.Text), today, Convert.ToInt32(cbOffice.SelectedValue.ToString()), Convert.ToInt32(tbPrice.Text));
            }
            catch
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + "Проверьте правильность ввода данных!";
            }

            tbBookTitle.Clear();
            tbBookAuthor.Clear();
            cbPublisher.SelectedIndex = -1;
            tbYearPublish.Clear();
            cbOffice.SelectedIndex = -1;
            tbPrice.Clear();
            tbDateAcceptance.Clear();
            tbPrice.Clear();
        }
        private void btnDelete_Click(object sender, EventArgs e)    //кнопка Списания книги
        {
            switch (MessageBox.Show(MessageUser.QuestionDeleteBook + " " + tbBookTitle.Text + "?", "Списание книги", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    if (AuthorizationForm.userRole == 1)
                    {
                        storedProcedures.SPBooksJournalDelete(Convert.ToInt32(dgvBookJournal.CurrentRow.Cells[0].Value.ToString()));
                    }
                    else
                    {
                        storedProcedures.SPUBooksJournalLogicalDelete(Convert.ToInt32(dgvBookJournal.CurrentRow.Cells[0].Value.ToString()));
                    }
                    tbBookTitle.Clear();
                    tbBookAuthor.Clear();
                    cbPublisher.SelectedIndex = -1;
                    tbYearPublish.Clear();
                    tbPrice.Clear();
                    tbDateAcceptance.Clear();
                    tbPrice.Clear();
                    break;
            }
        }
        //Окно Журнал фона. КОНЕЦ.
        private void btnInsertNewReader_Click(object sender, EventArgs e)
        {
            InsertNewReaderForm insertNewReaderForm = new InsertNewReaderForm();
            insertNewReaderForm.Show();
        }
        //Окно Формуляры читателей. НАЧАЛО
        private void ReadersFormularsFill() //Заполнение DataGrid данными из БД
        {
            DBTables dBTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dBTables.DTReaderFormular.Clear();
                    dBTables.DTReaderFormularFIll();
                    dBTables.dependency.OnChange += ChangeReadersFormulars;

                    dgvFormulars.DataSource = dBTables.DTReaderFormular;
                    dgvFormulars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvFormulars.Columns[0].HeaderText = "№ п/п";
                    dgvFormulars.Columns[1].HeaderText = "Дата создания";
                    dgvFormulars.Columns[2].Visible = false;
                    dgvFormulars.Columns[3].HeaderText = "ФИО читателя";
                    dgvFormulars.Columns[4].HeaderText = "Номер телефона";
                    dgvFormulars.Columns[5].HeaderText = "Домашний адрес";
                    dgvFormulars.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            Invoke(action);
        }
        private void ChangeReadersFormulars(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                BookJournalFill();
        }
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = (MessageBox.Show("Вы действительно хотите выйти?", "Выход из системы", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2));
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
                //LogoForm logoForm = new LogoForm();
                //logoForm.LogoForm_FormClosing(sender, e);
            }
            else e.Cancel = true;
        }
    }
}