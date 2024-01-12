using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.SqlClient;

namespace HealthCare_Plus
{
	public partial class Resource : Form
	{
        string path = @"Data Source=DESKTOP-R998OAS;Initial Catalog=HealthCarePlus; Integrated Security=True;";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        Dictionary<int, string> idNameMapping = new Dictionary<int, string>();

        public string selectedName { get; set; }
        public int selectedId { get; set; }
		public string ReportType { get; private set; }

		public int ID;

        public Resource()
		{
			InitializeComponent();
            con = new SqlConnection(path);
            fillComboBox();

        }



        public void fillComboBox()
        {
            cmd = new SqlCommand("select * from Patients", con);
            SqlDataReader myreader;

            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();


                while (myreader.Read())
                {
                    int id = myreader.GetInt32(0);
                    string name = myreader.GetString(1);

                    cmbxPertientName.Items.Add(name);
                    idNameMapping[id] = name;
                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



		private void button1_Click(object sender, EventArgs e)
		{
			//To where your opendialog box get starting location. My initial directory location is desktop.
			openFileDialog1.InitialDirectory = "C://Desktop";
			//Your opendialog box title name.
			openFileDialog1.Title = "Select file to be upload.";
			//which type file format you want to upload in database. just add them.
			openFileDialog1.Filter = "Select Valid Document(*.pdf; *.doc; *.xlsx; *.html)|*.pdf; *.docx; *.xlsx; *.html";
			//FilterIndex property represents the index of the filter currently selected in the file dialog box.
			openFileDialog1.FilterIndex = 1;
			try
			{
				if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
				{
					if (openFileDialog1.CheckFileExists)
					{
						string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
						label1.Text = path;
					}
				}
				else
				{
                    //MessageBox.Show("Please Upload document.");
                    MessageBox.Show("Please Upload document.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
			}
			catch (Exception ex)
			{
                MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}


		private void btnAdd_Click_1(object sender, EventArgs e)
		{
 
            try
            {
      

                if (cmbxPertientName.Text == "" || cmbReportType.Text == "" )
                {
                    MessageBox.Show("All Fields are required...", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {


                    try
                    {
                        string filename = System.IO.Path.GetFileName(openFileDialog1.FileName);
                        if (filename == null)
                        {
                            //MessageBox.Show("Please select a valid document.");
                            MessageBox.Show("Please select a valid document.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else
                        {
                            //we already define our connection globaly. We are just calling the object of connection.
                            con.Open();
                            SqlCommand cmd = new SqlCommand("insert into Resources (Patient_Id,Patient_Name,Report_Type,Report) values('" + selectedId + "','" + selectedName+"','"+ReportType+"','\\Document\\" + filename + "')", con);
                            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                            System.IO.File.Copy(openFileDialog1.FileName, path + "\\Document\\" + filename);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            //MessageBox.Show("Resources Data has been Saved Successfully...");
                            MessageBox.Show("Resources Data has been Saved Successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

			}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

		private void cmbReportType_SelectedIndexChanged(object sender, EventArgs e)
		{
            ReportType = cmbReportType.SelectedItem.ToString();
		}

		private void cmbxPertientName_SelectedIndexChanged(object sender, EventArgs e)
		{
            if (cmbxPertientName.SelectedIndex != -1)
            {
                selectedName = cmbxPertientName.SelectedItem.ToString();
                selectedId = idNameMapping.FirstOrDefault(x => x.Value == selectedName).Key;


            }
        }
	}
}
