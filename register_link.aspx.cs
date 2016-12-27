using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PPC
{
    public partial class register_link : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click13(object sender, EventArgs e)
        {
            Response.Redirect("/company_register.aspx");
        }

        protected void btnSubmit_Click14(object sender, EventArgs e)
        {
            Response.Redirect("/student_register.aspx");
        }
    }
}