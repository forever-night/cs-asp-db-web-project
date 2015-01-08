using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;


namespace Database
{
    public partial class Add_phone : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			if ((int)Session["Role"] < 0)
				Response.Redirect("Login.aspx");
			else if ((int)Session["Role"] == 10)
				Response.Redirect("Emps.aspx");
        }


        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            tb_phone.Text = String.Empty;
            lbl_status.Text = String.Empty;


			SessionRemove(
				new string[] {"empname", "empsurname", "emppersid", "empdept",
					"country", "city", "street", "house", "zip", "phone"});


            Response.Redirect("Emps.aspx");
        }


        protected void btn_back_Click(object sender, EventArgs e)
        {
			Session.Remove("phone");

            Response.Redirect("Add_address.aspx");
        }


        protected void btn_next_Click(object sender, EventArgs e)
        {
            if (tb_phone.Text.Equals(String.Empty))
                lbl_status.Text = "Please, fill the field.";
            else if (!Regex.IsMatch(tb_phone.Text, @"[0-9]+"))
                lbl_status.Text = "Field must contain only numbers.";
            else
            {
                lbl_status.Text = String.Empty;


				Session["phone"] = tb_phone.Text;


                Response.Redirect("Add_checking.aspx");
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