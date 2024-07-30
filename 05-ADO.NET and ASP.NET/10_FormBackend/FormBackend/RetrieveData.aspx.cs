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

namespace FormBackend
{
    public partial class RetrieveData : System.Web.UI.Page
    {
        MySqlDataAdapter adapter;
        MySqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindEmployeeGrid();
                BindCustomerGrid();
            }
        }

        private void BindEmployeeGrid()
        {
            MySqlConnection con = new MySqlConnection("Data Source=localhost;Database=db_name;");
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT * FROM Employees1";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
               //DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                //da.Fill(dt);
                da.Fill(ds);
                //gvEmployees.DataSource = dt;
                gvEmployees.DataSource = ds;
                gvEmployees.DataBind();
            }
        }
        private void BindCustomerGrid()
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT * FROM Customers";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvCustomers.DataSource = dt;
                gvCustomers.DataBind();
            }
        }
    }
}