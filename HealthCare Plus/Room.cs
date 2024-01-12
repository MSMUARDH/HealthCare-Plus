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
	public partial class Room : Form
	{
		string path = @"Data Source=DESKTOP-R998OAS;Initial Catalog=HealthCarePlus; Integrated Security=True;";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;
		int ID;

		public Room()
		{
			InitializeComponent();
			con = new SqlConnection(path);
			display();
			btnClear.Enabled = false;
			btnDelete.Enabled = false;
			btnUpdate.Enabled = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (txtRoomNo.Text == "" || txtRoomPrice.Text == "" || (!rbtnActive.Checked && !rbtnInactive.Checked))
			{

				MessageBox.Show("All Fields are required...", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				try
				{
					string Occupancy_Status;

					if (rbtnActive.Checked)
					{
						Occupancy_Status = "occupied";
					}
					else
					{
						Occupancy_Status = "unoccupied";
					}

					con.Open();
					cmd = new SqlCommand("insert into Rooms (Room_Number,Room_Price,Occupancy_Status) values('" + int.Parse(txtRoomNo.Text) + "','" + int.Parse(txtRoomPrice.Text) + "','" + Occupancy_Status + "') ", con);
					cmd.ExecuteNonQuery();
					con.Close();
					//MessageBox.Show("Room Data has been Saved Successfully...");
					MessageBox.Show("Room Data has been Saved Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
			txtRoomNo.Text = "";
			txtRoomPrice.Text = "";
			rbtnActive.Checked = false;
			rbtnInactive.Checked = false;
		}


		public void display()
		{

			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from Rooms", con);
				dataGridView1.DataSource = dt;
				con.Close();
				adpt.Fill(dt);
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

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			txtRoomNo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtRoomPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();

			if (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() == "occupied")
			{
				rbtnActive.Checked = true;
				rbtnInactive.Checked = false;
			}
			else
			{
				rbtnActive.Checked = false;
				rbtnInactive.Checked = true;
			}

			btnClear.Enabled = true;
			btnDelete.Enabled = true;
			btnUpdate.Enabled = true;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				string Occupancy_Status;

				if (rbtnActive.Checked)
				{
					Occupancy_Status = "occupied";
				}
				else
				{
					Occupancy_Status = "unoccupied";
				}
				//Room_Number,Room_Price,Occupancy_Status
				con.Open();
				cmd = new SqlCommand("update Rooms set Room_Number='" + txtRoomNo.Text + "',Room_Price='" + txtRoomPrice.Text + "',Occupancy_Status='" + Occupancy_Status + "'where Room_Id='" + ID + "'", con);
				cmd.ExecuteNonQuery();
				con.Close();
				//MessageBox.Show("Room data has been updated successfully...");
				MessageBox.Show("Room data has been updated successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
				cmd = new SqlCommand("delete from Rooms where Room_Id='" + ID + "'", con);
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

	
	}
}
