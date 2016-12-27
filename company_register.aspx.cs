using System;
using System.IO;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

namespace PPC
{
    public partial class company_register : System.Web.UI.Page
    {
        protected void btnSubmit_Click1(object sender, EventArgs e)
        {
            try
            {
                string fileName = null;
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PPCConnectionString1"].ConnectionString);
                conn.Open();
                SqlCommand cmdSql = new SqlCommand("INSERT INTO tbl_Company(CompanyName, Email, Password, ContactNumber) VALUES(@CompanyName, @Email, @Password, @ContactNumber)", conn);
                cmdSql.Parameters.AddWithValue("@CompanyName", TextBox4.Text);
                cmdSql.Parameters.AddWithValue("@Email", TextBox1.Text);
                cmdSql.Parameters.AddWithValue("@Password", TextBox2.Text);
                cmdSql.Parameters.AddWithValue("@ContactNumber", TextBox3.Text);
                cmdSql.ExecuteNonQuery();

                SqlCommand cmdSql1 = new SqlCommand("SELECT CompanyID FROM tbl_Company WHERE Email='" + TextBox1.Text + "' and Password ='" + TextBox2.Text + "'", conn);
                SqlDataReader rs1;
                rs1 = cmdSql1.ExecuteReader();
                if (rs1.Read())
                {
                    fileName = rs1[0].ToString();
                }
                conn.Close();
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Successfully Registered. Going To Login Page.');window.location='/company_login.aspx';", true);
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
                
            }           
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ppc_home.aspx");
        }

       
    }
}