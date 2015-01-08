using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Database
{
    public partial class Phones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
		{
			if ((int)Session["Role"] < 0)
				Response.Redirect("Login.aspx");
			else if ((int)Session["Role"] == 10)
				Response.Redirect("Emps.aspx");


			gv_emp_phones.DataBind();
        }


        protected void btn_emps_Click(object sender, EventArgs e)
        {
            Response.Redirect("Emps.aspx");
        }


        protected void btn_emp_phones_Click(object sender, EventArgs e)
        {
            Response.Redirect("Phones.aspx");
        }


        protected void btn_emp_addr_Click(object sender, EventArgs e)
        {
            Response.Redirect("Addresses.aspx");
        }
    }
}