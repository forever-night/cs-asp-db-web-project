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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btn_login_Click(object sender, EventArgs e)
        {
			string txtSqlConnect = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();


			using (SqlConnection sqlConnect = new SqlConnection(txtSqlConnect))
			{
				string txtSqlCommand = "SELECT COUNT(*) FROM Users WHERE username = @username AND password = @password";
				SqlCommand sqlCommand = new SqlCommand(txtSqlCommand, sqlConnect);

				sqlCommand.Parameters.AddWithValue("@username", tb_login.Text);
				sqlCommand.Parameters.AddWithValue("@password", tb_pwd.Text);

				sqlConnect.Open();


				int result = (int)sqlCommand.ExecuteScalar();

				if (result >= 0)
				{
					SqlCommand sqlCommandRole = new SqlCommand(
						"SELECT role FROM Users WHERE username = @username AND password = @password", sqlConnect);

					sqlCommandRole.Parameters.AddWithValue("@username", tb_login.Text);
					sqlCommandRole.Parameters.AddWithValue("@password", tb_pwd.Text);

					Session["Role"] = (int)sqlCommandRole.ExecuteScalar();
					Session["User"] = tb_login.Text;
				}
				else
				{
					Session["Role"] = -1;
					Session["User"] = "";
				}
				

				sqlConnect.Close();
			}

			tb_login.Text = String.Empty;
			tb_pwd.Text = String.Empty;

			Response.Redirect("Main.aspx");
        }
    }
}