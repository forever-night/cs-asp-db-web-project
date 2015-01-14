using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;


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
				string txtSqlCommand = "SELECT * FROM Users WHERE username = @username AND password = @password";
				SqlCommand sqlCommand = new SqlCommand(txtSqlCommand, sqlConnect);

				MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

				byte[] pwdEncrypt = System.Text.Encoding.UTF8.GetBytes(tb_pwd.Text);


				sqlCommand.Parameters.AddWithValue("@username", tb_login.Text);
				sqlCommand.Parameters.AddWithValue(
					"@password",
					BitConverter.ToString(md5.ComputeHash(pwdEncrypt)).Replace("-", "").ToLower());


				sqlConnect.Open();
				SqlDataReader reader = sqlCommand.ExecuteReader();

				if (reader.HasRows)
				{
					reader.Read();

					Session["Role"] = reader["role"];
					Session["User"] = reader["username"];


					reader.Close();
				}
				else
				{
					Session["Role"] = -1;
					Session["User"] = "";
				}
												
				sqlConnect.Close();

				Response.Redirect("Main.aspx");
			}

			tb_login.Text = String.Empty;
			tb_pwd.Text = String.Empty;

			Response.Redirect("Main.aspx");
        }
    }
}