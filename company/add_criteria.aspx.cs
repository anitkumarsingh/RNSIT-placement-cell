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
using System.IO;

namespace PPC.company
{
    
    public partial class add_criteria : System.Web.UI.Page
    {
        int count=0;
        string[] arr4 = new string[11];
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
                    conn.Open();
                    string name = null;
                    
                    SqlCommand cmdSql = new SqlCommand("SELECT CompanyName FROM tbl_Company WHERE CompanyID='" + Session["Company_ID"] + "' and Email ='" + Session["Email"] + "'", conn);
                    SqlDataReader rs;
                    rs = cmdSql.ExecuteReader();
                    if (rs.Read())
                    {
                        name = rs[0].ToString();
                    }
                    rs.Close();


                    SqlCommand cmdSql1 = new SqlCommand("SELECT * FROM tbl_Questions WHERE CompanyID='" + Session["Company_ID"] + "'", conn);
                    SqlDataReader rs1;
                    rs1 = cmdSql1.ExecuteReader();
                    if (rs1.Read())
                    {
                        rs1.Close();
                    }
                    else {
                        rs1.Close();
                        ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('There are no Questions in Company Database. Redirecting to Create Questions.');window.location='/company/create_editexam.aspx';", true);
                    }


                    conn.Close();
                    Literal2.Text = name.ToUpper();
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "')</script>");

                }
            }
        }

        
        protected void btnSubmit_Click11(object sender, EventArgs e)
        {
            string visit="";
            try
            {
                string date = TextBox7.Text;
                DateTime myDate = DateTime.ParseExact(date, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                if (myDate <= DateTime.Today)
                {
                    ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Date must be greater than today's. Re-Enter details.');window.location='/company/add_criteria.aspx';", true);

                }
                else
                {

                    foreach (ListItem listItem in CheckBoxList1.Items)
                    {
                        if (listItem.Selected)
                        {
                            arr4[count++] = "YES";
                        }
                        else
                        {
                            arr4[count++] = "NO";
                        }
                    }
                    foreach (ListItem listItem in CheckBoxList2.Items)
                    {
                        if (listItem.Selected)
                        {
                            arr4[count++] = "YES";
                        }
                        else
                        {
                            arr4[count++] = "NO";
                        }
                    }
                    //Response.Write("<script>alert('" + arr4[0] + arr4[1] + arr4[2] + arr4[3] + arr4[4] + arr4[5] + arr4[6] + arr4[7] + arr4[8] + arr4[9] + "')</script>"); 
                    //Response.Write("<script>alert('"+arr4[0]+"'hi"+arr4[1]+"'hi"+arr4[2]+"'hi"+arr4[3]+"'hi"+arr4[4]+"')</script>"); 
                    //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PPCConnectionString1"].ConnectionString);
                    conn.Open();

                    SqlCommand cmdSql = new SqlCommand("INSERT INTO tbl_Criteria(CompanyID, Designation, Tenth, Twelve, UG, PG, CTC, DateTime) VALUES(@CompanyID, @Designation, @Tenth, @Twelve, @UG, @PG, @CTC, @DateTime)", conn);
                    cmdSql.Parameters.AddWithValue("@CompanyID", Session["Company_ID"]);
                    cmdSql.Parameters.AddWithValue("@Designation", TextBox4.Text);
                    cmdSql.Parameters.AddWithValue("@Tenth", TextBox1.Text);
                    cmdSql.Parameters.AddWithValue("@Twelve", TextBox2.Text);
                    cmdSql.Parameters.AddWithValue("@UG", TextBox3.Text);
                    cmdSql.Parameters.AddWithValue("@PG", TextBox5.Text);
                    cmdSql.Parameters.AddWithValue("@CTC", TextBox6.Text);
                    cmdSql.Parameters.AddWithValue("@DateTime", TextBox7.Text);
                    cmdSql.ExecuteNonQuery();

                    SqlCommand cmdSql1 = new SqlCommand("SELECT max(VisitNumber) FROM tbl_Criteria WHERE CompanyID='" + Session["Company_ID"] + "'", conn);
                    SqlDataReader rs;
                    rs = cmdSql1.ExecuteReader();
                    if (rs.Read())
                    {
                        visit = rs[0].ToString();
                        rs.Close();
                    }
                    SqlCommand cmdSql2 = new SqlCommand("INSERT INTO tbl_Branch(CompanyID, VisitNumber, BE_Civil, BE_Mechanical, BE_Computers, BE_Electronics, PG_MCA, PG_MBA, MTECH_Civil, MTECH_Mechanical, MTECH_Computers, MTECH_Electronics) VALUES(@CompanyID, @VisitNumber, @BE_Civil, @BE_Mechanical, @BE_Computers, @BE_Electronics, @PG_MCA, @PG_MBA, @MTECH_Civil, @MTECH_Mechanical, @MTECH_Computers, @MTECH_Electronics)", conn);
                    cmdSql2.Parameters.AddWithValue("@CompanyID", Session["Company_ID"]);
                    cmdSql2.Parameters.AddWithValue("@VisitNumber", visit);
                    cmdSql2.Parameters.AddWithValue("@BE_Civil", arr4[0]);
                    cmdSql2.Parameters.AddWithValue("@BE_Mechanical", arr4[1]);
                    cmdSql2.Parameters.AddWithValue("@BE_Computers", arr4[2]);
                    cmdSql2.Parameters.AddWithValue("@BE_Electronics", arr4[3]);
                    cmdSql2.Parameters.AddWithValue("@PG_MCA", arr4[4]);
                    cmdSql2.Parameters.AddWithValue("@PG_MBA", arr4[5]);
                    cmdSql2.Parameters.AddWithValue("@MTECH_Civil", arr4[6]);
                    cmdSql2.Parameters.AddWithValue("@MTECH_Mechanical", arr4[7]);
                    cmdSql2.Parameters.AddWithValue("@MTECH_Computers", arr4[8]);
                    cmdSql2.Parameters.AddWithValue("@MTECH_Electronics", arr4[9]);
                    cmdSql2.ExecuteNonQuery();
                    conn.Close();
                    ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Successfully Criteria Added. Going To Home Page.');window.location='/company/company_home.aspx';", true);
                } 
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");

            }           
        }
        protected void btnCancel_Click1(object sender, EventArgs e)
        {
            Response.Redirect("/company/company_home.aspx");
        }
    }
}