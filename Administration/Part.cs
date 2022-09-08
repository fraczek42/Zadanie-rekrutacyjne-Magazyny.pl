using DBSystem;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administration
{
    public class Part
    {
        private string name;
        private string description;

        public Part(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public void AddPartToDB()
        {
            string quaery = "INSERT INTO public.part(name_part, description_part) VALUES (@name, @description)";
            NpgsqlCommand cmd = new NpgsqlCommand(quaery);

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@description", description);

            DBSystem.DBSystem.InsertToDB(cmd);
        }
    }
}
