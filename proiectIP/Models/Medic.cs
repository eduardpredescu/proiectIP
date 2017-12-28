using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectIP.Models
{
    class Medic
    {
        private int id;
        private string name;
        private string surname;
        private string specialisation;

        public Medic(int id, string name, string surname, string specialisation)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Specialisation = specialisation;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Specialisation { get => specialisation; set => specialisation = value; }
    }
}
