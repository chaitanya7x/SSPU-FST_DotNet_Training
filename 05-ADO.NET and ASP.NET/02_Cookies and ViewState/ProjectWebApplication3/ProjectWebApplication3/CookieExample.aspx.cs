using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectWebApplication3
{
    public partial class CookieExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie myCookie = new HttpCookie("name");

            //set the cookie value
            myCookie.Values["name"] = TextBox1.Text;

            //set the expiry date
            myCookie.Expires=DateTime.Now.AddDays(30);

            //add the cookie to the brrowser
            Response.Cookies.Add(myCookie);
            Response.Redirect("CookiesLogin2.aspx");

        }
    }
}