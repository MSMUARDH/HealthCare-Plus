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
	public partial class DoctorSchedule : Form
	{
		string path = @"Data Source=DESKTOP-R998OAS;Initial Catalog=HealthCarePlus; Integrated Security=True;";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;
		Dictionary<int, string> idNameMapping = new Dictionary<int, string>();

		public string selectedName { get; set; }
		public int selectedId { get; set; }

		public string consultDate { get; set; }

		public int Fee { get; set; }

		public TimeSpan selectedFromTime { get; set; }
		public TimeSpan selectedToTime { get; set; }

		public int ID { get; set; }
		public DoctorSchedule()
		{
			InitializeComponent();
			con = new SqlConnection(path);
			toTimePicker.Value = new DateTime(2023, 09, 12, 0, 0, 0);
			fromTimePicker.Value = new DateTime(2023, 09, 12, 0, 0, 0);
			display();
			fillComboBox();
		}



		public void resetAllValue()
		{
			cmbDoctorName.Text = "";
			//cmbDay.Text = "";
			toTimePicker.Value = new DateTime(2023, 09, 12, 0, 0, 0);
			fromTimePicker.Value = new DateTime(2023, 09, 12, 0, 0, 0);
			txtFee.Value = 0;

		}
		public void fillComboBox()
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
				adpt = new SqlDataAdapter("select * from Doctorschedule", con);
				dataGridView1.DataSource = dt;
				con.Close();
				adpt.Fill(dt);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DoctorSchedule_Load(object sender, EventArgs e)
		{
			btnDelete.Enabled = false;
			btnClear.Enabled = false;
			btnUpdate.Enabled = false;
		}
		private void cmbDoctorName_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbDoctorName.SelectedIndex != -1)
			{
				selectedName = cmbDoctorName.SelectedItem.ToString();
				selectedId = idNameMapping.FirstOrDefault(x => x.Value == selectedName).Key;
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			resetAllValue();
		}

		private void cmbDay_SelectedIndexChanged(object sender, EventArgs e)
		{
		   //day = cmbDay.Text;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string inputDate = dateScheduleDoctor.Value.ToString();
			DateTime dateValue = DateTime.Parse(inputDate);
			 consultDate = dateValue.ToShortDateString(); // take only date

		


			if (cmbDoctorName.Text == "" || consultDate == "" ||  selectedFromTime.ToString() == "00:00:00" || selectedToTime.ToString() == "00:00:00" || Fee == 0)
			{
				MessageBox.Show("All Fields are required...", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				try
				{

					con.Open();
					cmd = new SqlCommand("insert into Doctorschedule(Doctor_Id,Doctor_Name,Consult_Date,From_Time,To_Time,Fee) values('" + selectedId + "','" + selectedName + "', '" + consultDate + "','" + selectedFromTime + "','" + selectedToTime + "','" + Fee + "') ", con);
					cmd.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Doctor Schedule Data has been Saved Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					resetAllValue();
					display();
					resetAllValue();

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
			int doctorId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
			cmbDoctorName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
		    dateScheduleDoctor.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString())  ;
			string fromTime = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			string toTime = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
			txtFee.Value = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString()) ;


			

			//From Time
			string timeString2 = fromTime;
			string[] timeParts2 = timeString2.Split(':');

			if (timeParts2.Length == 3)
			{
				int hour = int.Parse(timeParts2[0]);
				int minute = int.Parse(timeParts2[1]);
				int second = int.Parse(timeParts2[2]);

				fromTimePicker.Value = new DateTime(2023, 09, 12, hour, minute, second);

			}

			//toTime
			string timeString1 = toTime;
			string[] timeParts1 = timeString1.Split(':');

			if (timeParts1.Length == 3)
			{
				int hour = int.Parse(timeParts1[0]);
				int minute = int.Parse(timeParts1[1]);
				int second = int.Parse(timeParts1[2]);

				toTimePicker.Value = new DateTime(2023, 09, 12, hour, minute, second);
			}

			btnClear.Enabled = true;
			btnDelete.Enabled = true;
			btnUpdate.Enabled = true;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{

			if (cmbDoctorName.Text == "" || consultDate == "" || fromTimePicker.Value.TimeOfDay.ToString() == "00:00:00" || toTimePicker.Value.ToString() == "00:00:00")
			{
				MessageBox.Show("All Fields are required...", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				try
				{
					con.Open();
					cmd = new SqlCommand("update Doctorschedule set Doctor_Id='" + selectedId + "',Doctor_Name ='" + selectedName + "',Consult_Date ='" + consultDate + "',From_Time='" + fromTimePicker.Value.TimeOfDay + "',To_Time='" + toTimePicker.Value.TimeOfDay + "',Fee='"+txtFee.Value+"' where Shedule_Id='" + ID + "'", con);
					cmd.ExecuteNonQuery();
					con.Close();
					//MessageBox.Show("Doctor Schedule data has been updated successfully...");
					MessageBox.Show("Doctor Schedule data has been updated successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					display();
					resetAllValue();

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
				cmd = new SqlCommand("delete from Doctorschedule where Shedule_Id='" + ID + "'", con);
				cmd.ExecuteNonQuery();
				con.Close();
				//MessageBox.Show("Selected record has been deleted successfully...");
				MessageBox.Show("Selected record has been deleted successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				display();
				resetAllValue();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void fromTimePicker_ValueChanged(object sender, EventArgs e)
		{
			 selectedFromTime = fromTimePicker.Value.TimeOfDay;
			//MessageBox.Show("Selected Time: " + selectedTime.ToString());
		}

		private void toTimePicker_ValueChanged(object sender, EventArgs e)
		{
			selectedToTime = toTimePicker.Value.TimeOfDay;
		}

		private void txtFee_ValueChanged(object sender, EventArgs e)
		{
			Fee = (int)txtFee.Value;
		}

		private void dateScheduleDoctor_ValueChanged(object sender, EventArgs e)
		{
			string inputDate = dateScheduleDoctor.Value.ToString();
			DateTime dateValue = DateTime.Parse(inputDate);
			consultDate = dateValue.ToShortDateString(); // take only date
		}
	}
}
