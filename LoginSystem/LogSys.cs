using DBSystem;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem
{
    public class LogSys
    {
        public static void Login(string username, string password)
        {
            DataTable dt = new DataTable();
            string query = "SELECT login_user, password_user FROM login_user WHERE login_user = @username AND password_user = @password;";
            NpgsqlCommand cmd = new NpgsqlCommand(query);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);

            DBSystem.DBSystem.SelectFromDB(dt, cmd);

            if (dt.Rows.Count == 0)
                return;


        }
    }
}
