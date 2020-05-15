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
        private string today = dateToday.Date.ToString("dd-MM--yyyy");
                    
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            dbConnection.ConnectionState += InformationConnection;
            threadConnection = new Thread(dbConnection.CheckConnection);
            threadConnection.Start();
        }
        private void btnNewFormular_Click(object sender, EventArgs e)
        {
            //ReadersFormular RF = new ReadersFormular();
            //RF.Show();
            Thread threadBookJournal = new Thread(BookJournalFill);
            threadBookJournal.Start();
            Thread threadUsers = new Thread(UsersFill);
            threadUsers.Start();
            Thread threadPublishers = new Thread(PublishersFill);
            threadPublishers.Start();
            tbDateAcceptance.Text = today.ToString();
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
                            //AuthorizationForm authorizationForm = new AuthorizationForm();
                            //authorizationForm.Show();
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
        private void BookJournalFill()
        {
            MainWindow MW = new MainWindow();
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
        private void UsersFill()
        {
            MainWindow MW = new MainWindow();
            DBTables dbTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dbTables.DTUsers.Clear();
                    dbTables.DTUsersFill();
                    dbTables.dependency.OnChange += ChangeUser;

                    dgvUsers.DataSource = dbTables.DTUsers;
                    dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvUsers.Columns[0].HeaderText = "Роль";
                    dgvUsers.Columns[1].HeaderText = "Фамилия пользователя";
                    dgvUsers.Columns[2].HeaderText = "Имя пользователя";
                    dgvUsers.Columns[3].HeaderText = "Отчество пользователя";
                    dgvUsers.Columns[4].HeaderText = "Логин";
                    dgvUsers.Columns[5].HeaderText = "Пароль";

                    dgvUsers.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            Invoke(action);
        }
        private void ChangeUser(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                UsersFill();
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

        private void btnInsertBook_Click(object sender, EventArgs e)
        {
            try
            {
                storedProcedures.SPBooksJournalInsert(tbBookTitle.Text, tbBookAuthor.Text, Convert.ToInt32(cbPublisher.SelectedValue.ToString()),
                    Convert.ToInt32(tbYearPublish.Text), today, Convert.ToInt32(tbPrice.Text));
            }
            catch
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + "Проверьте правильность ввода данных!";
            }

            //tbBookTitle.Clear();
            //tbBookAuthor.Clear();
            //cbPublisher.SelectedIndex = -1;
            //tbYearPublish.Clear();
            //tbPrice.Clear();
            //tbDateAcceptance.Clear();
            //tbPrice.Clear();
        }
        private void btnDelete_Click(object sender, EventArgs e)    //кнопка удаления записи
        {
            switch (MessageBox.Show(MessageUser.QuestionDeleteBook + " " + tbBookTitle.Text + "?", "Списание книги", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    //if (AuthorizationForm.userRole == 1)
                    //{
                        storedProcedures.SPBooksJournalDelete(Convert.ToInt32(dgvBookJournal.CurrentRow.Cells[0].Value.ToString()));
                    //}
                    //else
                    //{
                    //    storedProcedures.SPUBooksJournalLogicalDelete(Convert.ToInt32(dgvBookJournal.CurrentRow.Cells[0].Value.ToString()));
                    //}
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
    }
}