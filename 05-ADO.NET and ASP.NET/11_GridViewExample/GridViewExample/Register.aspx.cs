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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rvDateOfBirth.MinimumValue = "1900-01-01";
            rvDateOfBirth.MaximumValue = DateTime.Now.ToString("yyyy-MM-dd");
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Users (Username, UName, Email, Gender, DateOfBirth, ConfirmPassword) VALUES (@Username, @UName, @Email, @Gender, @DateOfBirth, @ConfirmPassword)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@UName", txtUName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Gender", rblGender.SelectedValue);
                    cmd.Parameters.AddWithValue("@DateOfBirth", txtDateOfBirth.Text);
                    cmd.Parameters.AddWithValue("@ConfirmPassword", txtConfirmPassword.Text); 

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            Label1.Text = txtUsername.Text + " Registered Successfully!";
        }
    }
}