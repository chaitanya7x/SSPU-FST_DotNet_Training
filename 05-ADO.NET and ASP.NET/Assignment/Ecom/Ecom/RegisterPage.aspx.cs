using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecom
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string enteredUsername = username.Text;
                string enteredPassword = password.Text;
                string confirmedPassword = txtConfirmPassword.Text;

                Session["username"] = enteredUsername;
                Session["password"] = enteredPassword;


                Response.Redirect("LoginPage.aspx?p=" + username.Text);
            }
        }

    }
}