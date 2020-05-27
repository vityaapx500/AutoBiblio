using System;
using AForge.Video;
using System.Drawing;
using System.Threading;
using AForge.Video.DirectShow;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Автобиблио
{
    public partial class CamSearchForm : Form
    {
        public string searchResult;
        delegate void SetStringDeledate(String parametr);
        private ZXing.BarcodeReader reader; //То, что считалось камерой
        private FilterInfoCollection videoDevices; //Коллекция источников изображения
        private VideoCaptureDevice videoSource; //Камера, источник изображения
        public string ScanResult;
        public CamSearchForm()
        {
            InitializeComponent();
        }
        void SetResult(string result)
        {
            if (!InvokeRequired) ScanResult = result;
            else Invoke(new SetStringDeledate(SetResult), new object[] { result });
        }
        private void CamSearchForm_Load(object sender, EventArgs e)
        {
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
            Thread threadShowPictire = new Thread(ShowPicture);
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone(); //Загрузка картинки с камеры в picturebox
            pbCamImage.Image = bitmap;

            ZXing.Result result = reader.Decode((Bitmap)eventArgs.Frame.Clone()); //Выгрузка результата сканирования
            if (result != null)
            {
                SetResult(result.Text);
                videoSource = null;
                threadShowPictire.Abort();
                //Hide();
            }
        }
        private void ShowPicture() //Вывод изображения на форму
        {
            videoSource = new VideoCaptureDevice(videoDevices[lbSources.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
            videoSource.Start();
        }
        private void CamSearchForm_FormClosing(object sender, FormClosingEventArgs e) //корректное закрытие формы, завершение всех процессов
        {
            if (videoSource != null)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
        }
    }
}