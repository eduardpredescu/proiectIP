using proiectIP.Models;
using proiectIP.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proiectIP.Controllers;

namespace proiectIP.Forms
{
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            patientListView.Items.Clear();

            patientListView.GridLines = true;
            patientListView.View = View.Details;
            

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
    }
}
