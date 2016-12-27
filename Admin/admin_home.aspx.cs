using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace PPC.admin
{
    public partial class admin_home : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PPCConnectionString1"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Count == 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Sorry you cannot view this page. Login to view this page.');window.location='/admin_login.aspx';", true);
            }
            else
            {
                try
                {
                    Literal1.Text = "Current Login Time : " + Session["Login_Time"] ;
                    // *** Read from file ***
                    Server.MapPath("\\logs\\admin.txt");
                    // Specify file, instructions, and privelegdes
                    FileStream file = new FileStream(Server.MapPath("\\logs\\admin.txt"), FileMode.OpenOrCreate, FileAccess.Read);

                    // Create a new stream to read from a file
                    StreamReader sr = new StreamReader(file);

                    // Read contents of file into a string
                    string cval = sr.ReadToEnd();
                    if (cval.Equals("") || cval.Equals("null"))
                    {
                        Literal2.Text = "Welcome for the First Time.";
                    }
                    else
                    {
                        Literal2.Text = "Last Login Activity :" + cval;
                    }
                    // Close StreamReader
                    sr.Close();

                    // Close file
                    file.Close();
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "')</script>");

                }
            }          
        }

        protected void butnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("/admin/change_password.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/admin/view_student.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/admin/view_company.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("/admin/edit_student.aspx");
        }
    }
}