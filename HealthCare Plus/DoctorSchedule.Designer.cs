
namespace HealthCare_Plus
{
	partial class DoctorSchedule
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
			this.label1 = new System.Windows.Forms.Label();
			this.cmbDoctorName = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.fromTimePicker = new System.Windows.Forms.DateTimePicker();
			this.toTimePicker = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtFee = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.dateScheduleDoctor = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFee)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(12, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Doctor Name";
			// 
			// cmbDoctorName
			// 
			this.cmbDoctorName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbDoctorName.FormattingEnabled = true;
			this.cmbDoctorName.Location = new System.Drawing.Point(118, 75);
			this.cmbDoctorName.Name = "cmbDoctorName";
			this.cmbDoctorName.Size = new System.Drawing.Size(125, 23);
			this.cmbDoctorName.TabIndex = 1;
			this.cmbDoctorName.SelectedIndexChanged += new System.EventHandler(this.cmbDoctorName_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label2.Location = new System.Drawing.Point(65, 118);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Date";
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(333, 76);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(742, 244);
			this.dataGridView1.TabIndex = 4;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
			this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnAdd.Location = new System.Drawing.Point(27, 361);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(90, 30);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnUpdate.Location = new System.Drawing.Point(141, 361);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(90, 30);
			this.btnUpdate.TabIndex = 5;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Maroon;
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnDelete.Location = new System.Drawing.Point(254, 361);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(90, 30);
			this.btnDelete.TabIndex = 5;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.Maroon;
			this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnClear.Location = new System.Drawing.Point(374, 361);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(90, 30);
			this.btnClear.TabIndex = 5;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// fromTimePicker
			// 
			this.fromTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fromTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.fromTimePicker.Location = new System.Drawing.Point(118, 162);
			this.fromTimePicker.Margin = new System.Windows.Forms.Padding(2);
			this.fromTimePicker.Name = "fromTimePicker";
			this.fromTimePicker.ShowUpDown = true;
			this.fromTimePicker.Size = new System.Drawing.Size(190, 23);
			this.fromTimePicker.TabIndex = 6;
			this.fromTimePicker.Value = new System.DateTime(2023, 9, 12, 16, 15, 0, 0);
			this.fromTimePicker.ValueChanged += new System.EventHandler(this.fromTimePicker_ValueChanged);
			// 
			// toTimePicker
			// 
			this.toTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.toTimePicker.Location = new System.Drawing.Point(118, 203);
			this.toTimePicker.Margin = new System.Windows.Forms.Padding(2);
			this.toTimePicker.Name = "toTimePicker";
			this.toTimePicker.ShowUpDown = true;
			this.toTimePicker.Size = new System.Drawing.Size(190, 23);
			this.toTimePicker.TabIndex = 6;
			this.toTimePicker.Value = new System.DateTime(2023, 9, 12, 16, 15, 0, 0);
			this.toTimePicker.ValueChanged += new System.EventHandler(this.toTimePicker_ValueChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label7.Location = new System.Drawing.Point(62, 162);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 17);
			this.label7.TabIndex = 0;
			this.label7.Text = "From";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label8.Location = new System.Drawing.Point(79, 207);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(23, 17);
			this.label8.TabIndex = 0;
			this.label8.Text = "To";
			// 
			// txtFee
			// 
			this.txtFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtFee.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFee.Location = new System.Drawing.Point(118, 249);
			this.txtFee.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.txtFee.Name = "txtFee";
			this.txtFee.Size = new System.Drawing.Size(125, 23);
			this.txtFee.TabIndex = 8;
			this.txtFee.ValueChanged += new System.EventHandler(this.txtFee_ValueChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label3.Location = new System.Drawing.Point(73, 249);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 17);
			this.label3.TabIndex = 9;
			this.label3.Text = "Fee";
			// 
			// dateScheduleDoctor
			// 
			this.dateScheduleDoctor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateScheduleDoctor.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateScheduleDoctor.Location = new System.Drawing.Point(118, 118);
			this.dateScheduleDoctor.Name = "dateScheduleDoctor";
			this.dateScheduleDoctor.Size = new System.Drawing.Size(200, 23);
			this.dateScheduleDoctor.TabIndex = 10;
			this.dateScheduleDoctor.Value = new System.DateTime(2023, 9, 20, 0, 0, 0, 0);
			this.dateScheduleDoctor.ValueChanged += new System.EventHandler(this.dateScheduleDoctor_ValueChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(529, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(159, 25);
			this.label4.TabIndex = 11;
			this.label4.Text = "Doctor Schedule";
			// 
			// DoctorSchedule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(1087, 410);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.dateScheduleDoctor);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtFee);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.toTimePicker);
			this.Controls.Add(this.fromTimePicker);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cmbDoctorName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1103, 449);
			this.MinimumSize = new System.Drawing.Size(1103, 449);
			this.Name = "DoctorSchedule";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Doctor Schedule";
			this.Load += new System.EventHandler(this.DoctorSchedule_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtFee)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbDoctorName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.DateTimePicker fromTimePicker;
		private System.Windows.Forms.DateTimePicker toTimePicker;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown txtFee;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dateScheduleDoctor;
		private System.Windows.Forms.Label label4;
	}
}