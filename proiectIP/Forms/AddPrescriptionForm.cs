using proiectIP.Controllers;
using proiectIP.Utils;
using System;
using System.Windows.Forms;

namespace proiectIP.Forms
{
    public partial class AddPrescriptionForm : Form
    {
        private int patientId;
        private int medicId;
        public AddPrescriptionForm(int patientId, int medicId)
        {
            this.patientId = patientId;
            this.medicId = medicId;
            this.FormClosing += FormUtility.CloseForm;
            InitializeComponent();
        }

        private void savePrescriptionButton_Click(object sender, EventArgs e)
        {
            if (PrescriptionController.savePrescription(prescriptionTextBox.Text, this.medicId, this.patientId))
            {
                MessageBox.Show("Data Added");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void generatePrescriptionDocButton_Click(object sender, EventArgs e)
        {
            if (PrescriptionController.savePrescription(prescriptionTextBox.Text, this.medicId, this.patientId))
            {
                MessageBox.Show("Data Added");

            }
            else
            {
                MessageBox.Show("Error");
            }

        }
    }
}
