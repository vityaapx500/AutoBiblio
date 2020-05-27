using System;
using System.Threading;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Автобиблио
{
    public partial class InsertNewReaderForm : Form
    {
        DBStoredProcedures storedProcedures = new DBStoredProcedures();
        MainWindow mainWindow = new MainWindow();
        private static DateTime dateToday = DateTime.Now;
        public string today = dateToday.Date.ToString("dd.MM.yyyy");
        public InsertNewReaderForm()
        {
            InitializeComponent();
        }
        private void InsertNewReaderForm_Load(object sender, EventArgs e)
        {
            tbCreationDate.Text = today.ToString();
            Thread threadReaderFill = new Thread(ReaderFill);
            threadReaderFill.Start();
        }
        private void ReaderFill()
        {
            DBTables dbTables = new DBTables();

            Action action = () =>
            {
                try
                {
                    dbTables.DTReaders.Clear();
                    dbTables.DTCBReadersFill();
                    dbTables.dependency.OnChange += ChangeReader;

                    cbReader.DataSource = dbTables.DTReaders;
                    cbReader.ValueMember = "ID_Reader";
                    cbReader.DisplayMember = "Reader";
                    cbReader.SelectedValue = -1;
                }
                catch
                {
                    MessageBox.Show("Ошибка заполнения списка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }
        private void ChangeReader(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                ReaderFill();
        }

        private void btnInsertBook_Click(object sender, EventArgs e)
        {
            try
            {
                storedProcedures.SPReaderFormularInsert(tbCreationDate.Text, Convert.ToInt32(cbReader.SelectedValue.ToString()), mtbPhoneNumber.Text, tbHomeAddress.Text);
            }
            catch
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + "Проверьте правильность ввода данных!";
            }
            cbReader.SelectedIndex = -1;
            mtbPhoneNumber.Clear();
            tbHomeAddress.Clear();
            MessageBox.Show(MessageUser.FormularInsert, MessageUser.TitleApp, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Close();
        }

        
    }
}
