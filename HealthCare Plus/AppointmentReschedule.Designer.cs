
namespace HealthCare_Plus
{
	partial class AppointmentReschedule
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnAppointmentCancelation = new System.Windows.Forms.Button();
			this.RescheduleTime = new System.Windows.Forms.DateTimePicker();
			this.RescheduleDate = new System.Windows.Forms.DateTimePicker();
			this.btnRescheduleAppointment = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGridView1.Location = new System.Drawing.Point(11, 164);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(865, 184);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// btnAppointmentCancelation
			// 
			this.btnAppointmentCancelation.BackColor = System.Drawing.Color.Maroon;
			this.btnAppointmentCancelation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAppointmentCancelation.ForeColor = System.Drawing.SystemColors.Control;
			this.btnAppointmentCancelation.Location = new System.Drawing.Point(672, 97);
			this.btnAppointmentCancelation.Margin = new System.Windows.Forms.Padding(2);
			this.btnAppointmentCancelation.Name = "btnAppointmentCancelation";
			this.btnAppointmentCancelation.Size = new System.Drawing.Size(118, 41);
			this.btnAppointmentCancelation.TabIndex = 1;
			this.btnAppointmentCancelation.Text = "Cancellations";
			this.btnAppointmentCancelation.UseVisualStyleBackColor = false;
			this.btnAppointmentCancelation.Click += new System.EventHandler(this.btnDeleteAppointment_Click);
			// 
			// RescheduleTime
			// 
			this.RescheduleTime.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
			this.RescheduleTime.Cursor = System.Windows.Forms.Cursors.Hand;
			this.RescheduleTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.RescheduleTime.Location = new System.Drawing.Point(89, 109);
			this.RescheduleTime.MinimumSize = new System.Drawing.Size(200, 20);
			this.RescheduleTime.Name = "RescheduleTime";
			this.RescheduleTime.Size = new System.Drawing.Size(200, 20);
			this.RescheduleTime.TabIndex = 2;
			this.RescheduleTime.ValueChanged += new System.EventHandler(this.RescheduleTime_ValueChanged);
			// 
			// RescheduleDate
			// 
			this.RescheduleDate.CalendarTitleBackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.RescheduleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.RescheduleDate.Location = new System.Drawing.Point(312, 109);
			this.RescheduleDate.Name = "RescheduleDate";
			this.RescheduleDate.Size = new System.Drawing.Size(200, 20);
			this.RescheduleDate.TabIndex = 3;
			this.RescheduleDate.ValueChanged += new System.EventHandler(this.RescheduleDate_ValueChanged);
			// 
			// btnRescheduleAppointment
			// 
			this.btnRescheduleAppointment.BackColor = System.Drawing.Color.SeaGreen;
			this.btnRescheduleAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRescheduleAppointment.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRescheduleAppointment.ForeColor = System.Drawing.SystemColors.Control;
			this.btnRescheduleAppointment.Location = new System.Drawing.Point(559, 97);
			this.btnRescheduleAppointment.Name = "btnRescheduleAppointment";
			this.btnRescheduleAppointment.Size = new System.Drawing.Size(108, 41);
			this.btnRescheduleAppointment.TabIndex = 4;
			this.btnRescheduleAppointment.Text = "Reschedule";
			this.btnRescheduleAppointment.UseVisualStyleBackColor = false;
			this.btnRescheduleAppointment.Click += new System.EventHandler(this.btnRescheduleAppointment_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(313, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(244, 25);
			this.label2.TabIndex = 6;
			this.label2.Text = "Appointment Managment";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(309, 78);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 15);
			this.label3.TabIndex = 8;
			this.label3.Text = "Date";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(86, 78);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 15);
			this.label1.TabIndex = 7;
			this.label1.Text = "Time";
			// 
			// AppointmentReschedule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(887, 451);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnRescheduleAppointment);
			this.Controls.Add(this.RescheduleDate);
			this.Controls.Add(this.RescheduleTime);
			this.Controls.Add(this.btnAppointmentCancelation);
			this.Controls.Add(this.dataGridView1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(903, 490);
			this.MinimumSize = new System.Drawing.Size(903, 490);
			this.Name = "AppointmentReschedule";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Appointment Managment";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnAppointmentCancelation;
		private System.Windows.Forms.DateTimePicker RescheduleTime;
		private System.Windows.Forms.DateTimePicker RescheduleDate;
		private System.Windows.Forms.Button btnRescheduleAppointment;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
	}
}