using System;
using System.Data;
using Npgsql;

namespace DBSystem
{
    public class DBSystem
    {
        public static string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=qazwsxedc;Database=Magazyny";
        public static NpgsqlConnection npgsql = new NpgsqlConnection(connectionString);

        public static DataTable SelectFromDB (DataTable data, NpgsqlCommand command)
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
        public static void InsertToDB (NpgsqlCommand command)
        {
            try
            {
                using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    npgsqlConnection.Open();
                    NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter(command);
                    command.Connection = npgsqlConnection;
                    npgsqlDataAdapter.InsertCommand = command;
                    npgsqlDataAdapter.InsertCommand.ExecuteReader();
                    npgsqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }
        public static void UpdateDB(NpgsqlCommand command)
        {
            try
            {
                using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    npgsqlConnection.Open();
                    NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
                    command.Connection = npgsqlConnection;
                    npgsqlDataAdapter.UpdateCommand = command;
                    npgsqlDataAdapter.UpdateCommand.ExecuteNonQuery();
                    npgsqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }
        public static void DeleteFromDB(NpgsqlCommand command)
        {
            try
            {
                using (NpgsqlConnection npgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    npgsqlConnection.Open();
                    NpgsqlDataAdapter npgsqlDataAdapter = new NpgsqlDataAdapter();
                    command.Connection = npgsqlConnection;
                    npgsqlDataAdapter.DeleteCommand = command;
                    npgsqlDataAdapter.DeleteCommand.ExecuteNonQuery();
                    npgsqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }
    }
}
