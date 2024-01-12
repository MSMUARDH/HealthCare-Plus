
namespace HealthCare_Plus
{
	partial class Consultation
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
			this.cmbxPertientName = new System.Windows.Forms.ComboBox();
			this.Pateint = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTreatment = new System.Windows.Forms.RichTextBox();
			this.txtDisease = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtPrescription = new System.Windows.Forms.RichTextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbxPertientName
			// 
			this.cmbxPertientName.BackColor = System.Drawing.SystemColors.ControlLight;
			this.cmbxPertientName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbxPertientName.FormattingEnabled = true;
			this.cmbxPertientName.Location = new System.Drawing.Point(288, 84);
			this.cmbxPertientName.Margin = new System.Windows.Forms.Padding(2);
			this.cmbxPertientName.Name = "cmbxPertientName";
			this.cmbxPertientName.Size = new System.Drawing.Size(206, 25);
			this.cmbxPertientName.TabIndex = 0;
			this.cmbxPertientName.SelectedIndexChanged += new System.EventHandler(this.cmbxPertientName_SelectedIndexChanged);
			// 
			// Pateint
			// 
			this.Pateint.AutoSize = true;
			this.Pateint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Pateint.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.Pateint.Location = new System.Drawing.Point(179, 88);
			this.Pateint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Pateint.Name = "Pateint";
			this.Pateint.Size = new System.Drawing.Size(92, 17);
			this.Pateint.TabIndex = 1;
			this.Pateint.Text = "Patient Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label2.Location = new System.Drawing.Point(179, 149);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Disease";
			// 
			// txtTreatment
			// 
			this.txtTreatment.BackColor = System.Drawing.SystemColors.ControlLight;
			this.txtTreatment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTreatment.Location = new System.Drawing.Point(288, 188);
			this.txtTreatment.Margin = new System.Windows.Forms.Padding(2);
			this.txtTreatment.Name = "txtTreatment";
			this.txtTreatment.Size = new System.Drawing.Size(206, 28);
			this.txtTreatment.TabIndex = 2;
			this.txtTreatment.Text = "";
			// 
			// txtDisease
			// 
			this.txtDisease.BackColor = System.Drawing.SystemColors.ControlLight;
			this.txtDisease.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDisease.Location = new System.Drawing.Point(288, 138);
			this.txtDisease.Margin = new System.Windows.Forms.Padding(2);
			this.txtDisease.Name = "txtDisease";
			this.txtDisease.Size = new System.Drawing.Size(206, 28);
			this.txtDisease.TabIndex = 2;
			this.txtDisease.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label3.Location = new System.Drawing.Point(179, 199);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 17);
			this.label3.TabIndex = 1;
			this.label3.Text = "Treatment";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label4.Location = new System.Drawing.Point(179, 250);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 17);
			this.label4.TabIndex = 1;
			this.label4.Text = "Prescription";
			// 
			// txtPrescription
			// 
			this.txtPrescription.BackColor = System.Drawing.SystemColors.ControlLight;
			this.txtPrescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrescription.Location = new System.Drawing.Point(288, 246);
			this.txtPrescription.Margin = new System.Windows.Forms.Padding(2);
			this.txtPrescription.Name = "txtPrescription";
			this.txtPrescription.Size = new System.Drawing.Size(206, 59);
			this.txtPrescription.TabIndex = 2;
			this.txtPrescription.Text = "";
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(20, 410);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(781, 187);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
			this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
			this.btnAdd.Location = new System.Drawing.Point(167, 337);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(90, 40);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.Maroon;
			this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
			this.btnClear.Location = new System.Drawing.Point(516, 337);
			this.btnClear.Margin = new System.Windows.Forms.Padding(2);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(90, 40);
			this.btnClear.TabIndex = 4;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
			this.btnUpdate.Location = new System.Drawing.Point(288, 337);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(90, 40);
			this.btnUpdate.TabIndex = 4;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Maroon;
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
			this.btnDelete.Location = new System.Drawing.Point(404, 337);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(90, 40);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(180, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(337, 25);
			this.label1.TabIndex = 10;
			this.label1.Text = "Doctor Consultation and Medication";
			// 
			// Consultation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(826, 608);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.txtDisease);
			this.Controls.Add(this.txtPrescription);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtTreatment);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Pateint);
			this.Controls.Add(this.cmbxPertientName);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(842, 647);
			this.MinimumSize = new System.Drawing.Size(842, 647);
			this.Name = "Consultation";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consultation";
			this.Load += new System.EventHandler(this.Consultation_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbxPertientName;
		private System.Windows.Forms.Label Pateint;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox txtTreatment;
		private System.Windows.Forms.RichTextBox txtDisease;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox txtPrescription;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label label1;
	}
}