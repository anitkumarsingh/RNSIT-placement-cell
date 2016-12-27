using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace PPC.company
{
    public partial class logout : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PPCConnectionString1"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            try {
            Server.MapPath("/logs/company"+Session["Company_ID"]+".txt");
            FileStream file1 = new FileStream(Server.MapPath("/logs/company"+Session["Company_ID"]+".txt"), FileMode.Create, FileAccess.Write);
            // Create a new stream to write to the file
            StreamWriter sw1 = new StreamWriter(file1);

            // Write a string to the file
            sw1.Write(Session["Login_Time"]);

            // Close StreamWriter
            sw1.Close();

            // Close file
            file1.Close();

            Session.Clear();
            Session.Abandon();
            Response.Redirect("/ppc_home.aspx");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "')</script>");

            } 
        }
    }
}