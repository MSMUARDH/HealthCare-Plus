using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HealthCare_Plus
{
	public partial class SearchDoctors : Form
	{
		string path = @"Data Source=DESKTOP-R998OAS;Initial Catalog=HealthCarePlus; Integrated Security=True;";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;


		public string searchvalue { get; set; }
		public string location { get; set; }
		public string specialization { get; set; }


		public SearchDoctors()
		{
			InitializeComponent();
			con = new SqlConnection(path);
		}

		public void display()
		{
			try
			{
				dt = new DataTable();
				con.Open();

				if (rdoLocation.Checked)
				{
					adpt = new SqlDataAdapter("select * from Doctors where Location='" + txtSearchValue.Text + "'", con);
				}
				else
				{
					adpt = new SqlDataAdapter("select * from Doctors where Specialization='" + txtSearchValue.Text + "'", con);
				}



				dataGridView1.DataSource = dt;
				con.Close();
				adpt.Fill(dt);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void displayAllDoctor()
		{

			dt = new DataTable();
			con.Open();
			adpt = new SqlDataAdapter("select * from Doctors", con);
			dataGridView1.DataSource = dt;
			con.Close();
			adpt.Fill(dt);

		}

		private void btnSearchDoctor_Click(object sender, EventArgs e)
		{
			if (!rdoSpecialization.Checked && !rdoLocation.Checked)
			{
				//MessageBox.Show("Please select the category to search");
				MessageBox.Show("Please select the category to search", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

			}
			else
			{
				display();
			}
		}

		private void rdoSpecialization_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoLocation.Checked)
			{
				 location = rdoLocation.Text.ToString();
			}
			else
			{
				 specialization = rdoSpecialization.Text.ToString();
			}
		}

		private void rdoLocation_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoSpecialization.Checked)
			{
				 specialization = rdoSpecialization.Text.ToString();
				
			}
			else
			{
				 location = rdoLocation.Text.ToString();
			}
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
		    int doctorId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			string doctorName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			string specilization = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			string availability = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			string  location = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			string qualifications = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			string  expertise =dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
			string contact = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
			DoctorProfile obj = new DoctorProfile( doctorName, specilization, availability, location, qualifications, expertise, contact);
			obj.Show();
		}

		private void btnViewAllDoctor_Click(object sender, EventArgs e)
		{
			displayAllDoctor();
		}
	}
}
