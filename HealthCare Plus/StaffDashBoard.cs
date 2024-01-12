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
	public partial class StaffDashBoard : Form
	{
		string path = @"Data Source=DESKTOP-R998OAS;Initial Catalog=HealthCarePlus; Integrated Security=True;";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;
		public StaffDashBoard()
		{
			InitializeComponent();
			con = new SqlConnection(path);
			display();
		}


		void display()
		{

			try
			{
				con.Open();
				// Execute a SQL query to count occupied rooms
				string sqlQuery1 = "SELECT COUNT(*) FROM Rooms WHERE Occupancy_Status = 'occupied'";
				string sqlQuery2 = "SELECT COUNT(*) FROM Rooms WHERE Occupancy_Status = 'unoccupied'";
				string sqlQuery3 = "SELECT COUNT(*) FROM Patients";
				string sqlQuery4 = "SELECT COUNT(*) FROM Doctors";

				SqlCommand cmd1 = new SqlCommand(sqlQuery1, con);
				SqlCommand cmd2 = new SqlCommand(sqlQuery2, con);
				SqlCommand cmd3 = new SqlCommand(sqlQuery3, con);
				SqlCommand cmd4 = new SqlCommand(sqlQuery4, con);

				// Execute the query and get the count
				int occupiedRoomCount = (int)cmd1.ExecuteScalar();
				int unoccupiedRoomCount = (int)cmd2.ExecuteScalar();
				int patientsCount = (int)cmd3.ExecuteScalar();
				int doctorsCount = (int)cmd4.ExecuteScalar();

				lblRoomAllocatedCount.Text = occupiedRoomCount.ToString();
				lblVacantRoom.Text = unoccupiedRoomCount.ToString();
				lblPatientsCount.Text = patientsCount.ToString();
				lblDoctorsCount.Text = doctorsCount.ToString();
				con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
	

		}


		private void StaffDashBoard_FormClosing(object sender, FormClosingEventArgs e)
		{
			LogIn obj = new LogIn();
			obj.Show();
	
		}


		private void timer1_Tick(object sender, EventArgs e)
		{
			lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
			lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
			display();
		}

		private void StaffDashBoard_Load(object sender, EventArgs e)
		{
			timer1.Start();

			try
			{
				con.Open();
				string sqlQuery1 = "SELECT COUNT(*) FROM Doctors where Specialization='Neurology'";
				string sqlQuery2 = "SELECT COUNT(*) FROM Doctors where Specialization='Ophthalmology'";
				string sqlQuery3 = "SELECT COUNT(*) FROM Doctors where Specialization='Family medicine'";
				string sqlQuery4 = "SELECT COUNT(*) FROM Doctors where Specialization='Gastroenterologist'";
				string sqlQuery5 = "SELECT COUNT(*) FROM Doctors where Specialization='VP'";

				SqlCommand cmd1 = new SqlCommand(sqlQuery1, con);
				SqlCommand cmd2 = new SqlCommand(sqlQuery2, con);
				SqlCommand cmd3 = new SqlCommand(sqlQuery3, con);
				SqlCommand cmd4 = new SqlCommand(sqlQuery4, con);
				SqlCommand cmd5 = new SqlCommand(sqlQuery5, con);


				int count1 = (int)cmd1.ExecuteScalar();
				int count2 = (int)cmd2.ExecuteScalar();
				int count3 = (int)cmd3.ExecuteScalar();
				int count4 = (int)cmd4.ExecuteScalar();
				int count5 = (int)cmd4.ExecuteScalar();

				chart1.Series["Doctors"].Points.AddXY("Neurology", count1);
				chart1.Series["Doctors"].Points.AddXY("Ophthalmology", count2);
				chart1.Series["Doctors"].Points.AddXY("Family medicine", count3);
				chart1.Series["Doctors"].Points.AddXY("Gastroenterologist", count4);
				chart1.Series["Doctors"].Points.AddXY("VP", count5);


				con.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		private void btnDoctorSchedule_Click(object sender, EventArgs e)
		{
			DoctorSchedule obj = new DoctorSchedule();
			obj.Show();
		}

		private void btnAppointment_Click(object sender, EventArgs e)
		{
			//check whather object is correct or not
			AppointmentManagment obj = new AppointmentManagment();
			obj.Show();
		}

		private void btnMedicationSchedule_Click(object sender, EventArgs e)
		{
			Consultation obj = new Consultation();
			obj.Show();
		}

		private void btnRoomAllocation_Click(object sender, EventArgs e)
		{
			Roomallocations obj = new Roomallocations();
			obj.Show();
		}

	

		private void btnPatientsMedicalRecords_Click(object sender, EventArgs e)
		{
			Resource obj = new Resource();
			obj.Show();
		}

		private void btnSearchforDoctors_Click(object sender, EventArgs e)
		{
			SearchDoctors obj = new SearchDoctors();
			obj.Show();
		}
	}
}
