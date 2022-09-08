using Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUI.Pages
{
    public partial class AdminReceiptOfGoods : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GvReceiptOfGoods.DataSource = StockStatus.LoadReceiptOfGoods();
            GvReceiptOfGoods.DataBind();
        }

        protected void BtnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/AdminMenuPage.aspx");
        }
    }
}