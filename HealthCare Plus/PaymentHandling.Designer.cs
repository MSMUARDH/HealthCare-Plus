
namespace HealthCare_Plus
{
	partial class PaymentHandling
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
			this.cmbPatientName = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnSearchPatient = new System.Windows.Forms.Button();
			this.btnPayNow = new System.Windows.Forms.Button();
			this.txtTotalAmount = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.rdoCardPayment = new System.Windows.Forms.RadioButton();
			this.rdoCashpayment = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// cmbPatientName
			// 
			this.cmbPatientName.BackColor = System.Drawing.SystemColors.ControlLight;
			this.cmbPatientName.DropDownHeight = 500;
			this.cmbPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbPatientName.FormattingEnabled = true;
			this.cmbPatientName.IntegralHeight = false;
			this.cmbPatientName.Location = new System.Drawing.Point(268, 134);
			this.cmbPatientName.Name = "cmbPatientName";
			this.cmbPatientName.Size = new System.Drawing.Size(167, 24);
			this.cmbPatientName.TabIndex = 0;
			this.cmbPatientName.SelectedIndexChanged += new System.EventHandler(this.cmbPatientName_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Location = new System.Drawing.Point(265, 101);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Select Patient Name";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(25, 187);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(787, 150);
			this.dataGridView1.TabIndex = 2;
			// 
			// btnSearchPatient
			// 
			this.btnSearchPatient.BackColor = System.Drawing.Color.SeaGreen;
			this.btnSearchPatient.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearchPatient.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnSearchPatient.Location = new System.Drawing.Point(468, 130);
			this.btnSearchPatient.Name = "btnSearchPatient";
			this.btnSearchPatient.Size = new System.Drawing.Size(90, 30);
			this.btnSearchPatient.TabIndex = 3;
			this.btnSearchPatient.Text = "Search";
			this.btnSearchPatient.UseVisualStyleBackColor = false;
			this.btnSearchPatient.Click += new System.EventHandler(this.btnSearchPatient_Click);
			// 
			// btnPayNow
			// 
			this.btnPayNow.BackColor = System.Drawing.Color.SeaGreen;
			this.btnPayNow.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPayNow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPayNow.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnPayNow.Location = new System.Drawing.Point(320, 474);
			this.btnPayNow.Name = "btnPayNow";
			this.btnPayNow.Size = new System.Drawing.Size(166, 34);
			this.btnPayNow.TabIndex = 7;
			this.btnPayNow.Text = "Pay Now";
			this.btnPayNow.UseVisualStyleBackColor = false;
			this.btnPayNow.Click += new System.EventHandler(this.btnPayNow_Click);
			// 
			// txtTotalAmount
			// 
			this.txtTotalAmount.BackColor = System.Drawing.SystemColors.ControlLight;
			this.txtTotalAmount.Location = new System.Drawing.Point(401, 366);
			this.txtTotalAmount.Name = "txtTotalAmount";
			this.txtTotalAmount.ReadOnly = true;
			this.txtTotalAmount.Size = new System.Drawing.Size(166, 34);
			this.txtTotalAmount.TabIndex = 8;
			this.txtTotalAmount.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label2.Location = new System.Drawing.Point(256, 366);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Total Amount";
			// 
			// rdoCardPayment
			// 
			this.rdoCardPayment.AutoSize = true;
			this.rdoCardPayment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdoCardPayment.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.rdoCardPayment.Location = new System.Drawing.Point(404, 425);
			this.rdoCardPayment.Name = "rdoCardPayment";
			this.rdoCardPayment.Size = new System.Drawing.Size(54, 21);
			this.rdoCardPayment.TabIndex = 9;
			this.rdoCardPayment.TabStop = true;
			this.rdoCardPayment.Text = "Card";
			this.rdoCardPayment.UseVisualStyleBackColor = true;
			this.rdoCardPayment.CheckedChanged += new System.EventHandler(this.rdoCardPayment_CheckedChanged);
			// 
			// rdoCashpayment
			// 
			this.rdoCashpayment.AutoSize = true;
			this.rdoCashpayment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdoCashpayment.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.rdoCashpayment.Location = new System.Drawing.Point(466, 425);
			this.rdoCashpayment.Name = "rdoCashpayment";
			this.rdoCashpayment.Size = new System.Drawing.Size(55, 21);
			this.rdoCashpayment.TabIndex = 9;
			this.rdoCashpayment.TabStop = true;
			this.rdoCashpayment.Text = "Cash";
			this.rdoCashpayment.UseVisualStyleBackColor = true;
			this.rdoCashpayment.CheckedChanged += new System.EventHandler(this.rdoCashpayment_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label3.Location = new System.Drawing.Point(256, 425);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 17);
			this.label3.TabIndex = 10;
			this.label3.Text = "Payment Method";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.Control;
			this.label8.Location = new System.Drawing.Point(363, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(98, 30);
			this.label8.TabIndex = 12;
			this.label8.Text = "Payment";
			// 
			// PaymentHandling
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(837, 602);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.rdoCashpayment);
			this.Controls.Add(this.rdoCardPayment);
			this.Controls.Add(this.txtTotalAmount);
			this.Controls.Add(this.btnPayNow);
			this.Controls.Add(this.btnSearchPatient);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbPatientName);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(853, 641);
			this.MinimumSize = new System.Drawing.Size(853, 641);
			this.Name = "PaymentHandling";
			this.Text = "Payment Handling";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbPatientName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnSearchPatient;
		private System.Windows.Forms.Button btnPayNow;
		private System.Windows.Forms.RichTextBox txtTotalAmount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton rdoCardPayment;
		private System.Windows.Forms.RadioButton rdoCashpayment;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label8;
	}
}