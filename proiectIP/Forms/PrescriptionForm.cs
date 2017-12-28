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
    public partial class PrescriptionForm : Form
    {
        public PrescriptionForm()
        {
            InitializeComponent();
        }

        private void PrescriptionForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bazaDeDateIPDataSet.Prescription' table. You can move, or remove it, as needed.
            this.prescriptionTableAdapter.Fill(this.bazaDeDateIPDataSet.Prescription);
        }
        
    }
}
