
namespace HealthCare_Plus
{
	partial class CheckDoctorAvailability
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
			this.cmbDoctorName = new System.Windows.Forms.ComboBox();
			this.cmbPatientName = new System.Windows.Forms.ComboBox();
			this.timePickerforSchedule = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.datePickerConsultDate = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbDoctorName
			// 
			this.cmbDoctorName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbDoctorName.FormattingEnabled = true;
			this.cmbDoctorName.Location = new System.Drawing.Point(134, 149);
			this.cmbDoctorName.Margin = new System.Windows.Forms.Padding(2);
			this.cmbDoctorName.Name = "cmbDoctorName";
			this.cmbDoctorName.Size = new System.Drawing.Size(139, 21);
			this.cmbDoctorName.TabIndex = 0;
			this.cmbDoctorName.SelectedIndexChanged += new System.EventHandler(this.cmbDoctorName_SelectedIndexChanged);
			// 
			// cmbPatientName
			// 
			this.cmbPatientName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbPatientName.FormattingEnabled = true;
			this.cmbPatientName.Location = new System.Drawing.Point(133, 113);
			this.cmbPatientName.Margin = new System.Windows.Forms.Padding(2);
			this.cmbPatientName.Name = "cmbPatientName";
			this.cmbPatientName.Size = new System.Drawing.Size(140, 21);
			this.cmbPatientName.TabIndex = 1;
			this.cmbPatientName.SelectedIndexChanged += new System.EventHandler(this.cmbPatientName_SelectedIndexChanged);
			// 
			// timePickerforSchedule
			// 
			this.timePickerforSchedule.Checked = false;
			this.timePickerforSchedule.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timePickerforSchedule.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.timePickerforSchedule.Location = new System.Drawing.Point(133, 183);
			this.timePickerforSchedule.Margin = new System.Windows.Forms.Padding(2);
			this.timePickerforSchedule.Name = "timePickerforSchedule";
			this.timePickerforSchedule.ShowUpDown = true;
			this.timePickerforSchedule.Size = new System.Drawing.Size(177, 22);
			this.timePickerforSchedule.TabIndex = 2;
			this.timePickerforSchedule.Value = new System.DateTime(2023, 9, 12, 0, 0, 0, 0);
			this.timePickerforSchedule.ValueChanged += new System.EventHandler(this.timePickerforSchedule_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(36, 115);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Patient Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(75, 227);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Date";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(37, 151);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "Doctor Name";
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.SeaGreen;
			this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
			this.btnSearch.Location = new System.Drawing.Point(134, 286);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(133, 34);
			this.btnSearch.TabIndex = 6;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(332, 113);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(740, 197);
			this.dataGridView1.TabIndex = 7;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.Control;
			this.label5.Location = new System.Drawing.Point(75, 188);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 15);
			this.label5.TabIndex = 4;
			this.label5.Text = "Time";
			// 
			// datePickerConsultDate
			// 
			this.datePickerConsultDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.datePickerConsultDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.datePickerConsultDate.Location = new System.Drawing.Point(133, 222);
			this.datePickerConsultDate.Margin = new System.Windows.Forms.Padding(2);
			this.datePickerConsultDate.Name = "datePickerConsultDate";
			this.datePickerConsultDate.Size = new System.Drawing.Size(177, 22);
			this.datePickerConsultDate.TabIndex = 8;
			this.datePickerConsultDate.ValueChanged += new System.EventHandler(this.datePickerConsultDate_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(367, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(176, 25);
			this.label4.TabIndex = 9;
			this.label4.Text = "Doctor Availability";
			// 
			// CheckDoctorAvailability
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(1098, 366);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.datePickerConsultDate);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.timePickerforSchedule);
			this.Controls.Add(this.cmbPatientName);
			this.Controls.Add(this.cmbDoctorName);
			this.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1114, 405);
			this.MinimumSize = new System.Drawing.Size(1114, 405);
			this.Name = "CheckDoctorAvailability";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Doctor Availability";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbDoctorName;
		private System.Windows.Forms.ComboBox cmbPatientName;
		private System.Windows.Forms.DateTimePicker timePickerforSchedule;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker datePickerConsultDate;
		private System.Windows.Forms.Label label4;
	}
}