using System;
using System.Collections.Generic;
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
    public partial class student_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSubmit_Click2(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PPCConnectionString1"].ConnectionString);
                conn.Open();
                SqlCommand cmdSql = new SqlCommand("SELECT * FROM tbl_Student WHERE USN='" + TextBox1.Text + "' and Password ='" + TextBox2.Text + "'", conn);
                SqlDataReader rs;
                rs = cmdSql.ExecuteReader();
                if (rs.Read())
                {
                    Session["Student_USN"] = rs[0].ToString();
                    Response.Redirect("/student/student_home.aspx");
                }
                else {
                    ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Sorry either USN Or Password do not match. Re-enter details.');window.location='/student_login.aspx';", true);
                }
                conn.Close();
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Contact Placement Co-Ordinator to know the Password.');window.location='/student_login.aspx';", true);
           
        }
    }
}