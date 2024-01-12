using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus
{
	public partial class ReportManagment : Form
	{
		public ReportManagment()
		{
			InitializeComponent();
		}

		private void btnReportTotalIncome_Click(object sender, EventArgs e)
		{
			Reports.TotalIncomeForm obj = new Reports.TotalIncomeForm();
			obj.Show();
		}

		private void btnPayment_Click(object sender, EventArgs e)
		{
			Reports.PrintInvoiceForm obj = new Reports.PrintInvoiceForm();
			obj.Show();
		}

		private void btnReport_Click(object sender, EventArgs e)
		{
			Reports.PatientsDetails obj = new Reports.PatientsDetails();
			obj.Show();
		}
	}
}
