using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankApplicationExample
{
    public partial class BankOperations : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["UserLogin"] != null)
                {
                    lblUsername.Text = Request.Cookies["UserLogin"]["Username"];
                    chkBalance.Text = Request.Cookies["UserLogin"]["value"];
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            if (Request.Cookies["UserLogin"] != null)
            {
                HttpCookie userCookie = new HttpCookie("UserLogin");
                userCookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(userCookie);
            }

            Response.Redirect("mainPage.aspx");
        }

    }
}