namespace CMS_BWP
{
	partial class FM_Login
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			txt_user = new TextBox();
			txt_password = new TextBox();
			lbl_password = new Label();
			btn_login = new Button();
			btn_cancel = new Button();
			label2 = new Label();
			lnk_register = new LinkLabel();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(574, 337);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(114, 25);
			label1.TabIndex = 0;
			label1.Text = "User Name:";
			// 
			// txt_user
			// 
			txt_user.Location = new Point(768, 337);
			txt_user.Margin = new Padding(4);
			txt_user.Name = "txt_user";
			txt_user.PlaceholderText = "Enter Your User Name";
			txt_user.Size = new Size(410, 32);
			txt_user.TabIndex = 1;
			// 
			// txt_password
			// 
			txt_password.Location = new Point(768, 427);
			txt_password.Margin = new Padding(4);
			txt_password.Name = "txt_password";
			txt_password.PlaceholderText = "Enter Your Password";
			txt_password.Size = new Size(410, 32);
			txt_password.TabIndex = 3;
			txt_password.UseSystemPasswordChar = true;
			// 
			// lbl_password
			// 
			lbl_password.AutoSize = true;
			lbl_password.Location = new Point(586, 427);
			lbl_password.Margin = new Padding(4, 0, 4, 0);
			lbl_password.Name = "lbl_password";
			lbl_password.Size = new Size(102, 25);
			lbl_password.TabIndex = 2;
			lbl_password.Text = "Password:";
			// 
			// btn_login
			// 
			btn_login.BackColor = Color.LightSeaGreen;
			btn_login.Location = new Point(768, 497);
			btn_login.Margin = new Padding(4);
			btn_login.Name = "btn_login";
			btn_login.Size = new Size(185, 72);
			btn_login.TabIndex = 4;
			btn_login.Text = "Login";
			btn_login.UseVisualStyleBackColor = false;
			btn_login.Click += btn_login_Click;
			// 
			// btn_cancel
			// 
			btn_cancel.BackColor = Color.FromArgb(192, 0, 0);
			btn_cancel.Location = new Point(982, 497);
			btn_cancel.Margin = new Padding(4);
			btn_cancel.Name = "btn_cancel";
			btn_cancel.Size = new Size(196, 72);
			btn_cancel.TabIndex = 5;
			btn_cancel.Text = "Forget Password";
			btn_cancel.UseVisualStyleBackColor = false;
			btn_cancel.Click += btn_cancel_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.Green;
			label2.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
			label2.ForeColor = SystemColors.ControlLightLight;
			label2.Location = new Point(494, 99);
			label2.Name = "label2";
			label2.Size = new Size(780, 67);
			label2.TabIndex = 0;
			label2.Text = "Complaint Management System";
			// 
			// lnk_register
			// 
			lnk_register.AutoSize = true;
			lnk_register.Location = new Point(768, 633);
			lnk_register.Name = "lnk_register";
			lnk_register.Size = new Size(366, 25);
			lnk_register.TabIndex = 6;
			lnk_register.TabStop = true;
			lnk_register.Text = "Register if you do not have an account!!";
			lnk_register.LinkClicked += lnk_register_LinkClicked;
			// 
			// FM_Login
			// 
			AcceptButton = btn_login;
			AutoScaleDimensions = new SizeF(11F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			BackColor = Color.White;
			ClientSize = new Size(1372, 697);
			Controls.Add(lnk_register);
			Controls.Add(label2);
			Controls.Add(btn_cancel);
			Controls.Add(btn_login);
			Controls.Add(txt_password);
			Controls.Add(lbl_password);
			Controls.Add(txt_user);
			Controls.Add(label1);
			Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			ForeColor = SystemColors.ControlLightLight;
			Margin = new Padding(4);
			Name = "FM_Login";
			StartPosition = FormStartPosition.WindowsDefaultBounds;
			Text = "CMS Login";
			WindowState = FormWindowState.Maximized;
			Load += FM_Login_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txt_user;
		private TextBox txt_password;
		private Label lbl_password;
		private Button btn_login;
		private Button btn_cancel;
		private Label label2;
		private LinkLabel lnk_register;
	}
}
