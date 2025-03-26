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
using System.Text.RegularExpressions;
using Microsoft.Toolkit.Uwp.Notifications;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CMS_BWP
{
	public partial class Complaint_Registration : Form
	{
		string constring = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;


		public Complaint_Registration()
		{
			InitializeComponent();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			this.Close();

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

		private void Complaint_Registration_Load(object sender, EventArgs e)
		{
			comboBox1.SelectedItem = "Bahawalpur";
			cmb_district.SelectedItem = "Please Select District.....................";
			//cmb_Tehsil.SelectedItem = "Bahawalpur Sadar";
			cmb_zone.SelectedItem = "Please Select Zone......";
			cmb_complaintype.SelectedItem = "Please Select an Option.....";
			//cmb_uc.SelectedIndex = 0;

		}

		private void btn_Register_Click(object sender, EventArgs e)
		{
			string complaint_id = DateTime.Now.Nanosecond+DateTime.Now.Second+txt_complaintno.Text +"_"+ DateTime.Now.Year;
			try
			{
				SqlConnection con = new SqlConnection(constring);
				SqlCommand cmd = new SqlCommand("complaint_registration", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@complaint_id", complaint_id);
				//if (cmb_Tehsil.SelectedItem == "Bahawalpur Sadar")
				//{
				//	cmd.Parameters.AddWithValue("@complaint_number", "sdr-" + txt_complaintno.Text);
				//}
				//else if (cmb_Tehsil.SelectedItem == "Bahawalpur City")
				//{
				//	cmd.Parameters.AddWithValue("@complaint_number", "cty-" + txt_complaintno.Text);
				//}
				//else if (cmb_Tehsil.SelectedItem == "Ahmed Pur East")
				//{
				//	cmd.Parameters.AddWithValue("@complaint_number", "ape-" + txt_complaintno.Text);
				//}
				//else if (cmb_Tehsil.SelectedItem == "Yazman")
				//{
				//	cmd.Parameters.AddWithValue("@complaint_number", "yzn-" + txt_complaintno.Text);
				//}
				//else if (cmb_Tehsil.SelectedItem == "Hasilpur")
				//{
				//	cmd.Parameters.AddWithValue("@complaint_number", "hsr-" + txt_complaintno.Text);
				//}
				//else if (cmb_Tehsil.SelectedItem == "Khairpur")
				//{
				//	cmd.Parameters.AddWithValue("@complaint_number", "khr-" + txt_complaintno.Text);
				//}

				//else if (cmb_Tehsil.SelectedItem == "Bahawalnagar")
				//{
				//	cmd.Parameters.AddWithValue("@complaint_number", "bwn-" + txt_complaintno.Text);
				//}

				//else if (cmb_Tehsil.SelectedItem == "Chishtian")
				//{
				//	cmd.Parameters.AddWithValue("@complaint_number", "ctn-" + txt_complaintno.Text);
				//}
				//else if (cmb_Tehsil.SelectedItem == "Minchinabad")
				//{
				//	cmd.Parameters.AddWithValue("@complaint_number", "mbd-" + txt_complaintno.Text);
				//}
				//else if (cmb_Tehsil.SelectedItem == "Haroonabad")
				//{
				//	cmd.Parameters.AddWithValue("@complaint_number", "hrn-" + txt_complaintno.Text);
				//}

				//else if (cmb_Tehsil.SelectedItem == "Fortabbas")
				//{
				//	cmd.Parameters.AddWithValue("@complaint_number", "fts-" + txt_complaintno.Text);
				//}

				//else if (cmb_Tehsil.SelectedItem == "Rahim Yar Khan")
				//{
				//	cmd.Parameters.AddWithValue("@complaint_number", "ryk-" + txt_complaintno.Text);
				//}
				//else if (cmb_Tehsil.SelectedItem == "Sadiqabad")
				//{
				//	cmd.Parameters.AddWithValue("@complaint_number", "sdq-" + txt_complaintno.Text);
				//}
				//else if (cmb_Tehsil.SelectedItem == "Khanpur")
				//{
				//	cmd.Parameters.AddWithValue("@complaint_number", "knr-" + txt_complaintno.Text);
				//}
				//else if (cmb_Tehsil.SelectedItem == "Liaqatpur")
				//{
				//	cmd.Parameters.AddWithValue("@complaint_number", "lqr-" + txt_complaintno.Text);
				//}

				cmd.Parameters.AddWithValue("@complaint_number", txt_complaintno.Text);
				cmd.Parameters.AddWithValue("@Name", txt_name.Text);
				cmd.Parameters.AddWithValue("@Mobile", txt_mobile.Text);
				cmd.Parameters.AddWithValue("@Address", txt_adress.Text);
				cmd.Parameters.AddWithValue("@Division", comboBox1.SelectedItem.ToString());
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
				cmd.Parameters.AddWithValue("@PS_type", ps_type.SelectedText);
				cmd.Parameters.AddWithValue("@Status", "Open");
				cmd.Parameters.AddWithValue("@Reg_date", DateTime.Now);
				cmd.Parameters.AddWithValue("@last_updated", DateTime.Now);
				cmd.Parameters.AddWithValue("@reg_by", FM_Login.user);
				cmd.Parameters.AddWithValue("@updated_by", FM_Login.user);
				cmd.Parameters.AddWithValue("@remarks", "");

				con.Open();
				int i = cmd.ExecuteNonQuery();

				con.Close();

				if (i != 0)
				{
					new ToastContentBuilder()
					 .AddArgument("action", "viewConversation")
					 .AddArgument("Complaint Number", txt_complaintno.Text)
					 .AddText(txt_name.Text + " registered a complaint from " + cmb_Tehsil.SelectedItem)
					 .AddText("Check this out!")
					 .Show();

					MessageBox.Show(i + "Data Saved");
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show("Complaint Number Can not be duplicate. " + ex.ToString());
			}

		}

		private void cmb_district_SelectedIndexChanged(object sender, EventArgs e)
		{
			//if (cmb_district.SelectedIndex == 1)
			//{
			//	cmb_zone.Enabled = true;
			//	cmb_uc.Enabled = true;

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
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
			{
				e.Handled = true;
			}

			
		}
	}
}

