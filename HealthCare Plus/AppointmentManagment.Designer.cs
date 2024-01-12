
namespace HealthCare_Plus
{
	partial class AppointmentManagment
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentManagment));
			this.btnAppointment = new System.Windows.Forms.Button();
			this.btnDoctorSchedule = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAppointment
			// 
			this.btnAppointment.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAppointment.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAppointment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnAppointment.Image = ((System.Drawing.Image)(resources.GetObject("btnAppointment.Image")));
			this.btnAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAppointment.Location = new System.Drawing.Point(309, 67);
			this.btnAppointment.Name = "btnAppointment";
			this.btnAppointment.Size = new System.Drawing.Size(227, 83);
			this.btnAppointment.TabIndex = 1;
			this.btnAppointment.Text = "Make an Appoinment";
			this.btnAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAppointment.UseVisualStyleBackColor = false;
			this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
			// 
			// btnDoctorSchedule
			// 
			this.btnDoctorSchedule.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnDoctorSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDoctorSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDoctorSchedule.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDoctorSchedule.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnDoctorSchedule.Image = ((System.Drawing.Image)(resources.GetObject("btnDoctorSchedule.Image")));
			this.btnDoctorSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDoctorSchedule.Location = new System.Drawing.Point(53, 67);
			this.btnDoctorSchedule.Name = "btnDoctorSchedule";
			this.btnDoctorSchedule.Size = new System.Drawing.Size(221, 83);
			this.btnDoctorSchedule.TabIndex = 2;
			this.btnDoctorSchedule.Text = "Manage Appointments";
			this.btnDoctorSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDoctorSchedule.UseVisualStyleBackColor = false;
			this.btnDoctorSchedule.Click += new System.EventHandler(this.btnDoctorSchedule_Click);
			// 
			// AppointmentManagment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(594, 276);
			this.Controls.Add(this.btnAppointment);
			this.Controls.Add(this.btnDoctorSchedule);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(610, 315);
			this.MinimumSize = new System.Drawing.Size(610, 315);
			this.Name = "AppointmentManagment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Appointment Managment";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAppointment;
		private System.Windows.Forms.Button btnDoctorSchedule;
	}
}