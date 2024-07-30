using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridViewExample
{
    public partial class UpdateForm : System.Web.UI.Page
    {
        SqlDataAdapter da;
        SqlConnection conn;
        SqlDataReader reader;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();
                    string query = "SELECT EmployeeNumber FROM Employees1";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    reader = cmd.ExecuteReader();
                    ddlEmployeeIds.DataSource = reader;
                    ddlEmployeeIds.DataTextField = "EmployeeNumber";
                    ddlEmployeeIds.DataBind();
                    reader.Close();
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string selectedEmployeeId = ddlEmployeeIds.SelectedItem.Text;
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string sql = "UPDATE Employees1 SET FullName = @FullName, Address = @Address, City = @City, DOB = @DOB WHERE EmployeeNumber = @EmployeeNumber";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@City", txtCity.Text);
                cmd.Parameters.AddWithValue("@DOB", calDOB.SelectedDate);
                cmd.Parameters.AddWithValue("@EmployeeNumber", selectedEmployeeId);
                cmd.ExecuteNonQuery();
            }
        }

        protected void ddlEmployeeIds_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEmployeeId = ddlEmployeeIds.SelectedItem.Text;
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                string query = "SELECT FullName, Address, City, DOB FROM Employees1 WHERE EmployeeNumber = @EmployeeNumber";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmployeeNumber", selectedEmployeeId);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtFullName.Text = reader["FullName"].ToString();
                    txtAddress.Text = reader["Address"].ToString();
                    txtCity.Text = reader["City"].ToString();
                    calDOB.SelectedDate = Convert.ToDateTime(reader["DOB"]);
                }
                reader.Close();
            }
        }
    }
}