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
    public partial class view_company : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PPCConnectionString1"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["Student_USN"] = "1PI13MCA25";
            if (Session.Count == 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Sorry you cannot view this page. Login to view this page.');window.location='/student_login.aspx';", true);
            }
            else
            {

                try
                {
                    conn.Open();
                    //SqlCommand cmdSqle = new SqlCommand("SELECT ExamCode FROM tbl_Exam WHERE CompanyID IN (SELECT DISTINCT CompanyID FROM tbl_Criteria WHERE DateTime='" + DateTime.Now.Date.ToString("dd-MMM-yy") + "')", conn);
                    SqlCommand cmdSqle = new SqlCommand("SELECT ExamCode FROM tbl_Exam WHERE CompanyID IN (SELECT CompanyID FROM tbl_criteria WHERE DateTime='"+DateTime.Now.Date.ToString("dd/MM/yyyy")+"')",conn);
                    
                    SqlDataReader rse;
                    rse = cmdSqle.ExecuteReader();
                    while (rse.Read())
                    {
                        DropDownList2.Items.Add(rse[0].ToString());
                    }
                    rse.Close();
                    
                    if (!this.IsPostBack)
                    {
                        //Populating a DataTable from database.
                        DataTable dt = this.GetData();

                        //Building an HTML string.
                        StringBuilder html = new StringBuilder();

                        //Table start.
                        html.Append("<table border = '1'>");

                        //Building the Header row.
                        html.Append("<tr>");
                        foreach (DataColumn column in dt.Columns)
                        {
                            html.Append("<th>");
                            html.Append(column.ColumnName);
                            html.Append("</th>");
                        }
                        html.Append("</tr>");

                        //Building the Data rows.
                        foreach (DataRow row in dt.Rows)
                        {
                            html.Append("<tr>");
                            foreach (DataColumn column in dt.Columns)
                            {
                                html.Append("<td>");
                                html.Append(row[column.ColumnName]);
                                html.Append("</td>");
                            }
                            html.Append("</tr>");
                        }

                        //Table end.
                        html.Append("</table>");

                        //Append the HTML string to Placeholder.
                        PlaceHolder1.Controls.Add(new Literal { Text = html.ToString() });
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "')</script>");

                }
            }
        }

        private DataTable GetData()
        {
            //SqlCommand cmd = new SqlCommand("SELECT co.CompanyName, cr.Designation, cr.CTC FROM tbl_Company co, tbl_Criteria cr WHERE cr.CompanyID=co.CompanyID AND cr.CompanyID='"+Session["Company_ID"]+"' AND cr.VisitNumber='"+Session["Visit_Number"]+"'");
            SqlCommand cmd = new SqlCommand("SELECT co.CompanyID, cr.VisitNumber, co.CompanyName, cr.Designation, cr.CTC, cr.DateTime FROM tbl_Company co, tbl_Criteria cr WHERE co.CompanyID=cr.CompanyID AND DateTime>='"+DateTime.Now.Date.ToString("dd/MM/yyyy")+"'");
            SqlDataAdapter sda = new SqlDataAdapter();
            cmd.Connection = conn;
            sda.SelectCommand = cmd;
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            try
            {
                Response.Write("<script>alert('" + DropDownList2.SelectedValue + "')</script>");
                conn.Open();
                SqlCommand cmdSql4 = new SqlCommand("SELECT * FROM tbl_Student_Exam WHERE USN='"+Session["USN"]+"' AND ExamCode='" + DropDownList2.SelectedValue + "'", conn);
                SqlDataReader rs4;
                rs4 = cmdSql4.ExecuteReader();
                if (rs4.Read())
                {
                    rs4.Close();
                    conn.Close();
                    ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Sorry you cannot take test twice. Going to Results Page.');window.location='/student/exam_results.aspx';", true);
                }
                else
                {
                    rs4.Close();
                    conn.Close();
                    Session["Exam_Code"] = DropDownList2.SelectedValue;
                    ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Are you ready to take test?. Click OK to read instructions. ');window.location='/student/exam_instructions.aspx';", true);
                    
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");

            }  
        }
    }
}