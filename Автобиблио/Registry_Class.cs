using System;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace Автобиблио
{
    class Registry_Class
    {
        public static string DataSource = "", DSServerName = "", InitialCatalog = "", UserID = "", UserPassword = "";
        public static string error_message = "App:start:" + DateTime.Now.ToLongDateString();
        public static SqlConnection sqlConnection = new SqlConnection();
        public static string DirPath = "";
        public void GetRegistry()  //Получение баз данных из реестра
        {
            RegistryKey registry = Registry.CurrentUser;
            RegistryKey key = registry.CreateSubKey("AutoBiblio");
            try
            {
                DataSource = key.GetValue("DataSourceIP").ToString();
                DSServerName = key.GetValue("DataSourceServerName").ToString();
                InitialCatalog = key.GetValue("InitialCatalog").ToString();
                UserID = key.GetValue("UserID").ToString();
                UserPassword = key.GetValue("UserPassword").ToString();
            }
            catch
            {
                key.SetValue("DataSourceIP", "Empty");
                key.SetValue("DataSourceServerName", "Empty");
                key.SetValue("InitialCatalog", "Empty");
                key.SetValue("UserID", "Empty");
                key.SetValue("UserPassword", "Empty");
            }
            finally
            {
                sqlConnection.ConnectionString = "Data Source = " + DataSource + "\\" + DSServerName + "; Initial Catalog = " + InitialCatalog +
                    "; Persist Security Info = true; " + "User ID = " + UserID + "; Password = \"" + UserPassword + "\"";
            }
        }

        public void SetRegistry(string DataSource, string DSServerName, string InitialCatalog, string UserID, string UserPassword) //Отправка данных в реестр
        {
            RegistryKey registry = Registry.CurrentUser;
            RegistryKey key = registry.CreateSubKey("AutoBiblio");
            try
            {
                key.SetValue("DataSourceIP", DataSource);
                key.SetValue("DataSourceServerName", DSServerName);
                key.SetValue("InitialCatalog", InitialCatalog);
                key.SetValue("UserID", UserID);
                key.SetValue("UserPassword", UserPassword);
                GetRegistry();
            }
            catch (Exception ex)
            {
                error_message += "\n" + DateTime.Now.ToLongDateString() + ex.Message;
            }
        }
        public void ConfigurationGet()  //получение данных о конфигурации приложения из реестра
        {
            RegistryKey registry = Registry.CurrentUser;
            RegistryKey keyRegistry = registry.CreateSubKey("AutoBiblio");
            RegistryKey subKey = registry.CreateSubKey("Configuration");

            try
            {
                DirPath = subKey.GetValue("DirPath").ToString();
            }
            catch
            {
                subKey.SetValue("DirPath", "Empty");
            }
        }
        public void ConfigurationSet(string Path)   //отправка данных о конфигурации приложения из реестра
        {
            RegistryKey registry = Registry.CurrentUser;
            RegistryKey keyRegistry = registry.CreateSubKey("AutoBiblio");
            RegistryKey subKey = registry.CreateSubKey("Configuration");
            subKey.SetValue("DirPath", Path);
            ConfigurationGet();
        }
    }
}