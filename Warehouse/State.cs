using DBSystem;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class State
    {
        public static DataTable LoadState()
        {
            DataTable dt = new DataTable();
            string query = "SELECT stock_status.id_stock_status, part.name_part, stock_status.series, stock_status.date_take, data_user.name_user, data_user.last_name_user FROM stock_status INNER JOIN part ON part.id_part = stock_status.id_part_fk INNER JOIN data_user ON data_user.id_user = stock_status.person_take_fk";
            NpgsqlCommand cmd = new NpgsqlCommand(query);

            DBSystem.DBSystem.SelectFromDB(dt, cmd);

            return dt;
        }
        public static int GetIdUser(string lastName)
        {
            DataTable dt = new DataTable();
            string query = "SELECT id_user FROM data_user WHERE last_name_user = @LastName";
            NpgsqlCommand cmd = new NpgsqlCommand(query);
            cmd.Parameters.AddWithValue("@LastName", lastName);

            DBSystem.DBSystem.SelectFromDB(dt, cmd);

            return (int)dt.Rows[0][0];
        }
        public static int GetIdUserByName(string name)
        {
            DataTable dt = new DataTable();
            string query = "SELECT id_user FROM data_user WHERE name_user = @Name";
            NpgsqlCommand cmd = new NpgsqlCommand(query);
            cmd.Parameters.AddWithValue("@Name", name);

            DBSystem.DBSystem.SelectFromDB(dt, cmd);

            return (int)dt.Rows[0][0];
        }
        public static int GetIdPart(string namePart)
        {
            DataTable dt = new DataTable();
            string query = "SELECT id_part FROM part WHERE name_part = @NamePart";
            NpgsqlCommand cmd = new NpgsqlCommand(query);
            cmd.Parameters.AddWithValue("@NamePart", namePart);

            DBSystem.DBSystem.SelectFromDB(dt, cmd);

            return (int)dt.Rows[0][0];
        }
    }
}
