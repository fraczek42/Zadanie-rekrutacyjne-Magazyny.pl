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

        protected void Btn_AddPartsPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/AddPartPage.aspx");
        }
    }
}