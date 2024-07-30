using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Ecom.Products;

namespace Ecom
{
    public partial class CartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
            if (!IsPostBack)
            {
                LoadCartItems();
            }
        }
        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("LoginPage.aspx");
        }
        private void LoadCartItems()
        {
            List<Product> cart = Session["cart"] as List<Product>;

            if (cart != null)
            {
                foreach (var item in cart)
                {
                    lstCartItems.Items.Add(new ListItem($"{item.ProductDemo} - {item.Price}", item.ProductDemo));
                }

                double total = cart.Sum(item => item.Price);
                lblTotal.Text = $"Total: {total}";
            }
        }

    }

}