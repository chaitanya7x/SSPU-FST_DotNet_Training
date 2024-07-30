using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectWebApplication3
{
    public partial class cookie3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["name"] == null)
            {
                Response.Redirect("cookiesLogin.aspx");
            }
            else
            {
                Label1.Text = Request.Cookies["name"].Value;
            }
        }
    }
}