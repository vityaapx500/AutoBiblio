using System;
using System.Drawing;
using MessagingToolkit.QRCode.Codec;
using System.Windows.Forms;

namespace Автобиблио
{
    public partial class CreateQRCodeForm : Form
    {
        public CreateQRCodeForm()
        {
            InitializeComponent();
        }
        private void CreateQRCodeForm_Load(object sender, EventArgs e)
        {
            tbBook.Text = MainWindow.BookTitle + ", " + MainWindow.BookAuthor + ", " + MainWindow.Publisher + ", " + MainWindow.YearPublish;
        }
        private void btnCreateCode_Click(object sender, EventArgs e)
        {
            string qrtext = MainWindow.IDBook;
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap qrcode = encoder.Encode(qrtext);
            pbBookCode.Image = qrcode as Image;
        }

        private void btnSaveCode_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif|BMP|*.bmp";
            save.FileName = tbBook.Text;
            if (save.ShowDialog() == DialogResult.OK)
                pbBookCode.Image.Save(save.FileName);
        }
    }
}