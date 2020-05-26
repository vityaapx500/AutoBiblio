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
    public partial class ReadersFormularForm : Form
    {
        public string stateProcess = "";
        public ReadersFormularForm()
        {
            InitializeComponent();
        }

        private void btnGive_Click(object sender, EventArgs e)
        {
            CamSearchForm camSearchForm = new CamSearchForm();
            camSearchForm.ShowDialog();
            //Наладить процесс выдачи возврата книги после сканирования
        }
    }
}