using System;
using System.Data;
using System.Threading;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Автобиблио
{
    public partial class ReadersFormularForm : Form
    {
        public bool scanningStatus;
        DataTable DTIssuedBook = new DataTable("Issued_Book");
        SqlCommand commandIssuedBook = new SqlCommand("", Registry_Class.sqlConnection);
        private string QWIssuedBook = "SELECT IB.ID_Issued_Book, IB.Reader_Formular_ID, RF.ID_Formular, IB.Book_ID, BJ.Book_Title + ', ' + BJ.Book_Author + ', ' + BJ.Year_Publish as 'Book', IB.Date_Issued, IB.Date_Returned, " +
            "IB.Status_ID, SI.Name_Status FROM dbo.Issued_Book AS IB " +
            "INNER JOIN dbo.Reader_Formular AS RF on IB.Reader_Formular_ID = ID_Formular " +
            "INNER JOIN dbo.Book_Journal AS BJ ON IB.Book_ID = BJ.ID_Book " +
            "INNER JOIN dbo.Status_Issue AS SI ON IB.Status_ID = SI.ID_Status WHERE Reader_Formular_ID = " + MainWindow.FormularNumber;
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
        public void IssuedBookFill()
        {
            DBTables dbTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dbTables.DTIssuedBook.Clear();
                    DTIssuedBookFill();
                    dbTables.dependency.OnChange += ChangeIssuedBook;

                    dgvIssuedBooks.DataSource = DTIssuedBook;
                    dgvIssuedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvIssuedBooks.Columns[0].HeaderText = "№ п/п";
                    dgvIssuedBooks.Columns[1].Visible = false;
                    dgvIssuedBooks.Columns[2].Visible = false;
                    dgvIssuedBooks.Columns[3].Visible = false;
                    dgvIssuedBooks.Columns[4].HeaderText = "Книга";
                    dgvIssuedBooks.Columns[5].HeaderText = "Дата выдачи";
                    dgvIssuedBooks.Columns[6].HeaderText = "Когда нужно сдать";
                    dgvIssuedBooks.Columns[7].Visible = false;
                    dgvIssuedBooks.Columns[8].HeaderText = "Статус книги";
                    dgvIssuedBooks.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            Invoke(action);
        }
        public void DTIssuedBookFill()
        {
            DBTables dbTables = new DBTables();
            dbTables.DataTableFill(DTIssuedBook, QWIssuedBook);
        }
        public void ChangeIssuedBook(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                IssuedBookFill();
        }
        private void btnGiveBook_Click(object sender, EventArgs e)
        {
            CamSearchForm camSearchForm = new CamSearchForm();
            camSearchForm.statusProcess = true;
            camSearchForm.Show();

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            CamSearchForm camSearchForm = new CamSearchForm();
            camSearchForm.statusProcess = false;
            camSearchForm.Show();
            //IssuedBookFill();
        }

        private void ReadersFormularForm_Activated(object sender, EventArgs e)
        {
            DTIssuedBookFill();
        }
    }
}