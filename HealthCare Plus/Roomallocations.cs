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
	public partial class Roomallocations : Form
	{

		string path = @"Data Source=DESKTOP-R998OAS;Initial Catalog=HealthCarePlus; Integrated Security=True;";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;
		Dictionary<int, string> idRoomMapping = new Dictionary<int, string>();

		Dictionary<int, string> idNameMapping = new Dictionary<int, string>();

		public string selectedRoom { get; set; }
		public int selectedRoomId { get; set; }

		public string selectedPatient { get; set; }
		public int selectedPatientId { get; set; }

		public int  roomPrice { get; set; }

		public int ID { get; set; }

		public Roomallocations()
		{
			InitializeComponent();
			con = new SqlConnection(path);
			display();
			fillPatientComboBox();
			fillRoomComboBox();

		}


		public void resetAllValue()
		{
			cmbPatientName.Text = "";
			cmbRoomNo.Text = "";
		
		}

		public void display()
		{
			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from Roomallocation", con);
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
					idNameMapping[id] = name;
				}

				con.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
		public void fillRoomComboBox()
		{
			cmd = new SqlCommand("SELECT * FROM Rooms WHERE Occupancy_Status='unoccupied'", con);
			SqlDataReader myreader;

			try
			{
				con.Open();
				myreader = cmd.ExecuteReader();


				while (myreader.Read())
				{
					int id = myreader.GetInt32(0);
					string name = myreader.GetString(1);

					cmbRoomNo.Items.Add(name);
					idRoomMapping[id] = name;
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
				selectedPatient = cmbPatientName.SelectedItem.ToString();
				selectedPatientId = idNameMapping.FirstOrDefault(x => x.Value == selectedPatient).Key;
			}

		}

		public void getRoomFee()
		{
			cmd = new SqlCommand("SELECT Room_Price FROM Rooms WHERE Room_Id='"+selectedRoomId+"'", con);
			SqlDataReader myreader;

			try
			{
				con.Open();
				myreader = cmd.ExecuteReader();


				while (myreader.Read())
				{
					roomPrice = myreader.GetInt32(0);
			
				}

				con.Close();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}


		private void btnAdd_Click(object sender, EventArgs e)
		{
			DateTime dateTime = DateTime.UtcNow.Date;


			getRoomFee();

			if (cmbPatientName.Text == "" || cmbRoomNo.Text == "")
			{

				MessageBox.Show("All Fields are required...", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-R998OAS;Initial Catalog=HealthCarePlus; Integrated Security=True;"))
				{
					con.Open();

					// Start a transaction
					SqlTransaction transaction = con.BeginTransaction();

					try
					{
						SqlCommand cmd1 = new SqlCommand("insert into Roomallocation(Patient_Id, Patient_Name, Room_Number, Room_Id) values('" + selectedPatientId + "', '" + selectedPatient + "', '" + selectedRoom + "', '" + selectedRoomId + "') ",con, transaction);
						cmd1.ExecuteNonQuery();

			
						SqlCommand cmd2 = new SqlCommand("UPDATE Rooms SET Occupancy_Status='occupied' WHERE Room_Id='" + selectedRoomId + "'", con, transaction);
						cmd2.ExecuteNonQuery();



						SqlCommand cmd3 = new SqlCommand("insert into Transactions(Patient_Id ,Patient_Name,Transaction_Name,Transaction_Date,Amount,Is_paid) values('" + selectedPatientId + "','" + selectedPatient + "', 'Room Charge' ,'" + dateTime.ToString("yyyy/MM/dd") + "','" + roomPrice + "','No') ", con, transaction);
						cmd3.ExecuteNonQuery();

						transaction.Commit();

						MessageBox.Show("Room has been Allocated Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



						resetAllValue();
						display();
						Roomallocations roomallocations = new Roomallocations();
						roomallocations.Show();
						this.Hide();

					}
					catch (Exception ex)
					{
						// An error occurred, so roll back the transaction
						transaction.Rollback();
						MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}


				//try
				//{

				//	con.Open();
				//	cmd = new SqlCommand("insert into Roomallocation(Patient_Id,Patient_Name,Room_Number,Room_Id) values('" + selectedPatientId + "','" + selectedPatient + "', '" + selectedRoom + "','" + selectedRoomId + "') ", con);
				//	cmd.ExecuteNonQuery();

				//	cmd = new SqlCommand("UPDATE Rooms SET Occupancy_Status='occupied' WHERE Room_Id='" + selectedRoomId + "'", con);
				//	cmd.ExecuteNonQuery();

				//	cmd = new SqlCommand("insert into Transactions(Patient_Id ,Patient_Name,Transaction_Name,Transaction_Date,Amount,Is_paid) values('" + selectedPatientId + "','" + selectedPatient + "', 'Room Charge' ,'" + dateTime.ToString("yyyy/MM/dd") + "','" + roomPrice + "','No') ", con);
				//	cmd.ExecuteNonQuery();

				//	con.Close();



				//	MessageBox.Show("Room Allocated Successfully...");
				//	resetAllValue();
				//	display();
				//	Roomallocations roomallocations = new Roomallocations();
				//	roomallocations.ShowDialog();
				//	this.Close();

				//}
				//catch (Exception ex)
				//{

				//	MessageBox.Show(ex.Message);
				//}
			}
		}

		private void cmbRoomNo_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbRoomNo.SelectedIndex != -1)
			{
				selectedRoom = cmbRoomNo.SelectedItem.ToString();
				selectedRoomId = idRoomMapping.FirstOrDefault(x => x.Value == selectedRoom).Key;
			}
		}

		//private void btnUpdate_Click(object sender, EventArgs e)
		//{

		//	Console.WriteLine(cmbPatientName.Text);
		//	Console.WriteLine(selectedPatientId);
		//	Console.WriteLine(cmbRoomNo.Text);
		//	Console.WriteLine(selectedRoomId);

		//	if (cmbPatientName.Text == "" || cmbRoomNo.Text == "")
		//	{
		//		MessageBox.Show("All Fields are required...");
		//	}
		//	else
		//	{
		//		try
		//		{
		//			con.Open();
		//			cmd = new SqlCommand("update Roomallocation set Patient_Id='" + selectedPatientId + "',Patient_Name ='" + cmbPatientName.Text + "',Room_Number ='" + selectedRoomId + "' where Roomalc_Id='" + ID + "'", con);
		//			cmd.ExecuteNonQuery();
		//			con.Close();
		//			MessageBox.Show("Allocated room data updated successfully...");
		//			display();
		//			resetAllValue();
		//		}
		//		catch (Exception ex)
		//		{

		//			MessageBox.Show(ex.Message);
		//		}
		//	}
		//}

		private void Roomallocations_Load(object sender, EventArgs e)
		{
			btnDelete.Enabled = false;
			btnClear.Enabled = false;
		
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			selectedPatientId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()) ;
			cmbPatientName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			cmbRoomNo.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			selectedRoomId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()) ;

			btnClear.Enabled = true;
			btnDelete.Enabled = true;
		
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{

				con.Open();
				cmd = new SqlCommand("delete from Roomallocation where Roomalc_Id='" + ID + "'", con);
				cmd.ExecuteNonQuery();
				cmd = new SqlCommand("UPDATE Rooms SET Occupancy_Status='unoccupied' WHERE Room_Id='" + selectedRoomId + "'", con);
				//here we need to implement a query to delete payment detail also 
				
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Selected record has been deleted successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


				display();
				resetAllValue();
				Roomallocations roomallocations = new Roomallocations();
				roomallocations.ShowDialog();
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			resetAllValue();
		}
	}
}
