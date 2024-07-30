using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridViewExample
{
    public partial class XMLExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CityChanged(object sender, EventArgs e)
        {
            DropDownList1.SelectedIndex = -1;
            string city = DropDownList2.SelectedItem.Value;
            if (city != "All")
            {
                XmlDataSource1.XPath = $"/Employees/Employee[@City='{city}']";
            }
            else
            {
                XmlDataSource1.XPath = "/Employees/Employee";
            }
        }

        protected void CountryChanged(object sender, EventArgs e)
        {
            DropDownList2.SelectedIndex = -1;
            string country = DropDownList1.SelectedItem.Value;
            if (country != "All")
            {
                XmlDataSource1.XPath = $"/Employees/Employee[Country='{country}']";
            }
            else
            {
                XmlDataSource1.XPath = "/Employees/Employee";
            }
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            CityChanged(sender, e);
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CountryChanged(sender, e);
        }
    }
}
