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

namespace PPC
{
    public partial class student_register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("/student_register.aspx");
        }

        protected void btnSubmit_Click1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PPCConnectionString1"].ConnectionString);
                conn.Open();
                Response.Write("<script>alert('"+TextBox7.Text+TextBox4.Text+TextBox8.Text+TextBox1.Text+TextBox2.Text+TextBox3.Text+TextBox5.Text+TextBox6.Text+TextBox9.Text+DropDownList2.SelectedValue+"')</script>");
                SqlCommand cmdSql = new SqlCommand("INSERT INTO tbl_Student(USN, Name, Password, Tenth, Twelve, UG, PG, Email, Mobile, Stream) VALUES(@USN, @Name, @Password, @Tenth, @Twelve, @UG, @PG, @Email, @Mobile, @Stream)", conn);
                cmdSql.Parameters.AddWithValue("@USN", TextBox7.Text);
                cmdSql.Parameters.AddWithValue("@Name", TextBox4.Text);
                cmdSql.Parameters.AddWithValue("@Password", TextBox8.Text);
                cmdSql.Parameters.AddWithValue("@Tenth", TextBox1.Text);
                cmdSql.Parameters.AddWithValue("@Twelve", TextBox2.Text);
                cmdSql.Parameters.AddWithValue("@UG", TextBox3.Text);
                cmdSql.Parameters.AddWithValue("@PG", TextBox5.Text);
                cmdSql.Parameters.AddWithValue("@Email", TextBox6.Text);
                cmdSql.Parameters.AddWithValue("@Mobile", TextBox9.Text);
                cmdSql.Parameters.AddWithValue("@Stream", DropDownList2.SelectedItem.Text.ToString());
                cmdSql.ExecuteNonQuery();
                conn.Close();
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Successfully Registered. Going To Login Page.');window.location='/student_login.aspx';", true);
                
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");

            }           
        }
    }
}