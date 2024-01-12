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
using Microsoft.Reporting.WinForms;

namespace HealthCare_Plus.Reports
{
	public partial class PatientsDetails : Form
	{
		string path = @"Data Source=DESKTOP-R998OAS;Initial Catalog=HealthCarePlus; Integrated Security=True;";
		SqlConnection con;
		SqlCommand cmd;
		SqlDataAdapter adpt;
		DataTable dt;
		public PatientsDetails()
		{
			InitializeComponent();
			con = new SqlConnection(path);
		}

		private void PatientsDetails_Load(object sender, EventArgs e)
		{

			this.reportViewer1.RefreshReport();

			con.Open();
			SqlCommand cmd = new SqlCommand("select * from Patients",con);
			adpt = new SqlDataAdapter(cmd);
			dt = new DataTable();
			adpt.Fill(dt);

			reportViewer1.LocalReport.DataSources.Clear();
			ReportDataSource source = new ReportDataSource("DataSet4",dt);

			reportViewer1.LocalReport.ReportPath = @"C:\Users\msmua\source\repos\HealthCare Plus\HealthCare Plus\Reports\Report3.rdlc";

			reportViewer1.LocalReport.DataSources.Add(source);
			reportViewer1.RefreshReport();


		}
	}
}
