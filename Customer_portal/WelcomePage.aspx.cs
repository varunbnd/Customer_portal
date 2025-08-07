using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Customer_portal
{
    public partial class WelcomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:51766/Cropdistributioncenters/Indexuserlist?class=btn%20btn-success");
        }
        protected void Button2(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:51766/Soiltypetables/Indexuserview");
        }

    }
}