
namespace HealthCare_Plus
{
	partial class SearchDoctors
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
			this.rdoLocation = new System.Windows.Forms.RadioButton();
			this.rdoSpecialization = new System.Windows.Forms.RadioButton();
			this.txtSearchValue = new System.Windows.Forms.TextBox();
			this.btnSearchDoctor = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnViewAllDoctor = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(47, 234);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(838, 233);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// rdoLocation
			// 
			this.rdoLocation.AutoSize = true;
			this.rdoLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdoLocation.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.rdoLocation.Location = new System.Drawing.Point(368, 130);
			this.rdoLocation.Name = "rdoLocation";
			this.rdoLocation.Size = new System.Drawing.Size(79, 21);
			this.rdoLocation.TabIndex = 2;
			this.rdoLocation.TabStop = true;
			this.rdoLocation.Text = "Location";
			this.rdoLocation.UseVisualStyleBackColor = true;
			this.rdoLocation.CheckedChanged += new System.EventHandler(this.rdoLocation_CheckedChanged);
			// 
			// rdoSpecialization
			// 
			this.rdoSpecialization.AutoSize = true;
			this.rdoSpecialization.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdoSpecialization.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.rdoSpecialization.Location = new System.Drawing.Point(231, 130);
			this.rdoSpecialization.Name = "rdoSpecialization";
			this.rdoSpecialization.Size = new System.Drawing.Size(111, 21);
			this.rdoSpecialization.TabIndex = 3;
			this.rdoSpecialization.TabStop = true;
			this.rdoSpecialization.Text = "Specialization";
			this.rdoSpecialization.UseVisualStyleBackColor = true;
			this.rdoSpecialization.CheckedChanged += new System.EventHandler(this.rdoSpecialization_CheckedChanged);
			// 
			// txtSearchValue
			// 
			this.txtSearchValue.Location = new System.Drawing.Point(231, 177);
			this.txtSearchValue.Multiline = true;
			this.txtSearchValue.Name = "txtSearchValue";
			this.txtSearchValue.Size = new System.Drawing.Size(201, 29);
			this.txtSearchValue.TabIndex = 4;
			// 
			// btnSearchDoctor
			// 
			this.btnSearchDoctor.BackColor = System.Drawing.Color.SeaGreen;
			this.btnSearchDoctor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearchDoctor.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnSearchDoctor.Location = new System.Drawing.Point(459, 167);
			this.btnSearchDoctor.Name = "btnSearchDoctor";
			this.btnSearchDoctor.Size = new System.Drawing.Size(117, 40);
			this.btnSearchDoctor.TabIndex = 5;
			this.btnSearchDoctor.Text = "Search Doctor";
			this.btnSearchDoctor.UseVisualStyleBackColor = false;
			this.btnSearchDoctor.Click += new System.EventHandler(this.btnSearchDoctor_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Location = new System.Drawing.Point(228, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(219, 17);
			this.label1.TabIndex = 6;
			this.label1.Text = "Please Select a Category to Search";
			// 
			// btnViewAllDoctor
			// 
			this.btnViewAllDoctor.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnViewAllDoctor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnViewAllDoctor.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnViewAllDoctor.Location = new System.Drawing.Point(582, 167);
			this.btnViewAllDoctor.Name = "btnViewAllDoctor";
			this.btnViewAllDoctor.Size = new System.Drawing.Size(120, 40);
			this.btnViewAllDoctor.TabIndex = 7;
			this.btnViewAllDoctor.Text = "View All Doctor";
			this.btnViewAllDoctor.UseVisualStyleBackColor = false;
			this.btnViewAllDoctor.Click += new System.EventHandler(this.btnViewAllDoctor_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.Control;
			this.label8.Location = new System.Drawing.Point(398, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(160, 30);
			this.label8.TabIndex = 12;
			this.label8.Text = "Search Doctors";
			// 
			// SearchDoctors
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(929, 508);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnViewAllDoctor);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSearchDoctor);
			this.Controls.Add(this.txtSearchValue);
			this.Controls.Add(this.rdoSpecialization);
			this.Controls.Add(this.rdoLocation);
			this.Controls.Add(this.dataGridView1);
			this.Name = "SearchDoctors";
			this.Text = "Search Doctors";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.RadioButton rdoLocation;
		private System.Windows.Forms.RadioButton rdoSpecialization;
		private System.Windows.Forms.TextBox txtSearchValue;
		private System.Windows.Forms.Button btnSearchDoctor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnViewAllDoctor;
		private System.Windows.Forms.Label label8;
	}
}