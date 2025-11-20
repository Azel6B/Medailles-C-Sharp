using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__medailles_Opdrachten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Naam: ");
            string name = Console.ReadLine();

            Console.Write("Leeftijd: ");
            string age = Console.ReadLine();

                Console.WriteLine($"Hoi {name}, Je bent {age} jaar oud");
                Console.WriteLine("Druk op een knop om door te gaan");
                Console.ReadKey();
        }
    }
}
