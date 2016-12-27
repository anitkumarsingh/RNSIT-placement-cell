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
    public partial class create_editexam : System.Web.UI.Page
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
                    DropDownList2.Items.Clear();
                    
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

                    SqlCommand cmdSql = new SqlCommand("SELECT ExamCode FROM tbl_Exam WHERE CompanyID='"+Session["Company_ID"]+"'", conn);
                    SqlDataReader rs;
                    rs = cmdSql.ExecuteReader();
                    while (rs.Read()) {
                        DropDownList2.Items.Add(rs[0].ToString());
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

        protected void btnSubmit_Click17(object sender, EventArgs e)
        {
            try
            {
                string name = "Error2";
                string id = "Error1";
                
                conn.Open();
                string date = DateTime.Now.Date.ToString("dd/MM/yyyy");
                SqlCommand cmdSql = new SqlCommand("SELECT CompanyID, CompanyName FROM tbl_Company WHERE Email='"+Session["Email"]+"'", conn);
                SqlDataReader rs;
                rs = cmdSql.ExecuteReader();
                if(rs.Read())
                {
                    id = rs[0].ToString();
                    name = rs[1].ToString();
                }
                rs.Close();

                string examCode = null;
                examCode = id+"_"+name + "_" + date;
                Response.Write("<script>alert('Exam created. ExamCode is " + examCode + "')</script>");
                Session["Exam_Code"] = examCode;
                SqlCommand cmdSql1 = new SqlCommand("INSERT INTO tbl_Exam(CompanyID, ExamCode, NumberOfQuestions, Date) VALUES(@CompanyID, @ExamCode, @NumberOfQuestions, @Date)", conn);
                cmdSql1.Parameters.AddWithValue("@CompanyID", id);
                cmdSql1.Parameters.AddWithValue("@ExamCode", examCode);
                cmdSql1.Parameters.AddWithValue("@NumberOfQuestions", TextBox1.Text);
                cmdSql1.Parameters.AddWithValue("@Date", date);
                cmdSql1.ExecuteNonQuery();
                conn.Close();
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Exam Created with code "+examCode+". Click OK to Add Questions.');window.location='/company/create_exam.aspx';", true);
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }         
        }

        protected void btnSubmit_Click18(object sender, EventArgs e)
        {
            Session["Exam_Code"] = DropDownList2.SelectedItem.Text;
            Response.Redirect("/company/create_exam.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["Exam_Code"] = DropDownList2.SelectedItem.Text;
            Response.Redirect("/company/edit_exam.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session["Exam_Code"] = DropDownList2.SelectedItem.Text;
            Response.Redirect("/company/edit_questions.aspx");
        }
    }
}