using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Configuration;


namespace Database
{
    public partial class Employees : System.Web.UI.Page
    {
        string txtSqlConnect = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        string txtSqlCommand;
        SqlCommand sqlCommand;
 

        protected enum Status { Clear, Insert, Warning, NoNumbers };


        protected enum Forms { Employees, Addresses, Telephones };


        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void ClearForm(Forms form)
        {
            if (form == Forms.Employees)
            {
                this.dl_dept_id.ClearSelection();

                this.tb_emp_name.Text = String.Empty;
                this.tb_emp_surname.Text = String.Empty;
                this.tb_emp_personal_id.Text = String.Empty;
            }
            else if (form == Forms.Addresses)
            {
                this.dl_addr_emp_id.ClearSelection();

                this.tb_country.Text = String.Empty;
                this.tb_city.Text = String.Empty;
                this.tb_street.Text = String.Empty;
                this.tb_house.Text = String.Empty;
                this.tb_zipcode.Text = String.Empty;
            }
            else if (form == Forms.Telephones)
            {
                this.dl_tel_emp_id.ClearSelection();

                this.tb_tel_number.Text = String.Empty;
            }
        }


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
            ClearForm(Forms.Employees);

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
                using (SqlConnection sqlConnect = new SqlConnection(txtSqlConnect))
                {
                    txtSqlCommand = "INSERT INTO Employees (emp_name, emp_surname, emp_personal_id, emp_dept_id) VALUES (@emp_name, @emp_surname, @emp_personal_id, @emp_dept_id);";


                    sqlCommand = new SqlCommand(txtSqlCommand, sqlConnect);


                    sqlCommand.Parameters.AddWithValue("@emp_name", this.tb_emp_name.Text);
                    sqlCommand.Parameters.AddWithValue("@emp_surname", this.tb_emp_surname.Text);
                    sqlCommand.Parameters.AddWithValue("@emp_personal_id", this.tb_emp_personal_id.Text);
                    sqlCommand.Parameters.AddWithValue("@emp_dept_id", this.dl_dept_id.Text);


                    sqlCommand.Connection.Open();
                    sqlCommand.ExecuteNonQuery();
                }

                // TODO show updated DB


                ClearForm(Forms.Employees);

                ChangeStatus(this.lbl_status_emp, Status.Insert);
            }
        }


        protected void btn_clear_addr_Click(object sender, EventArgs e)
        {
            ClearForm(Forms.Addresses);

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
                using (SqlConnection sqlConnect = new SqlConnection(txtSqlConnect))
                {
                    txtSqlCommand = "INSERT INTO Addresses (addr_emp_id, addr_country, addr_city, addr_street, addr_house, addr_zipcode) VALUES (@addr_emp_id, @addr_country, @addr_city, @addr_street, @addr_house, @addr_zipcode); UPDATE Employees SET emp_addr_id = addr_id FROM Addresses WHERE emp_id=@addr_emp_id;";


                    sqlCommand = new SqlCommand(txtSqlCommand, sqlConnect);


                    sqlCommand.Parameters.AddWithValue("@addr_emp_id", Int32.Parse(this.dl_addr_emp_id.Text));
                    sqlCommand.Parameters.AddWithValue("@addr_country", this.tb_country.Text);
                    sqlCommand.Parameters.AddWithValue("@addr_city", this.tb_city.Text);
                    sqlCommand.Parameters.AddWithValue("@addr_street", this.tb_street.Text);
                    sqlCommand.Parameters.AddWithValue("@addr_house", Int32.Parse(this.tb_house.Text));
                    sqlCommand.Parameters.AddWithValue("@addr_zipcode", Int32.Parse(this.tb_zipcode.Text));


                    sqlCommand.Connection.Open();
                    sqlCommand.ExecuteNonQuery();
                }

                // TODO update and show updated DB


                ClearForm(Forms.Addresses);

                ChangeStatus(this.lbl_status_addr, Status.Insert);
            }
        }

        protected void btn_clear_tel_Click(object sender, EventArgs e)
        {
            

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
                using (SqlConnection sqlConnect = new SqlConnection(txtSqlConnect))
                {
                    txtSqlCommand = "INSERT INTO Telephones (tel_emp_id, tel_num) VALUES (@tel_emp_id, @tel_num); UPDATE Employees SET emp_tel_id = tel_id FROM Telephones WHERE emp_id=@tel_emp_id;";


                    sqlCommand = new SqlCommand(txtSqlCommand, sqlConnect);


                    sqlCommand.Parameters.AddWithValue("@tel_emp_id", Int32.Parse(this.dl_tel_emp_id.Text));
                    sqlCommand.Parameters.AddWithValue("@tel_num", Int32.Parse(this.tb_tel_number.Text));


                    sqlCommand.Connection.Open();
                    sqlCommand.ExecuteNonQuery();
                }

                // TODO update and show updated DB


                ClearForm(Forms.Telephones);

                ChangeStatus(this.lbl_status_tel, Status.Insert);
            }
        }
    }
}