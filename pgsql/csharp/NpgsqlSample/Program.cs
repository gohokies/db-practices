using System;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace NPgsqlSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var dataSourceBuilder = new NpgsqlDataSourceBuilder("Host=localhost;Username=postgres;Password=SQLPassword");
            await using var dataSource = dataSourceBuilder.Build();

            await using var command = dataSource.CreateCommand("SELECT 'Hello World!' AS _message");
            await using var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                Console.WriteLine(reader.GetString(0));
            }            
        }
    }
}