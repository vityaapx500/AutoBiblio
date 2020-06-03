using System;
using System.Net;
using System.Data.SqlClient;
using System.Threading;
using System.Data;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Автобиблио
{
    class Server
    {
        //public Thread threadServer = new Thread(ServerActivate);
        private static bool process;
        public class Book
        {
            public string title;
            public string year;
            public string bookAuthor;
            public string Publisher;
        }
        static HttpListener listener;
        public void ServerActivate()
        {

            //Book book = new Book();
            //Book book1 = new Book();
            //book.title = "Война и мир";
            //book.date = "1905";
            //book1.title = "Горе от ума";
            //book1.date = "1890";
            //List<Book> vector = new List<Book>();
            //vector.Add(book);
            //vector.Add(book1);

            //string json_output = JsonConvert.SerializeObject(vector);

            string[] prefixes = { "http://localhost:8086/books/" };
            if (!HttpListener.IsSupported)
            {
                Console.WriteLine("Windows XP SP2 or Server 2003 is required to use the HttpListener class.");
                return;
            }
            // URI prefixes are required,
            // for example "http://contoso.com:8080/index/".
            if (prefixes == null || prefixes.Length == 0)
                throw new ArgumentException("prefixes");

            // Create a listener.
            listener = new HttpListener();
            // Add the prefixes.
            foreach (string s in prefixes)
            {
                listener.Prefixes.Add(s);
            }
            listener.Start();

            process = true;
            while (process)
            {
                    // Note: The GetContext method blocks while waiting for a request.
                    HttpListenerContext context = listener.GetContext();
                HttpListenerRequest request = context.Request;
                //MessageBox.Show(request.QueryString.Get("format"));
                // Obtain a response object.

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
                ////try
                //{
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

                //}
                //catch
                //{

                //}
                //finally
                //{
                Registry_Class.sqlConnection.Close();
                //}

                string json_output = JsonConvert.SerializeObject(vector);

                HttpListenerResponse response = context.Response;
                response.ContentType = "application/json";
                // Construct a response.
                //string responseString = "<HTML><BODY> Hello world!</BODY></HTML>";
                string responseString = json_output;
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                // Get a response stream and write the response to it.
                response.ContentLength64 = buffer.Length;
                System.IO.Stream output = response.OutputStream;
                output.Write(buffer, 0, buffer.Length);
                // You must close the output stream.
                output.Close();
                DialogResult dialogResult = (MessageBox.Show("Продолжать?", MessageUser.TitleApp, MessageBoxButtons.YesNo));
                if (dialogResult == DialogResult.Yes)
                    process = true;
                else process = false;
                //listener.Stop();
            }
        }
        public void listenerStop()
        {
            listener.Stop();
        }
    }
}
