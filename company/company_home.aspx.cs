using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace PPC
{
    public partial class company_home : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PPCConnectionString1"].ConnectionString);            
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Count == 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Sorry you cannot view this page. Login to view this page.');window.location='/company_login.aspx';", true);
            }
            else {

                try
                {
                    string name = null;
                    conn.Open();
                    SqlCommand cmdSql = new SqlCommand("SELECT CompanyName FROM tbl_Company WHERE CompanyID='" + Session["Company_ID"] + "' and Email ='" + Session["Email"] + "'", conn);
                    SqlDataReader rs;
                    rs = cmdSql.ExecuteReader();
                    if (rs.Read())
                    {
                        name = rs[0].ToString();
                    }
                    rs.Close();
                    conn.Close();
                    Literal2.Text = name.ToUpper();
                    Literal4.Text = "Current Login Time : " + Session["Login_Time"];

                // *** Read from file ***
                    Server.MapPath("/logs/company"+Session["Company_ID"]+".txt");
                // Specify file, instructions, and privelegdes
                FileStream file = new FileStream(Server.MapPath("/logs/company"+Session["Company_ID"]+".txt"), FileMode.OpenOrCreate, FileAccess.Read);
                if (file.Equals("") || file.Equals("null")) {
                    Literal1.Text = "Welcome for the First Time.";
                }
                // Create a new stream to read from a file
                StreamReader sr = new StreamReader(file);

                // Read contents of file into a string
                string cval = sr.ReadToEnd();
                if (cval.Equals("") || cval.Equals("null"))
                {
                    Literal1.Text = "Welcome for the First Time.";
                }
                else
                {
                    Literal1.Text = "Last Login Activity :" + cval;
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

        protected void btnSubmit_Click9(object sender, EventArgs e)
        {
            Response.Redirect("/company/edit_exam.aspx");
        }

        protected void btnSubmit_Click5(object sender, EventArgs e)
        {
            Response.Redirect("/company/edit_profile.aspx");
        }

        protected void btnSubmit_Click6(object sender, EventArgs e)
        {
            Response.Redirect("/company/add_criteria.aspx");
        }

        protected void btnSubmit_Click7(object sender, EventArgs e)
        {
            Response.Redirect("/company/edit_criteria.aspx");
        }

        protected void btnSubmit_Click8(object sender, EventArgs e)
        {
            Response.Redirect("/company/create_editexam.aspx");
        }
    }
}