using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Автобиблио
{
    class DBStoredProcedures
    {
        private SqlCommand storedProcedure = new SqlCommand("", DBConnection.sqlConnection);

        private void ConfigurationProcedure(string nameProcedure)
        {
            storedProcedure.CommandText = nameProcedure;
            storedProcedure.CommandType = System.Data.CommandType.StoredProcedure;
        }
        public void ExecuteStoredProcedure() //Выполнение процедуры
        {
            try
            {
                DBConnection.sqlConnection.Open();
                DBConnection.sqlConnection.InfoMessage += MessageInformation;
                storedProcedure.ExecuteNonQuery();
                storedProcedure.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DBConnection.sqlConnection.Close();
            }
        }

        public void MessageInformation(object sender, SqlInfoMessageEventArgs e) //Сообщение об ошибке
        {
            MessageBox.Show(e.Message);
        }
        //Процедуры для таблицы Роли
        public void SPRoleInsert(string RoleName, string AdminRole, string Libararian) //Добавление роли
        {
            ConfigurationProcedure("Roles_Insert");

            storedProcedure.Parameters.AddWithValue("@Role_Name", RoleName);
            storedProcedure.Parameters.AddWithValue("@Admin_role", AdminRole);
            storedProcedure.Parameters.AddWithValue("@Librarian", Libararian);

            ExecuteStoredProcedure();
        }

        public void SPRoleUpdate(Int32 IDRole, string RoleName, string AdminRole, string Libararian) //Обновление данных о роли
        {
            ConfigurationProcedure("Roles_Update");

            storedProcedure.Parameters.AddWithValue("@ID_Role", IDRole);
            storedProcedure.Parameters.AddWithValue("@Role_Name", RoleName);
            storedProcedure.Parameters.AddWithValue("@Admin_role", AdminRole);
            storedProcedure.Parameters.AddWithValue("@Librarian", Libararian);

            ExecuteStoredProcedure();
        }

        public void SPRoleDelete(Int32 IDRole) //Удаление роли
        {
            ConfigurationProcedure("Roles_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_Role", IDRole);

            ExecuteStoredProcedure();
        }

        public void SPRoleLogicalDelete(Int32 IDRole) //Логическое удаление роли
        {
            ConfigurationProcedure("Roles_Logical_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_Role", IDRole);

            ExecuteStoredProcedure();
        }
        //Процедуры для таблицы Пользователи
        public void SPUsersInsert(Int32 UserRoleID, string SurName, string Name, string Pantronymic, string UserLogin, string UserPassword) //Добавление пользователя
        {
            ConfigurationProcedure("Users_Insert");

            storedProcedure.Parameters.AddWithValue("@User_Role_ID", UserRoleID);
            storedProcedure.Parameters.AddWithValue("@SurName", SurName);
            storedProcedure.Parameters.AddWithValue("@Name", Name);
            storedProcedure.Parameters.AddWithValue("@Pantronymic", Pantronymic);
            storedProcedure.Parameters.AddWithValue("@User_Login", UserLogin);
            storedProcedure.Parameters.AddWithValue("@User_Password", UserPassword);

            ExecuteStoredProcedure();
        }

        public void SPUsersUpdate(Int32 IDUser, Int32 UserRoleID, string SurName, string Name, string Pantronymic, string UserLogin, string UserPassword) //Обновление данных о пользователе
        {
            ConfigurationProcedure("Users_Update");

            storedProcedure.Parameters.AddWithValue("@ID_User", IDUser);
            storedProcedure.Parameters.AddWithValue("@User_Role_ID", UserRoleID);
            storedProcedure.Parameters.AddWithValue("@SurName", SurName);
            storedProcedure.Parameters.AddWithValue("@Name", Name);
            storedProcedure.Parameters.AddWithValue("@Pantronymic", Pantronymic);
            storedProcedure.Parameters.AddWithValue("@User_Login", UserLogin);
            storedProcedure.Parameters.AddWithValue("@User_Password", UserPassword);

            ExecuteStoredProcedure();
        }

        public void SPUsersDelete(Int32 IDUser) //Удаление пользователя
        {
            ConfigurationProcedure("Users_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_User", IDUser);

            ExecuteStoredProcedure();
        }

        public void SPUsersLogicalDelete(Int32 IDUser) //Логическое удаление пользователя
        {
            ConfigurationProcedure("Users_Logical_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_User", IDUser);

            ExecuteStoredProcedure();
        }
        //Процедуры для таблицы Журнал фонда
        public void SPBooksJournalInsert(string CodeBook, string BookTitle, string BookAuthor, Int32 PublisherID, Int32 YearPublish, Int32 DateAcceptance, Int32 Price) //Добавление книги
        {
            ConfigurationProcedure("Journal_Insert");

            storedProcedure.Parameters.AddWithValue("@Code_Book", CodeBook);
            storedProcedure.Parameters.AddWithValue("@Book_Title", BookTitle);
            storedProcedure.Parameters.AddWithValue("@Book_Author", BookAuthor);
            storedProcedure.Parameters.AddWithValue("@Publisher_ID", PublisherID);
            storedProcedure.Parameters.AddWithValue("@Year_Publish", YearPublish);
            storedProcedure.Parameters.AddWithValue("@Date_Acceptance", DateAcceptance);
            storedProcedure.Parameters.AddWithValue("@Price", Price);

            ExecuteStoredProcedure();
        }

        public void SPBooksJournalUpdate(Int32 IDBook, string CodeBook, string BookTitle, string BookAuthor, Int32 PublisherID, Int32 YearPublish, Int32 DateAcceptance, Int32 Price) //Обновление данных о книги
        {
            ConfigurationProcedure("Journal_Update");

            storedProcedure.Parameters.AddWithValue("@ID_User", IDBook);
            storedProcedure.Parameters.AddWithValue("@Code_Book", CodeBook);
            storedProcedure.Parameters.AddWithValue("@Book_Title", BookTitle);
            storedProcedure.Parameters.AddWithValue("@Book_Author", BookAuthor);
            storedProcedure.Parameters.AddWithValue("@Publisher_ID", PublisherID);
            storedProcedure.Parameters.AddWithValue("@Year_Publish", YearPublish);
            storedProcedure.Parameters.AddWithValue("@Date_Acceptance", DateAcceptance);
            storedProcedure.Parameters.AddWithValue("@Price", Price);

            ExecuteStoredProcedure();
        }

        public void SPBooksJournalDelete(Int32 IDBook) //Удаление пользователя
        {
            ConfigurationProcedure("Journal_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_Book", IDBook);

            ExecuteStoredProcedure();
        }

        public void SPUBooksJournalLogicalDelete(Int32 IDBook) //Логическое удаление книги
        {
            ConfigurationProcedure("Journal_Logical_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_Book", IDBook);

            ExecuteStoredProcedure();
        }
        //Процедуры для таблицы Издательства
        public void SPPublishersInsert(string NamePublisher) //Добавление издательства
        {
            ConfigurationProcedure("Publish_Insert");

            storedProcedure.Parameters.AddWithValue("@Name_Publisher", NamePublisher);
            
            ExecuteStoredProcedure();
        }

        public void SPPublishersUpdate(Int32 IDPublish, string NamePublisher) //Обновление данных о издательстве
        {
            ConfigurationProcedure("Publish_Update");

            storedProcedure.Parameters.AddWithValue("@ID_Publish", IDPublish);
            storedProcedure.Parameters.AddWithValue("@Name_Publisher", NamePublisher);

            ExecuteStoredProcedure();
        }

        public void SPPublishersDelete(Int32 IDPublish) //Удаление издательства
        {
            ConfigurationProcedure("Publish_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_Publish", IDPublish);

            ExecuteStoredProcedure();
        }

        public void SPUPublishersLogicalDelete(Int32 IDPublish) //Логическое удаление издательства
        {
            ConfigurationProcedure("Publish_Logical_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_Publish", IDPublish);

            ExecuteStoredProcedure();
        }
        //Процедуры для таблицы Выданная книга
        public void SPIssuedBookInsert(Int32 ReaderID, Int32 BookID, Int32 DateIssued, Int32 DateReturned, Int32 Returned) //Добавление выданной книги
        {
            ConfigurationProcedure("Issued_Book_Insert");

            storedProcedure.Parameters.AddWithValue("@Reader_ID", ReaderID);
            storedProcedure.Parameters.AddWithValue("@Book_ID", BookID);
            storedProcedure.Parameters.AddWithValue("@Date_Issued", DateIssued);
            storedProcedure.Parameters.AddWithValue("@Date_Returned", DateReturned);
            storedProcedure.Parameters.AddWithValue("@Returned", Returned);
            
            ExecuteStoredProcedure();
        }

        public void SPIssuedBookUpdate(Int32 IDIssuedBook, Int32 ReaderID, Int32 BookID, Int32 DateIssued, Int32 DateReturned, Int32 Returned) //Обновление данных о выданной книге
        {
            ConfigurationProcedure("Issued_Book_Update");

            storedProcedure.Parameters.AddWithValue("@ID_Issued_Book", IDIssuedBook);
            storedProcedure.Parameters.AddWithValue("@Reader_ID", ReaderID);
            storedProcedure.Parameters.AddWithValue("@Book_ID", BookID);
            storedProcedure.Parameters.AddWithValue("@Date_Issued", DateIssued);
            storedProcedure.Parameters.AddWithValue("@Date_Returned", DateReturned);
            storedProcedure.Parameters.AddWithValue("@Returned", Returned);

            ExecuteStoredProcedure();
        }

        public void SPIssuedBookDelete(Int32 IDIssuedBook) //Удаление выданной книги
        {
            ConfigurationProcedure("Issued_Book_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_Issued_Book", IDIssuedBook);

            ExecuteStoredProcedure();
        }

        public void SPUIssuedBookLogicalDelete(Int32 IDIssuedBook) //Логическое удаление выданной книги
        {
            ConfigurationProcedure("Issued_Book_Logical_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_Issued_Book", IDIssuedBook);

            ExecuteStoredProcedure();
        }
        //Процедуры для таблицы Формуляр
        public void SPReaderFormularInsert(Int32 Creation_Date, string Phone_Num, string Home_Address, Int32 IssuedBookID) //Добавление пользователя
        {
            ConfigurationProcedure("Formular_Insert");

            storedProcedure.Parameters.AddWithValue("@Creation_Date", Creation_Date);
            storedProcedure.Parameters.AddWithValue("@Phone_Num", Phone_Num);
            storedProcedure.Parameters.AddWithValue("@Home_Address", Home_Address);
            storedProcedure.Parameters.AddWithValue("@Issued_Book_ID", IssuedBookID);

            ExecuteStoredProcedure();
        }

        public void SPReaderFormularUpdate(Int32 IDFormular, Int32 Creation_Date, string Phone_Num, string Home_Address, Int32 IssuedBookID) //Обновление данных о пользователе
        {
            ConfigurationProcedure("Formular_Update");

            storedProcedure.Parameters.AddWithValue("@ID_Formular", IDFormular);
            storedProcedure.Parameters.AddWithValue("@Creation_Date", Creation_Date);
            storedProcedure.Parameters.AddWithValue("@Phone_Num", Phone_Num);
            storedProcedure.Parameters.AddWithValue("@Home_Address", Home_Address);
            storedProcedure.Parameters.AddWithValue("@Issued_Book_ID", IssuedBookID);

            ExecuteStoredProcedure();
        }

        public void SPReaderFormularDelete(Int32 IDFormular) //Удаление пользователя
        {
            ConfigurationProcedure("Formular_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_Formular", IDFormular);

            ExecuteStoredProcedure();
        }

        public void SPUReaderFormularLogicalDelete(Int32 IDFormular) //Логическое удаление пользователя
        {
            ConfigurationProcedure("Formular_Logical_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_Formular", IDFormular);

            ExecuteStoredProcedure();
        }
        //Процедуры для таблицы Читатели
        public void SPReaderslInsert(Int32 NumReader, string SurName, string Name, string Pantronymic) //Добавление пользователя
        {
            ConfigurationProcedure("Reader_Insert");

            storedProcedure.Parameters.AddWithValue("@NumReader", NumReader);
            storedProcedure.Parameters.AddWithValue("@SurName", SurName);
            storedProcedure.Parameters.AddWithValue("@Name", Name);
            storedProcedure.Parameters.AddWithValue("@Pantronymic", Pantronymic);

            ExecuteStoredProcedure();
        }

        public void SPReadersUpdate(Int32 IDReader, Int32 NumReader, string SurName, string Name, string Pantronymic) //Обновление данных о пользователе
        {
            ConfigurationProcedure("Reader_Update");

            storedProcedure.Parameters.AddWithValue("@@ID_Reader", IDReader);
            storedProcedure.Parameters.AddWithValue("@NumReader", NumReader);
            storedProcedure.Parameters.AddWithValue("@SurName", SurName);
            storedProcedure.Parameters.AddWithValue("@Name", Name);
            storedProcedure.Parameters.AddWithValue("@Pantronymic", Pantronymic);

            ExecuteStoredProcedure();
        }

        public void SPReadersDelete(Int32 IDReader) //Удаление пользователя
        {
            ConfigurationProcedure("Reader_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_Reader", IDReader);

            ExecuteStoredProcedure();
        }

        public void SPUReadersLogicalDelete(Int32 IDReader) //Логическое удаление пользователя
        {
            ConfigurationProcedure("Reader_Logical_Delete");

            storedProcedure.Parameters.AddWithValue("@ID_Reader", IDReader);

            ExecuteStoredProcedure();
        }
    }
}
