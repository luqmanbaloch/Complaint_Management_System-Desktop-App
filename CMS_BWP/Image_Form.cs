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
	public partial class Image_Form : Form
	{
		string constring = ConfigurationManager.ConnectionStrings["constring"].ConnectionString;
		public Image_Form()
		{
			InitializeComponent();
		}

		private void Image_Form_Load(object sender, EventArgs e)
		{
			LoadImage(Dashboard.id);
			LoadImageafter(Dashboard.id);
		}


		private void LoadImage(string imageId)
		{
			using (SqlConnection connection = new SqlConnection(constring))
			{
				string query = "SELECT Imagefile FROM tbl_complaints WHERE complaint_number = @Id";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Id", imageId);
					connection.Open();
					byte[] imageData = command.ExecuteScalar() as byte[]; if (imageData != null)
					{
						using (MemoryStream ms = new MemoryStream(imageData))
						{
							pictureBox1.Image = Image.FromStream(ms);
						}
					}
					


				}
			}


		}



		private void LoadImageafter(string imageId)
		{
			using (SqlConnection connection = new SqlConnection(constring))
			{
				string query = "SELECT Imagefileafter FROM tbl_complaints WHERE complaint_number = @Id";
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					command.Parameters.AddWithValue("@Id", imageId);
					connection.Open();
					byte[] imageData = command.ExecuteScalar() as byte[]; if (imageData != null)
					{
						using (MemoryStream ms = new MemoryStream(imageData))
						{
							pictureBox2.Image = Image.FromStream(ms);
						}
					}



				}
			}


		}
	}
}
