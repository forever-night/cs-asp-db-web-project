using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Database
{
    public partial class mp : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			if ((int)Session["Role"] < 0)
				Response.Redirect("Login.aspx");
			else
				this.lbl_user.Text += (string)Session["User"];
        }


        protected void btn_link_main_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }


        protected void btn_logout_Click(object sender, EventArgs e)
        {
            this.lbl_user.Text = "You've logged in as ";

			Session.Clear();
			Session.Abandon();

            Response.Redirect("Login.aspx");
        }
    }
}