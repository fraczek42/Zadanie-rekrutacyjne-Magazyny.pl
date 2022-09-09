using Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUI.Pages
{
    public partial class AdminStockStatusPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GvStockStatus.DataSource = StockStatus.LoadState();
                GvStockStatus.DataBind();
            }
        }

        protected void BtnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/AdminMenuPage.aspx");
        }
    }
}