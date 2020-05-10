using System.Data;
using System.Data.SqlClient;

namespace Автобиблио
{
    class DBConnection
    {
        private static string dataSource = @"VICTOR-PC\DOTSUSQL";
        private static string initialCatalog = "AutoBiblio";
        private static string userID = "sa";
        private static string password = "123";
        private static bool checkSecurity = true;
        public static SqlConnection sqlConnection = new SqlConnection($"Data Source = {dataSource}; Initial Catalog = {initialCatalog};" +
            $"Persist Security Info = {checkSecurity}; User ID = {userID}; password = \"{password}\"");
        public DataSet TableFill(string query, SqlConnection sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, sql);
            DataSet dataSet = new DataSet();
            dataSet.Clear();
            adapter.Fill(dataSet);
            return dataSet;
        }
    }
}