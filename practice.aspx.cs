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
using System.IO;

namespace PPC
{
    public partial class practice : System.Web.UI.Page
    {
        int streamCode = 0, flag = 0, visitNumber = 0;
        string companyID = null, stream = null;
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PPCConnectionString1"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                /*ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Password Changed Succesfully.Login with New Password');window.location='/ppc_home.aspx';", true);
                Session["Student_USN"] = "1PI13MCA39";
                conn.Open();
                SqlCommand cmdSql = new SqlCommand("SELECT ExamCode FROM tbl_Exam WHERE CompanyID IN (SELECT DISTINCT CompanyID FROM tbl_Criteria WHERE DateTime='" + DateTime.Now.Date.ToString("MM/dd/yyyy") + "')", conn);
                SqlDataReader rs;
                rs = cmdSql.ExecuteReader();
                if (rs.Read())
                {
                    stream = rs[0].ToString();
                    //streamCode = (int)rs[1];
                }
                rs.Close();
                Literal1.Text = "'" + stream + "'";
                SqlCommand cmdSql1 = new SqlCommand("SELECT CompanyID, VisitNumber FROM tbl_Branch WHERE "+stream+" LIKE 'YES'", conn);
                SqlDataReader rs1;
                
                rs1 = cmdSql1.ExecuteReader();
                
                if (rs1.Read())
                {
                    companyID = rs1[0].ToString();
                    visitNumber = (int)rs1[1];
                    rs1.Close();
                    conn.Close();
                    Literal1.Text = "'" + companyID + visitNumber + "'";
                }
                   
                else
                {
                    rs1.Close();
                    conn.Close();
                    Response.Write("<script>alert('Sorry No Company.')</script>");
                }
                conn.Open();
                SqlCommand cmdSql2 = new SqlCommand("INSERT INTO tbl_Date(Date, Name) VALUES(@Date, @Name)", conn);
                cmdSql2.Parameters.AddWithValue("@Date", DateTime.Now.Date.ToString("dd/MM/yyyy"));
                cmdSql2.Parameters.AddWithValue("@Name", "Gnanendra");
                cmdSql2.ExecuteNonQuery();

                SqlCommand cmdSql3 = new SqlCommand("SELECT Date, Name FROM tbl_Date WHERE Date>'23/12/2015'", conn);
                
                SqlDataReader rs2;
                rs2 = cmdSql3.ExecuteReader();
                while (rs2.Read())
                {
                    Literal1.Text = rs2[0].ToString()+" "+rs2[1].ToString();
                }

                
                conn.Close();
                conn.Open();
                SqlCommand cmdSql = new SqlCommand("SELECT * FROM tbl_Student_Exam WHERE ExamCode='" + DropDownList2.SelectedItem.Text.ToString() + "'", conn);
                SqlDataReader rs;
                rs = cmdSql.ExecuteReader();
                if (rs.Read())
                {
                    rs.Close();
                    ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Sorry you can not take exam twice. Going To Home Page');window.location='/student/student_home.aspx';", true);
                }
                rs.Close();
                Session["Exam_Code"] = DropDownList2.SelectedItem.Text;
                conn.Close();
                Response.Redirect("/student/exam_instructions.aspx");*/
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");
            }
        }
    }
}