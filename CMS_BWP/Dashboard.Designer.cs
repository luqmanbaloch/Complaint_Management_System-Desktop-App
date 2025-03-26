namespace CMS_BWP
{
	partial class Dashboard
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
			Btn_All = new Button();
			btn_New = new Button();
			btn_inprogress = new Button();
			btn_onhold = new Button();
			btn_closed = new Button();
			lbl_all = new Label();
			lbl_inprogress = new Label();
			lbl_pending = new Label();
			lbl_resolved = new Label();
			cmb_District = new ComboBox();
			label2 = new Label();
			label3 = new Label();
			cmb_Tehsils = new ComboBox();
			label1 = new Label();
			groupBox1 = new GroupBox();
			dataGridView1 = new DataGridView();
			lbl_judicial = new Label();
			btn_judicial = new Button();
			menuStrip1 = new MenuStrip();
			dashboardToolStripMenuItem = new ToolStripMenuItem();
			newComplaintToolStripMenuItem = new ToolStripMenuItem();
			tehsilWiseComplaintsToolStripMenuItem = new ToolStripMenuItem();
			updateComplaintStatusToolStripMenuItem = new ToolStripMenuItem();
			updateComplaintToolStripMenuItem = new ToolStripMenuItem();
			registerUserToolStripMenuItem = new ToolStripMenuItem();
			reportAnIssueToolStripMenuItem = new ToolStripMenuItem();
			helpToolStripMenuItem = new ToolStripMenuItem();
			aboutCMSToolStripMenuItem = new ToolStripMenuItem();
			lbl_currentmonth = new Label();
			lbl_previousmonth = new Label();
			lbl_allpreviousmonth = new Label();
			lbl_inprogresspmonth = new Label();
			lbl_prendingpmonth = new Label();
			lbl_resolvedpmonth = new Label();
			lbl_judicialpmonth = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			dt_startdate = new DateTimePicker();
			dateTimePicker1 = new DateTimePicker();
			lbl_new = new Label();
			btn_Export = new Button();
			panel1 = new Panel();
			btn_Refresh = new Button();
			label4 = new Label();
			cmb_searchbyid = new ComboBox();
			cmb_searchbyname = new ComboBox();
			cm_byid = new ComboBox();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// Btn_All
			// 
			Btn_All.BackColor = Color.DarkOrchid;
			Btn_All.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			Btn_All.ForeColor = Color.Black;
			Btn_All.Location = new Point(372, 134);
			Btn_All.Name = "Btn_All";
			Btn_All.Size = new Size(106, 42);
			Btn_All.TabIndex = 1;
			Btn_All.Text = "All";
			Btn_All.UseVisualStyleBackColor = false;
			// 
			// btn_New
			// 
			btn_New.BackColor = Color.MediumSpringGreen;
			btn_New.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			btn_New.ForeColor = Color.Black;
			btn_New.Location = new Point(526, 134);
			btn_New.Name = "btn_New";
			btn_New.Size = new Size(106, 42);
			btn_New.TabIndex = 2;
			btn_New.Text = "New";
			btn_New.UseVisualStyleBackColor = false;
			btn_New.Click += btn_New_Click;
			// 
			// btn_inprogress
			// 
			btn_inprogress.BackColor = Color.DarkTurquoise;
			btn_inprogress.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			btn_inprogress.ForeColor = Color.Black;
			btn_inprogress.Location = new Point(693, 134);
			btn_inprogress.Name = "btn_inprogress";
			btn_inprogress.Size = new Size(179, 42);
			btn_inprogress.TabIndex = 3;
			btn_inprogress.Text = "In Progress";
			btn_inprogress.UseVisualStyleBackColor = false;
			// 
			// btn_onhold
			// 
			btn_onhold.BackColor = Color.Gold;
			btn_onhold.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			btn_onhold.ForeColor = Color.Black;
			btn_onhold.Location = new Point(924, 134);
			btn_onhold.Name = "btn_onhold";
			btn_onhold.Size = new Size(126, 42);
			btn_onhold.TabIndex = 4;
			btn_onhold.Text = "Pending";
			btn_onhold.UseVisualStyleBackColor = false;
			// 
			// btn_closed
			// 
			btn_closed.BackColor = Color.FromArgb(0, 192, 0);
			btn_closed.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			btn_closed.ForeColor = Color.Black;
			btn_closed.Location = new Point(1099, 132);
			btn_closed.Name = "btn_closed";
			btn_closed.Size = new Size(131, 42);
			btn_closed.TabIndex = 5;
			btn_closed.Text = "Resolved";
			btn_closed.UseVisualStyleBackColor = false;
			// 
			// lbl_all
			// 
			lbl_all.AutoSize = true;
			lbl_all.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_all.ForeColor = Color.Black;
			lbl_all.Location = new Point(412, 199);
			lbl_all.Name = "lbl_all";
			lbl_all.Size = new Size(28, 35);
			lbl_all.TabIndex = 6;
			lbl_all.Text = "0";
			lbl_all.Click += lbl_all_Click;
			// 
			// lbl_inprogress
			// 
			lbl_inprogress.AutoSize = true;
			lbl_inprogress.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_inprogress.ForeColor = Color.Black;
			lbl_inprogress.Location = new Point(761, 199);
			lbl_inprogress.Name = "lbl_inprogress";
			lbl_inprogress.Size = new Size(28, 35);
			lbl_inprogress.TabIndex = 8;
			lbl_inprogress.Text = "0";
			lbl_inprogress.Click += lbl_inprogress_Click;
			// 
			// lbl_pending
			// 
			lbl_pending.AutoSize = true;
			lbl_pending.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_pending.ForeColor = Color.Black;
			lbl_pending.Location = new Point(968, 199);
			lbl_pending.Name = "lbl_pending";
			lbl_pending.Size = new Size(28, 35);
			lbl_pending.TabIndex = 9;
			lbl_pending.Text = "0";
			lbl_pending.Click += lbl_pending_Click;
			// 
			// lbl_resolved
			// 
			lbl_resolved.AutoSize = true;
			lbl_resolved.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_resolved.ForeColor = Color.Black;
			lbl_resolved.Location = new Point(1155, 200);
			lbl_resolved.Name = "lbl_resolved";
			lbl_resolved.Size = new Size(28, 35);
			lbl_resolved.TabIndex = 10;
			lbl_resolved.Text = "0";
			lbl_resolved.Click += lbl_resolved_Click;
			// 
			// cmb_District
			// 
			cmb_District.FormattingEnabled = true;
			cmb_District.Items.AddRange(new object[] { "Select A District.......", "Bahawalpur", "Bahawalnagar", "Rahim Yar Khan" });
			cmb_District.Location = new Point(905, 293);
			cmb_District.Name = "cmb_District";
			cmb_District.Size = new Size(163, 28);
			cmb_District.TabIndex = 11;
			cmb_District.SelectedIndexChanged += cmb_District_SelectedIndexChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.Black;
			label2.Location = new Point(812, 295);
			label2.Name = "label2";
			label2.Size = new Size(64, 20);
			label2.TabIndex = 12;
			label2.Text = "District:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = Color.Black;
			label3.Location = new Point(1107, 297);
			label3.Name = "label3";
			label3.Size = new Size(53, 20);
			label3.TabIndex = 14;
			label3.Text = "Tehsil:";
			// 
			// cmb_Tehsils
			// 
			cmb_Tehsils.FormattingEnabled = true;
			cmb_Tehsils.Items.AddRange(new object[] { "Select A Tehsil...........", "Bahawalpur Sadar", "Bahawalpur City", "Ahmed Pur East", "Yazman", "Hasilpur", "Khairpur", "Bahawalnagar", "Chishtian", "Haroonabad", "Minchinabad", "Fortabbas", "Rahim Yar Khan", "Sadiqabad", "Khanpur", "Liaqatpur" });
			cmb_Tehsils.Location = new Point(1194, 293);
			cmb_Tehsils.Name = "cmb_Tehsils";
			cmb_Tehsils.Size = new Size(173, 28);
			cmb_Tehsils.TabIndex = 13;
			cmb_Tehsils.SelectedIndexChanged += cmb_Tehsils_SelectedIndexChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.Black;
			label1.Location = new Point(319, 21);
			label1.Name = "label1";
			label1.Size = new Size(780, 67);
			label1.TabIndex = 0;
			label1.Text = "Complaint Management System";
			// 
			// groupBox1
			// 
			groupBox1.BackColor = Color.DarkSeaGreen;
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new Point(0, 27);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(1442, 101);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Enter += groupBox1_Enter;
			// 
			// dataGridView1
			// 
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView1.ColumnHeadersHeight = 29;
			dataGridView1.GridColor = Color.Black;
			dataGridView1.Location = new Point(2, 339);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(1658, 570);
			dataGridView1.TabIndex = 15;
			dataGridView1.CellBeginEdit += dataGridView1_CellBeginEdit;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
			// 
			// lbl_judicial
			// 
			lbl_judicial.AutoSize = true;
			lbl_judicial.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_judicial.ForeColor = Color.Black;
			lbl_judicial.Location = new Point(1377, 193);
			lbl_judicial.Name = "lbl_judicial";
			lbl_judicial.Size = new Size(28, 35);
			lbl_judicial.TabIndex = 17;
			lbl_judicial.Text = "0";
			lbl_judicial.Click += lbl_judicial_Click;
			// 
			// btn_judicial
			// 
			btn_judicial.BackColor = Color.Crimson;
			btn_judicial.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			btn_judicial.ForeColor = Color.Black;
			btn_judicial.Location = new Point(1267, 134);
			btn_judicial.Name = "btn_judicial";
			btn_judicial.Size = new Size(256, 42);
			btn_judicial.TabIndex = 16;
			btn_judicial.Text = "Out of Jurisdiction";
			btn_judicial.UseVisualStyleBackColor = false;
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(20, 20);
			menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1684, 28);
			menuStrip1.TabIndex = 18;
			menuStrip1.Text = "menuStrip1";
			// 
			// dashboardToolStripMenuItem
			// 
			dashboardToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newComplaintToolStripMenuItem, tehsilWiseComplaintsToolStripMenuItem, updateComplaintStatusToolStripMenuItem, updateComplaintToolStripMenuItem, registerUserToolStripMenuItem, reportAnIssueToolStripMenuItem, helpToolStripMenuItem, aboutCMSToolStripMenuItem });
			dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
			dashboardToolStripMenuItem.Size = new Size(60, 24);
			dashboardToolStripMenuItem.Text = "Menu";
			dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
			// 
			// newComplaintToolStripMenuItem
			// 
			newComplaintToolStripMenuItem.Name = "newComplaintToolStripMenuItem";
			newComplaintToolStripMenuItem.Size = new Size(258, 26);
			newComplaintToolStripMenuItem.Text = "New Complaint";
			newComplaintToolStripMenuItem.Click += newComplaintToolStripMenuItem_Click;
			// 
			// tehsilWiseComplaintsToolStripMenuItem
			// 
			tehsilWiseComplaintsToolStripMenuItem.Name = "tehsilWiseComplaintsToolStripMenuItem";
			tehsilWiseComplaintsToolStripMenuItem.Size = new Size(258, 26);
			tehsilWiseComplaintsToolStripMenuItem.Text = "Tehsil Wise Complaints";
			tehsilWiseComplaintsToolStripMenuItem.Click += tehsilWiseComplaintsToolStripMenuItem_Click;
			// 
			// updateComplaintStatusToolStripMenuItem
			// 
			updateComplaintStatusToolStripMenuItem.Name = "updateComplaintStatusToolStripMenuItem";
			updateComplaintStatusToolStripMenuItem.Size = new Size(258, 26);
			updateComplaintStatusToolStripMenuItem.Text = "Update Complaint Status";
			updateComplaintStatusToolStripMenuItem.Click += updateComplaintStatusToolStripMenuItem_Click;
			// 
			// updateComplaintToolStripMenuItem
			// 
			updateComplaintToolStripMenuItem.Name = "updateComplaintToolStripMenuItem";
			updateComplaintToolStripMenuItem.Size = new Size(258, 26);
			updateComplaintToolStripMenuItem.Text = "Update Complaint";
			updateComplaintToolStripMenuItem.Click += updateComplaintToolStripMenuItem_Click;
			// 
			// registerUserToolStripMenuItem
			// 
			registerUserToolStripMenuItem.Name = "registerUserToolStripMenuItem";
			registerUserToolStripMenuItem.Size = new Size(258, 26);
			registerUserToolStripMenuItem.Text = "Register User";
			registerUserToolStripMenuItem.Click += registerUserToolStripMenuItem_Click;
			// 
			// reportAnIssueToolStripMenuItem
			// 
			reportAnIssueToolStripMenuItem.Name = "reportAnIssueToolStripMenuItem";
			reportAnIssueToolStripMenuItem.Size = new Size(258, 26);
			reportAnIssueToolStripMenuItem.Text = "Report an Issue";
			// 
			// helpToolStripMenuItem
			// 
			helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			helpToolStripMenuItem.Size = new Size(258, 26);
			helpToolStripMenuItem.Text = "Help";
			// 
			// aboutCMSToolStripMenuItem
			// 
			aboutCMSToolStripMenuItem.Name = "aboutCMSToolStripMenuItem";
			aboutCMSToolStripMenuItem.Size = new Size(258, 26);
			aboutCMSToolStripMenuItem.Text = "About CMS";
			// 
			// lbl_currentmonth
			// 
			lbl_currentmonth.AutoSize = true;
			lbl_currentmonth.ForeColor = Color.Black;
			lbl_currentmonth.Location = new Point(352, 211);
			lbl_currentmonth.Name = "lbl_currentmonth";
			lbl_currentmonth.Size = new Size(56, 20);
			lbl_currentmonth.TabIndex = 19;
			lbl_currentmonth.Text = "Month";
			// 
			// lbl_previousmonth
			// 
			lbl_previousmonth.AutoSize = true;
			lbl_previousmonth.ForeColor = Color.Black;
			lbl_previousmonth.Location = new Point(351, 257);
			lbl_previousmonth.Name = "lbl_previousmonth";
			lbl_previousmonth.Size = new Size(56, 20);
			lbl_previousmonth.TabIndex = 20;
			lbl_previousmonth.Text = "Month";
			// 
			// lbl_allpreviousmonth
			// 
			lbl_allpreviousmonth.AutoSize = true;
			lbl_allpreviousmonth.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_allpreviousmonth.ForeColor = Color.Black;
			lbl_allpreviousmonth.Location = new Point(411, 250);
			lbl_allpreviousmonth.Name = "lbl_allpreviousmonth";
			lbl_allpreviousmonth.Size = new Size(28, 35);
			lbl_allpreviousmonth.TabIndex = 21;
			lbl_allpreviousmonth.Text = "0";
			lbl_allpreviousmonth.Click += lbl_allpreviousmonth_Click;
			// 
			// lbl_inprogresspmonth
			// 
			lbl_inprogresspmonth.AutoSize = true;
			lbl_inprogresspmonth.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_inprogresspmonth.ForeColor = Color.Black;
			lbl_inprogresspmonth.Location = new Point(758, 250);
			lbl_inprogresspmonth.Name = "lbl_inprogresspmonth";
			lbl_inprogresspmonth.Size = new Size(28, 35);
			lbl_inprogresspmonth.TabIndex = 22;
			lbl_inprogresspmonth.Text = "0";
			lbl_inprogresspmonth.Click += lbl_inprogresspmonth_Click;
			// 
			// lbl_prendingpmonth
			// 
			lbl_prendingpmonth.AutoSize = true;
			lbl_prendingpmonth.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_prendingpmonth.ForeColor = Color.Black;
			lbl_prendingpmonth.Location = new Point(968, 252);
			lbl_prendingpmonth.Name = "lbl_prendingpmonth";
			lbl_prendingpmonth.Size = new Size(28, 35);
			lbl_prendingpmonth.TabIndex = 23;
			lbl_prendingpmonth.Text = "0";
			lbl_prendingpmonth.Click += lbl_prendingpmonth_Click;
			// 
			// lbl_resolvedpmonth
			// 
			lbl_resolvedpmonth.AutoSize = true;
			lbl_resolvedpmonth.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_resolvedpmonth.ForeColor = Color.Black;
			lbl_resolvedpmonth.Location = new Point(1156, 251);
			lbl_resolvedpmonth.Name = "lbl_resolvedpmonth";
			lbl_resolvedpmonth.Size = new Size(28, 35);
			lbl_resolvedpmonth.TabIndex = 24;
			lbl_resolvedpmonth.Text = "0";
			lbl_resolvedpmonth.Click += lbl_resolvedpmonth_Click;
			// 
			// lbl_judicialpmonth
			// 
			lbl_judicialpmonth.AutoSize = true;
			lbl_judicialpmonth.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_judicialpmonth.ForeColor = Color.Black;
			lbl_judicialpmonth.Location = new Point(1380, 254);
			lbl_judicialpmonth.Name = "lbl_judicialpmonth";
			lbl_judicialpmonth.Size = new Size(28, 35);
			lbl_judicialpmonth.TabIndex = 25;
			lbl_judicialpmonth.Text = "0";
			lbl_judicialpmonth.Click += lbl_judicialpmonth_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(35, 230);
			label5.Name = "label5";
			label5.Size = new Size(1953, 20);
			label5.TabIndex = 26;
			label5.Text = resources.GetString("label5.Text");
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label6.ForeColor = Color.Black;
			label6.Location = new Point(4, 293);
			label6.Name = "label6";
			label6.Size = new Size(84, 20);
			label6.TabIndex = 28;
			label6.Text = "Start Date:";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label7.ForeColor = Color.Black;
			label7.Location = new Point(356, 294);
			label7.Name = "label7";
			label7.Size = new Size(76, 20);
			label7.TabIndex = 30;
			label7.Text = "End Date:";
			// 
			// dt_startdate
			// 
			dt_startdate.Location = new Point(91, 289);
			dt_startdate.Name = "dt_startdate";
			dt_startdate.Size = new Size(256, 27);
			dt_startdate.TabIndex = 31;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(467, 291);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(309, 27);
			dateTimePicker1.TabIndex = 32;
			dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
			// 
			// lbl_new
			// 
			lbl_new.AutoSize = true;
			lbl_new.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_new.ForeColor = Color.Black;
			lbl_new.Location = new Point(564, 199);
			lbl_new.Name = "lbl_new";
			lbl_new.Size = new Size(28, 35);
			lbl_new.TabIndex = 7;
			lbl_new.Text = "0";
			lbl_new.Click += lbl_new_Click;
			// 
			// btn_Export
			// 
			btn_Export.BackColor = Color.FromArgb(128, 128, 255);
			btn_Export.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			btn_Export.ForeColor = Color.Black;
			btn_Export.Location = new Point(1449, 285);
			btn_Export.Name = "btn_Export";
			btn_Export.Size = new Size(111, 42);
			btn_Export.TabIndex = 33;
			btn_Export.Text = "Export Data";
			btn_Export.UseVisualStyleBackColor = false;
			btn_Export.Click += btn_Export_Click;
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(224, 224, 224);
			panel1.Location = new Point(196, 907);
			panel1.Name = "panel1";
			panel1.Size = new Size(1074, 76);
			panel1.TabIndex = 34;
			// 
			// btn_Refresh
			// 
			btn_Refresh.BackColor = Color.MediumSpringGreen;
			btn_Refresh.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			btn_Refresh.ForeColor = Color.Black;
			btn_Refresh.Location = new Point(184, 132);
			btn_Refresh.Name = "btn_Refresh";
			btn_Refresh.Size = new Size(138, 42);
			btn_Refresh.TabIndex = 35;
			btn_Refresh.Text = "Refresh";
			btn_Refresh.UseVisualStyleBackColor = false;
			btn_Refresh.Click += btn_Refresh_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(14, 134);
			label4.Name = "label4";
			label4.Size = new Size(55, 20);
			label4.TabIndex = 36;
			label4.Text = "Search";
			// 
			// cmb_searchbyid
			// 
			cmb_searchbyid.FormattingEnabled = true;
			cmb_searchbyid.Location = new Point(12, 157);
			cmb_searchbyid.Name = "cmb_searchbyid";
			cmb_searchbyid.Size = new Size(158, 28);
			cmb_searchbyid.TabIndex = 37;
			cmb_searchbyid.Text = "By Mobile #";
			cmb_searchbyid.SelectedIndexChanged += cmb_searchbyid_SelectedIndexChanged;
			cmb_searchbyid.TextChanged += cmb_searchbyid_TextChanged;
			// 
			// cmb_searchbyname
			// 
			cmb_searchbyname.FormattingEnabled = true;
			cmb_searchbyname.Location = new Point(12, 203);
			cmb_searchbyname.Name = "cmb_searchbyname";
			cmb_searchbyname.Size = new Size(158, 28);
			cmb_searchbyname.TabIndex = 38;
			cmb_searchbyname.Text = "By Name";
			cmb_searchbyname.SelectedIndexChanged += cmb_searchbyname_SelectedIndexChanged;
			cmb_searchbyname.TextChanged += cmb_searchbyname_TextChanged;
			// 
			// cm_byid
			// 
			cm_byid.FormattingEnabled = true;
			cm_byid.Location = new Point(8, 255);
			cm_byid.Name = "cm_byid";
			cm_byid.Size = new Size(158, 28);
			cm_byid.TabIndex = 39;
			cm_byid.Text = "By Complaint No.";
			cm_byid.SelectedIndexChanged += cm_byid_SelectedIndexChanged;
			// 
			// Dashboard
			// 
			AutoScaleDimensions = new SizeF(9F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			BackColor = Color.DarkSeaGreen;
			ClientSize = new Size(1684, 721);
			Controls.Add(cm_byid);
			Controls.Add(cmb_searchbyname);
			Controls.Add(cmb_searchbyid);
			Controls.Add(label4);
			Controls.Add(btn_Refresh);
			Controls.Add(panel1);
			Controls.Add(btn_Export);
			Controls.Add(dateTimePicker1);
			Controls.Add(dt_startdate);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(lbl_judicialpmonth);
			Controls.Add(lbl_resolvedpmonth);
			Controls.Add(lbl_prendingpmonth);
			Controls.Add(lbl_inprogresspmonth);
			Controls.Add(lbl_allpreviousmonth);
			Controls.Add(lbl_previousmonth);
			Controls.Add(lbl_currentmonth);
			Controls.Add(lbl_judicial);
			Controls.Add(btn_judicial);
			Controls.Add(dataGridView1);
			Controls.Add(label3);
			Controls.Add(cmb_Tehsils);
			Controls.Add(label2);
			Controls.Add(cmb_District);
			Controls.Add(lbl_resolved);
			Controls.Add(lbl_pending);
			Controls.Add(lbl_inprogress);
			Controls.Add(lbl_new);
			Controls.Add(lbl_all);
			Controls.Add(btn_closed);
			Controls.Add(btn_onhold);
			Controls.Add(btn_inprogress);
			Controls.Add(btn_New);
			Controls.Add(Btn_All);
			Controls.Add(groupBox1);
			Controls.Add(menuStrip1);
			Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
			ForeColor = Color.Black;
			MainMenuStrip = menuStrip1;
			Name = "Dashboard";
			WindowState = FormWindowState.Maximized;
			Load += Dashboard_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button Btn_All;
		private Button btn_New;
		private Button btn_inprogress;
		private Button btn_onhold;
		private Button btn_closed;
		private Label lbl_all;
		private Label lbl_inprogress;
		private Label lbl_pending;
		private Label lbl_resolved;
		private ComboBox cmb_District;
		private Label label2;
		private Label label3;
		private ComboBox cmb_Tehsils;
		private Label label1;
		private GroupBox groupBox1;
		private DataGridView dataGridView1;
		private Label lbl_judicial;
		private Button btn_judicial;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem dashboardToolStripMenuItem;
		private ToolStripMenuItem newComplaintToolStripMenuItem;
		private ToolStripMenuItem tehsilWiseComplaintsToolStripMenuItem;
		private ToolStripMenuItem updateComplaintStatusToolStripMenuItem;
		private ToolStripMenuItem updateComplaintToolStripMenuItem;
		private ToolStripMenuItem registerUserToolStripMenuItem;
		private ToolStripMenuItem reportAnIssueToolStripMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem;
		private ToolStripMenuItem aboutCMSToolStripMenuItem;
		private Label lbl_currentmonth;
		private Label lbl_previousmonth;
		private Label lbl_allpreviousmonth;
		private Label lbl_inprogresspmonth;
		private Label lbl_prendingpmonth;
		private Label lbl_resolvedpmonth;
		private Label lbl_judicialpmonth;
		private Label label5;
		private Label label6;
		private Label label7;
		private DateTimePicker dt_startdate;
		private DateTimePicker dateTimePicker1;
		private Label lbl_new;
		private Button btn_Export;
		private Panel panel1;
		private Button btn_Refresh;
		private Label label4;
		private ComboBox cmb_searchbyid;
		private ComboBox cmb_searchbyname;
		private ComboBox cm_byid;
	}
}