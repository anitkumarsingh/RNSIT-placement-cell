using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PPC
{
    public partial class login_link : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click15(object sender, EventArgs e)
        {
            Response.Redirect("/company_login.aspx");
        }

        protected void btnSubmit_Click16(object sender, EventArgs e)
        {
            Response.Redirect("/student_login.aspx");
        }
    }
}