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
    public partial class edit_criteria : System.Web.UI.Page
    {
        int count = 0;
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

                    SqlCommand cmdSql1 = new SqlCommand("SELECT * FROM tbl_Criteria WHERE CompanyID='" + Session["Company_ID"] + "' AND VisitNumber IN (SELECT max(VisitNumber) FROM tbl_Criteria WHERE CompanyID='" + Session["Company_ID"] + "')", conn);
                    SqlDataReader rs;
                    rs = cmdSql1.ExecuteReader();
                    if (rs.Read())
                    {
                        TextBox4.Text = rs[2].ToString();
                        TextBox1.Text = rs[3].ToString();
                        TextBox2.Text = rs[4].ToString();
                        TextBox3.Text = rs[5].ToString();
                        TextBox5.Text = rs[6].ToString();
                        TextBox6.Text = rs[7].ToString();
                        TextBox7.Text = rs[8].ToString();
                        rs.Close();


                        SqlCommand cmdSql2 = new SqlCommand("SELECT * FROM tbl_Branch WHERE CompanyID='" + Session["Company_ID"] + "' AND VisitNumber IN (SELECT max(VisitNumber) FROM tbl_Criteria WHERE CompanyID='" + Session["Company_ID"] + "')", conn);
                        SqlDataReader rs1;
                        rs1 = cmdSql2.ExecuteReader();
                        if (rs1.Read())
                        {
                            int j;
                            for (int i = 2; i < 6; i++)
                            {
                                if (rs1[i].ToString().Equals("YES"))
                                {
                                    j = i - 2;
                                    CheckBoxList1.Items[j].Selected = true;
                                }
                                else
                                {
                                    j = i - 2;
                                    CheckBoxList1.Items[j].Selected = false;
                                }
                            }
                            for (int i = 6; i < 12; i++)
                            {
                                if (rs1[i].ToString().Equals("YES"))
                                {
                                    j = i - 6;
                                    CheckBoxList2.Items[j].Selected = true;
                                }
                                else
                                {
                                    j = i - 6;
                                    CheckBoxList2.Items[j].Selected = false;
                                }
                            }
                        }
                        rs1.Close();
                    }
                    else {
                        ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('There are no criteria. Go to Add Criteria.');window.location='/company/add_criteria.aspx';", true);
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "')</script>");
                }
            }
        }

        protected void btnSubmit_Click12(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PPCConnectionString1"].ConnectionString);
                conn.Open();


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

                SqlCommand cmdSql = new SqlCommand("UPDATE tbl_Criteria SET Tenth=@Tenth, Twelve=@Twelve, UG=@UG, PG=@PG, DateTime=@DateTime WHERE CompanyID='" + Session["Company_ID"] + "' AND VisitNumber IN (SELECT max(VisitNumber) FROM tbl_Criteria WHERE CompanyID='" + Session["Company_ID"] + "')", conn);
                cmdSql.Parameters.AddWithValue("@Tenth", TextBox1.Text);
                cmdSql.Parameters.AddWithValue("@Twelve", TextBox2.Text);
                cmdSql.Parameters.AddWithValue("@UG", TextBox3.Text);
                cmdSql.Parameters.AddWithValue("@PG", TextBox5.Text);
                cmdSql.Parameters.AddWithValue("@DateTime", TextBox7.Text);
                cmdSql.ExecuteNonQuery();
                Response.Write("<script>alert('Successfully Updated')</script>");

                SqlCommand cmdSql2 = new SqlCommand("UPDATE tbl_Branch SET BE_Civil=@BE_Civil, BE_Mechanical=@BE_Mechanical, BE_Computers=@BE_Computers, BE_Electronics=@BE_Electronics, PG_MCA=@PG_MCA, PG_MBA=@PG_MBA, MTECH_Civil=@MTECH_Civil, MTECH_Mechanical=@MTECH_Mechanical, MTECH_Computers=@MTECH_Computers, MTECH_Electronics=@MTECH_Electronics WHERE CompanyID='" + Session["Company_ID"] + "' AND VisitNumber IN (SELECT max(VisitNumber) FROM tbl_Criteria WHERE CompanyID='" + Session["Company_ID"] + "')", conn);
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
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Successfully Criteria Updated. Going To Home Page.');window.location='/company/company_home.aspx';", true);
               
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");

            }         
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("/company/company_home.aspx");
        }
    }
}