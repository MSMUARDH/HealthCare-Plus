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
	public partial class LogIn : Form
	{
		string path = @"Data Source=DESKTOP-R998OAS;Initial Catalog=HealthCarePlus; Integrated Security=True;";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;

		public string Role { get; set; }

		public LogIn()
		{
			InitializeComponent();
			con = new SqlConnection(path);

		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (txtUserName.Text=="" || txtPassword.Text =="" || (!rdoAdmin.Checked && !rdoStaff.Checked)  )
			{
				//MessageBox.Show("Please provide all the details...");
				MessageBox.Show("Please provide all the details...", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				try
				{
					cmd = new SqlCommand("select * from Users where User_Name=@name and Password=@password and Role=@role", con);
					cmd.Parameters.Add("@name", txtUserName.Text);
					cmd.Parameters.Add("@password", txtPassword.Text);
					cmd.Parameters.Add("@role",Role);

					adpt = new SqlDataAdapter(cmd);
					DataSet ds = new DataSet();
					adpt.Fill(ds);

					int count = ds.Tables[0].Rows.Count;

					if (count == 1  && Role=="Admin")
					{
						AdminDashboard obj = new AdminDashboard();
						this.Hide();
						obj.Show();
					}else if (count == 1 && Role == "Staff")
					{
						StaffDashBoard obj = new StaffDashBoard();
						this.Hide();
						obj.Show();
					}
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
				Role = "Staff";
			}
		}

		private void rdoAdmin_CheckedChanged(object sender, EventArgs e)
		{
			if (rdoAdmin.Checked)
			{
				Role = "Admin";
			}
		}

		
	}
}
