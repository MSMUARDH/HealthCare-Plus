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
	public partial class AdminDashboard : Form
	{
		string path = @"Data Source=DESKTOP-R998OAS;Initial Catalog=HealthCarePlus; Integrated Security=True;";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;
		public AdminDashboard()
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

		private void timer1_Tick_1(object sender, EventArgs e)
		{
			lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
			lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

			display();
		}

		private void AdminDashboard_Load(object sender, EventArgs e)
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

		private void btnPatientManagment_Click(object sender, EventArgs e)
		{
			PatientRegistrationForm patient = new PatientRegistrationForm();

			patient.ShowDialog();
		}

		private void btnConsultations_Click(object sender, EventArgs e)
		{
			ReportManagment obj = new ReportManagment();

			obj.Show();
		}

		private void btnRoomDetails_Click(object sender, EventArgs e)
		{
			Room room = new Room();

			room.ShowDialog();
		}

		private void btnDoctorManagment_Click(object sender, EventArgs e)
		{
			DoctorRegistrationForm doctor = new DoctorRegistrationForm();

			doctor.ShowDialog();
		}

		private void btnResources_Click(object sender, EventArgs e)
		{
			Resource resource= new Resource();
			
			resource.ShowDialog();
		}

		private void btnPayment_Click(object sender, EventArgs e)
		{
			PaymentHandling payment = new PaymentHandling();

			payment.ShowDialog();
		}

		private void AdminDashboard_FormClosing(object sender, FormClosingEventArgs e)
		{
			LogIn obj = new LogIn();
			obj.Show();
			this.Hide();
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void btnUserManagment_Click(object sender, EventArgs e)
		{
			UserRegistration payment = new UserRegistration();

			payment.ShowDialog();
		}
	}
}
