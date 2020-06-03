using System;
using AForge.Video;
using System.Drawing;
using System.Threading;
using System.Data.SqlClient;
using AForge.Video.DirectShow;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Автобиблио
{
    public partial class CamSearchForm : Form
    {
        delegate void SetStringDeledate(String parametr);
        private ZXing.BarcodeReader reader; //То, что считалось камерой
        private FilterInfoCollection videoDevices; //Коллекция источников изображения
        private VideoCaptureDevice videoSource; //Камера, источник изображения
        private ReadersFormularForm readersFormular = new ReadersFormularForm();
        private DBStoredProcedures dBStoredProcedures = new DBStoredProcedures();
        private DBTables dbTables = new DBTables();
        public string ScanResult;
        public bool statusProcess;
        public CamSearchForm()
        {
            InitializeComponent();
        }
        //Присвоение результата сканирования перменной
        void SetResult(string result)
        {
            if (!InvokeRequired)
            {
                ScanResult = result;
                switch (statusProcess) //Выбор между выдачей книги и возвратом
                {
                    case (true):
                        lblCaption.Left = (Width - lblCaption.Width) / 2;
                        lblCaption.Font = new Font(lblCaption.Font.FontFamily, 12, FontStyle.Bold);
                        lblCaption.Text = "Проверьте название и дату возращения выдаваемой книги";
                        pbCamImage.Visible = false;
                        pnDates.Left = (Width - pnDates.Width) / 2;
                        pnDates.Top = (Height - pnDates.Height) / 2;
                        pnDates.Visible = true;
                        btnAddIssuedBook.Visible = true;
                        btnAddIssuedBook.Text = "Оформить выдачу книги";
                        break;
                    case (false):
                        lblCaption.Left = (Width - lblCaption.Width) / 2;
                        lblCaption.Font = new Font(lblCaption.Font.FontFamily, 20, FontStyle.Bold);
                        lblCaption.Text = "Просканируйте QR-код";
                        pbCamImage.Visible = false;
                        pnDates.Visible = false;
                        btnAddIssuedBook.Visible = true;
                        btnAddIssuedBook.Text = "Оформить возврат книги";
                        break;
                }
            }
            else Invoke(new SetStringDeledate(SetResult), new object[] { result });
        }
        private void CamSearchForm_Load(object sender, EventArgs e)
        {
            lblCaption.Left = (Width - lblCaption.Width) / 2;
            Thread threadShowPicture = new Thread(ShowPicture);
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice); //Загрузка списка доступных камер
            if (videoDevices.Count > 0)
                foreach (FilterInfo device in videoDevices)
                {
                    lbSources.Items.Add(device.Name);
                }
            lbSources.SelectedIndex = 0;

            reader = new ZXing.BarcodeReader();
            reader.Options.PossibleFormats = new List<ZXing.BarcodeFormat>(); //Возможные форматы для ридера. Создание коллекции
            reader.Options.PossibleFormats.Add(ZXing.BarcodeFormat.QR_CODE); //Добавление в коллекцию формата QRCode

            threadShowPicture.Start(); //Поток вывода изобаржения камеры на форму
        }
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Thread threadShowPicture = new Thread(ShowPicture);
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone(); //Загрузка картинки с камеры в picturebox
            pbCamImage.Image = bitmap;

            ZXing.Result result = reader.Decode((Bitmap)eventArgs.Frame.Clone()); //Выгрузка результата сканирования
            if (result != null)
            {
                SetResult(result.Text);
                threadShowPicture.Abort();
            }
        }
        private void ShowPicture() //Вывод изображения на форму
        {
            videoSource = new VideoCaptureDevice(videoDevices[lbSources.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
            videoSource.Start();
        }
        private void btnAddIssuedBook_Click(object sender, EventArgs e)
        {
            switch (statusProcess)
            {
                case (true):
                    try
                    {
                        dBStoredProcedures.SPIssuedBookInsert(Convert.ToInt32(ScanResult), Convert.ToInt32(MainWindow.FormularNumber), dtpDateIssued.Text, dtpDateReturned.Text, 2);
                        //dbTables.dependency.OnChange += ChangeIssuedBook;
                        var result = MessageBox.Show(MessageUser.BookGiveSuccess, MessageUser.TitleApp, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if(result == DialogResult.OK) Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                case (false):
                    try
                    {
                        dBStoredProcedures.SPIssuedBookReturn(Convert.ToInt32(ScanResult));
                        //dbTables.dependency.OnChange += ChangeIssuedBook;
                        var result = MessageBox.Show(MessageUser.BookReturnSuccess, MessageUser.TitleApp, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if (result == DialogResult.OK) Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }
        //public void ChangeIssuedBook(object sender, SqlNotificationEventArgs e)
        //{
        //    ReadersFormularForm readersFormularForm = new ReadersFormularForm();
        //    if (e.Info != SqlNotificationInfo.Invalid)
        //        readersFormularForm.IssuedBookFill();
        //}
        private void CamSearchForm_FormClosing(object sender, FormClosingEventArgs e) //корректное закрытие формы, завершение всех процессов
        {
            try
            {
                if (videoSource != null)
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}