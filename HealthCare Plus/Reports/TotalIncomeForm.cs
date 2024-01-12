using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus.Reports
{
	public partial class TotalIncomeForm : Form
	{

		public string numericPart { get; set; }

		public TotalIncomeForm()
		{
			InitializeComponent();
		}

		private void TotalIncomeForm_Load(object sender, EventArgs e)
		{

			//this.reportViewer2.RefreshReport();
		}

		private void btnGetIncomeReport_Click(object sender, EventArgs e)
		{
			
			string connectionString = "Data Source=DESKTOP-R998OAS;Initial Catalog=HealthCarePlus; Integrated Security=True;";

			SqlConnection con = new SqlConnection(connectionString);
			SqlDataAdapter da1 = new SqlDataAdapter("SELECT Payment_Id,Payment_Type,Total_Amount, CAST(Payment_Date AS DATE) AS DateOnly FROM PaymentDetails WHERE MONTH(Payment_Date) = '"+ numericPart + "'", con);
			DataSet2 ds2 = new DataSet2();
			da1.Fill(ds2, "Total_Income_Details");
			//in the below code we need to consider DataSet1_Report value
			ReportDataSource dataSource1 = new ReportDataSource("DataSet_Income_Detail", ds2.Tables[0]);


			SqlDataAdapter da2 = new SqlDataAdapter("SELECT SUM(Total_Amount) AS TotalAmount FROM PaymentDetails WHERE MONTH(Payment_Date) ='"+ numericPart + "'", con);
			DataSet3 ds3 = new DataSet3();
			da2.Fill(ds3, "Total_Income");
			//in the below code we need to consider DataSet1_Report value
			ReportDataSource dataSource2 = new ReportDataSource("DataSet_Total_Income", ds3.Tables[0]);

			this.reportViewer2.LocalReport.DataSources.Clear();
			this.reportViewer2.LocalReport.DataSources.Add(dataSource1);
			this.reportViewer2.LocalReport.DataSources.Add(dataSource2);
			this.reportViewer2.RefreshReport();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			string text = cmbMonthSelection.Text;
			string[] parts = text.Split(' ');

			// Extract the numeric part (the first element of the array)
			 numericPart = parts[0];

		}
	}
}
