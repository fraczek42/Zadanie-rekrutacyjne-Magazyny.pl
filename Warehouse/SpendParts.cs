using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class SpendParts
    {
        public static void SpendPart(int id)
        {
            string query = "DELETE FROM public.stock_status WHERE id_stock_status = @Id";
            NpgsqlCommand cmd = new NpgsqlCommand(query);

            cmd.Parameters.AddWithValue("@Id", id);

            DBSystem.DBSystem.DeleteFromDB(cmd);
        }


    }
}
