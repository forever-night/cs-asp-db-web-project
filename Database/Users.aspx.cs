using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Database
{
	public partial class Users : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if ((int)Session["Role"] != 100)
				Response.Redirect("Main.aspx");


			gv_users.DataBind();
		}

		protected void btn_add_use_Click(object sender, EventArgs e)
		{
			Response.Redirect("Add_user.aspx");
		}
	}
}