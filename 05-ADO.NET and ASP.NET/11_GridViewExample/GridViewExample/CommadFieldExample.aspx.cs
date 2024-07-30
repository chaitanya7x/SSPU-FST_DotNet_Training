using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridViewExample
{
    public partial class UPD : System.Web.UI.Page
    {
        SqlDataAdapter da;
        SqlConnection conn;
        string connStr = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillGridView();
            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            FillGridView();
        }

        protected void FillGridView()
        {
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

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            TextBox txtEmpID = (TextBox)row.Cells[2].Controls[0];
            TextBox txtEmployeeNumber = (TextBox)row.Cells[3].Controls[0];
            TextBox txtFullName = (TextBox)row.Cells[4].Controls[0];
            TextBox txtAddress = (TextBox)row.Cells[5].Controls[0];
            TextBox txtCity = (TextBox)row.Cells[6].Controls[0];
            TextBox txtDOB = (TextBox)row.Cells[7].Controls[0];

            string dob = DateTime.Parse(txtDOB.Text).ToString("yyyy-MM-dd");

            string updateQuery = "UPDATE Employees1 SET " +
                                 "EmployeeNumber = '" + txtEmployeeNumber.Text + "', " +
                                 "FullName = '" + txtFullName.Text + "', " +
                                 "Address = '" + txtAddress.Text + "', " +
                                 "City = '" + txtCity.Text + "', " +
                                 "DOB = '" + dob + "' " +
                                 "WHERE EmployeeID = " + txtEmpID.Text;

            using (conn = new SqlConnection(connStr))
            {
                conn.Open();
                cmd = new SqlCommand(updateQuery, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                GridView1.EditIndex = 1;
                FillGridView();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int eid = Convert.ToInt32(GridView1.Rows[e.RowIndex].Cells[2].Text);
            string deletequery = "delete from Employees1 where EmployeeID=" + eid;

            using (conn = new SqlConnection(connStr))
            {
                string query = $"SELECT * FROM Employees1";
                da = new SqlDataAdapter(deletequery, conn);

                cmd = new SqlCommand(deletequery, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                GridView1.EditIndex = -1;
                FillGridView();

            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            FillGridView();
            GridView1.EditIndex = -1;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("CommadFieldExample.aspx");
        }
    }
}