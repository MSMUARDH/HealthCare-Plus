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
using System.Text.RegularExpressions;

namespace HealthCare_Plus
{
	public partial class Consultation : Form
	{
		string path = @"Data Source=DESKTOP-R998OAS;Initial Catalog=HealthCarePlus; Integrated Security=True;";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;
		Dictionary<int, string> idNameMapping = new Dictionary<int, string>();


		//public string integerValue { get; private set; }
		public string patientName { get; set; }
		public string selectedName { get;  set; }
		public int selectedId { get;  set; }
		public int ID;



		public Consultation()
		{
			InitializeComponent();
			con = new SqlConnection(path);
			display();
			fillComboBox();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (cmbxPertientName.Text == "" || txtDisease.Text == "" || txtTreatment.Text == "" || txtPrescription.Text == "")
			{
				MessageBox.Show("All Fields are required...", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				try
				{
					con.Open();
					cmd = new SqlCommand("insert into Consultations(Patient_Id,Patient_Name,Disease,Treatment,Prescription) values('" + selectedId + "','" + selectedName + "', '" + txtDisease.Text + "','" + txtTreatment.Text + "','" + txtPrescription.Text + "') ", con);
					cmd.ExecuteNonQuery();
					con.Close();
					//MessageBox.Show("Consultations Data has been Saved Successfully...");
					MessageBox.Show("Consultations Data has been Saved Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					resetAllValue();
					display();

				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}

		}

		public void resetAllValue()
		{
			cmbxPertientName.Text = "";
			txtDisease.Text = "";
			txtTreatment.Text = "";
			txtPrescription.Text = "";
		}


		public void fillComboBox()
		{
			cmd = new SqlCommand("select * from Patients", con);
			SqlDataReader myreader;

			try
			{
				con.Open();
				myreader = cmd.ExecuteReader();
	

				while (myreader.Read())
				{
					int id = myreader.GetInt32(0);
					string name = myreader.GetString(1);

					cmbxPertientName.Items.Add(name);
					idNameMapping[id] = name;
				}

				con.Close();

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
				adpt = new SqlDataAdapter("select * from Consultations", con);
				dataGridView1.DataSource = dt;
				con.Close();
				adpt.Fill(dt);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{


			ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			int patientId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
			cmbxPertientName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			txtDisease.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			txtTreatment.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			txtPrescription.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

			btnClear.Enabled = true;
			btnDelete.Enabled = true;
			btnUpdate.Enabled = true;
		}

		private void Consultation_Load(object sender, EventArgs e)
		{

			btnClear.Enabled = false;
			btnDelete.Enabled = false;
			btnUpdate.Enabled = false;
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			resetAllValue();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{

			if (cmbxPertientName.Text == "" || txtDisease.Text == "" || txtTreatment.Text == "" || txtPrescription.Text == "")
			{
				MessageBox.Show("All Fields are required...", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				try
				{
					con.Open();
					cmd = new SqlCommand("update Consultations set Patient_Id='" + selectedId + "',Patient_Name ='" + selectedName + "',Disease ='" + txtDisease.Text + "',Treatment='" + txtTreatment.Text + "',Prescription='" + txtPrescription.Text + "'where Consultation_Id='" + ID + "'", con);
					cmd.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Consultations data has been updated successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
				cmd = new SqlCommand("delete from Consultations where Consultation_Id='" + ID + "'", con);
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Selected record has been deleted successfully...");
				display();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cmbxPertientName_SelectedIndexChanged(object sender, EventArgs e)
		{

			if (cmbxPertientName.SelectedIndex != -1)
			{
				 selectedName = cmbxPertientName.SelectedItem.ToString();
				 selectedId = idNameMapping.FirstOrDefault(x => x.Value == selectedName).Key;

				
			}
		}
	}
}
