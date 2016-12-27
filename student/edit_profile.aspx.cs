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

namespace PPC.student
{
    public partial class edit_profile : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PPCConnectionString1"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Count == 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Sorry you cannot view this page. Login to view this page.');window.location='/student_login.aspx';", true);
            }
            else
            {
                try
                {
                    conn.Open();
                    SqlCommand cmdSql = new SqlCommand("SELECT * FROM tbl_Student WHERE USN='" + Session["Student_USN"] + "'", conn);
                    SqlDataReader rs;
                    rs = cmdSql.ExecuteReader();
                    while (rs.Read())
                    {
                        TextBox7.Text = rs[0].ToString();
                        TextBox4.Text = rs[1].ToString();
                        TextBox8.Text = rs[2].ToString();
                        TextBox1.Text = rs[3].ToString();
                        TextBox2.Text = rs[4].ToString();
                        TextBox3.Text = rs[5].ToString();
                        TextBox5.Text = rs[6].ToString();
                        TextBox6.Text = rs[7].ToString();
                        TextBox9.Text = rs[8].ToString();
                        DropDownList2.Items.Add(rs[9].ToString());
                    }
                    rs.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "')</script>");

                }
            }
        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmdSql = new SqlCommand("UPDATE tbl_Student SET Password=@Password, Email=@Email, Mobile=@Mobile WHERE USN='" + Session["Student_USN"] + "'", conn);
                cmdSql.Parameters.AddWithValue("@Password", TextBox8.Text);
                cmdSql.Parameters.AddWithValue("@Email", TextBox6.Text);
                cmdSql.Parameters.AddWithValue("@Mobile", TextBox9.Text);
                cmdSql.ExecuteNonQuery();
                conn.Close();
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Profile Updated Successfully.');window.location='/student_login.aspx';", true);
                //ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Profile Updated Successfully.');window.location='/student/student_login.aspx';", true);
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");

            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("/student/student_home.aspx");
        }
    }
}