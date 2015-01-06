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

        }

        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            // TODO remove data from previous form


            tb_country.Text = String.Empty;
            tb_city.Text = String.Empty;
            tb_street.Text = String.Empty;
            tb_house.Text = String.Empty;
            tb_zip.Text = String.Empty;


            lbl_status.ForeColor = System.Drawing.Color.FromArgb(555555);
            lbl_status.Text = String.Empty;


            Server.Transfer("Emps.aspx", false);
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            Server.Transfer("Add_employee.aspx", true);
        }

        protected void btn_next_Click(object sender, EventArgs e)
        {
            if (tb_country.Text.Equals(String.Empty) || tb_city.Text.Equals(String.Empty)
                || tb_street.Text.Equals(String.Empty) || tb_house.Text.Equals(String.Empty)
                || tb_zip.Text.Equals(String.Empty))
            {
                lbl_status.ForeColor = System.Drawing.Color.DarkRed;
                lbl_status.Text = "Please, fill every field.";
            }
            else if (!Regex.IsMatch(tb_zip.Text, @"[0-9]+"))
            {
                lbl_status.ForeColor = System.Drawing.Color.DarkRed;
                lbl_status.Text = "Field ZipCode must contain only numbers.";
            }
            else
            {
                lbl_status.ForeColor = System.Drawing.Color.FromArgb(555555);
                lbl_status.Text = String.Empty;


                // TODO pass data to next page


                Server.Transfer("Add_phone.aspx", true);
            }
        }
    }
}