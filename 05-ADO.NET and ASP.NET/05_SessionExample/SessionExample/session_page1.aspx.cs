using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionExample
{
    public partial class session_page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        { 
            String a=TextBox1.Text;
            Session["user"] = a;
            Response.Redirect("session_page2.aspx?p=" + TextBox2.Text);
        }
    }
}