using System;
using System.Threading;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Автобиблио
{
    public partial class ReadersFormularForm : Form
    {
        public string stateProcess = "";
        //MainWindow mainWindow = new MainWindow();
        

        public ReadersFormularForm()
        {
            InitializeComponent();
        }
        private void ReadersFormularForm_Load(object sender, EventArgs e)
        {
            lblReader.Text = "ФИО: " + MainWindow.FIOReader;
            lblNum.Text = "№ " + MainWindow.FormularNumber;
            lblCreationDate.Text = "Дата создания: " + MainWindow.CreationDate;
            lblPhoneNumber.Text = "Номер телефона: " + MainWindow.PhoneNumber;
            lblHomeAddress.Text = "Домашний адрес: " + MainWindow.HomeAddress;
            Thread threadIssuedBookFill = new Thread(IssuedBookFill);
            threadIssuedBookFill.Start();
        }
        private void IssuedBookFill()
        {
            DBTables dbTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dbTables.DTIssuedBook.Clear();
                    dbTables.DTIssuedBookFill();
                    dbTables.dependency.OnChange += ChangeIssuedBook;

                    dgvIssuedBooks.DataSource = dbTables.DTIssuedBook;
                    dgvIssuedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvIssuedBooks.Columns[0].HeaderText = "№ п/п";
                    dgvIssuedBooks.Columns[1].Visible = false;
                    dgvIssuedBooks.Columns[2].Visible = false;
                    dgvIssuedBooks.Columns[3].Visible = false;
                    dgvIssuedBooks.Columns[4].HeaderText = "Книга";
                    dgvIssuedBooks.Columns[5].HeaderText = "Дата выдачи";
                    dgvIssuedBooks.Columns[6].HeaderText = "Когда нужно сдать";
                    dgvIssuedBooks.Columns[7].HeaderText = "Книга возвращена";
                    dgvIssuedBooks.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            Invoke(action);
        }
        private void ChangeIssuedBook(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                IssuedBookFill();
        }
        private void btnGive_Click(object sender, EventArgs e)
        {
            CamSearchForm camSearchForm = new CamSearchForm();
            camSearchForm.ShowDialog();
            //Наладить процесс выдачи возврата книги после сканирования
        }
    }
}