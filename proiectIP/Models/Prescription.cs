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
        private string medicName;
        private string medicSpecialisation;
        private string patientName;
        private string patientSurname;
        private string patientBloodType;
        private string prescriptionText;

        public Prescription(int id, int medicId, int patientId, string prescriptionText)
        {
            this.Id = id;
            this.MedicId = medicId;
            this.PatientId = patientId;
            this.PrescriptionText = prescriptionText;
        }

        public Prescription(int id, 
            string medicName, 
            string medicSpecialisation, 
            string patientName, 
            string patientSurname, 
            string patientBloodType,
            string prescriptionText)
        {
            this.Id = id;
            this.MedicName = medicName;
            this.MedicSpecialisation = medicSpecialisation;
            this.PatientName = patientName;
            this.PatientSurname = patientSurname;
            this.PatientBloodType = patientBloodType;
            this.PrescriptionText = prescriptionText;
        }

        public int Id { get => id; set => id = value; }
        public int MedicId { get => medicId; set => medicId = value; }
        public int PatientId { get => patientId; set => patientId = value; }
        public string PrescriptionText { get => prescriptionText; set => prescriptionText = value; }
        public string MedicName { get => medicName; set => medicName = value; }
        public string MedicSpecialisation { get => medicSpecialisation; set => medicSpecialisation = value; }
        public string PatientName { get => patientName; set => patientName = value; }
        public string PatientSurname { get => patientSurname; set => patientSurname = value; }
        public string PatientBloodType { get => patientBloodType; set => patientBloodType = value; }
    }
}
