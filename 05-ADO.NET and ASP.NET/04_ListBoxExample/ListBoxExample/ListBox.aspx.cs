using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ListBoxExample
{
    public partial class ListBox : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListBox1.Items.Add(new ListItem("Item 1"));
            ListBox1.Items.Add(new ListItem("Item 2"));
            ListBox1.Items.Add(new ListItem("Item 3"));
        }

        protected void btnClickAdd_Click(object sender, EventArgs e)
        {
            foreach(ListItem item in ListBox1.Items)
            {
                if (item.Selected)
                {
                    ListBox2.Items.Add(item);
                    ListBox1.Items.Remove(item);
                }
                
            }
        }
    }
}