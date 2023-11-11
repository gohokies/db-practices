using System;
using System.Text;
using System.Data.Odbc;

namespace OdbcPgsqlSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Driver={PostgreSQL ANSI};" + 
                          "Server=localhost;" +
                          "Uid=postgres;" +
                          "Pwd=SQLPassword;";

            OdbcConnection conn = new OdbcConnection(connectionString);
            conn.Open();

            string query = "SELECT 'Hello World!' AS _message";
            OdbcCommand cmd = new OdbcCommand(query, conn);
            OdbcDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader["_message"]);
            }

            reader.Close();
            cmd.Dispose();
            conn.Close();

            Console.WriteLine("All done. Press any key to finish...");
            Console.ReadKey(true);
        }
    }
}