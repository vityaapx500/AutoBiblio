using System;
using Microsoft.Win32;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Автобиблио
{
    public partial class AuthorizationForm : Form
    {
        DBTables dbTables = new DBTables();
        private static DBConnection dBConnection = new DBConnection();
        private int checkUser = 0;
        public static int userRole = 0;
        public AuthorizationForm()
        {
            InitializeComponent();
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (tbLogin.TextLength == 0 || tbPassword.TextLength == 0)  //проверка заполненности полей
                MessageBox.Show("Все поля должны быть заполнены", "СОШ №654", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                SqlCommand commandSearchUser = new SqlCommand("", Registry_Class.sqlConnection);
                SqlCommand commandRoleUser = new SqlCommand("", Registry_Class.sqlConnection);
                commandSearchUser.CommandText = "SELECT COUNT(*) FROM dbo.Users AS U WHERE U.User_Login = @UserLogin and U.User_Password = @UserPassword";
                commandSearchUser.Parameters.AddWithValue("@UserLogin", tbLogin.Text);
                commandSearchUser.Parameters.AddWithValue("@UserPassword", tbPassword.Text);
                commandRoleUser.CommandText = "SELECT [User_Role_ID] FROM dbo.Users AS U WHERE U.User_Login = @UserLogin and U.User_Password = @UserPassword";
                commandRoleUser.Parameters.AddWithValue("@UserLogin", tbLogin.Text);
                commandRoleUser.Parameters.AddWithValue("@UserPassword", tbPassword.Text);

                try     //нахождение пользователя таким логином и паролем
                {
                    Registry_Class.sqlConnection.Open();
                    checkUser = Convert.ToInt32(commandSearchUser.ExecuteScalar().ToString());
                }
                catch
                {
                    MessageBox.Show("Не правильный логин или пароль", "Ошибки в результате работы", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Registry_Class.sqlConnection.Close();
                }

                if (checkUser == 0)
                    MessageBox.Show("Пользователя с данным логином и паролем не обнаружено! Проверьте правильность ввода данных или зарегистрируйтесь.", "СОШ №654", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else     //установление роли данного пользователя
                {
                    Registry_Class.sqlConnection.Open();
                    userRole = Convert.ToInt32(commandRoleUser.ExecuteScalar().ToString());
                    Registry_Class.sqlConnection.Close();
                    MessageBox.Show("Вы авторизовались в информационной системе.", "СОШ №654", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();
                    LogoForm logoForm = new LogoForm();
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                }
            }
        }
        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnEnter_Click(sender, e);
        }
        private void AuthorizationForm_Load(object sender, EventArgs e) //Проверка имени операционной системы
        {
            string key = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion";
            using (RegistryKey regKey = Registry.LocalMachine.OpenSubKey(key))
            {
                if (regKey != null)
                {
                    try
                    {
                        string name = regKey.GetValue("ProductName").ToString();
                        if (name.Contains("XP") || name.Contains("Vista"))
                        {
                            MessageBox.Show("Версия вашей операционной сисетмы не поддерживается. \nПожалуйства обновитесь до версии не ниже Windows 7 Home 32bit!", "Вокзал", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                    MessageBox.Show("Не удалось получить имя ОС в реестре");
            }
        }
        private void btnRegistr_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}