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
    public partial class edit_questions : System.Web.UI.Page
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
                   
                    string count = null;
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
                    Literal3.Text = name.ToUpper();

                    SqlCommand cmdSql = new SqlCommand("SELECT NumberOfQuestions FROM tbl_Exam WHERE CompanyID='" + Session["Company_ID"] + "' AND ExamCode='"+Session["Exam_Code"]+"'", conn);
                    SqlDataReader rs;
                    rs = cmdSql.ExecuteReader();
                    if (rs.Read()) {
                        count = rs[0].ToString();
                    }
                    
                    rs.Close();
                    conn.Close();
                    Literal2.Text = "Previous Set Of Questions is " + count;
                    //Response.Write("<script>alert('" + TextBox1.Text + Session["Company_ID"] + Session["Exam_Code"] + "')</script>");
                }

                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "')</script>");

                }
            }
        }

        protected void butnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PPCConnectionString1"].ConnectionString);
                conn.Open();
                
                SqlCommand cmdSql = new SqlCommand("UPDATE tbl_Exam SET NumberOfQuestions=@NumberOfQuestions WHERE CompanyID='" + Session["Company_ID"] + "' AND ExamCode='" + Session["Exam_Code"] + "'", conn);
                cmdSql.Parameters.AddWithValue("@NumberOfQuestions", TextBox1.Text);
                Response.Write("<script>alert('" + TextBox1.Text + Session["Company_ID"] + Session["Exam_Code"] + "')</script>");
                cmdSql.ExecuteNonQuery();
                conn.Close();
                Response.Write("<script>alert('Updated Succesfully')</script>");
                Response.Redirect("/company/create_editexam.aspx");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");

            }

        }
    }
}