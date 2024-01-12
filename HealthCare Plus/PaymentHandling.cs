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
	public partial class PaymentHandling : Form
	{

		string path = @"Data Source=DESKTOP-R998OAS;Initial Catalog=HealthCarePlus; Integrated Security=True;";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;
		Dictionary<int, string> idPatientNameMapping = new Dictionary<int, string>();

		public string selectedPatient { get; set; }
		public int selectedPatientId { get; set; }


		public decimal totalAmount { get; set; }
		public string paymentMethod { get; set; }

		public string deletedroomid { get; set; }

		public string insertedPaymentId { get; set; }



		public PaymentHandling()
		{
			InitializeComponent();
			con = new SqlConnection(path);
			//display();
			fillPatientComboBox();
		}

		public void display()
		{
			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from Transactions where Patient_Id='"+selectedPatientId+"' and Is_paid='No'", con);
				dataGridView1.DataSource = dt;
			
				// Check if there are any rows in the DataGridView
			
				adpt.Fill(dt);

				con.Close();
				if (dataGridView1.Rows.Count == 0)
				{
					// Display a message indicating no results
					MessageBox.Show("No matching patients found.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message,"this is from display",MessageBoxButtons.OK, MessageBoxIcon.Error);
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
					idPatientNameMapping[id] = name;
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
				selectedPatientId = idPatientNameMapping.FirstOrDefault(x => x.Value == selectedPatient).Key;
			}
		}

		private void btnSearchPatient_Click(object sender, EventArgs e)
		{
			//MessageBox.Show(selectedPatient);
			//Console.WriteLine(selectedPatientId);

			if (cmbPatientName.Text=="" || selectedPatient=="")
			{
				MessageBox.Show("No Patient selected.", "Empty Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			display();
	
			int rowIndexToCheck = 0;
			bool rowIsEmpty = true; 

			foreach (DataGridViewCell cell in dataGridView1.Rows[rowIndexToCheck].Cells)
			{
				if (cell.Value != null && !string.IsNullOrWhiteSpace(cell.Value.ToString()))
				{
					rowIsEmpty = false;
					break;
				}
			}

			if (rowIsEmpty)
			{
				// The row is empty (all cells are empty or contain whitespace)
				MessageBox.Show("There are no transactions for the selected Patient.", "Empty Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			 totalAmount = 0; // Initialize the total amount

			// Iterate through each row in the DataGridView
			foreach (DataGridViewRow row in dataGridView1.Rows)
			{
				// Check if the row is not a header row and the cell value is a valid decimal
				if (!row.IsNewRow && decimal.TryParse(row.Cells["Amount"].Value.ToString(), out decimal amount))
				{
					// Add the amount to the total
					totalAmount += amount;
				}
			}

			// Display or use the totalAmount as needed
			txtTotalAmount.Text = totalAmount.ToString();
		}

		private void btnPayNow_Click(object sender, EventArgs e)
		{
			if (txtTotalAmount.Text == "" || (!rdoCardPayment.Checked && !rdoCashpayment.Checked))
			{
				MessageBox.Show("Please Provide amount and payment method", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (txtTotalAmount.Text == "0")
			{
				MessageBox.Show("Can't Perform Transactions with this amount", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				using (con)
				{
					con.Open();

					// Start a transaction
					SqlTransaction transaction = con.BeginTransaction();

					try
					{

						SqlCommand cmd1 = new SqlCommand("INSERT INTO PaymentDetails (Payment_Type, Total_Amount,Payment_Date) OUTPUT INSERTED.* VALUES ('" + paymentMethod+"','"+totalAmount+"','" + DateTime.Today + "')", con, transaction);

						// Execute the DELETE statement and capture the deleted data
						SqlDataReader reader1 = cmd1.ExecuteReader();

						// Check if any data was deleted
						if (reader1.HasRows)
						{
							while (reader1.Read())
							{
								// Retrieve and process the deleted data from the reader
							    insertedPaymentId = reader1["Payment_Id"].ToString();
							}
						}

					

						reader1.Close();

						SqlCommand cmd2 = new SqlCommand("UPDATE Transactions SET Is_paid='Yes',Payment_Id='"+insertedPaymentId+"' WHERE Patient_Id='" + selectedPatientId + "' ", con, transaction);
						cmd2.ExecuteNonQuery();

						//SqlCommand cmd1 = new SqlCommand("UPDATE Transactions SET Is_paid='Yes' WHERE Patient_Id='" + selectedPatientId + "' ", con, transaction);
						//cmd1.ExecuteNonQuery();


						SqlCommand cmd3 = new SqlCommand("DELETE  FROM Roomallocation OUTPUT deleted.* WHERE Patient_Id ='" + selectedPatientId + "'", con, transaction);

						// Execute the DELETE statement and capture the deleted data
						SqlDataReader reader2 = cmd3.ExecuteReader();

						// Check if any data was deleted
						if (reader2.HasRows)
						{
							while (reader2.Read())
							{
								// Retrieve and process the deleted data from the reader
								deletedroomid = reader2["Room_Id"].ToString();
							}
						}

						reader2.Close();

						SqlCommand cmd4 = new SqlCommand("UPDATE Rooms SET Occupancy_Status='unoccupied' WHERE Room_Id='" + deletedroomid + "'", con, transaction);
						cmd4.ExecuteNonQuery();

						transaction.Commit();

						//MessageBox.Show("Payment Successful...");
						MessageBox.Show("Payment Successful...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

						PaymentHandling obj = new PaymentHandling();
						obj.Show();
						this.Hide();

					}
					catch (Exception ex)
					{
						// An error occurred, so roll back the transaction
						transaction.Rollback();
						MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void rdoCardPayment_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoCardPayment.Checked)
			{
				paymentMethod = "Card";
			}
			else
			{
				paymentMethod = "Cash";
			}
		}

		private void rdoCashpayment_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoCardPayment.Checked)
			{
				paymentMethod = "Card";
			}
			else
			{
				paymentMethod = "Cash";
			}
		}
	}
}
