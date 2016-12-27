using System;
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
    public partial class edit_exam : System.Web.UI.Page
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
                    conn.Close();
                }
                catch (Exception ex) {
                    Response.Write("<script>alert('" + ex.Message + "')</script>");
                 }
            }
        }

        protected void btnSubmit_Click19(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmdSql1 = new SqlCommand("SELECT * FROM tbl_Questions WHERE QuestionNumber='" +TextBox7.Text + "' AND CompanyID='"+Session["Company_ID"]+"' AND ExamCode='"+Session["Exam_Code"]+"'", conn);
                SqlDataReader rs;
                rs = cmdSql1.ExecuteReader();
                if (rs.Read())
                {
                    TextBox7.Text = rs[2].ToString();
                    TextBox6.Text = rs[3].ToString();
                    TextBox1.Text = rs[4].ToString();
                    TextBox2.Text = rs[5].ToString();
                    TextBox3.Text = rs[6].ToString();
                    TextBox4.Text = rs[7].ToString();
                    TextBox5.Text = rs[8].ToString();
                }
                else
                {
                    ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Sorry there is no Question "+TextBox7.Text+" in DataBase. Go to Create Exam to Add Questions.');window.location='/company/edit_exam.aspx';", true);
                }
                rs.Close();
                TextBox7.ReadOnly = true;
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");

            }            
        }

        protected void btnCancel_Click20(object sender, EventArgs e)
        {
            Response.Redirect("/company/edit_exam.aspx");
        }

        protected void btnCancel_Click21(object sender, EventArgs e)
        {
            try
            {
                    //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PPCConnectionString1"].ConnectionString);
                    conn.Open();
                    SqlCommand cmdSql = new SqlCommand("UPDATE tbl_Questions SET Question=@Question, Option1=@Option1, Option2=@Option2, Option3=@Option3, Option4=@Option4, Answer=@Answer WHERE CompanyID='" + Session["Company_ID"] + "' AND ExamCode='"+Session["Exam_Code"]+"' AND QuestionNumber='"+TextBox7.Text+"'", conn);
                    cmdSql.Parameters.AddWithValue("@Question", TextBox6.Text);
                    cmdSql.Parameters.AddWithValue("@Option1", TextBox1.Text);
                    cmdSql.Parameters.AddWithValue("@Option2", TextBox2.Text);
                    cmdSql.Parameters.AddWithValue("@Option3", TextBox3.Text);
                    cmdSql.Parameters.AddWithValue("@Option4", TextBox4.Text);
                    cmdSql.Parameters.AddWithValue("@Answer", TextBox5.Text);
                    cmdSql.ExecuteNonQuery();
                    conn.Close();
                    ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Updated Question " + TextBox7.Text + " successfully.');window.location='/company/edit_exam.aspx';", true);
                
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");

            }
        }
    }
}