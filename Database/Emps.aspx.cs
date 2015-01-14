using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


namespace Database
{
    public partial class Emps : System.Web.UI.Page
    {
		string txtSqlConnect = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
	

        protected void Page_Load(object sender, EventArgs e)
        {
			switch ((int)Session["Role"])
			{
				case -1:
					Response.Redirect("Login.aspx");
					break;
				case 10:
					btn_add_emp.Enabled = false;
					btn_add_emp.Visible = false;

					btn_emp_addr.Enabled = false;
					btn_emp_addr.Visible = false;

					btn_emp_phones.Enabled = false;
					btn_emp_phones.Visible = false;

					break;
				case 50:
					btn_add_emp.Enabled = false;
					btn_add_emp.Visible = false;
					break;
			}


			gv_emps.DataBind();
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


        protected void btn_add_emp_Click(object sender, EventArgs e)
        {
            Response.Redirect("Add_employee.aspx");
        }
    }
}