using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace PPC.admin
{
    public partial class view_company : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Count == 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "alert", "alert('Sorry you cannot view this page. Login to view this page.');window.location='/admin_login.aspx';", true);
            }
            else
            {
                try
                {
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "')</script>");

                }
            } 
        }
    }
}