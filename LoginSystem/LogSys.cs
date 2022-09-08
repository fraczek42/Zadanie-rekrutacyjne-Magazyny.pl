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
        public static bool ChceckIfLogged()
        {
            if(!MySession.Current.IsLogged)
                return false;

            return true;
        }

        public static void Login(string username, string password)
        {
            DataTable dt = new DataTable();
            string query = "SELECT data_user.name_user, data_user.position_user, login_user.login_user, login_user.password_user FROM login_user INNER JOIN data_user ON id_user_fk = data_user.id_user WHERE login_user = @username AND password_user = @password";
            NpgsqlCommand cmd = new NpgsqlCommand(query);
            cmd.Parameters.AddWithValue("username", username);
            cmd.Parameters.AddWithValue("password", password);

            DBSystem.DBSystem.SelectFromDB(dt, cmd);

            if (dt.Rows.Count == 0)
                return;
            
            MySession.Current.Login = username;
            MySession.Current.Name = dt.Rows[0]["name_user"].ToString();
            MySession.Current.Position = dt.Rows[0]["position_user"].ToString();
            MySession.Current.IsLogged = true;
        }
    }
}
