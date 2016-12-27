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
    public partial class create_exam : System.Web.UI.Page
    {
        int count = 1, max = 1, pending = 0;
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
                    Literal3.Text = name.ToUpper();

                    SqlCommand cmdSql1 = new SqlCommand("SELECT NumberOfQuestions FROM tbl_Exam WHERE CompanyID='" + Session["Company_ID"] + "' AND ExamCode='" + Session["Exam_Code"] + "'", conn);
                    SqlDataReader rs;
                    rs = cmdSql1.ExecuteReader();
                    if (rs.Read())
                    {
                        //examCode = rs[0].ToString();
                        max = (int)rs[0];
                    }
                    rs.Close();

                    SqlCommand cmdSql2 = new SqlCommand("SELECT QuestionNumber FROM tbl_Questions WHERE CompanyID='" + Session["Company_ID"] + "' AND ExamCode='" + Session["Exam_Code"] + "'", conn);
                    SqlDataReader rs2;
                    rs2 = cmdSql2.ExecuteReader();
                    while (rs2.Read())
                    {
                        count = (int)rs2[0];
                        count += 1;
                    }
                    rs2.Close();
                    conn.Close();
                    //Response.Write("<script>alert('4')</script>");
                    pending = (max - count);
                    pending += 1;
                    //Response.Write("<script>alert('pending is" + pending + "')</script>");
                    Literal1.Text = count.ToString();
                    Literal2.Text = "Questions Pending is " + pending;
                    if (count > max)
                    {
                        ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Inserted " + max + " questions successfully. To add more increase the Number Of Questions.');window.location='/company/create_editexam.aspx';", true);
                    }
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
                SqlCommand cmdSql = new SqlCommand("INSERT INTO tbl_Questions(CompanyID, ExamCode, QuestionNumber, Question, Option1, Option2, Option3, Option4, Answer) VALUES(@CompanyID, @ExamCode, @QuestionNumber, @Question, @Option1, @Option2, @Option3, @Option4, @Answer)", conn);
                //Response.Write("<script>alert('" + Session["Company_ID"] + Session["Exam_Code"] + count + TextBox6.Text + TextBox1.Text + TextBox2.Text + TextBox3.Text + TextBox4.Text + TextBox5.Text + "')</script>");
                cmdSql.Parameters.AddWithValue("@CompanyID", Session["Company_ID"]);
                cmdSql.Parameters.AddWithValue("@ExamCode", Session["Exam_Code"]);
                cmdSql.Parameters.AddWithValue("@QuestionNumber", count);
                cmdSql.Parameters.AddWithValue("@Question", TextBox6.Text);
                cmdSql.Parameters.AddWithValue("@Option1", TextBox1.Text);
                cmdSql.Parameters.AddWithValue("@Option2", TextBox2.Text);
                cmdSql.Parameters.AddWithValue("@Option3", TextBox3.Text);
                cmdSql.Parameters.AddWithValue("@Option4", TextBox4.Text);
                cmdSql.Parameters.AddWithValue("@Answer", TextBox5.Text);
                cmdSql.ExecuteNonQuery();
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Question " + count + " inserted successfully.');window.location='/company/create_exam.aspx';", true);
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");

            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("/company/create_exam.aspx");
        }
    }
}