using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectWebApplication3
{
    public partial class CookiesLogin2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Request.Cookies["name"].Value;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie nameCookie = Request.Cookies["name"];

            //set the expiry date to pass date
            nameCookie.Expires=DateTime.Now.AddDays(-10);

            //update the cookie in browser
            Response.Cookies.Add(nameCookie);
            Response.Redirect("cookie3.aspx");
        }
    }
}