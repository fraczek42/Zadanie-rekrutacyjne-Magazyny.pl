using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Warehouse;

namespace GUI.Pages
{
    public partial class WarehousePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            GvWarehouse.DataSource = State.LoadState();
            GvWarehouse.DataBind();

            if (!IsPostBack)
            {
                DdlParts.DataSource = State.LoadParts();
                DdlParts.DataValueField = "id_part";
                DdlParts.DataTextField = "name_part";
                DdlParts.DataBind();
            }
            
        }

        protected void GvWarehouse_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "spend")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GvWarehouse.Rows[index];
                int id = Convert.ToInt32(row.Cells[0].Text);

                int id_part = State.GetIdPart(row.Cells[1].Text);
                int series = Convert.ToInt32(TxbSeriesOut.Text);
                int lastNameTake = State.GetIdUser(row.Cells[5].Text);
                int lastNameSpend = Convert.ToInt32(State.GetIdUserByName(LoginSystem.MySession.Current.Name.ToString()));
                DateTime dateResult;              
                bool date = DateTime.TryParseExact(row.Cells[3].Text,"dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateResult);
                string dateTake = dateResult.ToString("yyyy-MM-dd");
                string dateSpend = DateTime.Now.ToString("yyyy-MM-dd");

                PartHistory partHistory = new PartHistory(id_part, series, lastNameTake, lastNameSpend, dateTake, dateSpend);
                partHistory.AddPartHistoryToDB();

                SpendParts.SpendPart(id);

                GvWarehouse.DataSource = State.LoadState();
                GvWarehouse.DataBind();
            }
        }

        protected void BtnAddPart_Click(object sender, EventArgs e)
        {
            int idPart = Convert.ToInt32(DdlParts.SelectedValue);
            int series = Convert.ToInt32(TxbSeries.Text);
            int idPerson = Convert.ToInt32(State.GetIdUserByName(LoginSystem.MySession.Current.Name.ToString()));
            string dateTake = DateTime.Now.ToString("yyyy-MM-dd");

            AddParts addParts = new AddParts(idPart, series, idPerson, dateTake);
            addParts.AddPartsToDB();

            GvWarehouse.DataSource = State.LoadState();
            GvWarehouse.DataBind();
        }
    }
}