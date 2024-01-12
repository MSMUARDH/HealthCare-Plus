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
	public partial class DoctorRegistrationForm : Form
	{
		string path = @"Data Source=DESKTOP-R998OAS;Initial Catalog=HealthCarePlus; Integrated Security=True;";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;
		int ID;
		public DoctorRegistrationForm()
		{
			InitializeComponent();
			con = new SqlConnection(path);
			display();

			btnClear.Enabled = false;
			btnDelete.Enabled = false;
			btnUpdate.Enabled = false;

			if (txtDoctorName.Text == "" || txtSpecialization.Text == "" || txtAvailability.Text == "" || txtLocation.Text == "" || txtQualifications.Text == "" || txtContact.Text == "" || txtExpertise.Text == "")
			{
				btnDelete.Enabled = false;
				btnUpdate.Enabled = false;
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{

			if (txtDoctorName.Text == "" || txtSpecialization.Text == "" || txtAvailability.Text == "" || txtLocation.Text == "" || txtQualifications.Text == "" || txtContact.Text == "" || txtExpertise.Text == "")
			{
				MessageBox.Show("All Fields are required...", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				try
				{

					con.Open();
					cmd = new SqlCommand("insert into Doctors (Doctor_Name,Specialization,Availability,Location,Qualifications,Expertise,Contact) values('" + txtDoctorName.Text + "','" + txtSpecialization.Text + "','" + txtAvailability.Text + "','" + txtLocation.Text + "','" + txtQualifications.Text + "','" + txtExpertise.Text + "','" + txtContact.Text + "') ", con);
					cmd.ExecuteNonQuery();
					con.Close();
					//MessageBox.Show("Doctor Data has been Saved Successfully...");
					MessageBox.Show("Doctor Data has been Saved Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					resetAllValue();
					display();
				}
				catch (Exception ex)
				{

					MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

		}


		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			txtDoctorName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtSpecialization.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			txtAvailability.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			txtLocation.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			txtQualifications.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			txtExpertise.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
			txtContact.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

			btnClear.Enabled = true;
			btnDelete.Enabled = true;
			btnUpdate.Enabled = true;
		}


		private void btnUpdate_Click_1(object sender, EventArgs e)

		{

			if (txtDoctorName.Text == "" || txtSpecialization.Text == "" || txtAvailability.Text == "" || txtLocation.Text == "" || txtQualifications.Text == "" || txtContact.Text == "" || txtExpertise.Text == "")
			{
				MessageBox.Show("All Fields are required...", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				try
				{

					con.Open();
					cmd = new SqlCommand("update Doctors set Doctor_Name='" + txtDoctorName.Text + "',Specialization='" + txtSpecialization.Text + "',Availability='" + txtAvailability.Text + "',Location='" + txtLocation.Text + "',Qualifications='" + txtQualifications.Text + "',Expertise='" + txtExpertise.Text + "',Contact='" + txtContact.Text + "'where Doctor_Id='" + ID + "'", con);
					cmd.ExecuteNonQuery();
					con.Close();
					//MessageBox.Show("Doctor data has been updated successfully...");
					MessageBox.Show("Doctor data has been updated successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					display();
				}
				catch (Exception ex)
				{

					MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}



		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				con.Open();
				cmd = new SqlCommand("delete from Doctors where Doctor_Id='" + ID + "'", con);
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Selected record has been deleted successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

				display();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}




		public void display()
		{

			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from Doctors", con);
				dataGridView1.DataSource = dt;
				con.Close();
				adpt.Fill(dt);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		public void resetAllValue()
		{
			txtDoctorName.Text = "";
			txtSpecialization.Text = "";
			txtAvailability.Text = "";
			txtLocation.Text = "";
			txtQualifications.Text = "";
			txtContact.Text = "";
			txtExpertise.Text = "";
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			resetAllValue();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}
	}
}
