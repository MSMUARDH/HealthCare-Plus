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
	public partial class PrintInvoiceForm : Form
	{
		//string path = @"Data Source=DESKTOP-R998OAS;Initial Catalog=HealthCarePlus; Integrated Security=True;";
		//SqlConnection con;
		//SqlCommand cmd;
		//SqlDataAdapter adpt;
		//DataTable dt;
		public PrintInvoiceForm()
		{
			InitializeComponent();
			//con = new SqlConnection(path);
		}

		private void PrintInvoiceForm_Load(object sender, EventArgs e)
		{

			//this.reportViewer1.RefreshReport();
		}

		private void brnPrintSlip_Click(object sender, EventArgs e)
		{
			if (txtInvoiceNo.Text == "")
			{
				MessageBox.Show("Please insert an Invoice ID", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				string connectionString = "Data Source=DESKTOP-R998OAS;Initial Catalog=HealthCarePlus; Integrated Security=True;";
				SqlConnection con = new SqlConnection(connectionString);
				SqlDataAdapter da = new SqlDataAdapter("SELECT T.Transaction_Id,T.Patient_Id,P.Patient_Name,T.Transaction_Name,T.Amount, T.Is_paid,T.Payment_Id,PD.Payment_Type,PD.Total_Amount FROM Transactions AS T INNER JOIN PaymentDetails AS PD ON T.Payment_Id = PD.Payment_Id INNER JOIN Patients AS P ON T.Patient_Id = P.Patient_Id where PD.Payment_Id='" + txtInvoiceNo.Text + "';", con);
				//adpt = new SqlDataAdapter("SELECT T.Transaction_Id,T.Patient_Id,T.Patient_Name,T.Transaction_Name,T.Transaction_Date,T.Amount,T.Is_paid,P.Payment_Type,P.Total_AmountFROM Transactions AS TINNER JOIN PaymentDetails AS P ON T.Payment_Id = P.Payment_Id where Patient_Id =3 ", con);
				DataSet1 ds = new DataSet1();
				da.Fill(ds, "DataTable_Invoice");
				//in the below code we need to consider DataSet1_Report value
				ReportDataSource dataSource = new ReportDataSource("DataSet_Report", ds.Tables[0]);

				this.reportViewer1.LocalReport.DataSources.Clear();
				this.reportViewer1.LocalReport.DataSources.Add(dataSource);
				this.reportViewer1.RefreshReport();
			}
			
		}

	
	}
}
