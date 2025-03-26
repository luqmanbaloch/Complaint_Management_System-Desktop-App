namespace CMS_BWP
{
	partial class Update_Complaint
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
			btn_cancel = new Button();
			btn_Update = new Button();
			label11 = new Label();
			ps_type = new ComboBox();
			label10 = new Label();
			cmb_zone = new ComboBox();
			label8 = new Label();
			label9 = new Label();
			cmb_complaintype = new ComboBox();
			label2 = new Label();
			cmb_uc = new ComboBox();
			label7 = new Label();
			cmb_Tehsil = new ComboBox();
			label6 = new Label();
			cmb_district = new ComboBox();
			label5 = new Label();
			cmb_division = new ComboBox();
			txt_adress = new TextBox();
			label4 = new Label();
			txt_mobile = new TextBox();
			label3 = new Label();
			txt_name = new TextBox();
			label1 = new Label();
			cmb_complaintnumber = new ComboBox();
			label13 = new Label();
			cmb_complaintstatus = new ComboBox();
			label12 = new Label();
			txt_remarks = new TextBox();
			lbl_complaintid = new Label();
			SuspendLayout();
			// 
			// btn_cancel
			// 
			btn_cancel.BackColor = Color.FromArgb(192, 0, 0);
			btn_cancel.Location = new Point(851, 712);
			btn_cancel.Margin = new Padding(6, 5, 6, 5);
			btn_cancel.Name = "btn_cancel";
			btn_cancel.Size = new Size(270, 90);
			btn_cancel.TabIndex = 9;
			btn_cancel.Text = "Cancel";
			btn_cancel.UseVisualStyleBackColor = false;
			btn_cancel.Click += btn_cancel_Click;
			// 
			// btn_Update
			// 
			btn_Update.BackColor = Color.LightSeaGreen;
			btn_Update.Location = new Point(556, 712);
			btn_Update.Margin = new Padding(6, 5, 6, 5);
			btn_Update.Name = "btn_Update";
			btn_Update.Size = new Size(254, 90);
			btn_Update.TabIndex = 8;
			btn_Update.Text = "Update";
			btn_Update.UseVisualStyleBackColor = false;
			btn_Update.Click += btn_Update_Click;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(780, 456);
			label11.Margin = new Padding(4, 0, 4, 0);
			label11.Name = "label11";
			label11.Size = new Size(172, 20);
			label11.TabIndex = 51;
			label11.Text = "Primary/Secondary Type:";
			// 
			// ps_type
			// 
			ps_type.FormattingEnabled = true;
			ps_type.Items.AddRange(new object[] { "P1", "P2", "P3", "P4", "P5", "P6", "P7", "P8", "P9", "P10", "P11", "S1", "S2", "S3", "S4", "S5", "S6" });
			ps_type.Location = new Point(1028, 456);
			ps_type.Margin = new Padding(4);
			ps_type.Name = "ps_type";
			ps_type.Size = new Size(428, 28);
			ps_type.TabIndex = 50;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(780, 316);
			label10.Margin = new Padding(4, 0, 4, 0);
			label10.Name = "label10";
			label10.Size = new Size(46, 20);
			label10.TabIndex = 49;
			label10.Text = "Zone:";
			// 
			// cmb_zone
			// 
			cmb_zone.FormattingEnabled = true;
			cmb_zone.Items.AddRange(new object[] { "Please Select Zone......", "Zone-I", "Zone-II", "Zone-III" });
			cmb_zone.Location = new Point(1028, 316);
			cmb_zone.Margin = new Padding(4);
			cmb_zone.Name = "cmb_zone";
			cmb_zone.Size = new Size(428, 28);
			cmb_zone.TabIndex = 48;
			cmb_zone.SelectedIndexChanged += cmb_zone_SelectedIndexChanged;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(72, 82);
			label8.Margin = new Padding(4, 0, 4, 0);
			label8.Name = "label8";
			label8.Size = new Size(139, 20);
			label8.TabIndex = 46;
			label8.Text = "Complaint Number:";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(780, 385);
			label9.Margin = new Padding(4, 0, 4, 0);
			label9.Name = "label9";
			label9.Size = new Size(116, 20);
			label9.TabIndex = 45;
			label9.Text = "Complaint Type:";
			// 
			// cmb_complaintype
			// 
			cmb_complaintype.FormattingEnabled = true;
			cmb_complaintype.Items.AddRange(new object[] { "Please Select an Option.....", "Primary", "Secondary" });
			cmb_complaintype.Location = new Point(1028, 385);
			cmb_complaintype.Margin = new Padding(4);
			cmb_complaintype.Name = "cmb_complaintype";
			cmb_complaintype.Size = new Size(428, 28);
			cmb_complaintype.TabIndex = 44;
			cmb_complaintype.SelectedIndexChanged += cmb_complaintype_SelectedIndexChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(72, 385);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(104, 20);
			label2.TabIndex = 43;
			label2.Text = "Union Council:";
			// 
			// cmb_uc
			// 
			cmb_uc.FormattingEnabled = true;
			cmb_uc.Items.AddRange(new object[] { "12", "13-A", "13-B", "14-A", "14-B", "15-A", "15-B", "16-A", "16-B", "17", "19-A", "19-B", "18-A", "18-B", "1-A", "1-B", "2", "3-A", "3-B", "4-A", "4-B", "5-A", "5-B", "11-A", "11-B", "10-A", "10-B", "7", "9", "8-A", "8-B" });
			cmb_uc.Location = new Point(320, 385);
			cmb_uc.Margin = new Padding(4);
			cmb_uc.Name = "cmb_uc";
			cmb_uc.Size = new Size(428, 28);
			cmb_uc.TabIndex = 42;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(72, 316);
			label7.Margin = new Padding(4, 0, 4, 0);
			label7.Name = "label7";
			label7.Size = new Size(49, 20);
			label7.TabIndex = 41;
			label7.Text = "Tehsil:";
			// 
			// cmb_Tehsil
			// 
			cmb_Tehsil.FormattingEnabled = true;
			cmb_Tehsil.Items.AddRange(new object[] { "Bahawalpur Sadar", "Bahawalpur City", "Ahmed Pur East", "Yazman", "Hasilpur", "Khairpur", "Bahawalnagar", "Chishtian", "Haroonabad", "Minchinabad", "Fortabbas", "Rahim Yar Khan", "Sadiqabad", "Khanpur", "Liaqatpur" });
			cmb_Tehsil.Location = new Point(320, 316);
			cmb_Tehsil.Margin = new Padding(4);
			cmb_Tehsil.Name = "cmb_Tehsil";
			cmb_Tehsil.Size = new Size(428, 28);
			cmb_Tehsil.TabIndex = 40;
			cmb_Tehsil.SelectedIndexChanged += cmb_Tehsil_SelectedIndexChanged;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(780, 245);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(59, 20);
			label6.TabIndex = 39;
			label6.Text = "District:";
			// 
			// cmb_district
			// 
			cmb_district.FormattingEnabled = true;
			cmb_district.Items.AddRange(new object[] { "Please Select District.....................", "Bahawalpur", "Bahawalnagar", "Rahim Yar Khan" });
			cmb_district.Location = new Point(1028, 245);
			cmb_district.Margin = new Padding(4);
			cmb_district.Name = "cmb_district";
			cmb_district.Size = new Size(428, 28);
			cmb_district.TabIndex = 38;
			cmb_district.SelectedIndexChanged += cmb_district_SelectedIndexChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(72, 236);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(65, 20);
			label5.TabIndex = 37;
			label5.Text = "Division:";
			// 
			// cmb_division
			// 
			cmb_division.FormattingEnabled = true;
			cmb_division.Items.AddRange(new object[] { "Bahawalpur" });
			cmb_division.Location = new Point(320, 236);
			cmb_division.Margin = new Padding(4);
			cmb_division.Name = "cmb_division";
			cmb_division.Size = new Size(428, 28);
			cmb_division.TabIndex = 36;
			// 
			// txt_adress
			// 
			txt_adress.Location = new Point(1028, 160);
			txt_adress.Margin = new Padding(4);
			txt_adress.Name = "txt_adress";
			txt_adress.Size = new Size(428, 27);
			txt_adress.TabIndex = 35;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(780, 160);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(154, 20);
			label4.TabIndex = 34;
			label4.Text = "Complainant Address:";
			// 
			// txt_mobile
			// 
			txt_mobile.Location = new Point(320, 163);
			txt_mobile.Margin = new Padding(4);
			txt_mobile.Name = "txt_mobile";
			txt_mobile.Size = new Size(428, 27);
			txt_mobile.TabIndex = 33;
			txt_mobile.KeyPress += txt_mobile_KeyPress;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(72, 163);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(157, 20);
			label3.TabIndex = 32;
			label3.Text = "Complainant Mobile#:";
			// 
			// txt_name
			// 
			txt_name.Location = new Point(1028, 82);
			txt_name.Margin = new Padding(4);
			txt_name.Name = "txt_name";
			txt_name.Size = new Size(428, 27);
			txt_name.TabIndex = 31;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(780, 82);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(141, 20);
			label1.TabIndex = 30;
			label1.Text = "Complainant Name:";
			// 
			// cmb_complaintnumber
			// 
			cmb_complaintnumber.FormattingEnabled = true;
			cmb_complaintnumber.Location = new Point(320, 79);
			cmb_complaintnumber.Name = "cmb_complaintnumber";
			cmb_complaintnumber.Size = new Size(428, 28);
			cmb_complaintnumber.TabIndex = 53;
			cmb_complaintnumber.SelectedIndexChanged += cmb_complaintnumber_SelectedIndexChanged;
			cmb_complaintnumber.TextUpdate += cmb_complaintnumber_TextUpdate;
			cmb_complaintnumber.TextChanged += cmb_complaintnumber_TextChanged;
			cmb_complaintnumber.KeyUp += cmb_complaintnumber_KeyUp;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(72, 456);
			label13.Margin = new Padding(4, 0, 4, 0);
			label13.Name = "label13";
			label13.Size = new Size(125, 20);
			label13.TabIndex = 55;
			label13.Text = "Complaint Status:";
			// 
			// cmb_complaintstatus
			// 
			cmb_complaintstatus.FormattingEnabled = true;
			cmb_complaintstatus.Items.AddRange(new object[] { "Open", "In Progress", "Pending", "Resolved", "Out of Jurisdiction" });
			cmb_complaintstatus.Location = new Point(320, 456);
			cmb_complaintstatus.Margin = new Padding(4);
			cmb_complaintstatus.Name = "cmb_complaintstatus";
			cmb_complaintstatus.Size = new Size(428, 28);
			cmb_complaintstatus.TabIndex = 54;
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new Point(72, 514);
			label12.Margin = new Padding(4, 0, 4, 0);
			label12.Name = "label12";
			label12.Size = new Size(68, 20);
			label12.TabIndex = 56;
			label12.Text = "Remarks:";
			// 
			// txt_remarks
			// 
			txt_remarks.Location = new Point(320, 514);
			txt_remarks.Multiline = true;
			txt_remarks.Name = "txt_remarks";
			txt_remarks.Size = new Size(1136, 125);
			txt_remarks.TabIndex = 57;
			// 
			// lbl_complaintid
			// 
			lbl_complaintid.AutoSize = true;
			lbl_complaintid.Location = new Point(752, 23);
			lbl_complaintid.Name = "lbl_complaintid";
			lbl_complaintid.Size = new Size(95, 20);
			lbl_complaintid.TabIndex = 58;
			lbl_complaintid.Text = "complaint_id";
			// 
			// Update_Complaint
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1871, 830);
			Controls.Add(lbl_complaintid);
			Controls.Add(txt_remarks);
			Controls.Add(label12);
			Controls.Add(label13);
			Controls.Add(cmb_complaintstatus);
			Controls.Add(cmb_complaintnumber);
			Controls.Add(label11);
			Controls.Add(ps_type);
			Controls.Add(label10);
			Controls.Add(cmb_zone);
			Controls.Add(label8);
			Controls.Add(label9);
			Controls.Add(cmb_complaintype);
			Controls.Add(label2);
			Controls.Add(cmb_uc);
			Controls.Add(label7);
			Controls.Add(cmb_Tehsil);
			Controls.Add(label6);
			Controls.Add(cmb_district);
			Controls.Add(label5);
			Controls.Add(cmb_division);
			Controls.Add(txt_adress);
			Controls.Add(label4);
			Controls.Add(txt_mobile);
			Controls.Add(label3);
			Controls.Add(txt_name);
			Controls.Add(label1);
			Controls.Add(btn_cancel);
			Controls.Add(btn_Update);
			Name = "Update_Complaint";
			Text = "Update_Complaint";
			WindowState = FormWindowState.Maximized;
			Load += Update_Complaint_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btn_cancel;
		private Button btn_Update;
		private Label label11;
		private ComboBox ps_type;
		private Label label10;
		private ComboBox cmb_zone;
		private Label label8;
		private Label label9;
		private ComboBox cmb_complaintype;
		private Label label2;
		private ComboBox cmb_uc;
		private Label label7;
		private ComboBox cmb_Tehsil;
		private Label label6;
		private ComboBox cmb_district;
		private Label label5;
		private ComboBox cmb_division;
		private TextBox txt_adress;
		private Label label4;
		private TextBox txt_mobile;
		private Label label3;
		private TextBox txt_name;
		private Label label1;
		private ComboBox cmb_complaintnumber;
		private Label label13;
		private ComboBox cmb_complaintstatus;
		private Label label12;
		private TextBox txt_remarks;
		private Label lbl_complaintid;
	}
}