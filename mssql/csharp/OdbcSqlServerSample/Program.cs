using System;
using System.Text;
using System.Data.Odbc;

namespace OdbcSqlServerSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Driver={SQL Server};" + 
                          "Server=localhost;" +
                          "Database=master;" +
                          "Uid=sa;" +
                          "Pwd=SQLPassword!0;";

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