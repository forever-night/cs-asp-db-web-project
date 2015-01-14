using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Security.Cryptography;


namespace Database
{
	public partial class Add_user : System.Web.UI.Page
	{
		string txtSqlConnect = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
		string txtSqlCommand;
		SqlCommand sqlCommand;


		protected void Page_Load(object sender, EventArgs e)
		{
			if ((int)Session["Role"] != 100)
				Response.Redirect("Main.aspx");
		}


		protected void btn_cancel_Click(object sender, EventArgs e)
		{
			tb_username.Text = String.Empty;
			tb_pwd.Text = String.Empty;
			tb_role.Text = String.Empty;


			Response.Redirect("Users.aspx");
		}


		protected void btn_finish_Click(object sender, EventArgs e)
		{
			if (!tb_username.Text.Equals(String.Empty) &&
				!tb_pwd.Text.Equals(String.Empty) &&
				!tb_role.Text.Equals(String.Empty) &&
				Regex.IsMatch(tb_role.Text, @"[0-9]+"))
			{
				using (SqlConnection sqlConnect = new SqlConnection(txtSqlConnect))
				{
					txtSqlCommand = "INSERT INTO Users (username, password, role) VALUES (@username, @password, @role);";

					sqlCommand = new SqlCommand(txtSqlCommand, sqlConnect);

					MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

					byte[] pwdEncrypt = System.Text.Encoding.UTF8.GetBytes(tb_pwd.Text);


					sqlCommand.Parameters.AddWithValue("@username", tb_username.Text);
					sqlCommand.Parameters.AddWithValue(
						"@password", 
						BitConverter.ToString(md5.ComputeHash(pwdEncrypt)).Replace("-", "").ToLower());

					sqlCommand.Parameters.AddWithValue("@role", tb_role.Text);


					sqlCommand.Connection.Open();
					sqlCommand.ExecuteNonQuery();
				}


				Response.Redirect("Users.aspx");
			}
			else { }
		}
	}
}