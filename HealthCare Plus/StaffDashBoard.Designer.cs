
namespace HealthCare_Plus
{
	partial class StaffDashBoard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDashBoard));
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.btnDoctorSchedule = new System.Windows.Forms.Button();
			this.btnAppointment = new System.Windows.Forms.Button();
			this.btnPatientsMedicalRecords = new System.Windows.Forms.Button();
			this.btnSearchforDoctors = new System.Windows.Forms.Button();
			this.btnMedicationSchedule = new System.Windows.Forms.Button();
			this.btnRoomAllocation = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lblTime = new System.Windows.Forms.Label();
			this.lblDate = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.lblRoomAllocatedCount = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.lblVacantRoom = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.lblPatientsCount = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.lblDoctorsCount = new System.Windows.Forms.Label();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnDoctorSchedule
			// 
			this.btnDoctorSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDoctorSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDoctorSchedule.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDoctorSchedule.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnDoctorSchedule.Image = ((System.Drawing.Image)(resources.GetObject("btnDoctorSchedule.Image")));
			this.btnDoctorSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDoctorSchedule.Location = new System.Drawing.Point(14, 22);
			this.btnDoctorSchedule.Name = "btnDoctorSchedule";
			this.btnDoctorSchedule.Size = new System.Drawing.Size(165, 63);
			this.btnDoctorSchedule.TabIndex = 0;
			this.btnDoctorSchedule.Text = "Doctor Schedule";
			this.btnDoctorSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDoctorSchedule.UseVisualStyleBackColor = true;
			this.btnDoctorSchedule.Click += new System.EventHandler(this.btnDoctorSchedule_Click);
			// 
			// btnAppointment
			// 
			this.btnAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAppointment.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAppointment.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnAppointment.Image = ((System.Drawing.Image)(resources.GetObject("btnAppointment.Image")));
			this.btnAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAppointment.Location = new System.Drawing.Point(185, 22);
			this.btnAppointment.Name = "btnAppointment";
			this.btnAppointment.Size = new System.Drawing.Size(227, 63);
			this.btnAppointment.TabIndex = 0;
			this.btnAppointment.Text = "Appointment Managment";
			this.btnAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAppointment.UseVisualStyleBackColor = true;
			this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
			// 
			// btnPatientsMedicalRecords
			// 
			this.btnPatientsMedicalRecords.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPatientsMedicalRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPatientsMedicalRecords.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPatientsMedicalRecords.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnPatientsMedicalRecords.Image = ((System.Drawing.Image)(resources.GetObject("btnPatientsMedicalRecords.Image")));
			this.btnPatientsMedicalRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPatientsMedicalRecords.Location = new System.Drawing.Point(418, 22);
			this.btnPatientsMedicalRecords.Name = "btnPatientsMedicalRecords";
			this.btnPatientsMedicalRecords.Size = new System.Drawing.Size(218, 63);
			this.btnPatientsMedicalRecords.TabIndex = 0;
			this.btnPatientsMedicalRecords.Text = "Patients Medical Records";
			this.btnPatientsMedicalRecords.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPatientsMedicalRecords.UseVisualStyleBackColor = true;
			this.btnPatientsMedicalRecords.Click += new System.EventHandler(this.btnPatientsMedicalRecords_Click);
			// 
			// btnSearchforDoctors
			// 
			this.btnSearchforDoctors.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearchforDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearchforDoctors.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearchforDoctors.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnSearchforDoctors.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchforDoctors.Image")));
			this.btnSearchforDoctors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSearchforDoctors.Location = new System.Drawing.Point(797, 22);
			this.btnSearchforDoctors.Name = "btnSearchforDoctors";
			this.btnSearchforDoctors.Size = new System.Drawing.Size(192, 63);
			this.btnSearchforDoctors.TabIndex = 0;
			this.btnSearchforDoctors.Text = "Search For Doctors";
			this.btnSearchforDoctors.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSearchforDoctors.UseVisualStyleBackColor = true;
			this.btnSearchforDoctors.Click += new System.EventHandler(this.btnSearchforDoctors_Click);
			// 
			// btnMedicationSchedule
			// 
			this.btnMedicationSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMedicationSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMedicationSchedule.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMedicationSchedule.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnMedicationSchedule.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicationSchedule.Image")));
			this.btnMedicationSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnMedicationSchedule.Location = new System.Drawing.Point(642, 22);
			this.btnMedicationSchedule.Name = "btnMedicationSchedule";
			this.btnMedicationSchedule.Size = new System.Drawing.Size(149, 63);
			this.btnMedicationSchedule.TabIndex = 0;
			this.btnMedicationSchedule.Text = "Consultation";
			this.btnMedicationSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnMedicationSchedule.UseVisualStyleBackColor = true;
			this.btnMedicationSchedule.Click += new System.EventHandler(this.btnMedicationSchedule_Click);
			// 
			// btnRoomAllocation
			// 
			this.btnRoomAllocation.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRoomAllocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRoomAllocation.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRoomAllocation.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnRoomAllocation.Image = ((System.Drawing.Image)(resources.GetObject("btnRoomAllocation.Image")));
			this.btnRoomAllocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRoomAllocation.Location = new System.Drawing.Point(995, 22);
			this.btnRoomAllocation.Name = "btnRoomAllocation";
			this.btnRoomAllocation.Size = new System.Drawing.Size(177, 63);
			this.btnRoomAllocation.TabIndex = 0;
			this.btnRoomAllocation.Text = "Room Allocation";
			this.btnRoomAllocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRoomAllocation.UseVisualStyleBackColor = true;
			this.btnRoomAllocation.Click += new System.EventHandler(this.btnRoomAllocation_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.panel1.Controls.Add(this.btnAppointment);
			this.panel1.Controls.Add(this.btnMedicationSchedule);
			this.panel1.Controls.Add(this.btnSearchforDoctors);
			this.panel1.Controls.Add(this.btnDoctorSchedule);
			this.panel1.Controls.Add(this.btnRoomAllocation);
			this.panel1.Controls.Add(this.btnPatientsMedicalRecords);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1192, 113);
			this.panel1.TabIndex = 3;
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblTime.Location = new System.Drawing.Point(553, 373);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(43, 19);
			this.lblTime.TabIndex = 5;
			this.lblTime.Text = "Time";
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblDate.Location = new System.Drawing.Point(731, 373);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(41, 19);
			this.lblDate.TabIndex = 5;
			this.lblDate.Text = "Date";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(504, 373);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 19);
			this.label1.TabIndex = 5;
			this.label1.Text = "Time";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label2.Location = new System.Drawing.Point(684, 373);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 19);
			this.label2.TabIndex = 5;
			this.label2.Text = "Date";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.lblRoomAllocatedCount);
			this.panel2.Location = new System.Drawing.Point(370, 203);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(167, 95);
			this.panel2.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(9, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(143, 18);
			this.label4.TabIndex = 1;
			this.label4.Text = "Occupied Rooms";
			// 
			// lblRoomAllocatedCount
			// 
			this.lblRoomAllocatedCount.AutoSize = true;
			this.lblRoomAllocatedCount.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRoomAllocatedCount.Location = new System.Drawing.Point(62, 39);
			this.lblRoomAllocatedCount.Name = "lblRoomAllocatedCount";
			this.lblRoomAllocatedCount.Size = new System.Drawing.Size(36, 26);
			this.lblRoomAllocatedCount.TabIndex = 0;
			this.lblRoomAllocatedCount.Text = "00";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.label5);
			this.panel3.Controls.Add(this.lblVacantRoom);
			this.panel3.Location = new System.Drawing.Point(592, 203);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(154, 95);
			this.panel3.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(16, 10);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(117, 18);
			this.label5.TabIndex = 1;
			this.label5.Text = "Vacant Room";
			// 
			// lblVacantRoom
			// 
			this.lblVacantRoom.AutoSize = true;
			this.lblVacantRoom.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVacantRoom.Location = new System.Drawing.Point(53, 39);
			this.lblVacantRoom.Name = "lblVacantRoom";
			this.lblVacantRoom.Size = new System.Drawing.Size(36, 26);
			this.lblVacantRoom.TabIndex = 0;
			this.lblVacantRoom.Text = "00";
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.label7);
			this.panel4.Controls.Add(this.lblPatientsCount);
			this.panel4.Location = new System.Drawing.Point(814, 203);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(122, 95);
			this.panel4.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(24, 10);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 18);
			this.label7.TabIndex = 1;
			this.label7.Text = "Patients";
			// 
			// lblPatientsCount
			// 
			this.lblPatientsCount.AutoSize = true;
			this.lblPatientsCount.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPatientsCount.Location = new System.Drawing.Point(48, 39);
			this.lblPatientsCount.Name = "lblPatientsCount";
			this.lblPatientsCount.Size = new System.Drawing.Size(36, 26);
			this.lblPatientsCount.TabIndex = 0;
			this.lblPatientsCount.Text = "00";
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel5.Controls.Add(this.label6);
			this.panel5.Controls.Add(this.lblDoctorsCount);
			this.panel5.Location = new System.Drawing.Point(982, 203);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(135, 95);
			this.panel5.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(34, 10);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 18);
			this.label6.TabIndex = 1;
			this.label6.Text = "Doctors";
			// 
			// lblDoctorsCount
			// 
			this.lblDoctorsCount.AutoSize = true;
			this.lblDoctorsCount.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDoctorsCount.Location = new System.Drawing.Point(54, 39);
			this.lblDoctorsCount.Name = "lblDoctorsCount";
			this.lblDoctorsCount.Size = new System.Drawing.Size(36, 26);
			this.lblDoctorsCount.TabIndex = 0;
			this.lblDoctorsCount.Text = "00";
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(11, 131);
			this.chart1.Margin = new System.Windows.Forms.Padding(2);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
			series1.IsValueShownAsLabel = true;
			series1.Legend = "Legend1";
			series1.Name = "Doctors";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(335, 259);
			this.chart1.TabIndex = 12;
			this.chart1.Text = "chart1";
			// 
			// StaffDashBoard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(1192, 401);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblTime);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1208, 440);
			this.MinimumSize = new System.Drawing.Size(1208, 440);
			this.Name = "StaffDashBoard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Staff DashBoard";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StaffDashBoard_FormClosing);
			this.Load += new System.EventHandler(this.StaffDashBoard_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnDoctorSchedule;
		private System.Windows.Forms.Button btnAppointment;
		private System.Windows.Forms.Button btnPatientsMedicalRecords;
		private System.Windows.Forms.Button btnSearchforDoctors;
		private System.Windows.Forms.Button btnMedicationSchedule;
		private System.Windows.Forms.Button btnRoomAllocation;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Label lblDate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblRoomAllocatedCount;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label lblVacantRoom;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label lblPatientsCount;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label lblDoctorsCount;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Label label6;
	}
}