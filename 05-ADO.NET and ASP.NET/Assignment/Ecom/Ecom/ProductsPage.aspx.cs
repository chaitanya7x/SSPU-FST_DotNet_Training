using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecom
{
   
    public partial class Products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("LoginPage.aspx");
        }

        protected void Category_Click(object sender, EventArgs e)
        {
            var button = sender as ImageButton;

            if (button != null)
            {
                switch (button.CommandArgument)
                {
                    case "Grocery":
                        MultiView1.SetActiveView(ViewGrocery);
                        break;
                    case "Mobiles":
                        MultiView1.SetActiveView(ViewMobiles);
                        break;
                    case "Fashion":
                        MultiView1.SetActiveView(ViewFashion);
                        break;
                    case "Electronics":
                        MultiView1.SetActiveView(ViewElectronics);
                        break;
                    case "Home":
                        MultiView1.SetActiveView(ViewHome);
                        break;
                    case "Appliances":
                        MultiView1.SetActiveView(ViewAppliances);
                        break;
                }
            }
        }
        protected void AddToCart_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                string productName = button.Attributes["data-name"];
                string productPriceString = button.Attributes["data-price"];
                double productPrice = double.Parse(productPriceString);

                List<Product> cart;
                if (Session["cart"] == null)
                {
                    cart = new List<Product>();
                }
                else
                {
                    cart = (List<Product>)Session["cart"];
                }

                cart.Add(new Product { ProductDemo = productName, Price = productPrice });
                Session["cart"] = cart;
            }
        }

    }
}