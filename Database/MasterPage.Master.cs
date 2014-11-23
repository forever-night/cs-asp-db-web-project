using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Database
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btn_clear_Click(object sender, EventArgs e)
        {
            this.tb_emp_name.Text = String.Empty;
            this.tb_emp_surname.Text = String.Empty;
            this.tb_emp_personal_id.Text = String.Empty;

            this.dl_dept_id.ClearSelection();

            this.lbl_status.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_status.Text = "form cleared";
        }

        protected void btn_insert_Click(object sender, EventArgs e)
        {
            if (tb_emp_name.Text == String.Empty || tb_emp_surname.Text == String.Empty ||
                tb_emp_personal_id.Text == String.Empty || dl_dept_id.SelectedValue == "empty")
            {
                this.lbl_status.ForeColor = System.Drawing.Color.Crimson;
                this.lbl_status.Text = "every field shoud be filled";
            }
            else
            {
                // insert data

                this.lbl_status.ForeColor = System.Drawing.Color.DarkGreen;
                this.lbl_status.Text = "data inserted";
            }
        }
    }
}