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
	public partial class BookingDoctor : Form
	{
		string path = @"Data Source=DESKTOP-R998OAS;Initial Catalog=HealthCarePlus; Integrated Security=True;";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;


		public int patientId { set; get; }
		public int doctorId { set; get; }
		public int scheduleId { set; get; }

		public TimeSpan time { set; get; }
		public int fee { set; get; }

		public string consultDate { get; set; }



		public BookingDoctor(int scheduleId, int patientId, int doctorId, TimeSpan time, int fee)
		{
			this.patientId = patientId;
			this.doctorId = doctorId;
			this.scheduleId = scheduleId;
			this.time = time;
			this.fee = fee;

			InitializeComponent();
			//con = new SqlConnection(path);

			displayPatientDetails();
			displayDoctorDetails();
			displaySheduleDetails();
		}




		public void displayPatientDetails()
		{
			// Establish a connection to the SQL Server database
			using (con = new SqlConnection("Data Source=DESKTOP-R998OAS;Initial Catalog=HealthCarePlus; Integrated Security=True;"))
			{
				con.Open();

				// Create a SQL command to fetch data 
				using (cmd = new SqlCommand("SELECT * FROM Patients where Patient_Id='" + patientId + "'", con))
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					// Read data from the database
					if (reader.Read())
					{
						lblPatientName.Text = reader["Patient_Name"].ToString();
						lblAge.Text = reader["Age"].ToString();
						lblGender.Text = reader["Gender"].ToString();
						lblContactNumber.Text = reader["Phone"].ToString();

						// Now, you have the data in firstName and lastName variables
					}
				}

			}



		}


		public void displayDoctorDetails()
		{
			// Establish a connection to the SQL Server database
			using (con = new SqlConnection("Data Source=DESKTOP-R998OAS;Initial Catalog=HealthCarePlus; Integrated Security=True;"))
			{
				con.Open();

				// Create a SQL command to fetch data 
				using (cmd = new SqlCommand("SELECT * FROM Doctors where Doctor_Id='" + doctorId + "'", con))
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					// Read data from the database
					if (reader.Read())
					{
						lblDoctorName.Text = reader["Doctor_Name"].ToString();
						lblSpecialization.Text = reader["Specialization"].ToString();
						lblExpertise.Text = reader["Expertise"].ToString();
						lblDcotorContactNumber.Text = reader["Contact"].ToString();

						// Now, you have the data in firstName and lastName variables
					}
				}

			}



		}


		public void displaySheduleDetails()
		{
			// Establish a connection to the SQL Server database
			using (con = new SqlConnection("Data Source=DESKTOP-R998OAS;Initial Catalog=HealthCarePlus; Integrated Security=True;"))
			{
				con.Open();

				// Create a SQL command to fetch data 
				using (cmd = new SqlCommand("SELECT * FROM Doctorschedule where Shedule_Id='" + scheduleId + "'", con))
				using (SqlDataReader reader = cmd.ExecuteReader())
				{
					// Read data from the database
					if (reader.Read())
					{
					   

						string inputDate = reader["Consult_Date"].ToString();
						DateTime dateValue = DateTime.Parse(inputDate);
						consultDate = dateValue.ToShortDateString(); // take only date

						lblDay.Text = consultDate;
				
						lblBookingTime.Text = time.ToString();

					}
				}

			}

		}

		private void btnBooking_Click(object sender, EventArgs e)
		{
			DateTime dateTime = DateTime.UtcNow.Date;

			using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-R998OAS;Initial Catalog=HealthCarePlus; Integrated Security=True;"))
			{
				con.Open();
				SqlTransaction transaction = con.BeginTransaction();

				try
				{
					using (SqlCommand cmd = new SqlCommand("insert into DoctorAppointment(Shedule_Id,Patient_Id,Patient_Name,Doctor_Id,Doctor_Name,Consult_Date,Booked_Time) values(@scheduleId, @patientId, @patientName, @doctorId, @doctorName, @consultDate, @bookingTime)", con))
					{
						cmd.Parameters.AddWithValue("@scheduleId", scheduleId);
						cmd.Parameters.AddWithValue("@patientId", patientId);
						cmd.Parameters.AddWithValue("@patientName", lblPatientName.Text);
						cmd.Parameters.AddWithValue("@doctorId", doctorId);
						cmd.Parameters.AddWithValue("@doctorName", lblDoctorName.Text);

						cmd.Parameters.AddWithValue("@consultDate", consultDate);
						cmd.Parameters.AddWithValue("@bookingTime", lblBookingTime.Text);

						cmd.Transaction = transaction;
						cmd.ExecuteNonQuery();
					}

					MessageBox.Show("Doctor Booked Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

					// If the DoctorAppointment insert is successful, proceed to insert into the Payment table.
					//  code for inserting into the Payment table here...
					using (SqlCommand cmd = new SqlCommand("insert into Transactions(Patient_Id ,Patient_Name,Transaction_Name,Transaction_Date,Amount,Is_paid) values('" + patientId + "','" + lblPatientName.Text + "', 'Doctor Fee' ,'"+dateTime.ToString("yyyy/MM/dd")+"','" + fee + "','No') ", con))
					{
						cmd.Transaction = transaction;
						cmd.ExecuteNonQuery();
						MessageBox.Show("Transaction Inserted Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}



					// Commit the transaction if everything is successful.
					transaction.Commit();
					this.Close();
					con.Close();
				}
				catch (Exception ex)
				{
					// Handle any exceptions here, and roll back the transaction if necessary.
					transaction.Rollback();
					MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

			}


				//if (lblPatientName.Text == "" || lblDoctorName.Text == "" || lblDay.Text=="" || lblBookingTime.ToString() == "")
				//{
				//	MessageBox.Show("All Fields are required...");
				//}
				//else
				//{
				//	try
				//	{
				//		con = new SqlConnection("Data Source=DESKTOP-R998OAS;Initial Catalog=HealthCarePlus; Integrated Security=True;");
				//		con.Open();
				//		cmd = new SqlCommand("insert into DoctorAppointment(Shedule_Id,Patient_Id,Patient_Name,Doctor_Id,Doctor_Name,Day,Booked_Time) values('" + scheduleId + "','" + patientId + "', '" + lblPatientName.Text + "','" + doctorId + "','" + lblDoctorName.Text + "','"+lblDay.Text+"','"+lblBookingTime.Text+"') ", con);
				//		cmd.ExecuteNonQuery();
				//		con.Close();
				//		MessageBox.Show("Doctor Booked Successfully...");
				//		this.Close();

				//	}
				//	catch (Exception ex)
				//	{
				//		MessageBox.Show(ex.Message);
				//	}
				//}

			}
		}
}
