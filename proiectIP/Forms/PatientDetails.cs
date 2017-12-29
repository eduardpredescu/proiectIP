using proiectIP.Controllers;
using proiectIP.Models;
using proiectIP.Utils;
using System.Collections.Generic;
using System.Windows.Forms;

namespace proiectIP.Forms
{
    public partial class PatientDetails : Form
    {
        private string username;

        public PatientDetails(string username)
        {
            this.username = username;
            this.FormClosing += FormUtility.CloseForm;
            InitializeComponent();
        }

        private void PatientDetails_Load(object sender, System.EventArgs e)
        {
            Patient p = PatientController.getByUsername(this.username);

            if (p.Id == -1)
            {
                MessageBox.Show("Patient not found!");
                this.Hide();
                new FormManager().Show();
            }

            nameTextBox.Text = p.Name;
            surnameTextBox.Text = p.Surname;
            bloodTypeTextBox.Text = p.BloodType;
            List<Prescription> prList = PrescriptionController.getPatientPrescription(p.Id);

            prescriptionListView.Clear();

            prescriptionListView.Columns.Add("Prescription List", 100);
            prescriptionListView.Columns.Add("Medic Name", 150);
            prescriptionListView.Columns.Add("Medic Specialisation", 150);

            prescriptionListView.BeginUpdate();

            foreach(Prescription pr in prList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(pr.MedicName);
                lvi.SubItems.Add(pr.MedicSpecialisation);
                lvi.SubItems.Add(pr.PrescriptionText);
                prescriptionListView.Items.Add(lvi);
            }

            prescriptionListView.EndUpdate();
        }

        private void prescriptionListView_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            MessageBox.Show(prescriptionListView.SelectedItems[0].SubItems[3].Text);
        }
    }
}
