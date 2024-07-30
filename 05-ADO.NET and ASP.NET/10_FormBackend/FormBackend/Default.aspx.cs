using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace FormBackend
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SwitchToEmployee_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void SwitchToCustomer_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void SaveEmployee_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "INSERT INTO Employees1 (EmployeeNumber, FullName, Address, City, DOB) VALUES (@EmpNumber, @FullName, @Address, @City, @DOB)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@EmpNumber", txtEmpNumber.Text);
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@City", txtCity.Text);
                cmd.Parameters.AddWithValue("@DOB", txtDOB.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        protected void SaveCustomer_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "INSERT INTO Customers (CustomerName, Address, City, PostalCode, ContactNumber) VALUES (@CustomerName, @Address, @City, @PostalCode, @ContactNumber)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text);
                cmd.Parameters.AddWithValue("@Address", txtCustomerAddress.Text);
                cmd.Parameters.AddWithValue("@City", txtCustomerCity.Text);
                cmd.Parameters.AddWithValue("@PostalCode", txtPostalCode.Text);
                cmd.Parameters.AddWithValue("@ContactNumber", txtContactNumber.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        protected void Exit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}