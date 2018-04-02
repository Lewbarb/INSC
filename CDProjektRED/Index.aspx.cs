using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CDProjektRED
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            string adminUser = "admin";
            string adminPass = "123456";

            if (UserName.Text == adminUser && Password.Text == adminPass)
            {
                Response.Redirect("~/WebForm2.aspx");
            }
            else
            {
                System.Web.UI.ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "AlertBox", "alert('Login Unsuccessful');", true);
            }


        }
    }
}