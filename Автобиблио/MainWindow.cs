using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace Автобиблио
{
    public partial class MainWindow : Form
    {
        private DBConnection dbConnection = new DBConnection();
        private Thread threadConnection;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            dbConnection.ConnectionState += InformationConnection;
            threadConnection = new Thread(dbConnection.CheckConnection);
            threadConnection.Start();
        }
        private void btnNewFormular_Click(object sender, EventArgs e)
        {
            ReadersFormular RF = new ReadersFormular();
            RF.Show();
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
                            //lbsstConnection.Text = Registry_Class.DataSource + "\\" + Registry_Class.DSServerName + " - " + Registry_Class.InitialCatalog;
                            //AuthorizationForm authorizationForm = new AuthorizationForm();
                            //authorizationForm.Show();
                            break;
                        case (false):
                            //lbsstConnection.Text = MessageUser.NoConnection;

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
