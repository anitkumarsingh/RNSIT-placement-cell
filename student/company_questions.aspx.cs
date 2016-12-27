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

namespace PPC.student
{
    public partial class company_questions : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PPCConnectionString1"].ConnectionString);
        static int num = 1, marks=0, questions=0;
        string answer = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Count == 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Sorry you cannot view this page. Login to view this page.');window.location='/student_login.aspx';", true);
            }
            else {
                try
                {
                    conn.Open();
                    SqlCommand cmdSqlq = new SqlCommand("SELECT NumberOfQuestions FROM tbl_Exam WHERE ExamCode='" + Session["Exam_Code"] + "'", conn);
                    SqlDataReader rsq;
                    rsq = cmdSqlq.ExecuteReader();

                    if (rsq.Read()) {
                        questions = (int)rsq[0];
                        
                    }
                    rsq.Close();

                    SqlCommand cmdSql = new SqlCommand("SELECT * FROM tbl_Student_Exam WHERE USN='" + Session["Student_USN"] + "' AND ExamCode='"+Session["Exam_Code"]+"'", conn);
                    SqlDataReader rs;
                    rs = cmdSql.ExecuteReader();
                    if (rs.Read()) {
                        num = (int)rs[6];
                        num += 1;
                        //Response.Write("<script>alert('" + num + "')</script>");
                    }
                    rs.Close();

                    if (num > questions) {
                        ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('You have completed your exam. Going to view your results.');window.location='/student/exam_results.aspx';", true);
           
                    }
                    SqlCommand cmdSql1 = new SqlCommand("SELECT * FROM tbl_Questions WHERE QuestionNumber='" + num + "'", conn);
                    SqlDataReader rs1;
                    rs1 = cmdSql1.ExecuteReader();
                    if (rs1.Read())
                    {
                        TextBox7.Text = rs1[2].ToString();
                        TextBox6.Text = rs1[3].ToString();
                        RadioButtonList1.Items[0].Text = rs1[4].ToString();
                        RadioButtonList1.Items[1].Text = rs1[5].ToString();
                        RadioButtonList1.Items[2].Text = rs1[6].ToString();
                        RadioButtonList1.Items[3].Text = rs1[7].ToString();
                        answer = rs1[8].ToString();
                        rs1.Close();
                    }
                    else {
                        rs1.Close();
                        conn.Close();
                        ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Sorry there are no further questions in Database. Quit the Test. ');window.location='/student/view_exam.aspx';", true);
                    }
                    
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.StackTrace + "')</script>");

                }
            }
        }

        protected void btnSubmit_Click19(object sender, EventArgs e)
        {
            try
            {
                string sname = null, cname = null, rid=null;
                int cid = 0;
                //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PPCConnectionString1"].ConnectionString);
                conn.Open();
                SqlCommand cmdSqlq = new SqlCommand("SELECT Name FROM tbl_Student WHERE USN='" + Session["Student_USN"] + "'", conn);
                SqlDataReader rsq;
                rsq = cmdSqlq.ExecuteReader();
                if (rsq.Read())
                {
                    sname = rsq[0].ToString();
                }
                rsq.Close();

                SqlCommand cmdSqlc = new SqlCommand("SELECT CompanyID, CompanyName FROM tbl_Company WHERE CompanyID IN (SELECT CompanyID FROM tbl_Exam WHERE ExamCode='" + Session["Exam_Code"] + "')", conn);
                SqlDataReader rsc;
                rsc = cmdSqlc.ExecuteReader();
                if (rsc.Read())
                {
                    cid = (int)rsc[0];
                    cname = rsc[1].ToString();
                    
                }
                rsc.Close();

                rid=RadioButtonList1.SelectedValue;
                if(answer.Equals(rid )){
                    marks += 1;
                }

                if (num == 1)
                {
                    SqlCommand cmdSql = new SqlCommand("INSERT INTO tbl_Student_Exam(USN, Name, CompanyID, CompanyName, ExamCode, Marks, Questions) VALUES(@USN, @Name, @CompanyID, @CompanyName, @ExamCode, @Marks, @Questions)", conn);
                    cmdSql.Parameters.AddWithValue("@USN", Session["Student_USN"]);
                    cmdSql.Parameters.AddWithValue("@Name", sname);
                    cmdSql.Parameters.AddWithValue("@CompanyID", cid);
                    cmdSql.Parameters.AddWithValue("@CompanyName", cname);
                    cmdSql.Parameters.AddWithValue("@ExamCode", Session["Exam_Code"]);
                    cmdSql.Parameters.AddWithValue("@Marks", marks);
                    cmdSql.Parameters.AddWithValue("@Questions", num);
                    cmdSql.ExecuteNonQuery();
                    Response.Redirect("/student/company_questions.aspx");
                }
                else {
                    SqlCommand cmdSql = new SqlCommand("UPDATE tbl_Student_Exam SET Marks=@Marks, Questions=@Questions WHERE USN=@USN", conn);
                    cmdSql.Parameters.AddWithValue("@Marks", marks);
                    cmdSql.Parameters.AddWithValue("@Questions", num);
                    cmdSql.Parameters.AddWithValue("@USN", Session["Student_USN"]);
                    cmdSql.ExecuteNonQuery();
                    Response.Redirect("/student/company_questions.aspx");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.StackTrace + "')</script>");
            }
        }
    }
}