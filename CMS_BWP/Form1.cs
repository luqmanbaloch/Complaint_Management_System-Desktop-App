using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics.Eventing.Reader;

namespace CMS_BWP
{
	public partial class FM_Login : Form
	{
		string constring = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;


		public static string user = "";
		public FM_Login()
		{
			InitializeComponent();
		}

		private void btn_login_Click(object sender, EventArgs e)
		{

			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Login", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@username", txt_user.Text);
				myCmd.Parameters.AddWithValue("@password", txt_password.Text);
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				if (dt.Rows.Count > 0)
				{

					user = dt.Rows[0]["username"].ToString();
					Dashboard dashboardForm = new Dashboard();
					this.Hide();
					dashboardForm.Show();
				}
				else
				{
					MessageBox.Show("Error: Please Enter a Valid Username and Password");
				}
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}

		}

		private void FM_Login_Load(object sender, EventArgs e)
		{

		}

		private void lnk_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			User_Registration UrForm = new User_Registration();
			UrForm.Show();
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_password", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@username", txt_user.Text);
				//myCmd.Parameters.AddWithValue("@password", txt_password.Text);
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				if (dt.Rows.Count > 0)
				{

					MessageBox.Show("Your Passoword is " + dt.Rows[0]["Password"].ToString());
				}
				else
				{
					MessageBox.Show("Error: Please Enter a Valid Username and Password");
				}
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}
	}
}


