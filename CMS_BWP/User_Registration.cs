using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.ApplicationServices;
using System.Configuration;

namespace CMS_BWP
{
	public partial class User_Registration : Form
	{
		string constring = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

		public User_Registration()
		{
			InitializeComponent();
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_login_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(constring);
			SqlCommand cmd = new SqlCommand("user_Registeration", con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@name", txt_name.Text);
			cmd.Parameters.AddWithValue("@username", txt_email.Text);
			cmd.Parameters.AddWithValue("@password", txt_password.Text);
			cmd.Parameters.AddWithValue("@is_active", true);

			con.Open();
			int i = cmd.ExecuteNonQuery();

			con.Close();

			if (i != 0)
			{
				txt_name.Text = "";
				txt_email.Text = "";
				txt_password.Text = "";
				MessageBox.Show(i + "Data Saved");
			}
		}

		private void User_Registration_Load(object sender, EventArgs e)
		{

		}
	}
}
