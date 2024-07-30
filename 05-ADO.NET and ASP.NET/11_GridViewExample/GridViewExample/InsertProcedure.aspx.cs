using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridViewExample
{
    public partial class InsertProcedure : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
        public void onInsert()
        {
            int custID;
            string spName = "customer_insert";
            string conStr= ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand(spName))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id",TextBox1.Text);
                    cmd.Parameters.AddWithValue("@name",TextBox2.Text);
                    cmd.Parameters.AddWithValue("@id", DropDownList1.SelectedItem.Text);
                    cmd.Connection=conn;
                    conn.Open();
                    cmd.ExecuteScalar();
                    conn.Close();

                }
            }
        }
    }
}