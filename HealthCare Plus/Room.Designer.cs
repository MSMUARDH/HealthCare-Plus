
namespace HealthCare_Plus
{
	partial class Room
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
			this.txtRoomNo = new System.Windows.Forms.TextBox();
			this.txtRoomPrice = new System.Windows.Forms.TextBox();
			this.RoomNo = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.rbtnActive = new System.Windows.Forms.RadioButton();
			this.rbtnInactive = new System.Windows.Forms.RadioButton();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnCreateRoom = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtRoomNo
			// 
			this.txtRoomNo.BackColor = System.Drawing.SystemColors.ControlLight;
			this.txtRoomNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRoomNo.Location = new System.Drawing.Point(246, 82);
			this.txtRoomNo.Margin = new System.Windows.Forms.Padding(2);
			this.txtRoomNo.Multiline = true;
			this.txtRoomNo.Name = "txtRoomNo";
			this.txtRoomNo.Size = new System.Drawing.Size(167, 28);
			this.txtRoomNo.TabIndex = 1;
			// 
			// txtRoomPrice
			// 
			this.txtRoomPrice.BackColor = System.Drawing.SystemColors.ControlLight;
			this.txtRoomPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtRoomPrice.Location = new System.Drawing.Point(246, 138);
			this.txtRoomPrice.Margin = new System.Windows.Forms.Padding(2);
			this.txtRoomPrice.Multiline = true;
			this.txtRoomPrice.Name = "txtRoomPrice";
			this.txtRoomPrice.Size = new System.Drawing.Size(167, 30);
			this.txtRoomPrice.TabIndex = 4;
			// 
			// RoomNo
			// 
			this.RoomNo.AutoSize = true;
			this.RoomNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RoomNo.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.RoomNo.Location = new System.Drawing.Point(145, 85);
			this.RoomNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.RoomNo.Name = "RoomNo";
			this.RoomNo.Size = new System.Drawing.Size(66, 17);
			this.RoomNo.TabIndex = 1;
			this.RoomNo.Text = "Room No";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label2.Location = new System.Drawing.Point(95, 191);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Occupancy Status";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.label3.Location = new System.Drawing.Point(173, 141);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(38, 17);
			this.label3.TabIndex = 1;
			this.label3.Text = "Price";
			// 
			// rbtnActive
			// 
			this.rbtnActive.AutoSize = true;
			this.rbtnActive.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtnActive.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.rbtnActive.Location = new System.Drawing.Point(246, 191);
			this.rbtnActive.Margin = new System.Windows.Forms.Padding(2);
			this.rbtnActive.Name = "rbtnActive";
			this.rbtnActive.Size = new System.Drawing.Size(81, 21);
			this.rbtnActive.TabIndex = 5;
			this.rbtnActive.Text = "occupied";
			this.rbtnActive.UseVisualStyleBackColor = true;
			// 
			// rbtnInactive
			// 
			this.rbtnInactive.AutoSize = true;
			this.rbtnInactive.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtnInactive.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.rbtnInactive.Location = new System.Drawing.Point(339, 191);
			this.rbtnInactive.Margin = new System.Windows.Forms.Padding(2);
			this.rbtnInactive.Name = "rbtnInactive";
			this.rbtnInactive.Size = new System.Drawing.Size(97, 21);
			this.rbtnInactive.TabIndex = 6;
			this.rbtnInactive.Text = "unoccupied";
			this.rbtnInactive.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.Location = new System.Drawing.Point(58, 312);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(457, 193);
			this.dataGridView1.TabIndex = 3;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// btnCreateRoom
			// 
			this.btnCreateRoom.BackColor = System.Drawing.Color.SeaGreen;
			this.btnCreateRoom.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCreateRoom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreateRoom.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnCreateRoom.Location = new System.Drawing.Point(61, 246);
			this.btnCreateRoom.Margin = new System.Windows.Forms.Padding(2);
			this.btnCreateRoom.Name = "btnCreateRoom";
			this.btnCreateRoom.Size = new System.Drawing.Size(90, 30);
			this.btnCreateRoom.TabIndex = 4;
			this.btnCreateRoom.Text = "Create";
			this.btnCreateRoom.UseVisualStyleBackColor = false;
			this.btnCreateRoom.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.Maroon;
			this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnClear.Location = new System.Drawing.Point(425, 246);
			this.btnClear.Margin = new System.Windows.Forms.Padding(2);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(90, 30);
			this.btnClear.TabIndex = 4;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.RoyalBlue;
			this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnUpdate.Location = new System.Drawing.Point(182, 246);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(90, 30);
			this.btnUpdate.TabIndex = 4;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Maroon;
			this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
			this.btnDelete.Location = new System.Drawing.Point(309, 246);
			this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(90, 30);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.SystemColors.Control;
			this.label8.Location = new System.Drawing.Point(209, 9);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(129, 25);
			this.label8.TabIndex = 12;
			this.label8.Text = "Room Details";
			// 
			// Room
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.SteelBlue;
			this.ClientSize = new System.Drawing.Size(570, 516);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnCreateRoom);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.rbtnInactive);
			this.Controls.Add(this.rbtnActive);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.RoomNo);
			this.Controls.Add(this.txtRoomPrice);
			this.Controls.Add(this.txtRoomNo);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Room";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Room";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtRoomNo;
		private System.Windows.Forms.TextBox txtRoomPrice;
		private System.Windows.Forms.Label RoomNo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RadioButton rbtnActive;
		private System.Windows.Forms.RadioButton rbtnInactive;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnCreateRoom;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label label8;
	}
}