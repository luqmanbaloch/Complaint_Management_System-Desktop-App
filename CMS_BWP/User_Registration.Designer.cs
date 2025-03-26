namespace CMS_BWP
{
	partial class User_Registration
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
			txt_email = new TextBox();
			label2 = new Label();
			txt_password = new TextBox();
			label3 = new Label();
			btn_cancel = new Button();
			btn_login = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(531, 183);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(69, 25);
			label1.TabIndex = 0;
			label1.Text = "Name:";
			// 
			// txt_name
			// 
			txt_name.Location = new Point(636, 180);
			txt_name.Margin = new Padding(4);
			txt_name.Name = "txt_name";
			txt_name.Size = new Size(495, 32);
			txt_name.TabIndex = 1;
			// 
			// txt_email
			// 
			txt_email.Location = new Point(636, 261);
			txt_email.Margin = new Padding(4);
			txt_email.Name = "txt_email";
			txt_email.Size = new Size(495, 32);
			txt_email.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(531, 268);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(64, 25);
			label2.TabIndex = 2;
			label2.Text = "Email:";
			// 
			// txt_password
			// 
			txt_password.Location = new Point(636, 340);
			txt_password.Margin = new Padding(4);
			txt_password.Name = "txt_password";
			txt_password.Size = new Size(495, 32);
			txt_password.TabIndex = 5;
			txt_password.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(531, 343);
			label3.Margin = new Padding(4, 0, 4, 0);
			label3.Name = "label3";
			label3.Size = new Size(102, 25);
			label3.TabIndex = 4;
			label3.Text = "Password:";
			// 
			// btn_cancel
			// 
			btn_cancel.BackColor = Color.FromArgb(192, 0, 0);
			btn_cancel.Location = new Point(882, 476);
			btn_cancel.Margin = new Padding(6, 5, 6, 5);
			btn_cancel.Name = "btn_cancel";
			btn_cancel.Size = new Size(270, 90);
			btn_cancel.TabIndex = 7;
			btn_cancel.Text = "Cancel";
			btn_cancel.UseVisualStyleBackColor = false;
			btn_cancel.Click += btn_cancel_Click;
			// 
			// btn_login
			// 
			btn_login.BackColor = Color.LightSeaGreen;
			btn_login.Location = new Point(587, 476);
			btn_login.Margin = new Padding(6, 5, 6, 5);
			btn_login.Name = "btn_login";
			btn_login.Size = new Size(254, 90);
			btn_login.TabIndex = 6;
			btn_login.Text = "Register";
			btn_login.UseVisualStyleBackColor = false;
			btn_login.Click += btn_login_Click;
			// 
			// User_Registration
			// 
			AutoScaleDimensions = new SizeF(11F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(1556, 838);
			Controls.Add(btn_cancel);
			Controls.Add(btn_login);
			Controls.Add(txt_password);
			Controls.Add(label3);
			Controls.Add(txt_email);
			Controls.Add(label2);
			Controls.Add(txt_name);
			Controls.Add(label1);
			Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			ForeColor = Color.Black;
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(4);
			Name = "User_Registration";
			StartPosition = FormStartPosition.CenterParent;
			Text = "User_Registration";
			WindowState = FormWindowState.Maximized;
			Load += User_Registration_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txt_name;
		private TextBox txt_email;
		private Label label2;
		private TextBox txt_password;
		private Label label3;
		private Button btn_cancel;
		private Button btn_login;
	}
}