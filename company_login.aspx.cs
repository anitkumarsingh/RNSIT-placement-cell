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
    public partial class company_login : System.Web.UI.Page
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
                SqlCommand cmdSql = new SqlCommand("SELECT * FROM tbl_Company WHERE Email='"+TextBox1.Text+"' and Password ='"+TextBox2.Text+"'", conn);
                SqlDataReader rs;
                rs = cmdSql.ExecuteReader();
                if (rs.Read())
                {
                    Session["Company_ID"] = rs[0];
                    Session["Email"] = rs[2].ToString();
                    Session["Login_Time"] = DateTime.Now;
                    Response.Redirect("/company/company_home.aspx");
                }
                else {
                    ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Sorry either E-mail Or Password do not match. Re-enter details.');window.location='/company_login.aspx';", true);
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