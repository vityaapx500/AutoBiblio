using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Автобиблио
{
    public partial class InsertNewReaderForm : Form
    {
        DBStoredProcedures storedProcedures = new DBStoredProcedures();
        MainWindow mainWindow = new MainWindow();
        public InsertNewReaderForm()
        {
            InitializeComponent();
        }

        private void btnInsertBook_Click(object sender, EventArgs e)
        {
            try
            {
                storedProcedures.SPReaderFormularInsert(tbCreationDate.Text, mtbPhoneNumber.Text, tbHomeAddress.Text);
            }
            catch
            {
                Registry_Class.error_message += "\n" + DateTime.Now.ToLongDateString() + "Проверьте правильность ввода данных!";
            }
            mtbPhoneNumber.Clear();
            tbHomeAddress.Clear();
        }

        private void btnDeleteFormular_Click(object sender, EventArgs e)
        {
            //switch (MessageBox.Show("Удалить формуляр читателя?", "Удалеение формуляра", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            //{
            //    case DialogResult.Yes:
            //        if(AuthorizationForm.userRole == 1)
            //            storedProcedures.SPReaderFormularDelete(Convert.ToInt32())
            //        break;
            //}
        }
    }
}
