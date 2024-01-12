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
	public partial class AppointmentReschedule : Form
	{
		string path = @"Data Source=DESKTOP-R998OAS;Initial Catalog=HealthCarePlus; Integrated Security=True;";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;
	 
		public int ID;


		public TimeSpan time { set; get; }
		public string date { set; get; }

		public AppointmentReschedule()
		{
			InitializeComponent();
			con = new SqlConnection(path);
			display();
			btnRescheduleAppointment.Enabled = false;
			btnAppointmentCancelation.Enabled = false;
		}


		public void display()
		{
			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from DoctorAppointment", con);
				dataGridView1.DataSource = dt;
				con.Close();
				adpt.Fill(dt);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnDeleteAppointment_Click(object sender, EventArgs e)
		{
			try
			{
				con.Open();
				cmd = new SqlCommand("delete from Rooms where Appointment_Id='" + ID + "'", con);
				cmd.ExecuteNonQuery();
				con.Close();
				//MessageBox.Show("Selected Appoinment has been canceled successfully...");
				MessageBox.Show("Selected Appoinment has been canceled successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				display();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{

			ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			RescheduleDate.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString());
			string getTime = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();



			//From Time
			string timeString2 = getTime;
			string[] timeParts2 = timeString2.Split(':');

			if (timeParts2.Length == 3)
			{
				int hour = int.Parse(timeParts2[0]);
				int minute = int.Parse(timeParts2[1]);
				int second = int.Parse(timeParts2[2]);

				RescheduleTime.Value = new DateTime(2023, 09, 12, hour, minute, second);

			}


			btnRescheduleAppointment.Enabled = true;
			btnAppointmentCancelation.Enabled = true;

		}

		private void btnRescheduleAppointment_Click(object sender, EventArgs e)
		{
			Console.WriteLine(time);
			Console.WriteLine(date);
			Console.WriteLine(ID);

			try
			{
				con.Open();
				cmd = new SqlCommand("update DoctorAppointment set Consult_Date='" + date + "',Booked_Time ='" + time + "' where Appointment_Id='" + ID + "'", con);
				cmd.ExecuteNonQuery();
				con.Close();
				//MessageBox.Show("Appointment has been rescheduled successfully...");
				MessageBox.Show("Appointment has been rescheduled successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				display();
				//resetAllValue();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void RescheduleTime_ValueChanged(object sender, EventArgs e)
		{
			time = RescheduleTime.Value.TimeOfDay;
		}

		private void RescheduleDate_ValueChanged(object sender, EventArgs e)
		{
			string inputDate = RescheduleDate.Value.ToString();
			DateTime dateValue = DateTime.Parse(inputDate);
			date = dateValue.ToShortDateString(); // take only date
		}
	}
}
