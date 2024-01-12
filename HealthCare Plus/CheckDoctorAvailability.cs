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
	public partial class CheckDoctorAvailability : Form
	{

		string path = @"Data Source=DESKTOP-R998OAS;Initial Catalog=HealthCarePlus; Integrated Security=True;";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;
		Dictionary<int, string> idPatientMapping = new Dictionary<int, string>();

		Dictionary<int, string> idDoctorMapping = new Dictionary<int, string>();

		public string selectedPatientName { get; set; }
		public int selectedPatientId { get; set; }

		public string selectedDoctorName { get; set; }
		public int selectedDoctorId { get; set; }

		public TimeSpan time { get; set; }

		public string day { get; set; }
		public int ID { get; set; }

		public string consultDate { get; set; }


		public CheckDoctorAvailability()
		{
			InitializeComponent();
			con = new SqlConnection(path);
			fillDoctorComboBox();
			fillPatientComboBox();
		}

		public void resetAllValue()
		{
			cmbPatientName.Text = "";
			cmbDoctorName.Text = "";
			timePickerforSchedule.Value = new DateTime(2023, 09, 12, 0, 0, 0);
		}

		public void display()
		{
			string inputDate = datePickerConsultDate.Value.ToString();
			DateTime dateValue = DateTime.Parse(inputDate);
			consultDate = dateValue.ToShortDateString();
	
			// take only date
			//DECLARE @SearchTime TIME = '11:00:00'; --Replace with  desired end time
			//SELECT Doctor_Id, Doctor_Name FROM DoctorSchedule WHERE From_Time <= @SearchTime  AND To_Time >= @SearchTime;
			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("SELECT * FROM DoctorSchedule WHERE Doctor_Name='"+selectedDoctorName+ "' AND Consult_Date='"+consultDate+"' AND From_Time <= '" + time + "'AND To_Time >= '" + time + "'", con);
				dataGridView1.DataSource = dt;
				con.Close();
				adpt.Fill(dt);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void fillPatientComboBox()
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

					cmbPatientName.Items.Add(name);
					idPatientMapping[id] = name;
				}

				con.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		public void fillDoctorComboBox()
		{
			cmd = new SqlCommand("select * from Doctors", con);
			SqlDataReader myreader;

			try
			{
				con.Open();
				myreader = cmd.ExecuteReader();


				while (myreader.Read())
				{
					int id = myreader.GetInt32(0);
					string name = myreader.GetString(1);

					cmbDoctorName.Items.Add(name);
					idDoctorMapping[id] = name;
				}

				con.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		private void cmbPatientName_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbPatientName.SelectedIndex != -1)
			{
				selectedPatientName = cmbPatientName.SelectedItem.ToString();
				selectedPatientId = idPatientMapping.FirstOrDefault(x => x.Value == selectedPatientName).Key;
			}
		}
		private void cmbDoctorName_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbDoctorName.SelectedIndex != -1)
			{
				selectedDoctorName = cmbDoctorName.SelectedItem.ToString();
				selectedDoctorId = idDoctorMapping.FirstOrDefault(x => x.Value == selectedDoctorName).Key;
			}
		}


		private void btnSearch_Click(object sender, EventArgs e)
		{
			display();
		}


		private void datePickerConsultDate_ValueChanged(object sender, EventArgs e)
		{
			string inputDate = datePickerConsultDate.Value.ToString();
			DateTime dateValue = DateTime.Parse(inputDate);
			consultDate = dateValue.ToShortDateString(); // take only date
		}

		private void timePickerforSchedule_ValueChanged(object sender, EventArgs e)
		{
			time = timePickerforSchedule.Value.TimeOfDay;

		}

		private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
		{
			ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			int doctorId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
			string doctorname = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			string day = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			string fromTime = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			string toTime = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			int fee = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());


			BookingDoctor booking = new BookingDoctor(ID, selectedPatientId, doctorId, time, fee);

			booking.Show();

		}
	}
}
