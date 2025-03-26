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
//using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CMS_BWP
{
	public partial class Update_Complaint : Form
	{
		string constring = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

		public Update_Complaint()
		{
			InitializeComponent();
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Update_Complaint_Load(object sender, EventArgs e)
		{
			lbl_complaintid.Visible = false;
			cmb_zone.Enabled = false;
			cmb_uc.Enabled = false;
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaints", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				for (int i = 0; i < dt.Rows.Count; i++)
				{

					cmb_complaintnumber.Items.Add(dt.Rows[i]["complaint_number"]);
				}


				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}

			this.cmb_complaintnumber.AutoCompleteMode = AutoCompleteMode.Suggest;
			this.cmb_complaintnumber.AutoCompleteSource = AutoCompleteSource.ListItems;


		}



		private void cmb_complaintnumber_TextChanged(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaintsbycomplaint_number", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@complaint_number", cmb_complaintnumber.Text);
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);

				//cmb_complaintnumber..Add(dt.Rows[0]["complaint_number"]);
				lbl_complaintid.Text = dt.Rows[0]["complaint_id"].ToString();
				txt_name.Text = dt.Rows[0]["Name"].ToString();
				txt_mobile.Text = dt.Rows[0]["Mobile"].ToString();
				txt_adress.Text = dt.Rows[0]["Address"].ToString();
				cmb_division.Text = dt.Rows[0]["Division"].ToString();
				cmb_district.SelectedItem = dt.Rows[0]["District"].ToString();
				cmb_Tehsil.SelectedItem = dt.Rows[0]["Tehsil"].ToString();
				cmb_zone.Text = dt.Rows[0]["Zone"].ToString();
				cmb_uc.SelectedItem = dt.Rows[0]["Union_council"].ToString();
				cmb_complaintype.SelectedItem = dt.Rows[0]["Complaint_type"].ToString();
				ps_type.SelectedItem = dt.Rows[0]["PS_type"].ToString();
				cmb_complaintstatus.SelectedItem = dt.Rows[0]["Status"].ToString();



				con.Close();
			}
			catch (Exception ex)
			{
				//MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void cmb_complaintnumber_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaintsbycomplaint_number", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@complaint_number", cmb_complaintnumber.Text);
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);

				//cmb_complaintnumber..Add(dt.Rows[0]["complaint_number"]);
				lbl_complaintid.Text= dt.Rows[0]["complaint_id"].ToString();
				txt_name.Text = dt.Rows[0]["Name"].ToString();
				txt_mobile.Text = dt.Rows[0]["Mobile"].ToString();
				txt_adress.Text = dt.Rows[0]["Address"].ToString();
				cmb_division.Text = dt.Rows[0]["Division"].ToString();
				cmb_district.SelectedItem = dt.Rows[0]["District"].ToString();
				cmb_Tehsil.SelectedItem = dt.Rows[0]["Tehsil"].ToString();
				if (dt.Rows[0]["Tehsil"].ToString() == "Bahawalpur City")
				{
					cmb_zone.Enabled = true;
					cmb_uc.Enabled = true;
				}
				cmb_zone.Text = dt.Rows[0]["Zone"].ToString();
				cmb_uc.SelectedItem = dt.Rows[0]["Union_council"].ToString();
				cmb_complaintype.SelectedItem = dt.Rows[0]["Complaint_type"].ToString();
				ps_type.SelectedItem = dt.Rows[0]["PS_type"].ToString();
				cmb_complaintstatus.SelectedItem = dt.Rows[0]["Status"].ToString();
				txt_remarks.Text = dt.Rows[0]["remarks"].ToString();



				con.Close();
			}
			catch (Exception ex)
			{
				//MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void cmb_complaintnumber_TextUpdate(object sender, EventArgs e)
		{

		}


		private void cmb_complaintnumber_KeyUp(object sender, KeyEventArgs e)
		{

		}

		private void btn_Update_Click(object sender, EventArgs e)
		{
			SqlConnection con = new SqlConnection(constring);
			SqlCommand cmd = new SqlCommand("update_complaint", con);
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.AddWithValue("@complaint_id", lbl_complaintid.Text);
			cmd.Parameters.AddWithValue("@complaint_number", cmb_complaintnumber.SelectedItem);
			cmd.Parameters.AddWithValue("@Name", txt_name.Text);
			cmd.Parameters.AddWithValue("@Mobile", txt_mobile.Text);
			cmd.Parameters.AddWithValue("@Address", txt_adress.Text);
			cmd.Parameters.AddWithValue("@Division", cmb_division.SelectedItem.ToString());
			cmd.Parameters.AddWithValue("@District", cmb_district.SelectedItem.ToString());
			cmd.Parameters.AddWithValue("@Tehsil", cmb_Tehsil.SelectedItem.ToString());
			if (cmb_zone.Enabled)
			{
				cmd.Parameters.AddWithValue("@Zone", cmb_zone.SelectedItem.ToString());
				cmd.Parameters.AddWithValue("@Union_council", cmb_uc.SelectedItem.ToString());
			}
			else
			{
				cmd.Parameters.AddWithValue("@Zone", "");
				cmd.Parameters.AddWithValue("@Union_council", "");
			}

			cmd.Parameters.AddWithValue("@Complaint_type", cmb_complaintype.SelectedItem.ToString());
			cmd.Parameters.AddWithValue("@PS_type", ps_type.SelectedItem.ToString());
			cmd.Parameters.AddWithValue("@Status", cmb_complaintstatus.SelectedItem.ToString());
			cmd.Parameters.AddWithValue("@last_updated", DateTime.Now);
			cmd.Parameters.AddWithValue("@updated_by", FM_Login.user);
			cmd.Parameters.AddWithValue("@remarks", txt_remarks.Text);
			con.Open();
			int i = cmd.ExecuteNonQuery();

			con.Close();

			if (i != 0)
			{
				MessageBox.Show(i + "Data Saved");
			}
		}

		private void cmb_district_SelectedIndexChanged(object sender, EventArgs e)
		{
			//if (cmb_district.SelectedIndex == 1)
			//{
			//	cmb_Tehsil.Items.Clear();
			//	cmb_Tehsil.Items.Add("Bahawalpur Sadar");
			//	cmb_Tehsil.Items.Add("Bahawalpur City");
			//	cmb_Tehsil.Items.Add("Ahmed Pur East");
			//	cmb_Tehsil.Items.Add("Yazman");
			//	cmb_Tehsil.Items.Add("Hasilpur");
			//	cmb_Tehsil.Items.Add("Khairpur");

			//	cmb_Tehsil.SelectedItem = "Bahawalpur Sadar";
			//}
			//else if (cmb_district.SelectedIndex == 2)
			//{
			//	cmb_zone.Enabled = false;
			//	cmb_uc.Enabled = false;
			//	cmb_Tehsil.Items.Clear();
			//	cmb_Tehsil.Items.Add("Bahawalnagar");
			//	cmb_Tehsil.Items.Add("Chishtian");
			//	cmb_Tehsil.Items.Add("Minchinabad");
			//	cmb_Tehsil.Items.Add("Haroonabad");
			//	cmb_Tehsil.Items.Add("Fortabbas");
			//	cmb_Tehsil.SelectedItem = "Bahawalnagar";
			//}
			//else if (cmb_district.SelectedIndex == 3)
			//{
			//	cmb_zone.Enabled = false;
			//	cmb_uc.Enabled = false;
			//	cmb_Tehsil.Items.Clear();
			//	cmb_Tehsil.Items.Add("Rahim Yar Khan");
			//	cmb_Tehsil.Items.Add("Sadiqabad");
			//	cmb_Tehsil.Items.Add("Khanpur");
			//	cmb_Tehsil.Items.Add("Liaqatpur");
			//	cmb_Tehsil.SelectedItem = "Rahim Yar Khan";
			//}
		}

		private void cmb_zone_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmb_zone.SelectedIndex == 1)
			{
				cmb_uc.Items.Clear();
				cmb_uc.Items.Add("12");
				cmb_uc.Items.Add("13-A");
				cmb_uc.Items.Add("13-B");
				cmb_uc.Items.Add("14-A");
				cmb_uc.Items.Add("14-B");
				cmb_uc.Items.Add("15-A");
				cmb_uc.Items.Add("15-B");
				cmb_uc.SelectedItem = "12";

			}

			else if (cmb_zone.SelectedIndex == 2)
			{
				cmb_uc.Items.Clear();

				cmb_uc.Items.Add("16-A");
				cmb_uc.Items.Add("16-B");
				cmb_uc.Items.Add("17");
				cmb_uc.Items.Add("19-A");
				cmb_uc.Items.Add("19-B");
				cmb_uc.Items.Add("18-A");
				cmb_uc.Items.Add("18-B");
				cmb_uc.Items.Add("1-A");
				cmb_uc.Items.Add("1-B");
				cmb_uc.Items.Add("2");
				cmb_uc.Items.Add("3-A");
				cmb_uc.Items.Add("3-B");

				cmb_uc.SelectedItem = "16-A";

			}

			else if (cmb_zone.SelectedIndex == 3)
			{
				cmb_uc.Items.Clear();
				cmb_uc.Items.Add("4-A");
				cmb_uc.Items.Add("4-B");
				cmb_uc.Items.Add("5-A");
				cmb_uc.Items.Add("5-B");
				cmb_uc.Items.Add("11-A");
				cmb_uc.Items.Add("11-B");
				cmb_uc.Items.Add("18-B");
				cmb_uc.Items.Add("10-A");
				cmb_uc.Items.Add("10-B");
				cmb_uc.Items.Add("2");
				cmb_uc.Items.Add("9");
				cmb_uc.Items.Add("8-A");
				cmb_uc.Items.Add("8-B");

				cmb_uc.SelectedItem = "4-A";

			}
		}

		private void cmb_complaintype_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmb_complaintype.SelectedIndex == 2)
			{
				ps_type.Items.Clear();
				ps_type.Items.Add("S1");
				ps_type.Items.Add("S2");
				ps_type.Items.Add("S3");
				ps_type.Items.Add("S4");
				ps_type.Items.Add("S5");
				ps_type.Items.Add("S6");
				ps_type.SelectedItem = "S1";

			}
			else if (cmb_complaintype.SelectedIndex == 1)
			{
				ps_type.Items.Clear();
				ps_type.Items.Add("P1");
				ps_type.Items.Add("P2");
				ps_type.Items.Add("P3");
				ps_type.Items.Add("P4");
				ps_type.Items.Add("P5");
				ps_type.Items.Add("P6");
				ps_type.Items.Add("P7");
				ps_type.Items.Add("P8");
				ps_type.Items.Add("P9");
				ps_type.Items.Add("P10");
				ps_type.Items.Add("P11");
				ps_type.SelectedItem = "P1";
			}
		}

		private void cmb_Tehsil_SelectedIndexChanged(object sender, EventArgs e)
		{


			if (cmb_Tehsil.SelectedItem == "Bahawalpur Sadar" || cmb_Tehsil.SelectedItem == "Ahmed Pur East" || cmb_Tehsil.SelectedItem == "Yazman" || cmb_Tehsil.SelectedItem == "Hasilpur" || cmb_Tehsil.SelectedItem == "Khairpur" || cmb_Tehsil.SelectedItem == "Bahawalpur City")
			{


				cmb_district.SelectedItem = "Bahawalpur";

			}
			else if (cmb_Tehsil.SelectedItem == "Bahawalnagar" || cmb_Tehsil.SelectedItem == "Chishtian" || cmb_Tehsil.SelectedItem == "Minchinabad" || cmb_Tehsil.SelectedItem == "Haroonabad" || cmb_Tehsil.SelectedItem == "Fortabbas")
			{

				cmb_zone.Enabled = false;
				cmb_uc.Enabled = false;

				cmb_district.SelectedItem = "Bahawalnagar";
			}

			else if (cmb_Tehsil.SelectedItem == "Rahim Yar Khan" || cmb_Tehsil.SelectedItem == "Sadiqabad" || cmb_Tehsil.SelectedItem == "Khanpur" || cmb_Tehsil.SelectedItem == "Liaqatpur")
			{

				cmb_zone.Enabled = false;
				cmb_uc.Enabled = false;

				cmb_district.SelectedItem = "Rahim Yar Khan";
			}


			if (cmb_Tehsil.SelectedItem == "Bahawalpur Sadar" || cmb_Tehsil.SelectedItem == "Ahmed Pur East" || cmb_Tehsil.SelectedItem == "Yazman" || cmb_Tehsil.SelectedItem == "Hasilpur" || cmb_Tehsil.SelectedItem == "Khairpur")
			{

				cmb_zone.Enabled = false;
				cmb_uc.Enabled = false;
			}
			else if (cmb_Tehsil.SelectedItem == "Bahawalpur City")
			{
				cmb_zone.Enabled = true;
				cmb_uc.Enabled = true;
			}

		}

		private void txt_mobile_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}

		}
	}
}
