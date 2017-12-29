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
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\XT\source\repos\proiectIP\proiectIP\BazaDeDateIP.accdb");
            connection.Open();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT * FROM Patient", connection);
            reader = command.ExecuteReader();
            patientListView.Items.Clear();
            List<Patient> pList = new List<Patient>();

            while (reader.Read())
            {
                pList.Add(new Patient((int) reader[0], (string) reader[1], (string) reader[2], (string) reader[3]));
            }

            connection.Close();

            patientListView.GridLines = true;
            patientListView.View = View.Details;
            

            patientListView.Columns.Add("Patient List", 100);
            patientListView.Columns.Add("ID", 50);
            patientListView.Columns.Add("Name", 150);
            patientListView.Columns.Add("Surname", 150);
            patientListView.Columns.Add("Blood Type", 150);

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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    FormManager.AppInstance.Close();
                    break;
            }
        }
    }
}
