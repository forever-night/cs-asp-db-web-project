using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Database
{
    public partial class Add_department : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            tb_dept_name.Text = String.Empty;

            Server.Transfer("Departments.aspx", false);
        }

        protected void btn_finish_Click(object sender, EventArgs e)
        {
            // TODO sql insert


            Server.Transfer("Departments.aspx", false);
        }
    }
}