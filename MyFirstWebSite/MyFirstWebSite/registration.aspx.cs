using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebSite
{
    public partial class registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //txtFirstName.Text = "Swamy";

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Write(Convert.ToInt32(txtFirstName.Text) + Convert.ToInt32(txtLastName.Text));

        }
    }
}