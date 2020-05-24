using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Автобиблио
{
    public partial class LogoForm : Form
    {
        private DBConnection dbConnection = new DBConnection();
        private Thread threadConnection;
        private MainWindow mainWindow = new MainWindow();
        public LogoForm()
        {
            InitializeComponent();
        }

        private void LogoForm_Load(object sender, EventArgs e)
        {
            AllowTransparency = true;
            TransparencyKey = Color.Black;
            //dbConnection.ConnectionState += InformationConnection;
            //threadConnection = new Thread(dbConnection.CheckConnection);
            //threadConnection.Start();
        }
       private void tmLogo_Tick(object sender, EventArgs e)
        {
            if (Opacity != 0) Opacity -= 0.07;
            else
            {
                tmLogo.Enabled = false;
                dbConnection.ConnectionState += InformationConnection;
                threadConnection = new Thread(dbConnection.CheckConnection);
                threadConnection.Start();
            }
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
                            mainWindow.lbsstConnection.Text = Registry_Class.DataSource + "\\" + Registry_Class.DSServerName + " - " + Registry_Class.InitialCatalog;
                            AuthorizationForm authorizationForm = new AuthorizationForm();
                            authorizationForm.Show();
                            break;
                        case (false):
                            mainWindow.lbsstConnection.Text = MessageUser.NoConnection;

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
    }
}