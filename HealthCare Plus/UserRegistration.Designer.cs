
namespace HealthCare_Plus
{
	partial class UserRegistration
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
			this.label2 = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.RichTextBox();
			this.txtEmail = new System.Windows.Forms.RichTextBox();
			this.txtPassword = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.rdoStaff = new System.Windows.Forms.RadioButton();
			this.rdoAdmin = new System.Windows.Forms.RadioButton();
			this.grpRole = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label8 = new System.Windows.Forms.Label();
			this.grpRole.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Location = new System.Drawing.Point(66, 58);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "User Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label2.Location = new System.Drawing.Point(66, 159);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Email";
			// 
			// txtUserName
			// 
			this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUserName.Location = new System.Drawing.Point(70, 91);
			this.txtUserName.Margin = new System.Windows.Forms.Padding(4);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(233, 31);
			this.txtUserName.TabIndex = 2;
			this.txtUserName.Text = "";
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEmail.Location = new System.Drawing.Point(70, 197);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(233, 39);
			this.txtEmail.TabIndex = 2;
			this.txtEmail.Text = "";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPassword.Location = new System.Drawing.Point(365, 89);
			this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(208, 33);
			this.txtPassword.TabIndex = 2;
			this.txtPassword.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label3.Location = new System.Drawing.Point(362, 57);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 17);
			this.label3.TabIndex = 1;
			this.label3.Text = "Password";
			// 
			// btnCreate
			// 
			this.btnCreate.BackColor = System.Drawing.Color.SeaGreen;
			this.btnCreate.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnCreate.Location = new System.Drawing.Point(137, 290);
			this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(100, 30);
			this.btnCreate.TabIndex = 3;
			this.btnCreate.Text = "Create User";
			this.btnCreate.UseVisualStyleBackColor = false;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnUpdate.Location = new System.Drawing.Point(272, 290);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(100, 30);
			this.btnUpdate.TabIndex = 4;
			this.btnUpdate.Text = "Update User";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Maroon;
			this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnDelete.Location = new System.Drawing.Point(405, 290);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(100, 30);
			this.btnDelete.TabIndex = 5;
			this.btnDelete.Text = "Delete User";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// rdoStaff
			// 
			this.rdoStaff.AutoSize = true;
			this.rdoStaff.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.rdoStaff.Location = new System.Drawing.Point(31, 25);
			this.rdoStaff.Margin = new System.Windows.Forms.Padding(4);
			this.rdoStaff.Name = "rdoStaff";
			this.rdoStaff.Size = new System.Drawing.Size(55, 21);
			this.rdoStaff.TabIndex = 6;
			this.rdoStaff.TabStop = true;
			this.rdoStaff.Text = "Staff";
			this.rdoStaff.UseVisualStyleBackColor = true;
			this.rdoStaff.CheckedChanged += new System.EventHandler(this.rdoStaff_CheckedChanged);
			// 
			// rdoAdmin
			// 
			this.rdoAdmin.AutoSize = true;
			this.rdoAdmin.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.rdoAdmin.Location = new System.Drawing.Point(136, 25);
			this.rdoAdmin.Margin = new System.Windows.Forms.Padding(4);
			this.rdoAdmin.Name = "rdoAdmin";
			this.rdoAdmin.Size = new System.Drawing.Size(67, 21);
			this.rdoAdmin.TabIndex = 7;
			this.rdoAdmin.TabStop = true;
			this.rdoAdmin.Text = "Admin";
			this.rdoAdmin.UseVisualStyleBackColor = true;
			this.rdoAdmin.CheckedChanged += new System.EventHandler(this.rdoAdmin_CheckedChanged);
			// 
			// grpRole
			// 
			this.grpRole.Controls.Add(this.rdoStaff);
			this.grpRole.Controls.Add(this.rdoAdmin);
			this.grpRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpRole.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.grpRole.Location = new System.Drawing.Point(365, 173);
			this.grpRole.Margin = new System.Windows.Forms.Padding(4);
			this.grpRole.Name = "grpRole";
			this.grpRole.Padding = new System.Windows.Forms.Padding(4);
			this.grpRole.Size = new System.Drawing.Size(247, 63);
			this.grpRole.TabIndex = 8;
			this.grpRole.TabStop = false;
			this.grpRole.Text = "Role";
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(52, 344);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(542, 196);
			this.dataGridView1.TabIndex = 9;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.Control;
			this.label8.Location = new System.Drawing.Point(221, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(165, 25);
			this.label8.TabIndex = 12;
			this.label8.Text = "User Regsitration";
			// 
			// UserRegistration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(671, 588);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.grpRole);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(687, 627);
			this.MinimumSize = new System.Drawing.Size(687, 627);
			this.Name = "UserRegistration";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "User Registration";
			this.grpRole.ResumeLayout(false);
			this.grpRole.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RichTextBox txtUserName;
		private System.Windows.Forms.RichTextBox txtEmail;
		private System.Windows.Forms.RichTextBox txtPassword;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.RadioButton rdoStaff;
		private System.Windows.Forms.RadioButton rdoAdmin;
		private System.Windows.Forms.GroupBox grpRole;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label8;
	}
}