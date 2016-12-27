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

namespace PPC.company
{
                    
    public partial class edit_profile : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PPCConnectionString1"].ConnectionString);
    
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Count == 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Sorry you cannot view this page. Login to view this page.');window.location='/company_login.aspx';", true);
            }
            else
            {

                try
                {
                    string name = null;
                    conn.Open();
                    SqlCommand cmdSql4 = new SqlCommand("SELECT CompanyName FROM tbl_Company WHERE CompanyID='" + Session["Company_ID"] + "' and Email ='" + Session["Email"] + "'", conn);
                    SqlDataReader rs4;
                    rs4 = cmdSql4.ExecuteReader();
                    if (rs4.Read())
                    {
                        name = rs4[0].ToString();
                    }
                    rs4.Close();
                    Literal2.Text = name.ToUpper();

                    SqlCommand cmdSql = new SqlCommand("SELECT * FROM tbl_Company WHERE CompanyID='" + Session["Company_ID"] + "'", conn);
                    SqlDataReader rs;
                    rs = cmdSql.ExecuteReader();
                    while (rs.Read())
                    {
                        TextBox4.Text = rs[1].ToString();
                        TextBox1.Text = rs[2].ToString();
                        TextBox3.Text = rs[4].ToString();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "')</script>");

                }
            }
        }

        protected void btnSubmit_Click10(object sender, System.EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PPCConnectionString1"].ConnectionString);
                    conn.Open();
                    SqlCommand cmdSql = new SqlCommand("UPDATE tbl_Company SET Password='" + TextBox5.Text + "' WHERE CompanyID='" + Session["Company_ID"] + "'", conn);
                    cmdSql.ExecuteNonQuery();
                    conn.Close();
                    Session.Clear();
                    Session.Abandon();
                    ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Updated Successfully. Going To Login Page.');window.location='/company_login.aspx';", true);
               
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");

            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("/company/company_home.aspx");
        }
    }
}