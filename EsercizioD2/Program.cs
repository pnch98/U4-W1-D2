using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioD2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Marco", "Giacomini", 34);
            Console.WriteLine(persona1.GetDettagli());
            Persona persona2 = new Persona();
            Console.WriteLine("Inserisci il nome: ");
            string nome = Console.ReadLine();
            persona2.Name = nome;
            Console.WriteLine("Inserisci il cognome: ");
            string cognome = Console.ReadLine();
            persona2.Surname = cognome;

            Console.WriteLine("Inserisci età: ");
            int eta ;
            while(!int.TryParse(Console.ReadLine(), out eta)) {
                Console.WriteLine("Ho detto età!");
                Console.WriteLine("Inserisci età: ");
            }
            persona2.Age = eta;

            Console.WriteLine(persona2.GetDettagli());



        }
    }
}
