using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace PPC.admin
{
    public partial class view_student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Count == 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Sorry you cannot view this page. Login to view this page.');window.location='/admin_login.aspx';", true);
            }   
        }

        protected void butnSubmit_Click(object sender, EventArgs e)
        {
            Session["Course"] = "BE";
            Response.Redirect("/admin/student_list.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Course"] = "MCA";
            Response.Redirect("/admin/student_list.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["Course"] = "MBA";
            Response.Redirect("/admin/student_list.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session["Course"] = "MTECH";
            Response.Redirect("/admin/student_list.aspx");
        }
    }
}