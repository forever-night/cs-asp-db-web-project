using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;


namespace Database
{
    public partial class Add_address : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			//if ((int)Session["Role"] == -1)
			//	Server.Transfer("Load.aspx");


			if (Session["country"] != null)
				tb_country.Text = (string)Session["country"];

			if (Session["city"] != null)
				tb_city.Text = (string)Session["city"];

			if (Session["street"] != null)
				tb_street.Text = (string)Session["street"];

			if (Session["house"] != null)
				tb_house.Text = (string)Session["house"];

			if (Session["zip"] != null)
				tb_zip.Text = (string)Session["zip"];
        }


        protected void btn_cancel_Click(object sender, EventArgs e)
        {
			SessionRemove(
				new string[] {"empname", "empsurname", "emppersid", "empdept",
				"country", "city", "street", "house", "zip", "phone"});		


            tb_country.Text = String.Empty;
            tb_city.Text = String.Empty;
            tb_street.Text = String.Empty;
            tb_house.Text = String.Empty;
            tb_zip.Text = String.Empty;


            lbl_status.Text = String.Empty;


            Server.Transfer("Emps.aspx", false);
        }


        protected void btn_back_Click(object sender, EventArgs e)
        {
			SessionRemove(
				new string[]{"country", "city", "street", "house", "zip", "phone"});

            Server.Transfer("Add_employee.aspx", true);
        }


        protected void btn_next_Click(object sender, EventArgs e)
        {
            if (tb_country.Text.Equals(String.Empty) || tb_city.Text.Equals(String.Empty)
                || tb_street.Text.Equals(String.Empty) || tb_house.Text.Equals(String.Empty)
                || tb_zip.Text.Equals(String.Empty))
            {
                lbl_status.Text = "Please, fill every field.";
            }
            else if (!Regex.IsMatch(tb_zip.Text, @"[0-9]+"))
                lbl_status.Text = "Field ZipCode must contain only numbers.";
            else
            {
                lbl_status.Text = String.Empty;


				Session["country"] = tb_country.Text;
				Session["city"] = tb_city.Text;
				Session["street"] = tb_street.Text;
				Session["house"] = tb_house.Text;
				Session["zip"] = tb_zip.Text;


                Server.Transfer("Add_phone.aspx", true);
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