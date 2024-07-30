using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionExample
{
    public partial class session_page3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["user"] != null)
            {
                Label1.Text = Session["user"].ToString();
            }
            else
            {
                Response.Redirect("session_page1.aspx");
            }

        }
    }
}