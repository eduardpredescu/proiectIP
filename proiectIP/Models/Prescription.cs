using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectIP.Models
{
    class Prescription
    {
        private int id;
        private int medicId;
        private int patientId;
        private string prescriptionText;

        public Prescription(int id, int medicId, int patientId, string prescriptionText)
        {
            this.Id = id;
            this.MedicId = medicId;
            this.PatientId = patientId;
            this.PrescriptionText = prescriptionText;
        }

        public int Id { get => id; set => id = value; }
        public int MedicId { get => medicId; set => medicId = value; }
        public int PatientId { get => patientId; set => patientId = value; }
        public string PrescriptionText { get => prescriptionText; set => prescriptionText = value; }
    }
}
