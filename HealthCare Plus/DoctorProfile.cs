using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCare_Plus
{
	public partial class DoctorProfile : Form
	{
		public DoctorProfile(string doctorName,string specilization,string availability,string location,string qualifications,string expertise,string contact)
		{
			InitializeComponent();
			this.lblDoctorName.Text = doctorName;
			this.lblSpecialization.Text = specilization;
			this.lblAvailability.Text = availability;
			this.lblLocation.Text = location;
			this.lblQualification.Text = qualifications;
			this.lblExpertise.Text = expertise;
			this.lblContact.Text = contact;
	
		}

	}
}
