using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecom
{
    public partial class IndexPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["username"] != null)
            {
                string username = Session["username"].ToString();
                Label1.Text = "Logged in as: " + username;
            }
            else
            {
                Response.Redirect("LoginPage.aspx");
            }

        }
        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("LoginPage.aspx");
        }   

    }
}