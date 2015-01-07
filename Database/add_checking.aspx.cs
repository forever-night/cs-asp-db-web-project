using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Configuration;


namespace Database
{
    public partial class Add_checking : System.Web.UI.Page
    {
		string txtSqlConnect = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
		string txtSqlCommand;
		SqlCommand sqlCommand;


        protected void Page_Load(object sender, EventArgs e)
        {
			tb_emp_name.Text = (string)Session["empname"];
			tb_emp_surname.Text = (string)Session["empsurname"];
			tb_emp_pers_id.Text = (string)Session["emppersid"];
			dl_emp_dept.SelectedValue = (string)Session["empdept"];
			tb_country.Text = (string)Session["country"];
			tb_city.Text = (string)Session["city"];
			tb_street.Text = (string)Session["street"];
			tb_house.Text = (string)Session["house"];
			tb_zip.Text = (string)Session["zip"];
			tb_phone.Text = (string)Session["phone"];
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


            lbl_status.Text = String.Empty;
        }


        protected void btn_finish_Click(object sender, EventArgs e)
        {
            if (tb_emp_name.Text.Equals(String.Empty) || tb_emp_surname.Text.Equals(String.Empty)
                || tb_emp_pers_id.Text.Equals(String.Empty) || tb_country.Text.Equals(String.Empty)
                || tb_city.Text.Equals(String.Empty) || tb_street.Text.Equals(String.Empty)
                || tb_house.Text.Equals(String.Empty) || tb_zip.Text.Equals(String.Empty)
                || tb_phone.Text.Equals(String.Empty))
            {
                lbl_status.Text = "One of the fields is empty.";
            }
            else if (!Regex.IsMatch(tb_emp_pers_id.Text, @"[0-9]+")
                || !Regex.IsMatch(tb_zip.Text, @"[0-9]+")
                || !Regex.IsMatch(tb_phone.Text, @"[0-9]+")
				|| !Regex.IsMatch(tb_house.Text, @"[0-9]+"))
            {
                lbl_status.Text = "Fields PESEL, House, ZipCode and Phone must contain only numbers.";
            }
			else if (dl_emp_dept.SelectedValue.Equals("empty"))
				lbl_status.Text = "Please, select a department.";
            else
            {
				using (SqlConnection sqlConnect = new SqlConnection(txtSqlConnect))
				{
					int emp_id; 


					txtSqlCommand = "INSERT INTO Employees(emp_name, emp_surname, emp_personal_id, emp_dept_id) VALUES (@emp_name, @emp_surname, @emp_pers_id, @emp_dept_id);";
					
					sqlCommand = new SqlCommand(txtSqlCommand, sqlConnect);

					sqlCommand.Parameters.AddWithValue("@emp_name", tb_emp_name.Text);
					sqlCommand.Parameters.AddWithValue("@emp_surname", tb_emp_surname.Text);
					sqlCommand.Parameters.AddWithValue("@emp_pers_id", Int32.Parse(tb_emp_pers_id.Text));
					sqlCommand.Parameters.AddWithValue("@emp_dept_id", dl_emp_dept.Text);
					
					sqlCommand.Connection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlCommand.Connection.Close();


					txtSqlCommand = "SELECT emp_id FROM Employees WHERE emp_personal_id = @emp_pers_id AND emp_tel_id IS NULL;";

					sqlCommand = new SqlCommand(txtSqlCommand, sqlConnect);
					
					sqlCommand.Parameters.AddWithValue("@emp_pers_id", Int32.Parse(tb_emp_pers_id.Text));

					sqlCommand.Connection.Open();

					emp_id = (int)sqlCommand.ExecuteScalar();

					sqlCommand.Connection.Close();


					txtSqlCommand = "INSERT INTO Addresses(addr_emp_id, addr_country, addr_city, addr_street, addr_house, addr_zipcode) VALUES (@emp_id, @addr_country, @addr_city, @addr_street, @addr_house, @addr_zipcode);" +
					"INSERT INTO Telephones(tel_emp_id, tel_num) VALUES (@emp_id, @tel_num);";

					sqlCommand = new SqlCommand(txtSqlCommand, sqlConnect);

					sqlCommand.Parameters.AddWithValue("@emp_id", emp_id);
					sqlCommand.Parameters.AddWithValue("@addr_country", tb_country.Text);
					sqlCommand.Parameters.AddWithValue("@addr_city", tb_city.Text);
					sqlCommand.Parameters.AddWithValue("@addr_street", tb_street.Text);
					sqlCommand.Parameters.AddWithValue("@addr_house", Int32.Parse(tb_house.Text));
					sqlCommand.Parameters.AddWithValue("@addr_zipcode", Int32.Parse(tb_zip.Text));
					sqlCommand.Parameters.AddWithValue("@tel_num", Int32.Parse(tb_phone.Text));
					
					sqlCommand.Connection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlCommand.Connection.Close();


					txtSqlCommand = "UPDATE Employees SET emp_tel_id = tel_id FROM Telephones WHERE tel_emp_id = emp_id; UPDATE Employees SET emp_addr_id = addr_id FROM Addresses WHERE addr_emp_id = emp_id;";

					sqlCommand = new SqlCommand(txtSqlCommand, sqlConnect);

					sqlCommand.Connection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlCommand.Connection.Close();
				}


                lbl_status.Text = String.Empty;


                Server.Transfer("Emps.aspx", false);
            }
        }
    }
}