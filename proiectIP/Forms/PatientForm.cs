using System;
using System.Collections.Generic;
using System.Windows.Forms;
using proiectIP.Models;
using proiectIP.Controllers;
using proiectIP.Utils;


namespace proiectIP.Forms
{
    public partial class PatientForm : Form
    {
        private string username;
        private Medic currentUser;
        public PatientForm(string username)
        {
            this.username = username;
            this.FormClosing += FormUtility.CloseForm;
            InitializeComponent();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {

            this.currentUser = MedicController.getByUsername(this.username);
            patientListView.Items.Clear();           

            patientListView.Columns.Add("Patient List", 100);
            patientListView.Columns.Add("ID", 50);
            patientListView.Columns.Add("Name", 150);
            patientListView.Columns.Add("Surname", 150);
            patientListView.Columns.Add("Blood Type", 150);

            List<Patient> pList = PatientController.getAll();

            patientListView.BeginUpdate();
            
            foreach(Patient elem in pList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(elem.Id.ToString());
                lvi.SubItems.Add(elem.Name);
                lvi.SubItems.Add(elem.Surname);
                lvi.SubItems.Add(elem.BloodType);
                patientListView.Items.Add(lvi);
            }

            patientListView.EndUpdate();
        }

        private void patientListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();
            new AddPrescriptionForm(Int32.Parse(patientListView.SelectedItems[0].SubItems[1].Text), this.currentUser.Id).Show();
        }
    }
}
