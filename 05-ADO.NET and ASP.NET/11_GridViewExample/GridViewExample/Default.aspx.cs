using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace GridViewExample
{
    public partial class Default : System.Web.UI.Page
    {
        //MySqlDataAdapter adapter;
        //MySqlConnection conn;

        SqlDataAdapter da;
        SqlConnection conn;
        string str= "FullName";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindEmployeeGrid(str);
            }
        }

        private void BindEmployeeGrid(string str)
        {
            //conn = new MySqlConnection("Data Source=localhost;Database=db_name;");
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = $"SELECT * FROM Employees1 order by {str}";
                da = new SqlDataAdapter(query, conn);
                //adapter = new MySqlDataAdapter(query, conn);
                //DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                //da.Fill(dt);
                da.Fill(ds);
                //gvEmployees.DataSource = dt;
                gvEmployees.DataSource = ds;
                gvEmployees.DataBind();
            }
        }

        
        protected void gvEmployees_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvEmployees.PageIndex = e.NewPageIndex;
              BindEmployeeGrid(str);
        }

        protected void gvEmployees_Sorting(object sender, GridViewSortEventArgs e)
        {
            str = e.SortExpression;
            BindEmployeeGrid(str);
        }

        protected void gvEmployees_PageIndexChanged(object sender, EventArgs e)
        {

        }
    }
}