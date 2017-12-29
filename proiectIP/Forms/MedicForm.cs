using proiectIP.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace proiectIP
{
    public partial class MedicForm : Form
    {

        public MedicForm()
        {
            InitializeComponent();
        }

        private void MedicForm_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var patientForm = new PatientForm();
            Hide();
            patientForm.Show();
            Close();
        }
    }
}
