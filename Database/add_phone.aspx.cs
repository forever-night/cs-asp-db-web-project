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

        }


        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            tb_phone.Text = String.Empty;
            lbl_status.Text = String.Empty;


            Server.Transfer("Emps.aspx", false);
        }


        protected void btn_back_Click(object sender, EventArgs e)
        {
            Server.Transfer("Add_address.aspx", true);
        }


        protected void btn_next_Click(object sender, EventArgs e)
        {
            if (tb_phone.Text.Equals(String.Empty))
                lbl_status.Text = "Please, fill the field.";
            else if (!Regex.IsMatch(tb_phone.Text, @"[0-9]+"))
                lbl_status.Text = "Field must contain only numbers.";
            else
            {
                // TODO pass data to the next page


                lbl_status.Text = String.Empty;


                Server.Transfer("Add_checking.aspx", true);
            }
        }
    }
}