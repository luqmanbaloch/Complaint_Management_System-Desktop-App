using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
//using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
//using Microsoft.Office.Interop.Excel;

//using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Configuration;

namespace CMS_BWP
{
	public partial class Dashboard : Form
	{
		int PageSize = 25;
		string constring = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
		public static string id = "";
		//\MSSQLSERVER01
		//string constring = @"Server=.\MSSQLSERVER01;database=CMS_DB;user id=sa;password=Bitford***123;Trusted_Connection=yes;connection timeout=30";
		public Dashboard()
		{
			InitializeComponent();
		}

		private void btn_New_Click(object sender, EventArgs e)
		{
			Complaint_Registration CMForm = new Complaint_Registration();
			CMForm.Show();
		}

		private void Dashboard_Load(object sender, EventArgs e)
		{

			lbl_currentmonth.Text = getAbbreviatedName(DateTime.Now.Month);
			lbl_previousmonth.Text = getAbbreviatedName(DateTime.Now.Month - 1);

			searchbyid();
			searchbyname();
			searchbycomplaintnumber();

			cmb_District.SelectedItem = "Select A District.......";
			cmb_Tehsils.SelectedItem = "Select A Tehsil...........";
			getallcomplaintforcurrentmonth();
			getallcomplaintforpreviousmonth();
			getallcomplaintscountbystatuscurrentmonth("In Progress");
			getallcomplaintscountbystatuscurrentmonth("Pending");
			getallcomplaintscountbystatuscurrentmonth("Resolved");
			getallcomplaintscountbystatuscurrentmonth("Out of Jurisdiction");
			getallcomplaintscountbystatuspreviousmonth("In Progress");
			getallcomplaintscountbystatuspreviousmonth("Pending");
			getallcomplaintscountbystatuspreviousmonth("Resolved");
			getallcomplaintscountbystatuspreviousmonth("Out of Jurisdiction");
			Getcurrentmonthnewcomplaints();
			BindGrid(1);


			this.cmb_searchbyid.AutoCompleteMode = AutoCompleteMode.Suggest;
			this.cmb_searchbyid.AutoCompleteSource = AutoCompleteSource.ListItems;

			this.cmb_searchbyname.AutoCompleteMode = AutoCompleteMode.Suggest;
			this.cmb_searchbyname.AutoCompleteSource = AutoCompleteSource.ListItems;

		}

		public void searchbyid()
		{

			cmb_searchbyid.Items.Clear();

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

					cmb_searchbyid.Items.Add(dt.Rows[i]["Mobile"]);
				}


				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");


			}
		}

		public void searchbycomplaintnumber()
		{

			cmb_searchbyid.Items.Clear();

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

					cm_byid.Items.Add(dt.Rows[i]["complaint_number"]);
				}


				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");


			}
		}

		public void searchbyname()
		{
			cmb_searchbyname.Items.Clear();

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

					cmb_searchbyname.Items.Add(dt.Rows[i]["Name"]);
				}


				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");


			}
		}
		private void BindGrid(int pageIndex)
		{

			using (SqlConnection con = new SqlConnection(constring))
			{
				using (SqlCommand cmd = new SqlCommand("GetComplaintsPageWise", con))
				{
					cmd.CommandType = CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@PageIndex", pageIndex);
					cmd.Parameters.AddWithValue("@PageSize", PageSize);
					cmd.Parameters.Add("@RecordCount", SqlDbType.Int, 4);
					cmd.Parameters["@RecordCount"].Direction = ParameterDirection.Output;
					con.Open();
					DataTable dt = new DataTable();
					dt.Load(cmd.ExecuteReader());
					dataGridView1.DataSource = dt;
					con.Close();
					int recordCount = Convert.ToInt32(cmd.Parameters["@RecordCount"].Value);
					this.PopulatePager(recordCount, pageIndex);
				}
			}
		}


		private void PopulatePager(int recordCount, int currentPage)
		{
			List<Page> pages = new List<Page>();
			int startIndex, endIndex;
			int pagerSpan = 5;

			//Calculate the Start and End Index of pages to be displayed.
			double dblPageCount = (double)((decimal)recordCount / Convert.ToDecimal(PageSize));
			int pageCount = (int)Math.Ceiling(dblPageCount);
			startIndex = currentPage > 1 && currentPage + pagerSpan - 1 < pagerSpan ? currentPage : 1;
			endIndex = pageCount > pagerSpan ? pagerSpan : pageCount;
			if (currentPage > pagerSpan % 2)
			{
				if (currentPage == 2)
				{
					endIndex = 5;
				}
				else
				{
					endIndex = currentPage + 2;
				}
			}
			else
			{
				endIndex = (pagerSpan - currentPage) + 1;
			}

			if (endIndex - (pagerSpan - 1) > startIndex)
			{
				startIndex = endIndex - (pagerSpan - 1);
			}

			if (endIndex > pageCount)
			{
				endIndex = pageCount;
				startIndex = ((endIndex - pagerSpan) + 1) > 0 ? (endIndex - pagerSpan) + 1 : 1;
			}

			//Add the First Page Button.
			if (currentPage > 1)
			{
				pages.Add(new Page { Text = "First", Value = "1" });
			}

			//Add the Previous Button.
			if (currentPage > 1)
			{
				pages.Add(new Page { Text = "<<", Value = (currentPage - 1).ToString() });
			}

			for (int i = startIndex; i <= endIndex; i++)
			{
				pages.Add(new Page { Text = i.ToString(), Value = i.ToString(), Selected = i == currentPage });
			}

			//Add the Next Button.
			if (currentPage < pageCount)
			{
				pages.Add(new Page { Text = ">>", Value = (currentPage + 1).ToString() });
			}

			//Add the Last Button.
			if (currentPage != pageCount)
			{
				pages.Add(new Page { Text = "Last", Value = pageCount.ToString() });
			}

			//Clear existing Pager Buttons.
			panel1.Controls.Clear();

			//Loop and add Buttons for Pager.
			int count = 0;
			foreach (Page page in pages)
			{
				Button btnPage = new Button();
				btnPage.Location = new System.Drawing.Point(38 * count, 5);
				btnPage.Size = new System.Drawing.Size(70, 50);
				btnPage.Name = page.Value;
				btnPage.Text = page.Text;
				btnPage.Enabled = !page.Selected;
				btnPage.Click += new System.EventHandler(this.Dashboard_Click);
				panel1.Controls.Add(btnPage);
				count++;
			}
		}



		public void Getcurrentmonthnewcomplaints()
		{

			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_allcomplaintscountbystatus", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@status", "Open");
				myCmd.Parameters.AddWithValue("@currentmonth", DateTime.Now.Month);

				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				lbl_new.Text = dt.Rows[0][0].ToString();
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}


		public void Getcurrentmonthnewcomplaintsbytehsil(string tehsil)
		{

			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_allcomplaintscountbyTehsilandstatus", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@status", "Open");
				myCmd.Parameters.AddWithValue("@currentmonth", DateTime.Now.Month);
				myCmd.Parameters.AddWithValue("@tehsil", tehsil);
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				lbl_new.Text = dt.Rows[0][0].ToString();
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}
		static string getAbbreviatedName(int month)
		{
			int year = DateTime.Now.Year;
			if (month == 0)
			{
				month = 12;
				year = year - 1;

			}

			DateTime date = new DateTime(year, month, 1);


			return date.ToString("MMM");
		}


		public void getallcomplaintforcurrentmonth()
		{
			string startdate = DateTime.Now.Year + "-" + DateTime.Now.Month + "-1";
			string endate = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Date;

			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand cmd = new SqlCommand("Get_allcomcurrentmonth", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@startdate", DateTime.Now.Year + "-" + DateTime.Now.Month + "-1");
				cmd.Parameters.AddWithValue("@enddate", DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day);

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


		public void getallcomplaintforcurrentmonthbytehsil(string tehsil)
		{
			string startdate = DateTime.Now.Year + "-" + DateTime.Now.Month + "-1";
			string endate = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Date;

			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand cmd = new SqlCommand("Get_allcomcurrentmonthbytehsil", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@startdate", DateTime.Now.Year + "-" + DateTime.Now.Month + "-1");
				cmd.Parameters.AddWithValue("@enddate", DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day);
				cmd.Parameters.AddWithValue("@tehsil", tehsil);

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




		public void getallcomplaintforpreviousmonthbytehsil(string tehsil)
		{
			string endate = "0";
			int previousmonth = DateTime.Now.Month - 1;
			string startdate = DateTime.Now.Year + "-" + (DateTime.Now.Month - 1) + "-1";
			if (previousmonth == 1 || previousmonth == 3 || previousmonth == 5 || previousmonth == 7 || previousmonth == 8 || previousmonth == 10 || previousmonth == 12)
			{
				endate = DateTime.Now.Year + "-" + (DateTime.Now.Month - 1) + "-" + 31;
			}
			else if (previousmonth == 4 || previousmonth == 6 || previousmonth == 9 || previousmonth == 11)
			{
				endate = DateTime.Now.Year + "-" + (DateTime.Now.Month - 1) + "-" + 31;
			}
			else if (previousmonth == 2)
			{
				endate = DateTime.Now.Year + "-" + (DateTime.Now.Month - 1) + "-" + 28;
			}
			else if (previousmonth == 0)
			{
				endate = DateTime.Now.Year + "-" + 12 + "-" + 31;
			}
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand cmd = new SqlCommand("Get_allcomcurrentmonthbytehsil", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@startdate", startdate);
				cmd.Parameters.AddWithValue("@enddate", endate);
				cmd.Parameters.AddWithValue("@tehsil", tehsil);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
				lbl_allpreviousmonth.Text = dt.Rows[0]["complaint_total"].ToString();
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}

		}

		public void getallcomplaintforpreviousmonth()
		{
			string endate = "0";
			int previousmonth = DateTime.Now.Month - 1;
			string startdate = DateTime.Now.Year + "-" + (DateTime.Now.Month - 1) + "-1";
			if (previousmonth == 1 || previousmonth == 3 || previousmonth == 5 || previousmonth == 7 || previousmonth == 8 || previousmonth == 10 || previousmonth == 12)
			{
				endate = DateTime.Now.Year + "-" + (DateTime.Now.Month - 1) + "-" + 31;
			}
			else if (previousmonth == 4 || previousmonth == 6 || previousmonth == 9 || previousmonth == 11)
			{
				endate = DateTime.Now.Year + "-" + (DateTime.Now.Month - 1) + "-" + 31;
			}
			else if (previousmonth == 2)
			{
				endate = DateTime.Now.Year + "-" + (DateTime.Now.Month - 1) + "-" + 28;
			}
			else if (previousmonth == 0)
			{
				endate = DateTime.Now.Year + "-" + 12 + "-" + 31;
			}
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand cmd = new SqlCommand("Get_allcomcurrentmonth", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@startdate", startdate);
				cmd.Parameters.AddWithValue("@enddate", endate);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
				lbl_allpreviousmonth.Text = dt.Rows[0]["complaint_total"].ToString();
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}

		}

		public void getallcomplaintscountbystatuscurrentmonth(string status)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand cmd = new SqlCommand("Get_allcomplaintscountbystatus", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@status", status);
				cmd.Parameters.AddWithValue("@currentmonth", DateTime.Now.Month);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
				if (status == "In Progress")
				{
					lbl_inprogress.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (status == "Resolved")
				{
					lbl_resolved.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (status == "Pending")
				{
					lbl_pending.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (status == "Out of Jurisdiction")
				{
					lbl_judicial.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}

		}


		public void getallcomplaintscountbytehsilandstatuscurrentmonth(string status, string tehsil)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand cmd = new SqlCommand("Get_allcomplaintscountbyTehsilandstatus", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@status", status);
				cmd.Parameters.AddWithValue("@currentmonth", DateTime.Now.Month);
				cmd.Parameters.AddWithValue("@tehsil", tehsil);
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
				if (status == "In Progress")
				{
					lbl_inprogress.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (status == "Resolved")
				{
					lbl_resolved.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (status == "Pending")
				{
					lbl_pending.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (status == "Out of Jurisdiction")
				{
					lbl_judicial.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}

		}

		public void getallcomplaintscountbytehsilandstatuspreviousmonth(string status, string tehsil)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand cmd = new SqlCommand("Get_allcomplaintscountbyTehsilandstatus", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@status", status);
				cmd.Parameters.AddWithValue("@currentmonth", DateTime.Now.Month-1);
				cmd.Parameters.AddWithValue("@tehsil", tehsil);
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
				if (status == "In Progress")
				{
					lbl_inprogress.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (status == "Resolved")
				{
					lbl_resolved.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (status == "Pending")
				{
					lbl_pending.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (status == "Out of Jurisdiction")
				{
					lbl_judicial.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}

		}

		public void getallcomplaintscountbystatuspreviousmonth(string status)
		{
			int previousmonth = DateTime.Now.Month - 1;
			if (previousmonth == 0)
				previousmonth = 12;
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand cmd = new SqlCommand("Get_allcomplaintscountbystatus", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@status", status);
				cmd.Parameters.AddWithValue("@currentmonth", previousmonth);

				SqlDataAdapter da = new SqlDataAdapter(cmd);
				da.Fill(dt);
				if (status == "In Progress")
				{
					lbl_inprogresspmonth.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (status == "Resolved")
				{
					lbl_resolvedpmonth.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (status == "Pending")
				{
					lbl_prendingpmonth.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				else if (status == "Out of Jurisdiction")
				{
					lbl_judicialpmonth.Text = dt.Rows[0]["complaint_total"].ToString();
				}
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void newComplaintToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Complaint_Registration CMForm = new Complaint_Registration();
			CMForm.Show();
		}

		private void registerUserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			User_Registration UrForm = new User_Registration();
			UrForm.Show();
		}

		private void tehsilWiseComplaintsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Reports_Form rpform = new Reports_Form();
			rpform.Show();
		}

		private void updateComplaintToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Update_Complaint upcform = new Update_Complaint();
			upcform.Show();
		}

		private void cmb_District_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaintsdistrictwise", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@district", cmb_District.SelectedItem.ToString());
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dataGridView1.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void cmb_Tehsils_SelectedIndexChanged(object sender, EventArgs e)
		{

			getallcomplaintforcurrentmonthbytehsil(cmb_Tehsils.SelectedItem.ToString());
			getallcomplaintforpreviousmonthbytehsil(cmb_Tehsils.SelectedItem.ToString());
			getallcomplaintscountbytehsilandstatuscurrentmonth("In Progress",cmb_Tehsils.SelectedItem.ToString());
			getallcomplaintscountbytehsilandstatuscurrentmonth("Pending", cmb_Tehsils.SelectedItem.ToString());
			getallcomplaintscountbytehsilandstatuscurrentmonth("Resolved", cmb_Tehsils.SelectedItem.ToString());
			getallcomplaintscountbytehsilandstatuscurrentmonth("Out of Jurisdiction", cmb_Tehsils.SelectedItem.ToString());
			getallcomplaintscountbytehsilandstatuspreviousmonth("In Progress", cmb_Tehsils.SelectedItem.ToString());
			getallcomplaintscountbytehsilandstatuspreviousmonth("Pending", cmb_Tehsils.SelectedItem.ToString());
			getallcomplaintscountbytehsilandstatuspreviousmonth("Resolved", cmb_Tehsils.SelectedItem.ToString());
			getallcomplaintscountbytehsilandstatuspreviousmonth("Out of Jurisdiction", cmb_Tehsils.SelectedItem.ToString());
			Getcurrentmonthnewcomplaintsbytehsil(cmb_Tehsils.SelectedItem.ToString());

			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaintstehsilwise", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@tehsil", cmb_Tehsils.SelectedItem.ToString());
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dataGridView1.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}



		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaintsbydate", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@startdate", dt_startdate.Value);
				myCmd.Parameters.AddWithValue("@endate", dateTimePicker1.Value);
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dataGridView1.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_inprogress_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaintsbystatuswithmonth", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@status", "In Progress");
				myCmd.Parameters.AddWithValue("@month", DateTime.Now.Month);
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dataGridView1.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_pending_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaintsbystatuswithmonth", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@status", "Pending");
				myCmd.Parameters.AddWithValue("@month", DateTime.Now.Month);
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dataGridView1.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}

		}

		private void lbl_resolved_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaintsbystatuswithmonth", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@status", "Resolved");
				myCmd.Parameters.AddWithValue("@month", DateTime.Now.Month);
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dataGridView1.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_judicial_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaintsbystatuswithmonth", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@status", "Out of Jurisdiction");
				myCmd.Parameters.AddWithValue("@month", DateTime.Now.Month);
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dataGridView1.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_inprogresspmonth_Click(object sender, EventArgs e)
		{
			int previousmonth = DateTime.Now.Month - 1;
			if (previousmonth == 0)
			{
				previousmonth = 12;
			}
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaintsbystatuswithmonth", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@status", "In Progress");
				myCmd.Parameters.AddWithValue("@month", previousmonth);
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dataGridView1.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_prendingpmonth_Click(object sender, EventArgs e)
		{
			int previousmonth = DateTime.Now.Month - 1;
			if (previousmonth == 0)
			{
				previousmonth = 12;
			}
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaintsbystatuswithmonth", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@status", "Pending");
				myCmd.Parameters.AddWithValue("@month", previousmonth);
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dataGridView1.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_resolvedpmonth_Click(object sender, EventArgs e)
		{
			int previousmonth = DateTime.Now.Month - 1;
			if (previousmonth == 0)
			{
				previousmonth = 12;
			}
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaintsbystatuswithmonth", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@status", "Resolved");
				myCmd.Parameters.AddWithValue("@month", previousmonth);
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dataGridView1.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_judicialpmonth_Click(object sender, EventArgs e)
		{
			int previousmonth = DateTime.Now.Month - 1;
			if (previousmonth == 0)
			{
				previousmonth = 12;
			}
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaintsbystatuswithmonth", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@status", "Out of Jurisdiction");
				myCmd.Parameters.AddWithValue("@month", previousmonth);
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dataGridView1.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void lbl_new_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaintsbystatuswithmonth", con);
				myCmd.CommandType = CommandType.StoredProcedure;
				myCmd.Parameters.AddWithValue("@status", "Open");
				myCmd.Parameters.AddWithValue("@month", DateTime.Now.Month);
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dataGridView1.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void updateComplaintStatusToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Update_Complaint_Status upsform = new Update_Complaint_Status();
			upsform.Show();
		}

		private void btn_Export_Click(object sender, EventArgs e)
		{


			//Microsoft.Office.Interop.Excel.Application xlApp;
			//Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
			//Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
			//object misValue = System.Reflection.Missing.Value;

			//xlApp = new Microsoft.Office.Interop.Excel.Application();
			//xlWorkBook = xlApp.Workbooks.Add(misValue);
			//xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);


			//for (int x = 1; x < dataGridView1.Columns.Count + 1; x++)
			//{
			//	xlWorkSheet.Cells[1, x] = dataGridView1.Columns[x - 1].HeaderText;
			//}

			//for (int i = 0; i < dataGridView1.Rows.Count; i++)
			//{
			//	for (int j = 0; j < dataGridView1.Columns.Count; j++)
			//	{
			//		xlWorkSheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
			//	}
			//}

			//var saveFileDialoge = new SaveFileDialog();
			//saveFileDialoge.FileName = "ReportView";
			//saveFileDialoge.DefaultExt = ".xlsx";
			//if (saveFileDialoge.ShowDialog() == DialogResult.OK)
			//{
			//	xlWorkBook.SaveAs(saveFileDialoge.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
			//}


			//xlWorkBook.Close(true, misValue, misValue);
			//xlApp.Quit();

			//releaseObject(xlWorkSheet);
			//releaseObject(xlWorkBook);
			//releaseObject(xlApp);



			if (dataGridView1.Rows.Count > 0)
			{
				dataGridView1.SelectAll();
				DataObject copydata = dataGridView1.GetClipboardContent();
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

		//private void releaseObject(object obj)
		//{
		//	try
		//	{
		//		System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
		//		obj = null;
		//	}
		//	catch (Exception ex)
		//	{
		//		obj = null;
		//		MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
		//	}
		//	finally
		//	{
		//		GC.Collect();
		//	}
		//}

		private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			e.Cancel = true;
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dataGridView1.SelectedCells.Count > 0)
			{
				int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
				DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
				string cellValue = Convert.ToString(selectedRow.Cells["complaint_number"].Value);
				id = (cellValue);
			}

			//id = Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
			Image_Form imform = new Image_Form();
			imform.ShowDialog();
		}

		private void lbl_all_Click(object sender, EventArgs e)
		{
			BindGrid(1);
		}

		private void Dashboard_Click(object sender, EventArgs e)
		{
			Button btnPager = (sender as Button);
			this.BindGrid(int.Parse(btnPager.Name));
		}

		private void btn_Refresh_Click(object sender, EventArgs e)
		{
			lbl_currentmonth.Text = getAbbreviatedName(DateTime.Now.Month);
			lbl_previousmonth.Text = getAbbreviatedName(DateTime.Now.Month - 1);

			searchbyid();
			searchbyname();


			cmb_District.SelectedItem = "Select A District.......";
			cmb_Tehsils.SelectedItem = "Select A Tehsil...........";
			getallcomplaintforcurrentmonth();
			getallcomplaintforpreviousmonth();
			getallcomplaintscountbystatuscurrentmonth("In Progress");
			getallcomplaintscountbystatuscurrentmonth("Pending");
			getallcomplaintscountbystatuscurrentmonth("Resolved");
			getallcomplaintscountbystatuscurrentmonth("Out of Jurisdiction");
			getallcomplaintscountbystatuspreviousmonth("In Progress");
			getallcomplaintscountbystatuspreviousmonth("Pending");
			getallcomplaintscountbystatuspreviousmonth("Resolved");
			getallcomplaintscountbystatuspreviousmonth("Out of Jurisdiction");
			Getcurrentmonthnewcomplaints();
			BindGrid(1);
		}

		private void lbl_allpreviousmonth_Click(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaintsswithmonth", con);
				myCmd.CommandType = CommandType.StoredProcedure;

				myCmd.Parameters.AddWithValue("@month", DateTime.Now.Month - 1);
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dataGridView1.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void cmb_searchbyid_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaintsbymobile", con);
				myCmd.CommandType = CommandType.StoredProcedure;

				myCmd.Parameters.AddWithValue("@mobile", cmb_searchbyid.SelectedItem);
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dataGridView1.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				//MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void cmb_searchbyid_TextChanged(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaintsbycomplaint_number", con);
				myCmd.CommandType = CommandType.StoredProcedure;

				myCmd.Parameters.AddWithValue("@complaint_number", cmb_searchbyid.SelectedItem);
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dataGridView1.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				//MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void cmb_searchbyname_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("[Get_Complaintsbyname]", con);
				myCmd.CommandType = CommandType.StoredProcedure;

				myCmd.Parameters.AddWithValue("@name", cmb_searchbyname.SelectedItem);
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dataGridView1.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				//MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void cmb_searchbyname_TextChanged(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("[Get_Complaintsbyname]", con);
				myCmd.CommandType = CommandType.StoredProcedure;

				myCmd.Parameters.AddWithValue("@name", cmb_searchbyname.SelectedItem);
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dataGridView1.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				//	MessageBox.Show("Error while connecting to database!!");
			}
		}

		private void cm_byid_SelectedIndexChanged(object sender, EventArgs e)
		{

			DataTable dt = new DataTable();
			SqlConnection con = new SqlConnection(constring);
			try
			{
				con.Open();
				SqlCommand myCmd = new SqlCommand("Get_Complaintsbycomplaint_number", con);
				myCmd.CommandType = CommandType.StoredProcedure;

				myCmd.Parameters.AddWithValue("@complaint_number", cm_byid.SelectedItem);
				SqlDataAdapter da = new SqlDataAdapter(myCmd);
				da.Fill(dt);
				dataGridView1.DataSource = dt;
				con.Close();
			}
			catch (Exception ex)
			{
				//	MessageBox.Show("Error while connecting to database!!");
			}

		}
	}
}
