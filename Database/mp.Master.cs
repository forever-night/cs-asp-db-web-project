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
            // TODO get username
            // string username;
            //
            // this.lbl_user.Text += username;


			// TODO if not logged in redirect to login page
			// Server.Transfer("Login.aspx");
			//if ((int)Session["Role"] == -1)
			//	Server.Transfer("Load.aspx");
        }


        protected void btn_link_main_Click(object sender, EventArgs e)
        {
            Server.Transfer("Main.aspx", false);
        }


        protected void btn_logout_Click(object sender, EventArgs e)
        {
            // TODO logout

            this.lbl_user.Text = "You've logged in as ";

            Server.Transfer("Login.aspx", false);
        }
    }
}