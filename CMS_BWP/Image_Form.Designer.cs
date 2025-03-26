namespace CMS_BWP
{
	partial class Image_Form
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
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			label1 = new Label();
			label2 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Location = new Point(12, 42);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(716, 501);
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Location = new Point(796, 42);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(589, 501);
			pictureBox2.TabIndex = 1;
			pictureBox2.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(320, 9);
			label1.Name = "label1";
			label1.Size = new Size(53, 20);
			label1.TabIndex = 2;
			label1.Text = "Before";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(1068, 9);
			label2.Name = "label2";
			label2.Size = new Size(42, 20);
			label2.TabIndex = 3;
			label2.Text = "After";
			// 
			// Image_Form
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1413, 555);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			Name = "Image_Form";
			Text = "Image_Form";
			Load += Image_Form_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private Label label1;
		private Label label2;
	}
}