using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration
{
    public class StockStatus
    {
        public static DataTable LoadState()
        {
            DataTable dt = new DataTable();
            string query = "SELECT stock_status.id_stock_status, part.name_part, stock_status.series, stock_status.date_take, data_user.name_user FROM stock_status INNER JOIN part ON part.id_part = stock_status.id_part_fk INNER JOIN data_user ON data_user.id_user = stock_status.person_take_fk";
            NpgsqlCommand cmd = new NpgsqlCommand(query);

            DBSystem.DBSystem.SelectFromDB(dt, cmd);

            return dt;
        }
        public static DataTable LoadReceiptOfGoods()
        {
            DataTable dt = new DataTable();
            string query = "SELECT stock_status.id_stock_status, part.name_part, stock_status.series, stock_status.date_take, data_user.name_user, data_user.last_name_user FROM stock_status INNER JOIN part ON part.id_part = stock_status.id_part_fk INNER JOIN data_user ON data_user.id_user = stock_status.person_take_fk";
            NpgsqlCommand cmd = new NpgsqlCommand(query);

            DBSystem.DBSystem.SelectFromDB(dt, cmd);

            return dt;
        }
        public static DataTable LoadDeliveryOfTheGoods()
        {
            DataTable dt = new DataTable();
            string query = "SELECT parts_issued.id_parts_issued, part.name_part, parts_issued.series_of_outputs, data_user.last_name_user, data_user.last_name_user, parts_issued.date_take, parts_issued.date_spend FROM public.parts_issued INNER JOIN part ON part.id_part = parts_issued.id_part_fk INNER JOIN data_user ON data_user.id_user = parts_issued.person_spend_fk ";
            NpgsqlCommand cmd = new NpgsqlCommand(query);

            DBSystem.DBSystem.SelectFromDB(dt, cmd);

            return dt;
        }

    }
}
