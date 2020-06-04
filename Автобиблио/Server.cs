using System;
using System.Net;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Автобиблио
{
    class Server
    {
        public static bool process;
        private static HttpListener listener;
        public class Book
        {
            public string title;
            public string year;
        }
        public void ServerActivate()
        {
            string[] prefixes = { "http://localhost:8086/books/" };
            if (!HttpListener.IsSupported)
            {
                Console.WriteLine("Windows XP SP2 or Server 2003 is required to use the HttpListener class.");
                return;
            }
            // Префикс для URI,
            if (prefixes == null || prefixes.Length == 0)
                throw new ArgumentException("prefixes");

            // Создание объекта прослушки
            listener = new HttpListener();
            // Добавление префикса
            foreach (string s in prefixes)
            {
                listener.Prefixes.Add(s);
            }
            listener.Start();

            process = true;
            while (process)
            {
                HttpListenerContext context = listener.GetContext();
                HttpListenerRequest request = context.Request;
                
                // Рвспределение ответа сервера по виду запроса

                SqlCommand command = new SqlCommand("", Registry_Class.sqlConnection);
                if (request.QueryString.Get("author") != null && request.QueryString.Get("year") != null)
                {
                    command.CommandText = "SELECT * FROM dbo.Book_Journal"; //WHERE Book_Author = @author AND Year_Publish = @year";
                    command.Parameters.AddWithValue("@author", request.QueryString.Get("author"));
                    command.Parameters.AddWithValue("@year", request.QueryString.Get("year"));
                    MessageBox.Show("1");
                }
                else
                {
                    if (request.QueryString.Get("author") != null)
                    {
                        command.CommandText = "SELECT * FROM dbo.Book_Journal WHERE Book_Author = @author";
                        command.Parameters.AddWithValue("@author", request.QueryString.Get("author"));
                        MessageBox.Show("2");
                    }
                    else
                    {
                        if (request.QueryString.Get("year") != null)
                        {
                            command.CommandText = "SELECT * FROM dbo.Book_Journal WHERE Year_Publish = @year";
                            command.Parameters.AddWithValue("@year", request.QueryString.Get("year"));
                            MessageBox.Show("3");
                        }
                        else
                        {
                            command.CommandText = "SELECT * FROM dbo.Book_Journal";
                            MessageBox.Show("4");
                        }
                    }
                }
                
                List<Book> vector = new List<Book>();
                Registry_Class.sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Book book = new Book();
                    book.title = String.Format("{0}", reader["Book_Author"]);
                    book.year = String.Format("{0}", reader["Year_Publish"]);
                    vector.Add(book);
                }
                Registry_Class.sqlConnection.Close();

                string json_output = JsonConvert.SerializeObject(vector);

                HttpListenerResponse response = context.Response;
                response.ContentType = "application/json";
                // Сборка вывода в формате JSON
                string responseString = json_output;
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                // Get a response stream and write the response to it.
                response.ContentLength64 = buffer.Length;
                System.IO.Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                output.Close();
                //Вопрос Продолжить?
                DialogResult dialogResult = (MessageBox.Show("Продолжать?", MessageUser.TitleApp, MessageBoxButtons.YesNo));
                if (dialogResult == DialogResult.Yes)
                    process = true;
                else process = false;
            }
        }
        public void listenerStop()
        {
            listener.Stop();
        }
    }
}