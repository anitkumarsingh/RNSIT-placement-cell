using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace PPC
{
    public partial class admin_login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click4(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PPCConnectionString1"].ConnectionString);
                conn.Open();
                SqlCommand cmdSql = new SqlCommand("SELECT * FROM tbl_Admin WHERE Username='" + TextBox1.Text + "' and Password ='" + TextBox2.Text + "'", conn);
                SqlDataReader rs;
                rs = cmdSql.ExecuteReader();
                if (rs.Read())
                {
                    Session["Admin_Username"] = rs[0].ToString();
                    Session["Admin_Password"] = rs[1].ToString();
                    Session["Login_Time"] = DateTime.Now;
                    Response.Redirect("/admin/admin_home.aspx");
                }
                else {
                    ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Login Error..!!. Re-Enter Username and Password.');window.location='/admin_login.aspx';", true);
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
    }
}