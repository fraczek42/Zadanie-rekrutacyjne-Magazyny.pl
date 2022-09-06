using System;
using System.Data;
using Npgsql;

namespace DBSystem
{
    public class DBSystem
    {
        public static string connectionString = "Host=localhost;Username=postgrsql;Password=qazwsxedc;Database=Magazyny";
        public static NpgsqlConnection npgsql = new NpgsqlConnection(connectionString);

        public DataTable SelectFromDB (DataTable data, NpgsqlCommand command)
        {
            try
            {
                using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    npgsqlConnection.Open();
                    command.Connection = npgsqlConnection;
                    NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(command);
                    command.ExecuteScalar();
                    npgsqlDataAdapter.Fill(data);
                    return data;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
