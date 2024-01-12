
namespace HealthCare_Plus
{
	partial class ReportManagment
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportManagment));
			this.btnPayment = new System.Windows.Forms.Button();
			this.btnReportTotalIncome = new System.Windows.Forms.Button();
			this.btnReport = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnPayment
			// 
			this.btnPayment.BackColor = System.Drawing.Color.SeaGreen;
			this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPayment.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnPayment.Image")));
			this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPayment.Location = new System.Drawing.Point(198, 89);
			this.btnPayment.Name = "btnPayment";
			this.btnPayment.Size = new System.Drawing.Size(122, 61);
			this.btnPayment.TabIndex = 4;
			this.btnPayment.Text = "Invoice";
			this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPayment.UseVisualStyleBackColor = false;
			this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
			// 
			// btnReportTotalIncome
			// 
			this.btnReportTotalIncome.BackColor = System.Drawing.Color.SeaGreen;
			this.btnReportTotalIncome.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReportTotalIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReportTotalIncome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReportTotalIncome.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnReportTotalIncome.Image = ((System.Drawing.Image)(resources.GetObject("btnReportTotalIncome.Image")));
			this.btnReportTotalIncome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReportTotalIncome.Location = new System.Drawing.Point(21, 89);
			this.btnReportTotalIncome.Name = "btnReportTotalIncome";
			this.btnReportTotalIncome.Size = new System.Drawing.Size(150, 61);
			this.btnReportTotalIncome.TabIndex = 2;
			this.btnReportTotalIncome.Text = "Total income";
			this.btnReportTotalIncome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnReportTotalIncome.UseVisualStyleBackColor = false;
			this.btnReportTotalIncome.Click += new System.EventHandler(this.btnReportTotalIncome_Click);
			// 
			// btnReport
			// 
			this.btnReport.BackColor = System.Drawing.Color.SeaGreen;
			this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReport.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
			this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReport.Location = new System.Drawing.Point(341, 88);
			this.btnReport.Name = "btnReport";
			this.btnReport.Size = new System.Drawing.Size(172, 62);
			this.btnReport.TabIndex = 3;
			this.btnReport.Text = "Patients Details";
			this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnReport.UseVisualStyleBackColor = false;
			this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Location = new System.Drawing.Point(178, 21);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 25);
			this.label1.TabIndex = 5;
			this.label1.Text = "Click Report Type";
			// 
			// ReportManagment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(534, 266);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnPayment);
			this.Controls.Add(this.btnReportTotalIncome);
			this.Controls.Add(this.btnReport);
			this.MaximumSize = new System.Drawing.Size(550, 305);
			this.MinimumSize = new System.Drawing.Size(550, 305);
			this.Name = "ReportManagment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Report Managment";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnPayment;
		private System.Windows.Forms.Button btnReportTotalIncome;
		private System.Windows.Forms.Button btnReport;
		private System.Windows.Forms.Label label1;
	}
}