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
	public partial class AppointmentManagment : Form
	{
		public AppointmentManagment()
		{
			InitializeComponent();
		}

		private void btnDoctorSchedule_Click(object sender, EventArgs e)
		{
			AppointmentReschedule obj = new AppointmentReschedule();
			obj.Show();
		}

		private void btnAppointment_Click(object sender, EventArgs e)
		{
			CheckDoctorAvailability obj = new CheckDoctorAvailability();
			obj.Show();
		}
	}
}
