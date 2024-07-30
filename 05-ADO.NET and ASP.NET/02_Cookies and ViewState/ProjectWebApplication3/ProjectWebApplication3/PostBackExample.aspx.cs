using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectWebApplication3
{
    public partial class PostBackExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack) { // Validate(); }
            //IsPostBack : tells whether or not the page is on its initial load or 
            //if a user has perform a button on your web page that
            //has caused the page to reload
            if (Page.IsPostBack == false)
            {
                Label1.Text = "First Load";
            }
            else
            {
                Label1.Text = "Re-Loaded Page";
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = "After Submit Click";
        }
    }
}