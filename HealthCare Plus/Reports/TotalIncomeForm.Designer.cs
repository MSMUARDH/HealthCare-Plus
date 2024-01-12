
namespace HealthCare_Plus.Reports
{
	partial class TotalIncomeForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
			this.Total_Income_DetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DataSet2 = new HealthCare_Plus.Reports.DataSet2();
			this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.cmbMonthSelection = new System.Windows.Forms.ComboBox();
			this.btnGetIncomeReport = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.Total_Income_DetailsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataSet2)).BeginInit();
			this.SuspendLayout();
			// 
			// Total_Income_DetailsBindingSource
			// 
			this.Total_Income_DetailsBindingSource.DataMember = "Total_Income_Details";
			this.Total_Income_DetailsBindingSource.DataSource = this.DataSet2;
			// 
			// DataSet2
			// 
			this.DataSet2.DataSetName = "DataSet2";
			this.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// reportViewer2
			// 
			reportDataSource1.Name = "DataSet_Income_Detail";
			reportDataSource1.Value = this.Total_Income_DetailsBindingSource;
			this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer2.LocalReport.ReportEmbeddedResource = "HealthCare_Plus.Reports.Report2.rdlc";
			this.reportViewer2.Location = new System.Drawing.Point(49, 151);
			this.reportViewer2.Name = "reportViewer2";
			this.reportViewer2.ServerReport.BearerToken = null;
			this.reportViewer2.Size = new System.Drawing.Size(694, 287);
			this.reportViewer2.TabIndex = 0;
			// 
			// cmbMonthSelection
			// 
			this.cmbMonthSelection.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbMonthSelection.FormattingEnabled = true;
			this.cmbMonthSelection.Items.AddRange(new object[] {
            "1 - January",
            "2 - February",
            "3 - March",
            "4 - April",
            "5 - May",
            "6 - June",
            "7 - July",
            "8 - August",
            "9 - September",
            "10 - October",
            "11 - November",
            "12 - December"});
			this.cmbMonthSelection.Location = new System.Drawing.Point(263, 89);
			this.cmbMonthSelection.Name = "cmbMonthSelection";
			this.cmbMonthSelection.Size = new System.Drawing.Size(121, 25);
			this.cmbMonthSelection.TabIndex = 1;
			this.cmbMonthSelection.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// btnGetIncomeReport
			// 
			this.btnGetIncomeReport.BackColor = System.Drawing.Color.SeaGreen;
			this.btnGetIncomeReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGetIncomeReport.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnGetIncomeReport.Location = new System.Drawing.Point(404, 83);
			this.btnGetIncomeReport.Name = "btnGetIncomeReport";
			this.btnGetIncomeReport.Size = new System.Drawing.Size(106, 34);
			this.btnGetIncomeReport.TabIndex = 2;
			this.btnGetIncomeReport.Text = "Get Report";
			this.btnGetIncomeReport.UseVisualStyleBackColor = false;
			this.btnGetIncomeReport.Click += new System.EventHandler(this.btnGetIncomeReport_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Location = new System.Drawing.Point(304, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(159, 30);
			this.label1.TabIndex = 3;
			this.label1.Text = "Income Report";
			// 
			// TotalIncomeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnGetIncomeReport);
			this.Controls.Add(this.cmbMonthSelection);
			this.Controls.Add(this.reportViewer2);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(816, 489);
			this.MinimumSize = new System.Drawing.Size(816, 489);
			this.Name = "TotalIncomeForm";
			this.Text = "Total Income Form";
			this.Load += new System.EventHandler(this.TotalIncomeForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.Total_Income_DetailsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataSet2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
		private System.Windows.Forms.ComboBox cmbMonthSelection;
		private System.Windows.Forms.Button btnGetIncomeReport;
		private System.Windows.Forms.BindingSource Total_Income_DetailsBindingSource;
		private DataSet2 DataSet2;
		private System.Windows.Forms.Label label1;
	}
}