using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;


namespace Database
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected enum Status { Clear, Insert, Warning, NoNumbers };


        protected void ChangeStatus(Label status, Status st)
        {
            if (st == Status.Clear)
            {
                status.ForeColor = System.Drawing.Color.DarkGreen;
                status.Text = "form cleared";
            }
            else if (st == Status.Insert)
            {
                status.ForeColor = System.Drawing.Color.DarkGreen;
                status.Text = "data inserted";
            }
            else if (st == Status.NoNumbers)
            {
                status.ForeColor = System.Drawing.Color.Crimson;
                status.Text = "field should contain only numbers";
            }
            else if (st == Status.Warning)
            {
                status.ForeColor = System.Drawing.Color.Crimson;
                status.Text = "every field shoud be filled";
            }
        }


        protected void btn_clear_emp_Click(object sender, EventArgs e)
        {
            this.tb_emp_name.Text = String.Empty;
            this.tb_emp_surname.Text = String.Empty;
            this.tb_emp_personal_id.Text = String.Empty;


            this.dl_dept_id.ClearSelection();


            ChangeStatus(this.lbl_status_emp, Status.Clear);
        }


        protected void btn_insert_emp_Click(object sender, EventArgs e)
        {
            if (this.tb_emp_name.Text == String.Empty || this.tb_emp_surname.Text == String.Empty ||
                this.tb_emp_personal_id.Text == String.Empty || this.dl_dept_id.SelectedValue == "empty")
                ChangeStatus(this.lbl_status_emp, Status.Warning);
            else if (Regex.Match(this.tb_emp_personal_id.Text, @"^[0-9]+$").Success == false)
            {
                ChangeStatus(this.lbl_status_emp, Status.NoNumbers);
                this.lbl_status_emp.Text += ": PESEL";
            }
            else
            {
                // insert data


                // clear fields for later use
                btn_clear_emp_Click(sender, e);

                ChangeStatus(this.lbl_status_emp, Status.Insert);
            }
        }


        protected void btn_clear_addr_Click(object sender, EventArgs e)
        {
            this.dl_addr_emp_id.ClearSelection();

            this.tb_country.Text = String.Empty;
            this.tb_city.Text = String.Empty;
            this.tb_street.Text = String.Empty;
            this.tb_house.Text = String.Empty;
            this.tb_zipcode.Text = String.Empty;


            ChangeStatus(this.lbl_status_addr, Status.Clear);
        }


        protected void btn_insert_addr_Click(object sender, EventArgs e)
        {
            if (this.tb_country.Text == String.Empty || this.tb_city.Text == String.Empty ||
                this.tb_street.Text == String.Empty || this.tb_house.Text == String.Empty ||
                this.tb_zipcode.Text == String.Empty || this.dl_addr_emp_id.SelectedValue == "empty")
                ChangeStatus(this.lbl_status_addr, Status.Warning);
            else if (Regex.Match(this.tb_zipcode.Text, @"^[0-9]+$").Success == false)
            {
                ChangeStatus(this.lbl_status_addr, Status.NoNumbers);
                this.lbl_status_addr.Text += ": Zip-Code";
            }
            else
            {
                // insert data


                btn_clear_addr_Click(sender, e);

                ChangeStatus(this.lbl_status_addr, Status.Insert);
            }
        }

        protected void btn_clear_tel_Click(object sender, EventArgs e)
        {
            this.dl_tel_emp_id.ClearSelection();

            this.tb_tel_number.Text = String.Empty;


            ChangeStatus(this.lbl_status_tel, Status.Clear);
        }

        protected void btn_insert_tel_Click(object sender, EventArgs e)
        {
            if (this.dl_tel_emp_id.SelectedValue == "empty" || this.tb_tel_number.Text == String.Empty)
                ChangeStatus(this.lbl_status_tel, Status.Warning);
            else if (Regex.Match(this.tb_tel_number.Text, @"^[0-9]+$").Success == false)
            {
                ChangeStatus(this.lbl_status_tel, Status.NoNumbers);
                this.lbl_status_tel.Text += ": Phone";
            }
            else
            {
                // insert data


                btn_clear_tel_Click(sender, e);

                ChangeStatus(this.lbl_status_tel, Status.Insert);
            }
        }
    }
}