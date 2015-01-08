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
			if ((int)Session["Role"] < 0)
				Response.Redirect("Login.aspx");
			else if ((int)Session["Role"] == 10)
				Response.Redirect("Emps.aspx");


			if (Session["empname"] != null)
				tb_emp_name.Text = (string)Session["empname"];

			if (Session["empsurname"] != null)
				tb_emp_surname.Text = (string)Session["empsurname"];

			if (Session["emppersid"] != null)
				tb_emp_pers_id.Text = (string)Session["emppersid"];

			if (Session["empdept"] != null)
				dl_emp_dept.Text = (string)Session["empdept"];

        }


        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            tb_emp_name.Text = String.Empty;
            tb_emp_surname.Text = String.Empty;
            tb_emp_pers_id.Text = String.Empty;
            dl_emp_dept.SelectedValue = "empty";


            lbl_status.Text = String.Empty;


			SessionRemove(
				new string[]{"empname", "empsurname", "emppersid", "empdept",
				"country", "city", "street", "house", "zip", "phone"});


            Response.Redirect("Emps.aspx");
        }


        protected void btn_next_Click(object sender, EventArgs e)
        {
            if (tb_emp_name.Text.Equals(String.Empty) || tb_emp_surname.Text.Equals(String.Empty)
                || tb_emp_pers_id.Text.Equals(String.Empty) || dl_emp_dept.SelectedValue.Equals("empty"))
            {
                lbl_status.Text = "Please, fill every field.";
            }
            else if (!Regex.IsMatch(tb_emp_pers_id.Text, @"[0-9]+"))
                lbl_status.Text = "Field PESEL must contain only numbers.";
            else if (dl_emp_dept.SelectedValue.Equals("empty"))
                lbl_status.Text = "Please, choose a Department.";
            else
            {
                lbl_status.Text = String.Empty;


				Session["empname"] = tb_emp_name.Text;
				Session["empsurname"] = tb_emp_surname.Text;
				Session["emppersid"] = tb_emp_pers_id.Text;
				Session["empdept"] = dl_emp_dept.Text;


                Response.Redirect("Add_address.aspx");
            }
        }


		protected void SessionRemove(string[] args)
		{
			foreach (string s in args)
				if (Session[s] != null)
					Session.Remove(s);
		}
    }
}