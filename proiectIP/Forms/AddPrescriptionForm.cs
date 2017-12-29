using proiectIP.Controllers;
using proiectIP.Models;
using proiectIP.Utils;
using System;
using System.Windows.Forms;

namespace proiectIP.Forms
{
    public partial class AddPrescriptionForm : Form
    {
        private int patientId;
        private int medicId;
        private Medic currentUser;
        private Patient selectedPatient;
        public AddPrescriptionForm(int patientId, int medicId)
        {
            this.patientId = patientId;
            this.medicId = medicId;
            this.currentUser = MedicController.getById(this.medicId);
            this.selectedPatient = PatientController.getById(this.patientId);
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
                DocumentGenerator.generatePrescription(this.currentUser, this.selectedPatient, prescriptionTextBox.Text);
            }
            else
            {
                MessageBox.Show("Error");
            }

        }
    }
}
