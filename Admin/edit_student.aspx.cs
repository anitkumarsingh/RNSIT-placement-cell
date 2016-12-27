using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace PPC.admin
{
    public partial class edit_student : System.Web.UI.Page
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
                    DropDownList1.Items.Clear();
                    DropDownList2.Items.Clear();
                    conn.Open();
                    SqlCommand cmdSql = new SqlCommand("SELECT USN FROM tbl_Student", conn);
                    SqlDataReader rs;
                    rs = cmdSql.ExecuteReader();
                    while (rs.Read())
                    {
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

        protected void butnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmdSql = new SqlCommand("SELECT * FROM tbl_Student WHERE USN='" + DropDownList2.SelectedItem.Text.ToString() + "'", conn);
                SqlDataReader rs;
                rs = cmdSql.ExecuteReader();
                while (rs.Read())
                {
                    TextBox7.Text = rs[0].ToString();
                    TextBox4.Text = rs[1].ToString();
                    TextBox8.Text = rs[2].ToString();
                    TextBox1.Text = rs[3].ToString();
                    TextBox2.Text = rs[4].ToString();
                    TextBox3.Text = rs[5].ToString();
                    TextBox5.Text = rs[6].ToString();
                    TextBox6.Text = rs[7].ToString();
                    TextBox9.Text = rs[8].ToString();
                    DropDownList1.Items.Add(rs[9].ToString());
                }
                rs.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlCommand cmdSql = new SqlCommand("UPDATE tbl_Student SET USN=@USN, Name=@Name, Password=@Password, Tenth=@Tenth, Twelve=@Twelve, UG=@UG, PG=@PG, Email=@Email, Mobile=@Mobile, Stream=@Stream WHERE USN='" + DropDownList2.SelectedValue + "'", conn);
                cmdSql.Parameters.AddWithValue("@USN", TextBox7.Text);
                cmdSql.Parameters.AddWithValue("@Name", TextBox4.Text);
                cmdSql.Parameters.AddWithValue("@Password", TextBox8.Text);
                cmdSql.Parameters.AddWithValue("@Tenth", TextBox1.Text);
                cmdSql.Parameters.AddWithValue("@Twelve", TextBox2.Text);
                cmdSql.Parameters.AddWithValue("@UG", TextBox3.Text);
                cmdSql.Parameters.AddWithValue("@PG", TextBox5.Text);
                cmdSql.Parameters.AddWithValue("@Email", TextBox6.Text);
                cmdSql.Parameters.AddWithValue("@Mobile", TextBox9.Text);
                cmdSql.Parameters.AddWithValue("@Stream", DropDownList2.SelectedValue);
                cmdSql.ExecuteNonQuery();
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Student Profile Updated Successfully.');window.location='/admin/admin_home.aspx';", true);
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");

            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("/admin/admin_home.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/admin/edit_student.aspx");
        }
    }
}