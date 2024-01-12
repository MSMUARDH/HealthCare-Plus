
namespace HealthCare_Plus.Reports
{
	partial class PrintInvoiceForm
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
			this.DataTable_InvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.DataSet1 = new HealthCare_Plus.Reports.DataSet1();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.txtInvoiceNo = new System.Windows.Forms.TextBox();
			this.brnPrintSlip = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.DataTable_InvoiceBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// DataTable_InvoiceBindingSource
			// 
			this.DataTable_InvoiceBindingSource.DataMember = "DataTable_Invoice";
			this.DataTable_InvoiceBindingSource.DataSource = this.DataSet1;
			// 
			// DataSet1
			// 
			this.DataSet1.DataSetName = "DataSet1";
			this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// reportViewer1
			// 
			this.reportViewer1.BackColor = System.Drawing.SystemColors.ControlLight;
			reportDataSource1.Name = "DataSet_Report";
			reportDataSource1.Value = this.DataTable_InvoiceBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "HealthCare_Plus.Reports.Report1.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(20, 165);
			this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(839, 268);
			this.reportViewer1.TabIndex = 0;
			// 
			// txtInvoiceNo
			// 
			this.txtInvoiceNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtInvoiceNo.Location = new System.Drawing.Point(302, 101);
			this.txtInvoiceNo.Margin = new System.Windows.Forms.Padding(2);
			this.txtInvoiceNo.Multiline = true;
			this.txtInvoiceNo.Name = "txtInvoiceNo";
			this.txtInvoiceNo.Size = new System.Drawing.Size(142, 34);
			this.txtInvoiceNo.TabIndex = 1;
			// 
			// brnPrintSlip
			// 
			this.brnPrintSlip.BackColor = System.Drawing.Color.SeaGreen;
			this.brnPrintSlip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.brnPrintSlip.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.brnPrintSlip.Location = new System.Drawing.Point(473, 101);
			this.brnPrintSlip.Margin = new System.Windows.Forms.Padding(2);
			this.brnPrintSlip.Name = "brnPrintSlip";
			this.brnPrintSlip.Size = new System.Drawing.Size(77, 34);
			this.brnPrintSlip.TabIndex = 2;
			this.brnPrintSlip.Text = "Print Bill";
			this.brnPrintSlip.UseVisualStyleBackColor = false;
			this.brnPrintSlip.Click += new System.EventHandler(this.brnPrintSlip_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.SystemColors.Control;
			this.label11.Location = new System.Drawing.Point(387, 9);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(90, 30);
			this.label11.TabIndex = 13;
			this.label11.Text = "Invoice ";
			// 
			// PrintInvoiceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(882, 453);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.brnPrintSlip);
			this.Controls.Add(this.txtInvoiceNo);
			this.Controls.Add(this.reportViewer1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "PrintInvoiceForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Print InvoiceForm";
			this.Load += new System.EventHandler(this.PrintInvoiceForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.DataTable_InvoiceBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.TextBox txtInvoiceNo;
		private System.Windows.Forms.Button brnPrintSlip;
		private System.Windows.Forms.BindingSource DataTable_InvoiceBindingSource;
		private DataSet1 DataSet1;
		private System.Windows.Forms.Label label11;
	}
}