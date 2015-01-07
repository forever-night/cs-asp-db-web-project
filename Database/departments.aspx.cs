using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Database
{
    public partial class Departments : System.Web.UI.Page
    {		
        protected void Page_Load(object sender, EventArgs e)
        {
			//if ((int)Session["Role"] == -1)
			//	Server.Transfer("Load.aspx");


			gv_depts.DataBind();
        }


        protected void btn_add_dept_Click(object sender, EventArgs e)
        {
            Server.Transfer("Add_department.aspx");
        }
    }
}