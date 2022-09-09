using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class PartHistory
    {
        private int idPart;
        private int series;
        private int lastNameTake;
        private int lastNameSpend;
        private string dateTake;
        private string dateSpend;

        public PartHistory(int idPart, int series, int lastNameTake, int lastNameSpend, string dateTake, string dateSpend)
        {
            this.idPart = idPart;
            this.series = series;
            this.lastNameTake = lastNameTake;
            this.lastNameSpend = lastNameSpend;
            this.dateTake = dateTake;
            this.dateSpend = dateSpend;
        }

        public void AddPartHistoryToDB()
        {
            string query = "INSERT INTO public.parts_issued(id_part_fk, series_of_outputs, person_take_fk, person_spend_fk, date_take, date_spend) VALUES (@IdPart, @Series, @LastNameTake, @LastNameSpend, @DataTake, @DataSpend)";
            NpgsqlCommand cmd = new NpgsqlCommand(query);

            cmd.Parameters.AddWithValue("@IdPart", idPart);
            cmd.Parameters.AddWithValue("@Series", series);
            cmd.Parameters.AddWithValue("@LastNameTake", lastNameTake);
            cmd.Parameters.AddWithValue("@LastNameSpend", lastNameSpend);
            cmd.Parameters.AddWithValue("@DataTake", dateTake);
            cmd.Parameters.AddWithValue("@DataSpend", dateSpend);

            DBSystem.DBSystem.InsertToDB(cmd);
        }
    }
}
