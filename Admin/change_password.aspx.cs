using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace PPC.admin
{
    public partial class change_password : System.Web.UI.Page
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
                    conn.Open();
                    SqlCommand cmdSql = new SqlCommand("SELECT * FROM tbl_Admin WHERE Username='" + Session["Admin_Username"] + "' and Password ='" + Session["Admin_Password"] + "'", conn);
                    SqlDataReader rs;
                    rs = cmdSql.ExecuteReader();
                    if (rs.Read())
                    {
                        TextBox1.Text = rs[0].ToString();
                    }
                    conn.Close();

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "')</script>");
                }
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("/admin/admin_home.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (TextBox2.Text.Equals(TextBox3.Text))
                {
                    SqlCommand cmdSql = new SqlCommand("UPDATE tbl_Admin SET Password='" + TextBox3.Text + "' WHERE Username='" + Session["Admin_Username"] + "' and Password ='" + Session["Admin_Password"] + "'", conn);
                    cmdSql.ExecuteNonQuery();
                    Session["Admin_Password"] = TextBox3.Text.ToString();
                    ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Successfuully updated. Re Login.');window.location='/admin_login.aspx';", true);
                }
                else {
                    ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Passwords do not match. Enter correct one.');window.location='/admin/change_password.aspx';", true);
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }  
        }
    }
}