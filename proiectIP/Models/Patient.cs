using proiectIP.Forms;
using System.Collections.Generic;

namespace proiectIP.Models
{
    class Patient
    {
        private int id;
        private string name;
        private string surname;
        private string bloodType;

        public Patient(int id, string name, string surname, string bloodType)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.BloodType = bloodType;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string BloodType { get => bloodType; set => bloodType = value; }

        public override string ToString()
        {
            return Id.ToString()+" "+Name+" "+Surname+" "+BloodType;
        }
    }
}
