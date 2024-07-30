using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankApplicationExample
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ViewState["Username"] != null && ViewState["Password"] != null)
                {
                    txtUsername.Text = ViewState["Username"].ToString();
                    txtPassword.Text = ViewState["Password"].ToString();
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            HttpCookie userCookie = new HttpCookie("UserLogin");
            userCookie.Values["Username"] = txtUsername.Text;
            userCookie.Values["Password"] = txtPassword.Text;
            userCookie.Values["value"] = "20000";

            userCookie.Expires = DateTime.Now.AddMinutes(30); 

            Response.Cookies.Add(userCookie);

            Response.Redirect("BankOperations.aspx");
        }
    }
}