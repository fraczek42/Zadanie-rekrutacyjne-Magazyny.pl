using LoginSystem;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUI.Pages
{
    public partial class LoginPages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_login_Click(object sender, EventArgs e)
        {
            LogSys.Login(Txb_login.Text, Txb_pass.Text);

            if (LogSys.ChceckIfLogged())
            {
                switch (MySession.Current.Position)
                {
                    case "admin":
                        Response.Redirect("~/Pages/AdminMenuPage.aspx");
                        break;
                    case "magazynier":
                        Response.Redirect("~/Pages/WarehousePage.aspx");
                        break;
                }
            }
        }
    }
}