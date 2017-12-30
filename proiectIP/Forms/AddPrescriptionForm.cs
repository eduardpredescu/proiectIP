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
        private string username;
        private Medic currentUser;
        private Patient selectedPatient;
        public AddPrescriptionForm(int patientId, int medicId, string username)
        {
            this.patientId = patientId;
            this.medicId = medicId;
            this.username = username;
            this.currentUser = MedicController.getById(this.medicId);
            this.selectedPatient = PatientController.getById(this.patientId);
            this.FormClosing += FormUtility.CloseForm;
            InitializeComponent();
        }


        private void generatePrescriptionDocButton_Click(object sender, EventArgs e)
        {
            if (PrescriptionController.savePrescription(prescriptionTextBox.Text, this.medicId, this.patientId))
            {
                DocumentGenerator.generatePrescription(this.currentUser, this.selectedPatient, prescriptionTextBox.Text);
                MessageBox.Show("Document generated.");
                this.Hide();
                new PatientForm(this.username).Show();
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void AddPrescriptionForm_Load(object sender, EventArgs e)
        {
            patientNameTextBox.Text = selectedPatient.Name;
            patientSurnameTextBox.Text = selectedPatient.Surname;
            patientBloodTypeTextBox.Text = selectedPatient.BloodType;
        }
    }
}
