using System;
using System.Threading;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Автобиблио
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            Thread threadUsers = new Thread(UsersFill);
            threadUsers.Start();
        }
        private void UsersFill()
        {
            DBTables dbTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dbTables.DTUsers.Clear();
                    dbTables.DTUsersFill();
                    dbTables.dependency.OnChange += ChangeUser;

                    dgvUsers.DataSource = dbTables.DTUsers;
                    dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvUsers.Columns[0].Visible = false;
                    dgvUsers.Columns[1].HeaderText = "Роль";
                    dgvUsers.Columns[2].HeaderText = "Отделение";
                    dgvUsers.Columns[3].HeaderText = "Фамилия пользователя";
                    dgvUsers.Columns[4].HeaderText = "Имя пользователя";
                    dgvUsers.Columns[5].HeaderText = "Отчество пользователя";
                    dgvUsers.Columns[6].HeaderText = "Логин";
                    dgvUsers.Columns[7].HeaderText = "Пароль";

                    dgvUsers.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            Invoke(action);
        }
        private void ChangeUser(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                UsersFill();
        }
        private void OfficesFill()   //заполнение combo box данными из базы данных
        {
            DBTables dbTables = new DBTables();

            Action action = () =>
            {
                try
                {
                    dbTables.DTOffices.Clear();
                    dbTables.DTCBOfficeFill();
                    dbTables.dependency.OnChange += ChangeOffices;

                    cbOffice.DataSource = dbTables.DTOffices;
                    cbOffice.ValueMember = "ID_Office";
                    cbOffice.DisplayMember = "Office_Address";
                    cbOffice.SelectedValue = -1;
                }
                catch
                {
                    MessageBox.Show("Ошибка заполнения списка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };
            Invoke(action);
        }
        private void ChangeOffices(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                OfficesFill();
        }
    }
}