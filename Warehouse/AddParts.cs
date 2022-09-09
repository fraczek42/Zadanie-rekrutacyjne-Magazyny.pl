using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class AddParts
    {
        private int idPart;
        private int series;
        private int idPerson;
        private string dateTake;

        public AddParts(int idPart, int series, int idPerson, string dateTake)
        {
            this.idPart = idPart;
            this.series = series;
            this.idPerson = idPerson;
            this.dateTake = dateTake;            
        }
        public void AddPartsToDB()
        {
            string query = "INSERT INTO public.stock_status(id_part_fk, series, person_take_fk, date_take) VALUES (@IdPart, @Series, @PersonTake, @DateTake)";
            NpgsqlCommand cmd = new NpgsqlCommand(query);

            cmd.Parameters.AddWithValue("@IdPart", idPart);
            cmd.Parameters.AddWithValue("@Series", series);
            cmd.Parameters.AddWithValue("@PersonTake", idPerson);
            cmd.Parameters.AddWithValue("@DateTake", dateTake);

            DBSystem.DBSystem.InsertToDB(cmd);
        }
    }
}
