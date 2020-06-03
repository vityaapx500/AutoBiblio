using System;
using System.Threading;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Автобиблио
{
    public partial class RegistrationForm : Form
    {
        DBStoredProcedures storedProcedures = new DBStoredProcedures();
        public RegistrationForm()
        {
            InitializeComponent();
        }
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            Thread threadOffice = new Thread(OfficeFill);
            Thread threadRole = new Thread(RoleFill);
            threadOffice.Start();
            threadRole.Start();
        }
        private void OfficeFill()
        {
            DBTables dbTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dbTables.DTOffices.Clear();
                    dbTables.DTOfficeFill();
                    dbTables.dependency.OnChange += ChangeOffice;

                    cbOffice.DataSource = dbTables.DTOffices;
                    cbOffice.ValueMember = "ID_Office";
                    cbOffice.DisplayMember = "Office_Address";
                    cbOffice.SelectedValue = -1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            Invoke(action);
        }
        private void ChangeOffice(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                OfficeFill();
        }
        private void RoleFill()
        {
            DBTables dbTables = new DBTables();
            Action action = () =>
            {
                try
                {
                    dbTables.DTRoles.Clear();
                    dbTables.DTCBRolesFill();
                    dbTables.dependency.OnChange += ChangeRole;

                    cbRole.DataSource = dbTables.DTRoles;
                    cbRole.ValueMember = "ID_Role";
                    cbRole.DisplayMember = "Role_Name";
                    cbRole.SelectedValue = -1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
            Invoke(action);
        }
        private void ChangeRole(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                RoleFill();
        }
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (cbOffice.SelectedIndex != -1 || tbSurName.Text != "" || tbName.Text != "" || tbPantronymic.Text != "" || tbLogin.Text != "" || tbPassword.Text != "")
            {
                try
                {
                    storedProcedures.SPUsersInsert(Convert.ToInt32(cbRole.SelectedValue.ToString()), Convert.ToInt32(cbOffice.SelectedValue.ToString()), tbSurName.Text, tbName.Text, tbPantronymic.Text, tbLogin.Text, tbPassword.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else MessageBox.Show("Пожалуйста, заполните все поля!");
        }
    }
}
