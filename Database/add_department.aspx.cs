using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


namespace Database
{
    public partial class Add_department : System.Web.UI.Page
	{
		string txtSqlConnect = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
		string txtSqlCommand;
		SqlCommand sqlCommand;


        protected void Page_Load(object sender, EventArgs e)
        {
			if ((int)Session["Role"] < 0)
				Response.Redirect("Login.aspx");
			else if ((int)Session["Role"] != 100)
				Response.Redirect("Departments.aspx");
        }


        protected void btn_cancel_Click(object sender, EventArgs e)
        {
            tb_dept_name.Text = String.Empty;

            Response.Redirect("Departments.aspx");
        }


        protected void btn_finish_Click(object sender, EventArgs e)
        {
			using (SqlConnection sqlConnect = new SqlConnection(txtSqlConnect))
			{
				txtSqlCommand = "INSERT INTO Departments(dept_name) VALUES (@dept_name);";

				sqlCommand = new SqlCommand(txtSqlCommand, sqlConnect);

				sqlCommand.Parameters.AddWithValue("@dept_name", tb_dept_name.Text);

				sqlCommand.Connection.Open();
				sqlCommand.ExecuteNonQuery();
			}


            Response.Redirect("Departments.aspx", false);
        }
    }
}