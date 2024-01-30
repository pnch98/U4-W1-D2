using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioD2
{
    internal class Persona
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public Persona() { }
        public Persona(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public string GetDettagli() { 
            return "Name: " + this.Name + "\nSurname: " + this.Surname + "\nAge: " + this.Age + "\n";
        }
    }
}
