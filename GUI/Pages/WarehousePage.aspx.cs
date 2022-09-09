using System;
using System.Collections.Generic;
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
        }

        protected void GvWarehouse_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }
    }
}