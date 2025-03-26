using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CMS_BWP
{
	public partial class Reports_Form : Form
	{
		string constring = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

		public Reports_Form()
		{
			InitializeComponent();
		}
		public string[] Tehsils = { "Bahawalpur Sadar", "Bahawalpur City", "Ahmed Pur East", "Yazman", "Hasilpur", "Khairpur", "Bahawalnagar", "Chishtian", "Haroonabad", "Fortabbas", "Minchinabad", "Rahim Yar Khan", "Sadiqabad", "Khanpur", "Liaqatpur" };
		private void groupBox10_Enter(object sender, EventArgs e)
		{

		}

		private void Reports_Form_Load(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaints", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dt_complaintdata.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
			Getallcomplaints();
			Getallpendingcomplaints();
			Getallclosedcomplaints();
			for (int i = 0; i < Tehsils.Length; i++)
			{
				Getallcomplaintstehsilwise(Tehsils[i]);
				Getallcomplaintstehsilwisepending(Tehsils[i]);
				Getallcomplaintstehsilwiseclosed(Tehsils[i]);
			}

		}

		public void Getallcomplaints()
		{

			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand cmd = new SqlCommand("Get_allcomplaintscount", con);
				cmd.CommandType = CommandType.StoredProcedure;
				//cmd.Parameters.AddWithValue("@startdate", startdate);
				//cmd.Parameters.AddWithValue("@enddate", endate);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
				lbl_all.Text = dt.Rows[0]["complaint_total"].ToString();
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}

		}

		public void Getallpendingcomplaints()
		{

			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand cmd = new SqlCommand("Get_allcomplaintscountbystatus", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@status", "pending");
				cmd.Parameters.AddWithValue("@currentmonth", DateTime.Now.Month);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
				lbl_allpending.Text = dt.Rows[0]["complaint_total"].ToString();
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}

		}

		public void Getallclosedcomplaints()
		{

			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand cmd = new SqlCommand("Get_allcomplaintscountbystatus", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@status", "Resolved");
				cmd.Parameters.AddWithValue("@currentmonth", DateTime.Now.Month);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
				lbl_allclosed.Text = dt.Rows[0]["complaint_total"].ToString();
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}

		}
		public void Getallcomplaintstehsilwise(string Tehsil)
		{

			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand cmd = new SqlCommand("Get_allcomplaintscounttehsilwise", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@tehsil", Tehsil);
				//cmd.Parameters.AddWithValue("@enddate", endate);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
				if (Tehsil == "Bahawalpur Sadar")
				{
					lbl_sadarall.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Bahawalpur City")
				{
					lbl_cityall.Text = dt.Rows[0]["complaint_total"].ToString();
				}

				else if (Tehsil == "Ahmed Pur East")
				{
					lbl_ahmedpurall.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Hasilpur")
				{
					lbl_hasilpurall.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Yazman")
				{
					lbl_yazmanall.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Khairpur")
				{
					lbl_khairpurall.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Bahawalnagar")
				{
					lbl_bahawalnagarall.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Haroonabad")
				{
					lbl_haroonabadall.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Minchinabad")
				{
					lbl_minchinabadall.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Fortabbas")
				{
					lbl_fortabbasall.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Chishtian")
				{
					lbl_chishtianall.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Rahim Yar Khan")
				{
					lbl_rahimyarkhanall.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Khanpur")
				{
					lbl_khanpurall.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Liaqatpur")
				{
					lbl_liaqatpurall.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Sadiqabad")
				{
					lbl_sadiqabadall.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				con.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
				con.Close();
			}

			con.Close();
		}

		public void Getallcomplaintstehsilwisepending(string Tehsil)
		{

			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand cmd = new SqlCommand("Get_pendingcomplaintscounttehsilwise", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@tehsil", Tehsil);
				//cmd.Parameters.AddWithValue("@enddate", endate);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
				if (Tehsil == "Bahawalpur Sadar")
				{
					lbl_sadarpending.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Bahawalpur City")
				{
					lbl_citypending.Text = dt.Rows[0]["complaint_total"].ToString();
				}

				else if (Tehsil == "Ahmedpur")
				{
					lbl_ahmedpurpending.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Hasilpur")
				{
					lbl_hasilpurpending.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Yazman")
				{
					lbl_yazmanpending.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Khairpur")
				{
					lbl_khairpurpending.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Bahawalnagar")
				{
					lbl_bahawalnagarpending.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Haroonabad")
				{
					lbl_haroonabadpending.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Minchinabad")
				{
					lbl_minchinabadpending.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Fortabbas")
				{
					lbl_fortabbaspending.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Chishtian")
				{
					lbl_chishtianpending.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Rahim Yar Khan")
				{
					lbl_rahimyarkhanpending.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Khanpur")
				{
					lbl_khanpurpending.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Liaqatpur")
				{
					lbl_liaqatpurpending.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Sadiqabad")
				{
					lbl_sadiabadpending.Text = dt.Rows[0]["complaint_total"].ToString();
				}

				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}

		}

		public void Getallcomplaintstehsilwiseclosed(string Tehsil)
		{

			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand cmd = new SqlCommand("Get_closedcomplaintscounttehsilwise", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@tehsil", Tehsil);
				//cmd.Parameters.AddWithValue("@enddate", endate);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
				if (Tehsil == "Bahawalpur Sadar")
				{
					lbl_sadarclosed.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Bahawalpur City")
				{
					lbl_cityclosed.Text = dt.Rows[0]["complaint_total"].ToString();
				}

				else if (Tehsil == "Ahmedpur")
				{
					lbl_ahmedpurclosed.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Hasilpur")
				{
					lbl_hasilpurclosed.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Yazman")
				{
					lbl_yazmanclosed.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Khairpur")
				{
					lbl_khairpurclosed.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Bahawalnagar")
				{
					lbl_bahawalnagarclosed.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Haroonabad")
				{
					lbl_haroonabadclosed.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Minchinabad")
				{
					lbl_minchinabadclosed.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Fortabbas")
				{
					lbl_fortabbasclosed.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Chishtian")
				{
					lbl_chishtianclosed.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Rahim Yar Khan")
				{
					lbl_rahimyarkhanclosed.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Khanpur")
				{
					lbl_khanpurclosed.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Liaqatpur")
				{
					lbl_liaqatpurclosed.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (Tehsil == "Sadiqabad")
				{
					lbl_sadiabadclosed.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}

		}

		private void lbl_all_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaints", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dt_complaintdata.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_cityall_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("[Get_Complaintstehsilwise]", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@tehsil", "Bahawalpur City");
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dt_complaintdata.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_sadarall_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("[Get_Complaintstehsilwise]", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@tehsil", "Bahawalpur Sadar");
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dt_complaintdata.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_ahmedpurall_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("[Get_Complaintstehsilwise]", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@tehsil", "Ahmed Pur East");
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dt_complaintdata.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_yazmanall_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("[Get_Complaintstehsilwise]", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@tehsil", "Yazman");
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dt_complaintdata.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_hasilpurall_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("[Get_Complaintstehsilwise]", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@tehsil", "Hasilpur");
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dt_complaintdata.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_khairpurall_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("[Get_Complaintstehsilwise]", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@tehsil", "Khairpur");
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dt_complaintdata.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_bahawalnagarall_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("[Get_Complaintstehsilwise]", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@tehsil", "Bahawalnagar");
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dt_complaintdata.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_chishtianall_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("[Get_Complaintstehsilwise]", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@tehsil", "Chishtian");
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dt_complaintdata.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_haroonabadall_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("[Get_Complaintstehsilwise]", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@tehsil", "Haroonabad");
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dt_complaintdata.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_fortabbasall_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("[Get_Complaintstehsilwise]", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@tehsil", "Fortabbas");
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dt_complaintdata.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_minchinabadall_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("[Get_Complaintstehsilwise]", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@tehsil", "Minchinabad");
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dt_complaintdata.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_rahimyarkhanall_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("[Get_Complaintstehsilwise]", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@tehsil", "Rahim Yar Khan");
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dt_complaintdata.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_sadiqabadall_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("[Get_Complaintstehsilwise]", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@tehsil", "Sadiqabad");
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dt_complaintdata.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_khanpurall_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("[Get_Complaintstehsilwise]", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@tehsil", "Khanpur");
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dt_complaintdata.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_liaqatpurall_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("[Get_Complaintstehsilwise]", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@tehsil", "Liaqatpur");
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dt_complaintdata.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_sadarpending_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaintstehsilwisestatus", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@tehsil", "Bahawalpur Sadar");
				myCmd.Parameters.AddWithValue("@status", "Pending");
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dt_complaintdata.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_citypending_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaintstehsilwisestatus", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@tehsil", "Bahawalpur City");
				myCmd.Parameters.AddWithValue("@status", "Pending");
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dt_complaintdata.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_ahmedpurpending_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaintstehsilwisestatus", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@tehsil", "Ahmed Pur East");
				myCmd.Parameters.AddWithValue("@status", "Pending");
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dt_complaintdata.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_yazmanpending_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaintstehsilwisestatus", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@tehsil", "Yazman");
				myCmd.Parameters.AddWithValue("@status", "Pending");
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dt_complaintdata.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_hasilpurpending_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaintstehsilwisestatus", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@tehsil", "Hasilpur");
				myCmd.Parameters.AddWithValue("@status", "Pending");
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dt_complaintdata.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		public void Getcomplaintstehsilwisestatus(string tehsil, string status)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaintstehsilwisestatus", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@tehsil", tehsil);
				myCmd.Parameters.AddWithValue("@status", status);
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dt_complaintdata.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_khairpurpending_Click(object sender, EventArgs e)
		{
			Getcomplaintstehsilwisestatus(btn_khairpur.Text, "Pending");
		}

		private void lbl_bahawalnagarpending_Click(object sender, EventArgs e)
		{
			Getcomplaintstehsilwisestatus(btn_Bahawalnagar.Text, "Pending");
		}

		private void lbl_chishtianpending_Click(object sender, EventArgs e)
		{
			Getcomplaintstehsilwisestatus(btn_chishtian.Text, "Pending");
		}

		private void lbl_haroonabadpending_Click(object sender, EventArgs e)
		{
			Getcomplaintstehsilwisestatus(btn_Haroonabad.Text, "Pending");
		}

		private void lbl_fortabbaspending_Click(object sender, EventArgs e)
		{
			Getcomplaintstehsilwisestatus(btn_fortabbas.Text, "Pending");
		}

		private void lbl_minchinabadpending_Click(object sender, EventArgs e)
		{
			Getcomplaintstehsilwisestatus(btn_minchinabad.Text, "Pending");
		}

		private void lbl_rahimyarkhanpending_Click(object sender, EventArgs e)
		{
			Getcomplaintstehsilwisestatus(btn_rahimyarkhan.Text, "Pending");
		}

		private void lbl_sadiabadpending_Click(object sender, EventArgs e)
		{
			Getcomplaintstehsilwisestatus(btn_sadiqabad.Text, "Pending");
		}

		private void lbl_khanpurpending_Click(object sender, EventArgs e)
		{
			Getcomplaintstehsilwisestatus(btn_khanpur.Text, "Pending");
		}

		private void lbl_liaqatpurpending_Click(object sender, EventArgs e)
		{
			Getcomplaintstehsilwisestatus(btn_liaqatpur.Text, "Pending");
		}

		private void lbl_sadarclosed_Click(object sender, EventArgs e)
		{
			Getcomplaintstehsilwisestatus("Bahawalpur Sadar", "Resolved");
		}

		private void lbl_cityclosed_Click(object sender, EventArgs e)
		{
			Getcomplaintstehsilwisestatus("Bahawalpur City", "Resolved");
		}

		private void lbl_ahmedpurclosed_Click(object sender, EventArgs e)
		{
			Getcomplaintstehsilwisestatus("Ahmed Pur East", "Resolved");
		}

		private void lbl_yazmanclosed_Click(object sender, EventArgs e)
		{
			Getcomplaintstehsilwisestatus("Yazman", "Resolved");
		}

		private void lbl_hasilpurclosed_Click(object sender, EventArgs e)
		{
			Getcomplaintstehsilwisestatus("Hasilpur", "Resolved");
		}

		private void lbl_khairpurclosed_Click(object sender, EventArgs e)
		{
			Getcomplaintstehsilwisestatus("Khairpur", "Resolved");
		}

		private void lbl_bahawalnagarclosed_Click(object sender, EventArgs e)
		{
			Getcomplaintstehsilwisestatus("Bahawalnagar", "Resolved");
		}

		private void lbl_chishtianclosed_Click(object sender, EventArgs e)
		{
			Getcomplaintstehsilwisestatus("Chishtian", "Resolved");
		}

		private void lbl_haroonabadclosed_Click(object sender, EventArgs e)
		{
			Getcomplaintstehsilwisestatus("Haroonabad", "Resolved");
		}

		private void lbl_fortabbasclosed_Click(object sender, EventArgs e)
		{
			Getcomplaintstehsilwisestatus("Fortabbas", "Resolved");
		}

		private void lbl_minchinabadclosed_Click(object sender, EventArgs e)
		{
			Getcomplaintstehsilwisestatus("Minchinabad", "Resolved");
		}

		private void lbl_rahimyarkhanclosed_Click(object sender, EventArgs e)
		{
			Getcomplaintstehsilwisestatus("Rahim Yar Khan", "Resolved");
		}

		private void lbl_sadiabadclosed_Click(object sender, EventArgs e)
		{
			Getcomplaintstehsilwisestatus("Sadiqabad", "Resolved");
		}

		private void lbl_khanpurclosed_Click(object sender, EventArgs e)
		{
			Getcomplaintstehsilwisestatus("Khanpur", "Resolved");
		}

		private void lbl_liaqatpurclosed_Click(object sender, EventArgs e)
		{
			Getcomplaintstehsilwisestatus("Liaqatpur", "Resolved");
		}

		private void lbl_allpending_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("[Get_Complaintsbystatus]", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@status", "Pending");
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dt_complaintdata.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_allclosed_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("[Get_Complaintsbystatus]", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@status", "Resolved");
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dt_complaintdata.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void btn_Export_Click(object sender, EventArgs e)
		{
			if (dt_complaintdata.Rows.Count > 0)
			{
				dt_complaintdata.SelectAll();
				DataObject copydata = dt_complaintdata.GetClipboardContent();
				if (copydata != null) Clipboard.SetDataObject(copydata);
				Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
				xlapp.Visible = true;
				Microsoft.Office.Interop.Excel.Workbook xlWbook;
				Microsoft.Office.Interop.Excel.Worksheet xlsheet;
				object miseddata = System.Reflection.Missing.Value;
				xlWbook = xlapp.Workbooks.Add(miseddata);

				xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
				Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
				xlr.Select();

				xlsheet.PasteSpecial(xlr, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);


			}
			else
			{
				MessageBox.Show("No Record Found", "Info");
			}
		}
	}
}






