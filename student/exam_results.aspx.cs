using System;
using System.Text;
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
    public partial class exam_results : System.Web.UI.Page
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
                    conn.Open();
                    SqlCommand cmdSqle = new SqlCommand("SELECT ExamCode FROM tbl_Student_Exam WHERE USN='" + Session["Student_USN"] + "'", conn);
                    SqlDataReader rse;
                    rse = cmdSqle.ExecuteReader();
                    while (rse.Read())
                    {
                        DropDownList2.Items.Add(rse[0].ToString());
                    }
                    rse.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "')</script>");

                }
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            try
            {
                double result = 0.0;
                int marksObtained = 0, totalMarks=0;
                Session["Exam_Code"] = DropDownList2.SelectedItem.Text;
                conn.Open();
                SqlCommand cmdSql1 = new SqlCommand("SELECT Marks FROM tbl_Student_Exam WHERE USN='" + Session["Student_USN"] + "'", conn);
                SqlDataReader rs1;
                rs1 = cmdSql1.ExecuteReader();
                while (rs1.Read())
                {
                    marksObtained = (int)rs1[0];
                }
                Literal1.Text = "Your Marks Is " + marksObtained;
                rs1.Close();

                SqlCommand cmdSql2 = new SqlCommand("SELECT NumberOfQuestions FROM tbl_Exam WHERE ExamCode='" + Session["Exam_Code"] + "'", conn);
                SqlDataReader rs2;
                rs2 = cmdSql2.ExecuteReader();
                while (rs2.Read())
                {
                    totalMarks = (int)rs2[0];
                }
                rs2.Close();

                result = (marksObtained * 100) / totalMarks;
                if (result >= 60.0) { 
                    Literal2.Text = "You are Qualified. Contact Placement Office...!!";
                }
                else
                {
                    Literal2.Text = "You are not Qualified. Better Luck Next Time.";
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