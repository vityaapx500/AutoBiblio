﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Автобиблио
{
    class DBTables
    {
        public SqlCommand command = new SqlCommand("", Registry_Class.sqlConnection);
        public DataTable DTBookJournal = new DataTable("Book_Journal");
        public DataTable DTIssuedBook = new DataTable("Issued_Book");
        public DataTable DTPublishers = new DataTable("Publisers");
        public DataTable DTReaderFormular = new DataTable("Reader_Formular");
        public DataTable DTRoles = new DataTable("Roles");
        public DataTable DTUsers = new DataTable("Users");
        public DataTable DTReaders = new DataTable("Readers");
        public DataTable DTOffices = new DataTable("Offices");
        public SqlDependency dependency = new SqlDependency();

        public string QRReaders = "SELECT * FROM dbo.Readers WHERE Reader_Logical_Delete = 0";
        public string QRReadersForCB = "SELECT ID_Reader, SurName + ' ' + Name + ' ' + Pantronymic as 'Reader' FROM dbo.Readers WHERE Reader_Logical_Delete= 0";
        public string QRPublishers = "SELECT * FROM dbo.Publishers WHERE Publisher_Logical_Delete = 0";
        public string QRPublishersForCB = "SELECT ID_Publisher, Name_Publisher FROM dbo.Publishers WHERE Publisher_Logical_Delete = 0";
        public string QRUsers = "SELECT * FROM dbo.Users WHERE User_Logical_Delete = 0";
        public string QRRoles = "SELECT * FROM dbo.Roles WHERE Role_Logical_Delete = 0";
        public string QRRolesForCB = "SELECT ID_Role, Role_Name  FROM dbo.Roles WHERE Role_Logical_Delete = 0";
        public string QRBookJournal = "SELECT BJ.ID_Book, BJ.Book_Title, BJ.Book_Author, BJ.Publisher_ID, P.Name_Publisher, " +
            "BJ.Year_Publish, BJ.Date_Acceptance, BJ.Office_ID, O.Office_Address, Price FROM dbo.Book_Journal AS BJ " +
            "INNER JOIN dbo.Publishers AS P ON BJ.Publisher_ID = P.ID_Publisher " +
            "INNER JOIN dbo.Offices AS O ON BJ.Office_ID = O.ID_Office " +
            "WHERE Book_Logical_Delete = 0";
        public string QRBookJournalForCB = "SELECT ID_Book, Book_Title + ' ' + Book_Author + ' ' + Year_Publish AS 'Book' FROM dbo.Book_Journal WHERE Book_Logical_Delete = 0";
        public string QRIssuedBook = "SELECT IB.ID_Issued_Book, IB.Reader_ID, R.SurName + ' ' + R.Name + ' ' + R.Pantronymic AS 'Reader', IB.Book_ID," +
            "BJ.Book_Title + ' ' + BJ.Book_Author + ' ' + BJ.Year_Publish as 'Book', IB.Date_Issued, IB.Date_Returned, IB.Returned FROM dbo.Issued_Book AS IB" +
            "INNER JOIN dbo.Readers AS R ON IB..Reader_ID = R.ID_Reader" +
            "INNER JOIN dbo.Book_Journal AS BJ ON IB.Book_ID = BJ.ID_Book";
        public string QRIssuedBookForCB = "?????????";
        public string QRReaderFormular = "SELECT RF.ID_Formular, RF.Creation_Date, RF.Reader_ID, R.SurName + ' ' + R.Name + ' ' + R.Pantronymic AS 'Reader', " +
            "RF.Phone_Num, RF.Home_Address FROM dbo.Reader_Formular AS RF " +
            "INNER JOIN dbo.Readers AS R ON RF.Reader_ID = R.ID_Reader " +
            "WHERE Formular_Logical_Delete = 0";
        public string QROffice = "SELECT * FROM dbo.Offices WHERE Office_Logical_Delete = 0";
        public string QROfficeforCB = "SELECT ID_Office, Office_Address FROM dbo.Offices WHERE Office_Logical_Delete = 0";

        private void DataTableFill(DataTable table, string query)
        {
            try
            {
                table.Clear();
                command.Notification = null;
                command.CommandText = query;
                dependency.AddCommandDependency(command);
                SqlDependency.Start(Registry_Class.sqlConnection.ConnectionString);
                Registry_Class.sqlConnection.Open();
                table.Load(command.ExecuteReader());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void DTReadersFill()
        {
            DataTableFill(DTReaders, QRReaders);
        }
        public void DTCBReadersFill()
        {
            DataTableFill(DTReaders, QRReadersForCB);
        }
        public void DTPublishersFill()
        {
            DataTableFill(DTPublishers, QRPublishers);
        }
        public void DTCBPublishersFill()
        {
            DataTableFill(DTPublishers, QRPublishersForCB);
        }
        public void DTUsersFill()
        {
            DataTableFill(DTUsers, QRUsers);
        }
        public void DTRolesFill()
        {
            DataTableFill(DTRoles, QRRoles);
        }
        public void DTCBRolesFill()
        {
            DataTableFill(DTRoles, QRRolesForCB);
        }
        public void DTBookJournalFill()
        {
            DataTableFill(DTBookJournal, QRBookJournal);
        }
        public void DTCBBookJournalFill()
        {
            DataTableFill(DTBookJournal, QRBookJournalForCB);
        }
        public void DTIssuedBookFill()
        {
            DataTableFill(DTIssuedBook, QRIssuedBook);
        }
        public void DTCBIssuedBookFill()
        {
            DataTableFill(DTIssuedBook, QRIssuedBookForCB);
        }
        public void DTReaderFormularFIll()
        {
            DataTableFill(DTReaderFormular, QRReaderFormular);
        }
        public void DTOfficeFill()
        {
            DataTableFill(DTOffices, QROffice);
        }
        public void DTCBOfficeFill()
        {
            DataTableFill(DTOffices, QROfficeforCB);
        }
    }
}