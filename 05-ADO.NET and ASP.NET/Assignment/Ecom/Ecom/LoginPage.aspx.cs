using System;
using System.Web.UI;

namespace Ecom
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string username = Lusername.Text;
            string password = Lpassword.Text;

            string registeredUsername = Session["username"] as string;
            string registeredPassword = Session["password"] as string;

            if (username == registeredUsername && password == registeredPassword)
            {
                Session["username"] = username;
                Response.Redirect("IndexPage.aspx");
            }
            else
            {
                lblMessage.Text = "Invalid username or password";
            }
        }
    }
}