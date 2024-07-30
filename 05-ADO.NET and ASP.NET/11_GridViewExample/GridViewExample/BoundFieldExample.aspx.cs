using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridViewExample
{
    public partial class BoundFieldExample : System.Web.UI.Page
    {
        SqlDataAdapter da;
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{

            //}

            FillGridView();
        }
        protected void FillGridView()
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (conn = new SqlConnection(connStr))
            {
                string query = $"SELECT * FROM Employees1";
                da = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
        }
    }
}