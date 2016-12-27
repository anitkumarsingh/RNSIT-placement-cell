using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace PPC.admin
{
    public partial class admin_logout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FileStream file1 = new FileStream(Server.MapPath("\\logs\\admin.txt"), FileMode.Create, FileAccess.Write);
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
    }
}