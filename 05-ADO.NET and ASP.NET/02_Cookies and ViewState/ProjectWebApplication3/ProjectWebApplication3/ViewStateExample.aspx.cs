using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace ProjectWebApplication3
{
    public partial class ViewStateExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            //textbox1 and textbox2 value is assigning on the variable a and b
            //a=textbox1.text
            //b=textbox2.text
            //after clicking on the 
            ViewState["name"] = TextBox1.Text;
            ViewState["password"] = TextBox2.Text;
            //after clicking on button textbox value will be cleared
            TextBox1.Text=TextBox2.Text = string.Empty;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //value of variable a and b is assingning on TextBox1 and Textbox2
            //TextBox1.Text = a;
            //TextBox2.Text = b;

            //If ViewState Value is not Null then
            //Value of View State is Assign to TextBox

            if (ViewState["name"] != null)
            {
                TextBox1.Text = ViewState["name"].ToString();
            }
            if (ViewState["password"] != null)
            {
                TextBox2.Text = ViewState["password"].ToString();
            }
        }
    }
}