using System;
using System.Text;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace MySqlConnectorSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}", 
                "localhost",
                "myapp",
                "tiger",
                "SQLPassword");
  
            Console.WriteLine("Connect to database...");
            MySqlConnection conn = new MySqlConnection(connstring);
            conn.Open();

            conn.Close();
            Console.WriteLine("All done.");
        }
    }
}