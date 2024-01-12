
namespace HealthCare_Plus
{
	partial class Resource
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
			this.cmbReportType = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cmbxPertientName
			// 
			this.cmbxPertientName.DropDownHeight = 200;
			this.cmbxPertientName.FormattingEnabled = true;
			this.cmbxPertientName.IntegralHeight = false;
			this.cmbxPertientName.ItemHeight = 13;
			this.cmbxPertientName.Location = new System.Drawing.Point(142, 97);
			this.cmbxPertientName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cmbxPertientName.Name = "cmbxPertientName";
			this.cmbxPertientName.Size = new System.Drawing.Size(187, 21);
			this.cmbxPertientName.TabIndex = 3;
			this.cmbxPertientName.SelectedIndexChanged += new System.EventHandler(this.cmbxPertientName_SelectedIndexChanged);
			// 
			// cmbReportType
			// 
			this.cmbReportType.BackColor = System.Drawing.Color.White;
			this.cmbReportType.DropDownHeight = 200;
			this.cmbReportType.FormattingEnabled = true;
			this.cmbReportType.IntegralHeight = false;
			this.cmbReportType.ItemHeight = 13;
			this.cmbReportType.Items.AddRange(new object[] {
            "Lab Report",
            "ECG",
            "CT"});
			this.cmbReportType.Location = new System.Drawing.Point(142, 165);
			this.cmbReportType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cmbReportType.Name = "cmbReportType";
			this.cmbReportType.Size = new System.Drawing.Size(187, 21);
			this.cmbReportType.TabIndex = 4;
			this.cmbReportType.SelectedIndexChanged += new System.EventHandler(this.cmbReportType_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label3.Location = new System.Drawing.Point(139, 225);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "File Path";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(222, 225);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 17);
			this.label1.TabIndex = 7;
			this.label1.Text = "directory path...";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.RoyalBlue;
			this.button1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.button1.Location = new System.Drawing.Point(142, 261);
			this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 30);
			this.button1.TabIndex = 8;
			this.button1.Text = "Browse File";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
			this.btnAdd.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnAdd.Location = new System.Drawing.Point(142, 330);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(90, 30);
			this.btnAdd.TabIndex = 8;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label2.Location = new System.Drawing.Point(139, 72);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 17);
			this.label2.TabIndex = 7;
			this.label2.Text = "Patient";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label4.Location = new System.Drawing.Point(139, 137);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Report Type";
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Maroon;
			this.button4.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.button4.Location = new System.Drawing.Point(240, 330);
			this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(90, 30);
			this.button4.TabIndex = 8;
			this.button4.Text = "Delete";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.Control;
			this.label8.Location = new System.Drawing.Point(193, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(101, 25);
			this.label8.TabIndex = 12;
			this.label8.Text = "Resources";
			// 
			// Resource
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(488, 406);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmbxPertientName);
			this.Controls.Add(this.cmbReportType);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Resource";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Resource";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ComboBox cmbxPertientName;
		private System.Windows.Forms.ComboBox cmbReportType;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label8;
	}
}