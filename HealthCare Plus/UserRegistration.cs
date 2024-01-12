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
	public partial class UserRegistration : Form
	{
		string path = @"Data Source=DESKTOP-R998OAS;Initial Catalog=HealthCarePlus; Integrated Security=True;";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;
		int ID;

		public string role { get; set; }
		public UserRegistration()
		{
			InitializeComponent();
			con = new SqlConnection(path);
			btnDelete.Enabled = false;
		    btnUpdate.Enabled = false;
			display();
		
		}
		public void resetAllValue()
		{
			txtEmail.Text = "";
			txtPassword.Text = "";
			txtUserName.Text = "";
			rdoAdmin.Checked = false;
			rdoStaff.Checked = false;

		}


		public void display()
		{

			try
			{
				dt = new DataTable();
				con.Open();
				adpt = new SqlDataAdapter("select * from Users", con);
				dataGridView1.DataSource = dt;
				con.Close();
				adpt.Fill(dt);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}


		private void btnCreate_Click(object sender, EventArgs e)
		{


			if (txtUserName.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtEmail.Text == "" || (!rdoAdmin.Checked && !rdoStaff.Checked))
			{
				MessageBox.Show("All Fields are required...", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				try
				{
					con.Open();
					cmd = new SqlCommand("insert into Users (User_Name,Role,User_Email,Password) values('" + txtUserName.Text + "','" + role + "','" + txtEmail.Text + "','" + txtPassword.Text + "' ) ", con);
					cmd.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Patient Data has been Saved Successfully...");
					resetAllValue();
					display();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void rdoStaff_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoStaff.Checked)
			{
				role = "Staff";
			}
			else
			{
				role = "Admin";
			}
		}

		private void rdoAdmin_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoAdmin.Checked)
			{
				role = "Admin";
			}
			else
			{
				role = "Staff";
			}
		}

		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			txtUserName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			txtPassword.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

			if (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString() == "Staff")
			{
				rdoAdmin.Checked = false;
				rdoStaff.Checked = true;
			}
			else
			{
				rdoStaff.Checked = false;
				rdoAdmin.Checked = true;
			}

			btnDelete.Enabled = true;
			btnUpdate.Enabled = true;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{


			if (txtUserName.Text == "" || txtEmail.Text == "" || txtPassword.Text == "" || txtEmail.Text == "" || (!rdoAdmin.Checked && !rdoStaff.Checked))
			{
				MessageBox.Show("All Fields are required...", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				try
				{

					con.Open();
					cmd = new SqlCommand("update Users set User_Name='" + txtUserName.Text + "',Role='" + role + "',User_Email='" + txtEmail.Text + "',Password='" + txtPassword.Text + "' where User_Id='" + ID + "'", con);
					cmd.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("User data has been updated successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
				cmd = new SqlCommand("delete from Users where User_Id='" + ID + "'", con);
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Selected User Detail has been deleted successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				display();
				resetAllValue();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}
	}
}
