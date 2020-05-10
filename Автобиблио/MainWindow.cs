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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNewFormular_Click(object sender, EventArgs e)
        {
            ReadersFormular RF = new ReadersFormular();
            RF.Show();
        }
    }
}
