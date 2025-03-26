namespace CMS_BWP
{
	partial class Update_Complaint_Status
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
			cmb_complaintnumber = new ComboBox();
			label8 = new Label();
			btn_cancel = new Button();
			btn_Update = new Button();
			label13 = new Label();
			cmb_complaintstatus = new ComboBox();
			btn_browse = new Button();
			txt_selected_file = new TextBox();
			openFileDialog1 = new OpenFileDialog();
			pictureBox1 = new PictureBox();
			lbl_filepath = new Label();
			pictureBox2 = new PictureBox();
			btn_Browse2 = new Button();
			label1 = new Label();
			txt_fileafter = new TextBox();
			lbl_remarks = new Label();
			txt_remarks = new TextBox();
			lbl_complaintid = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// cmb_complaintnumber
			// 
			cmb_complaintnumber.FormattingEnabled = true;
			cmb_complaintnumber.Location = new Point(597, 275);
			cmb_complaintnumber.Name = "cmb_complaintnumber";
			cmb_complaintnumber.Size = new Size(428, 28);
			cmb_complaintnumber.TabIndex = 0;
			cmb_complaintnumber.SelectedIndexChanged += cmb_complaintnumber_SelectedIndexChanged;
			cmb_complaintnumber.TextChanged += cmb_complaintnumber_TextChanged;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(349, 278);
			label8.Margin = new Padding(4, 0, 4, 0);
			label8.Name = "label8";
			label8.Size = new Size(139, 20);
			label8.TabIndex = 54;
			label8.Text = "Complaint Number:";
			// 
			// btn_cancel
			// 
			btn_cancel.BackColor = Color.FromArgb(192, 0, 0);
			btn_cancel.Location = new Point(830, 798);
			btn_cancel.Margin = new Padding(6, 5, 6, 5);
			btn_cancel.Name = "btn_cancel";
			btn_cancel.Size = new Size(270, 90);
			btn_cancel.TabIndex = 8;
			btn_cancel.Text = "Cancel";
			btn_cancel.UseVisualStyleBackColor = false;
			btn_cancel.Click += btn_cancel_Click;
			// 
			// btn_Update
			// 
			btn_Update.BackColor = Color.LightSeaGreen;
			btn_Update.Location = new Point(535, 798);
			btn_Update.Margin = new Padding(6, 5, 6, 5);
			btn_Update.Name = "btn_Update";
			btn_Update.Size = new Size(254, 90);
			btn_Update.TabIndex = 7;
			btn_Update.Text = "Update";
			btn_Update.UseVisualStyleBackColor = false;
			btn_Update.Click += btn_Update_Click;
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new Point(349, 343);
			label13.Margin = new Padding(4, 0, 4, 0);
			label13.Name = "label13";
			label13.Size = new Size(125, 20);
			label13.TabIndex = 61;
			label13.Text = "Complaint Status:";
			// 
			// cmb_complaintstatus
			// 
			cmb_complaintstatus.FormattingEnabled = true;
			cmb_complaintstatus.Items.AddRange(new object[] { "Open", "In Progress", "Pending", "Resolved", "Out of Jurisdiction" });
			cmb_complaintstatus.Location = new Point(597, 343);
			cmb_complaintstatus.Margin = new Padding(4);
			cmb_complaintstatus.Name = "cmb_complaintstatus";
			cmb_complaintstatus.Size = new Size(428, 28);
			cmb_complaintstatus.TabIndex = 2;
			cmb_complaintstatus.SelectedIndexChanged += cmb_complaintstatus_SelectedIndexChanged;
			// 
			// btn_browse
			// 
			btn_browse.BackColor = Color.FromArgb(224, 224, 224);
			btn_browse.Location = new Point(597, 521);
			btn_browse.Margin = new Padding(6, 5, 6, 5);
			btn_browse.Name = "btn_browse";
			btn_browse.Size = new Size(192, 59);
			btn_browse.TabIndex = 5;
			btn_browse.Text = "Browse";
			btn_browse.UseVisualStyleBackColor = false;
			btn_browse.Visible = false;
			btn_browse.Click += btn_browse_Click;
			// 
			// txt_selected_file
			// 
			txt_selected_file.Location = new Point(597, 434);
			txt_selected_file.Name = "txt_selected_file";
			txt_selected_file.Size = new Size(428, 27);
			txt_selected_file.TabIndex = 3;
			txt_selected_file.Visible = false;
			txt_selected_file.TextChanged += txt_selected_file_TextChanged;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(1050, 44);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(550, 184);
			pictureBox1.TabIndex = 64;
			pictureBox1.TabStop = false;
			pictureBox1.Visible = false;
			// 
			// lbl_filepath
			// 
			lbl_filepath.AutoSize = true;
			lbl_filepath.Location = new Point(349, 441);
			lbl_filepath.Margin = new Padding(4, 0, 4, 0);
			lbl_filepath.Name = "lbl_filepath";
			lbl_filepath.Size = new Size(67, 20);
			lbl_filepath.TabIndex = 65;
			lbl_filepath.Text = "File Path:";
			lbl_filepath.Visible = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Location = new Point(1050, 275);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(550, 299);
			pictureBox2.TabIndex = 66;
			pictureBox2.TabStop = false;
			pictureBox2.Visible = false;
			// 
			// btn_Browse2
			// 
			btn_Browse2.BackColor = Color.FromArgb(224, 224, 224);
			btn_Browse2.Location = new Point(824, 521);
			btn_Browse2.Margin = new Padding(6, 5, 6, 5);
			btn_Browse2.Name = "btn_Browse2";
			btn_Browse2.Size = new Size(192, 59);
			btn_Browse2.TabIndex = 6;
			btn_Browse2.Text = "Browse";
			btn_Browse2.UseVisualStyleBackColor = false;
			btn_Browse2.Visible = false;
			btn_Browse2.Click += btn_Browse2_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(349, 493);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(67, 20);
			label1.TabIndex = 69;
			label1.Text = "File Path:";
			label1.Visible = false;
			// 
			// txt_fileafter
			// 
			txt_fileafter.Location = new Point(597, 486);
			txt_fileafter.Name = "txt_fileafter";
			txt_fileafter.Size = new Size(428, 27);
			txt_fileafter.TabIndex = 4;
			txt_fileafter.Visible = false;
			// 
			// lbl_remarks
			// 
			lbl_remarks.AutoSize = true;
			lbl_remarks.Location = new Point(349, 636);
			lbl_remarks.Name = "lbl_remarks";
			lbl_remarks.Size = new Size(65, 20);
			lbl_remarks.TabIndex = 72;
			lbl_remarks.Text = "Remarks";
			lbl_remarks.Visible = false;
			// 
			// txt_remarks
			// 
			txt_remarks.Location = new Point(605, 629);
			txt_remarks.Multiline = true;
			txt_remarks.Name = "txt_remarks";
			txt_remarks.Size = new Size(630, 146);
			txt_remarks.TabIndex = 73;
			txt_remarks.Visible = false;
			// 
			// lbl_complaintid
			// 
			lbl_complaintid.AutoSize = true;
			lbl_complaintid.Location = new Point(589, 100);
			lbl_complaintid.Name = "lbl_complaintid";
			lbl_complaintid.Size = new Size(95, 20);
			lbl_complaintid.TabIndex = 74;
			lbl_complaintid.Text = "complaint_id";
			// 
			// Update_Complaint_Status
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			CancelButton = btn_cancel;
			ClientSize = new Size(1781, 1006);
			Controls.Add(lbl_complaintid);
			Controls.Add(txt_remarks);
			Controls.Add(lbl_remarks);
			Controls.Add(label1);
			Controls.Add(txt_fileafter);
			Controls.Add(btn_Browse2);
			Controls.Add(pictureBox2);
			Controls.Add(lbl_filepath);
			Controls.Add(pictureBox1);
			Controls.Add(txt_selected_file);
			Controls.Add(btn_browse);
			Controls.Add(label13);
			Controls.Add(cmb_complaintstatus);
			Controls.Add(btn_cancel);
			Controls.Add(btn_Update);
			Controls.Add(cmb_complaintnumber);
			Controls.Add(label8);
			Name = "Update_Complaint_Status";
			Text = "Update_Complaint_Status";
			WindowState = FormWindowState.Maximized;
			Load += Update_Complaint_Status_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cmb_complaintnumber;
		private Label label8;
		private Button btn_cancel;
		private Button btn_Update;
		private Label label13;
		private ComboBox cmb_complaintstatus;
		private Button btn_browse;
		private TextBox txt_selected_file;
		private OpenFileDialog openFileDialog1;
		private PictureBox pictureBox1;
		private Label lbl_filepath;
		private PictureBox pictureBox2;
		private Button btn_Browse2;
		private Label label1;
		private TextBox txt_fileafter;
		private Label lbl_remarks;
		private TextBox txt_remarks;
		private Label lbl_complaintid;
	}
}