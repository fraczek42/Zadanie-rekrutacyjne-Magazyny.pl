using Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUI.Pages
{
    public partial class AddPart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAddPart_Click(object sender, EventArgs e)
        {
            Part part = new Part(txbName.Text, txbDescription.Text);
            part.AddPartToDB();

            Response.Redirect("~/Pages/AdminMenuPage.aspx");
        }
    }
}