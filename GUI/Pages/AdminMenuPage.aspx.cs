using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUI.Pages
{
    public partial class AdminMenuPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAddPartPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/AddPartPage.aspx");
        }

        protected void BtnState_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/AdminStockStatusPage.aspx");
        }

        protected void BtnReceiptOfGoods_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/AdminReceiptOfGoods.aspx");
        }

        protected void BtnDeliveryOfTheGoods_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/AdminDeliveryOfTheGoods.aspx");
        }
    }
}