using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridViewExample
{
    public partial class gridview : System.Web.UI.Page
    {
        SqlDataAdapter da;
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd;
                String sql = "";
                sql = "INSERT INTO Employees1 (EmployeeNumber, FullName, Address, City, DOB) VALUES (" + Convert.ToInt32(txtEmployeeNumber.Text) + ", '" + txtFullName.Text + "', '" + txtAddress.Text + "', '" + txtCity.Text + "', '" + calDOB.SelectedDate + "')";

                da = new SqlDataAdapter();
                cmd = new SqlCommand(sql, conn);
                da.InsertCommand=new SqlCommand(sql, conn);
                da.InsertCommand.ExecuteNonQuery();

                cmd.Dispose();
                conn.Close();

            }

        }
    }
}