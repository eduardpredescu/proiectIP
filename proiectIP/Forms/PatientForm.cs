using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            // TODO: This line of code loads data into the 'bazaDeDateIPDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.bazaDeDateIPDataSet.Patient);

        }
    }
}
