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

namespace CMS_BWP
{
	public partial class Update_Complaint_Status : Form
	{
		string constring = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;

		public Update_Complaint_Status()
		{
			InitializeComponent();
		}



		private void Update_Complaint_Status_Load(object sender, EventArgs e)
		{
			lbl_complaintid.Visible = false;
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

		private void btn_Update_Click(object sender, EventArgs e)
		{
			try
			{
				if (cmb_complaintstatus.SelectedItem == "Resolved")
				{
                   if(txt_selected_file.Text!="" && txt_fileafter.Text!="")

					{

						byte[] imageData = File.ReadAllBytes(txt_selected_file.Text);
						byte[] imageData2 = File.ReadAllBytes(txt_fileafter.Text);


						SqlConnection con = new SqlConnection(constring);
						SqlCommand cmd = new SqlCommand("[update_complaintstatus]", con);
						cmd.CommandType = CommandType.StoredProcedure;
						cmd.Parameters.AddWithValue("@complaint_id", lbl_complaintid.Text);
						cmd.Parameters.AddWithValue("@complaint_number", cmb_complaintnumber.SelectedItem);
						cmd.Parameters.AddWithValue("@Status", cmb_complaintstatus.SelectedItem.ToString());
						cmd.Parameters.AddWithValue("@last_updated", DateTime.Now);
						cmd.Parameters.AddWithValue("@updated_by", FM_Login.user);
						cmd.Parameters.AddWithValue("@Imagefile", imageData);
						cmd.Parameters.AddWithValue("@Imagefileafter", imageData2);
						cmd.Parameters.AddWithValue("@remarks", txt_remarks.Text);


						con.Open();
						int i = cmd.ExecuteNonQuery();

						con.Close();

						if (i != 0)
						{
							MessageBox.Show(i + " Status of Complaint Updated");
						}

					}
				   else
					{

						MessageBox.Show("Please Select before and after Image!!, Images are mandatory");
						//SqlConnection con = new SqlConnection(constring);
						//SqlCommand cmd = new SqlCommand("update_complaintbystatus", con);
						//cmd.CommandType = CommandType.StoredProcedure;
						//cmd.Parameters.AddWithValue("@complaint_number", cmb_complaintnumber.SelectedItem);
						//cmd.Parameters.AddWithValue("@Status", cmb_complaintstatus.SelectedItem.ToString());
						//cmd.Parameters.AddWithValue("@last_updated", DateTime.Now);
						//cmd.Parameters.AddWithValue("@updated_by", FM_Login.user);
						//cmd.Parameters.AddWithValue("@remarks", txt_remarks.Text);


						//con.Open();
						//int i = cmd.ExecuteNonQuery();

						//con.Close();

						//if (i != 0)
						//{
						//MessageBox.Show(i + " Status of Complaint Updated");
						//}

					}

				}
				else
				{
					SqlConnection con = new SqlConnection(constring);
					SqlCommand cmd = new SqlCommand("update_complaintbystatus", con);
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@complaint_id", lbl_complaintid.Text);
					cmd.Parameters.AddWithValue("@complaint_number", cmb_complaintnumber.SelectedItem);
					cmd.Parameters.AddWithValue("@Status", cmb_complaintstatus.SelectedItem.ToString());
					cmd.Parameters.AddWithValue("@last_updated", DateTime.Now);
					cmd.Parameters.AddWithValue("@updated_by", FM_Login.user);
					cmd.Parameters.AddWithValue("@remarks", txt_remarks.Text);

					con.Open();
					int i = cmd.ExecuteNonQuery();

					con.Close();

					if (i != 0)
					{
						MessageBox.Show(i + " Status of Complaint Updated");
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_browse_Click(object sender, EventArgs e)
		{
			string imagePath = "";

			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				//openFileDialog.Filter = "Image Files *.jpg;*.jpeg;*.png;*.bmp";
				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					imagePath = openFileDialog1.FileName;
					txt_selected_file.Text = imagePath;
					pictureBox1.Image = Image.FromFile(imagePath);
				}
			}
		}

		private void cmb_complaintstatus_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmb_complaintstatus.SelectedItem == "Resolved")
			{
				btn_browse.Visible = true;
				lbl_filepath.Visible = true;
				txt_selected_file.Visible = true;
				pictureBox1.Visible = true;
				btn_Browse2.Visible = true;
				label1.Visible = true;
				txt_fileafter.Visible = true;
				pictureBox2.Visible = true;
				lbl_remarks.Visible = true;
				txt_remarks.Visible = true;



			}
			else
			{
				btn_browse.Visible = false;
				lbl_filepath.Visible = false;
				txt_selected_file.Visible = false;
				pictureBox1.Visible = false;
				btn_Browse2.Visible = false;
				label1.Visible = false;
				txt_fileafter.Visible = false;
				pictureBox2.Visible = false;
				lbl_remarks.Visible = false;
				txt_remarks.Visible = false;

			}
		}

		private void txt_selected_file_TextChanged(object sender, EventArgs e)
		{

		}

		private void btn_Browse2_Click(object sender, EventArgs e)
		{
			string imagePath = "";

			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				//openFileDialog.Filter = "Image Files *.jpg;*.jpeg;*.png;*.bmp";
				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					imagePath = openFileDialog1.FileName;
					txt_fileafter.Text = imagePath;
					pictureBox2.Image = Image.FromFile(imagePath);
				}
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
				if (dt.Rows.Count > 0)
				{
					//cmb_complaintnumber..Add(dt.Rows[0]["complaint_number"]);
					lbl_complaintid.Text = dt.Rows[0]["complaint_id"].ToString();

					cmb_complaintstatus.SelectedItem = dt.Rows[0]["Status"].ToString();

				}


				con.Close();
			}
			catch (Exception ex)
			{
				//MessageBox.Show("Error while connecting to database!!");
			}
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
				if (dt.Rows.Count > 0)
				{ 
				//cmb_complaintnumber..Add(dt.Rows[0]["complaint_number"]);
				lbl_complaintid.Text = dt.Rows[0]["complaint_id"].ToString();
				
				cmb_complaintstatus.SelectedItem = dt.Rows[0]["Status"].ToString();

				}


				con.Close();
			}
			catch (Exception ex)
			{
				//MessageBox.Show("Error while connecting to database!!");
			}
		}


	

	
	}
}
