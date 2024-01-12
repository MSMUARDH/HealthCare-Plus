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
	public partial class PatientRegistrationForm : Form
	{
		string path = @"Data Source=DESKTOP-R998OAS;Initial Catalog=HealthCarePlus; Integrated Security=True;";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;
		int ID;


		public PatientRegistrationForm()
		{
			InitializeComponent();
			con = new SqlConnection(path);
			display();
			btnClear.Enabled = false;
			btnDelete.Enabled = false;
			btnUpdate.Enabled = false;
		}

		private void button2_Click(object sender, EventArgs e)
		{


			if (txtPetientName.Text == "" || txtAge.Text == "" || txtAddress.Text == "" || txtEmail.Text == "" || txtPhone.Text == "" || (!rbtnFemale.Checked && !rbtnMale.Checked))
			{
				MessageBox.Show("All Fields are required...", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				try
				{

					string gender;
					string role;

					if (rbtnMale.Checked)
					{
						gender = "Male";
					}
					else
					{
						gender = "Female";
					}

			

					con.Open();
					cmd = new SqlCommand("insert into Patients (Patient_Name,Age,Gender,Email,Address,Phone) values('" + txtPetientName.Text + "','" + txtAge.Text + "','" + gender + "','" + txtEmail.Text + "','" + txtAddress.Text + "','" + txtPhone.Text + "') ", con);
					cmd.ExecuteNonQuery();
					con.Close();
					//MessageBox.Show("Patient Data has been Saved Successfully...");
					MessageBox.Show("Patient Data has been Saved Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					resetAllValue();
					display();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}




		}
		public void resetAllValue()
		{
			txtPetientName.Text = "";
			txtAge.Text = "";
			txtAddress.Text = "";
			txtEmail.Text = "";
			txtPhone.Text = "";
			rbtnFemale.Checked = false;
			rbtnMale.Checked = false;
		}


		public void display()
		{

			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from Patients", con);
				dataGridView1.DataSource = dt;
				con.Close();
				adpt.Fill(dt);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void Clear_Click(object sender, EventArgs e)
		{
			resetAllValue();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{

			try
			{
				string gender;

				if (rbtnMale.Checked)
				{
					gender = "Male";
				}
				else
				{
					gender = "Female";
				}

				con.Open();
				cmd = new SqlCommand("update Patients set Patient_Name='" + txtPetientName.Text + "',Age='" + txtAge.Text + "',Gender='" + gender + "',Email='" + txtEmail.Text + "',Address='" + txtAddress.Text + "',Phone='" + txtPhone.Text + "'where Patient_Id='" + ID + "'", con);
				cmd.ExecuteNonQuery();
				con.Close();
				//MessageBox.Show("Patient data has been updated successfully...");
				MessageBox.Show("Patient data has been updated successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				display();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				con.Open();
				cmd = new SqlCommand("delete from Patients where Patient_Id='" + ID + "'", con);
				cmd.ExecuteNonQuery();
				con.Close();
				//MessageBox.Show("Selected record has been deleted successfully...");
				MessageBox.Show("Selected record has been deleted successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				display();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
		{
			ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			txtPetientName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtAge.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "Female")
			{
				rbtnMale.Checked = false;
				rbtnFemale.Checked = true;
			}
			else
			{
				rbtnMale.Checked = true;
				rbtnFemale.Checked = false;
			}
			txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

			btnClear.Enabled = true;
			btnDelete.Enabled = true;
			btnUpdate.Enabled = true;
		}
	}
}
