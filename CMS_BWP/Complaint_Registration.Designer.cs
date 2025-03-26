namespace CMS_BWP
{
	partial class Complaint_Registration
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
			label1 = new Label();
			txt_name = new TextBox();
			txt_mobile = new TextBox();
			label3 = new Label();
			txt_adress = new TextBox();
			label4 = new Label();
			comboBox1 = new ComboBox();
			label5 = new Label();
			label6 = new Label();
			cmb_district = new ComboBox();
			label7 = new Label();
			cmb_Tehsil = new ComboBox();
			btn_Register = new Button();
			btn_cancel = new Button();
			label2 = new Label();
			cmb_uc = new ComboBox();
			label9 = new Label();
			cmb_complaintype = new ComboBox();
			txt_complaintno = new TextBox();
			label8 = new Label();
			label10 = new Label();
			cmb_zone = new ComboBox();
			label11 = new Label();
			ps_type = new ComboBox();
			saveFileDialog1 = new SaveFileDialog();
			openFileDialog1 = new OpenFileDialog();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(811, 125);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(188, 25);
			label1.TabIndex = 0;
			label1.Text = "Complainant Name:";
			// 
			// txt_name
			// 
			txt_name.Location = new Point(1059, 125);
			txt_name.Margin = new Padding(4);
			txt_name.Name = "txt_name";
			txt_name.Size = new Size(428, 32);
			txt_name.TabIndex = 1;
			// 
			// txt_mobile
			// 
			txt_mobile.Location = new Point(1063, 206);
			txt_mobile.Margin = new Padding(4);
			txt_mobile.MaxLength = 11;
			txt_mobile.Name = "txt_mobile";
			txt_mobile.PlaceholderText = "Enter 11 Digit Mobile Number";
			txt_mobile.Size = new Size(428, 32);
			txt_mobile.TabIndex = 3;
			txt_mobile.KeyPress += txt_mobile_KeyPress;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(815, 206);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(209, 25);
			label3.TabIndex = 4;
			label3.Text = "Complainant Mobile#:";
			// 
			// txt_adress
			// 
			txt_adress.Location = new Point(351, 202);
			txt_adress.Margin = new Padding(4);
			txt_adress.Name = "txt_adress";
			txt_adress.Size = new Size(428, 32);
			txt_adress.TabIndex = 2;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(103, 202);
			label4.Margin = new Padding(4, 0, 4, 0);
			label4.Name = "label4";
			label4.Size = new Size(207, 25);
			label4.TabIndex = 6;
			label4.Text = "Complainant Address:";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Items.AddRange(new object[] { "Bahawalpur" });
			comboBox1.Location = new Point(351, 279);
			comboBox1.Margin = new Padding(4);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(428, 33);
			comboBox1.TabIndex = 4;
			comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(103, 279);
			label5.Margin = new Padding(4, 0, 4, 0);
			label5.Name = "label5";
			label5.Size = new Size(88, 25);
			label5.TabIndex = 9;
			label5.Text = "Division:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(811, 288);
			label6.Margin = new Padding(4, 0, 4, 0);
			label6.Name = "label6";
			label6.Size = new Size(80, 25);
			label6.TabIndex = 11;
			label6.Text = "District:";
			// 
			// cmb_district
			// 
			cmb_district.FormattingEnabled = true;
			cmb_district.Items.AddRange(new object[] { "Please Select District.....................", "Bahawalpur", "Bahawalnagar", "Rahim Yar Khan" });
			cmb_district.Location = new Point(1059, 288);
			cmb_district.Margin = new Padding(4);
			cmb_district.Name = "cmb_district";
			cmb_district.Size = new Size(428, 33);
			cmb_district.TabIndex = 5;
			cmb_district.SelectedIndexChanged += cmb_district_SelectedIndexChanged;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(103, 359);
			label7.Margin = new Padding(4, 0, 4, 0);
			label7.Name = "label7";
			label7.Size = new Size(65, 25);
			label7.TabIndex = 13;
			label7.Text = "Tehsil:";
			// 
			// cmb_Tehsil
			// 
			cmb_Tehsil.FormattingEnabled = true;
			cmb_Tehsil.Items.AddRange(new object[] { "Bahawalpur Sadar", "Bahawalpur City", "Ahmed Pur East", "Yazman", "Hasilpur", "Khairpur", "Bahawalnagar", "Chishtian", "Minchinabad", "Haroonabad", "Fortabbas", "Rahim Yar Khan", "Sadiqabad", "Khanpur", "Liaqatpur" });
			cmb_Tehsil.Location = new Point(351, 359);
			cmb_Tehsil.Margin = new Padding(4);
			cmb_Tehsil.Name = "cmb_Tehsil";
			cmb_Tehsil.Size = new Size(428, 33);
			cmb_Tehsil.TabIndex = 6;
			cmb_Tehsil.SelectedIndexChanged += cmb_Tehsil_SelectedIndexChanged;
			// 
			// btn_Register
			// 
			btn_Register.BackColor = Color.SteelBlue;
			btn_Register.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			btn_Register.Location = new Point(506, 631);
			btn_Register.Margin = new Padding(4);
			btn_Register.Name = "btn_Register";
			btn_Register.Size = new Size(242, 61);
			btn_Register.TabIndex = 11;
			btn_Register.Text = "Register";
			btn_Register.UseVisualStyleBackColor = false;
			btn_Register.Click += btn_Register_Click;
			// 
			// btn_cancel
			// 
			btn_cancel.BackColor = Color.Red;
			btn_cancel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
			btn_cancel.Location = new Point(855, 631);
			btn_cancel.Margin = new Padding(4);
			btn_cancel.Name = "btn_cancel";
			btn_cancel.Size = new Size(242, 61);
			btn_cancel.TabIndex = 12;
			btn_cancel.Text = "Cancel";
			btn_cancel.UseVisualStyleBackColor = false;
			btn_cancel.Click += btn_cancel_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(103, 428);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(144, 25);
			label2.TabIndex = 19;
			label2.Text = "Union Council:";
			// 
			// cmb_uc
			// 
			cmb_uc.FormattingEnabled = true;
			cmb_uc.Location = new Point(351, 428);
			cmb_uc.Margin = new Padding(4);
			cmb_uc.Name = "cmb_uc";
			cmb_uc.Size = new Size(428, 33);
			cmb_uc.TabIndex = 8;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(811, 428);
			label9.Margin = new Padding(4, 0, 4, 0);
			label9.Name = "label9";
			label9.Size = new Size(156, 25);
			label9.TabIndex = 21;
			label9.Text = "Complaint Type:";
			// 
			// cmb_complaintype
			// 
			cmb_complaintype.FormattingEnabled = true;
			cmb_complaintype.Items.AddRange(new object[] { "Please Select an Option.....", "Primary", "Secondary" });
			cmb_complaintype.Location = new Point(1059, 428);
			cmb_complaintype.Margin = new Padding(4);
			cmb_complaintype.Name = "cmb_complaintype";
			cmb_complaintype.Size = new Size(428, 33);
			cmb_complaintype.TabIndex = 9;
			cmb_complaintype.SelectedIndexChanged += cmb_complaintype_SelectedIndexChanged;
			// 
			// txt_complaintno
			// 
			txt_complaintno.Location = new Point(351, 125);
			txt_complaintno.Margin = new Padding(4);
			txt_complaintno.Name = "txt_complaintno";
			txt_complaintno.Size = new Size(428, 32);
			txt_complaintno.TabIndex = 0;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(103, 125);
			label8.Margin = new Padding(4, 0, 4, 0);
			label8.Name = "label8";
			label8.Size = new Size(189, 25);
			label8.TabIndex = 23;
			label8.Text = "Complaint Number:";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(811, 359);
			label10.Margin = new Padding(4, 0, 4, 0);
			label10.Name = "label10";
			label10.Size = new Size(63, 25);
			label10.TabIndex = 26;
			label10.Text = "Zone:";
			// 
			// cmb_zone
			// 
			cmb_zone.FormattingEnabled = true;
			cmb_zone.Items.AddRange(new object[] { "Please Select Zone......", "Zone-I", "Zone-II", "Zone-III" });
			cmb_zone.Location = new Point(1059, 359);
			cmb_zone.Margin = new Padding(4);
			cmb_zone.Name = "cmb_zone";
			cmb_zone.Size = new Size(428, 33);
			cmb_zone.TabIndex = 7;
			cmb_zone.SelectedIndexChanged += cmb_zone_SelectedIndexChanged;
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new Point(103, 510);
			label11.Margin = new Padding(4, 0, 4, 0);
			label11.Name = "label11";
			label11.Size = new Size(238, 25);
			label11.TabIndex = 28;
			label11.Text = "Primary/Secondary Type:";
			// 
			// ps_type
			// 
			ps_type.FormattingEnabled = true;
			ps_type.Location = new Point(351, 510);
			ps_type.Margin = new Padding(4);
			ps_type.Name = "ps_type";
			ps_type.Size = new Size(428, 33);
			ps_type.TabIndex = 10;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			// 
			// Complaint_Registration
			// 
			AcceptButton = btn_Register;
			AutoScaleDimensions = new SizeF(11F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			CancelButton = btn_cancel;
			ClientSize = new Size(1687, 1055);
			Controls.Add(label11);
			Controls.Add(ps_type);
			Controls.Add(label10);
			Controls.Add(cmb_zone);
			Controls.Add(txt_complaintno);
			Controls.Add(label8);
			Controls.Add(label9);
			Controls.Add(cmb_complaintype);
			Controls.Add(label2);
			Controls.Add(cmb_uc);
			Controls.Add(btn_cancel);
			Controls.Add(btn_Register);
			Controls.Add(label7);
			Controls.Add(cmb_Tehsil);
			Controls.Add(label6);
			Controls.Add(cmb_district);
			Controls.Add(label5);
			Controls.Add(comboBox1);
			Controls.Add(txt_adress);
			Controls.Add(label4);
			Controls.Add(txt_mobile);
			Controls.Add(label3);
			Controls.Add(txt_name);
			Controls.Add(label1);
			Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
			ForeColor = SystemColors.ActiveCaptionText;
			Margin = new Padding(4);
			Name = "Complaint_Registration";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Register Complaint";
			WindowState = FormWindowState.Maximized;
			Load += Complaint_Registration_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txt_name;
		private TextBox txt_mobile;
		private Label label3;
		private TextBox txt_adress;
		private Label label4;
		private ComboBox comboBox1;
		private Label label5;
		private Label label6;
		private ComboBox cmb_district;
		private Label label7;
		private ComboBox cmb_Tehsil;
		private Button btn_Register;
		private Button btn_cancel;
		private Label label2;
		private ComboBox cmb_uc;
		private Label label9;
		private ComboBox cmb_complaintype;
		private TextBox txt_complaintno;
		private Label label8;
		private Label label10;
		private ComboBox cmb_zone;
		private Label label11;
		private ComboBox ps_type;
		private SaveFileDialog saveFileDialog1;
		private OpenFileDialog openFileDialog1;
	}
}