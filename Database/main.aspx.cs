using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Database
{
    public partial class MainPg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			switch ((int)Session["Role"])
			{
				case -1:
					Response.Redirect("Login.aspx");
					break;
				case 10:
					this.lbl_user.Text += (string)Session["User"];
					btn_depts.Enabled = false;
					btn_depts.Visible = false;

					btn_users.Enabled = false;
					btn_users.Visible = false;
					break;
				case 50:
					this.lbl_user.Text += (string)Session["User"];
					btn_users.Enabled = false;
					btn_users.Visible = false;
					break;
				case 100:
					this.lbl_user.Text += (string)Session["User"];
					break;
			}		
        }


        protected void btn_depts_Click(object sender, EventArgs e)
        {
            Response.Redirect("Departments.aspx");
        }


        protected void btn_emps_Click(object sender, EventArgs e)
        {
            Response.Redirect("Emps.aspx");
        }


        protected void btn_logout_Click(object sender, EventArgs e)
        {
            this.lbl_user.Text = "You've logged in as ";

			Session.Abandon();
			Session.Clear();

            Response.Redirect("Login.aspx");
        }

		protected void btn_users_Click(object sender, EventArgs e)
		{
			Response.Redirect("Users.aspx");
		}
    }
}