using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PPC.student
{
    public partial class student_home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Count == 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Sorry you cannot view this page. Login to view this page.');window.location='/company_login.aspx';", true);
            }
        }

        protected void butnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("/student/edit_profile.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/student/view_company.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("/student/exam_results.aspx");
        }
       

        protected void Button3_Click(object sender, EventArgs e)
        {
           }
    }
}