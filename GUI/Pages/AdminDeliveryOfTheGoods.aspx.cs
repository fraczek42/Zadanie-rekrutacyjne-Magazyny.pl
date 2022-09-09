﻿using Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUI.Pages
{
    public partial class AdminDeliveryOfTheGoods : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GvDeliveryOfTheGoods.DataSource = StockStatus.LoadDeliveryOfTheGoods();
            GvDeliveryOfTheGoods.DataBind();
        }

        protected void BtnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/AdminMenuPage.aspx");
        }
    }
}