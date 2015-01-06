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
            // TODO get username
            // string username;
            //
            // this.lbl_user.Text += username;
        }


        protected void btn_depts_Click(object sender, EventArgs e)
        {
            Server.Transfer("Departments.aspx", false);
        }


        protected void btn_emps_Click(object sender, EventArgs e)
        {
            Server.Transfer("Emps.aspx", false);
        }


        protected void btn_logout_Click(object sender, EventArgs e)
        {
            // TODO logout

            this.lbl_user.Text = "You've logged in as ";

            Server.Transfer("Login.aspx", false);
        }
    }
}