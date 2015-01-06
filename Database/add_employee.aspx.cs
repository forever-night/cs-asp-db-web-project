using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;


namespace Database
{
    public partial class Add_employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            tb_emp_name.Text = String.Empty;
            tb_emp_surname.Text = String.Empty;
            tb_emp_pers_id.Text = String.Empty;
            dl_emp_dept.SelectedValue = "empty";


            lbl_status.ForeColor = System.Drawing.Color.FromArgb(555555);
            lbl_status.Text = String.Empty;


            Server.Transfer("Emps.aspx", false);
        }

        protected void btn_next_Click(object sender, EventArgs e)
        {
            if (tb_emp_name.Text.Equals(String.Empty) || tb_emp_surname.Text.Equals(String.Empty)
                || tb_emp_pers_id.Text.Equals(String.Empty) || dl_emp_dept.SelectedValue.Equals("empty"))
            {
                lbl_status.ForeColor = System.Drawing.Color.DarkRed;
                lbl_status.Text = "Please, fill every field.";
            }
            else if (!Regex.IsMatch(tb_emp_pers_id.Text, @"[0-9]+"))
            {
                lbl_status.ForeColor = System.Drawing.Color.DarkRed;
                lbl_status.Text = "Field PESEL must contain only numbers.";
            }
            else if (dl_emp_dept.SelectedValue.Equals("empty"))
            {
                lbl_status.ForeColor = System.Drawing.Color.DarkRed;
                lbl_status.Text = "Please, choose a Department.";
            }
            else
            {
                lbl_status.ForeColor = System.Drawing.Color.FromArgb(555555);
                lbl_status.Text = String.Empty;


                // TODO pass data to next page
                //emp_name = tb_emp_name.Text;
                //emp_surname = tb_emp_surname.Text;
                //emp_pers_id = tb_emp_pers_id.Text;
                //emp_dept_value = dl_emp_dept.SelectedValue;


                Server.Transfer("Add_address.aspx", true);
            }
        }
    }
}