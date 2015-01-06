using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Database
{
    public partial class Add_checking : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            tb_emp_name.Text = String.Empty;
            tb_emp_surname.Text = String.Empty;
            tb_emp_pers_id.Text = String.Empty;
            tb_country.Text = String.Empty;
            tb_city.Text = String.Empty;
            tb_street.Text = String.Empty;
            tb_house.Text = String.Empty;
            tb_zip.Text = String.Empty;
            tb_phone.Text = String.Empty;


            lbl_status.ForeColor = System.Drawing.Color.FromArgb(555555);
            lbl_status.Text = String.Empty;
        }

        protected void btn_finish_Click(object sender, EventArgs e)
        {
            // TODO perform check
            // TODO sql data insert


            lbl_status.ForeColor = System.Drawing.Color.FromArgb(555555);
            lbl_status.Text = String.Empty;


            Server.Transfer("Emps.aspx", false);
        }
    }
}