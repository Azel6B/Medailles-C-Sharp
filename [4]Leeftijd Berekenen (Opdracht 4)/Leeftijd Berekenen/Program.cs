using System;

namespace Leeftijd_Berekenen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CurrentYear = DateTime.Now.Year;
            Console.Write("Geef je geboortejaar in: ");
            int BirthYear = Convert.ToInt32(Console.ReadLine());
            int Age = CurrentYear - BirthYear;
            Console.WriteLine("Je bent " + Age + " jaar oud.");
            Console.ReadLine();
            if (Age >= 18)
            {
                Console.WriteLine("Je bent meerderjarig, je mag stemmen.");
            }
            else
            {
                Console.WriteLine("Je bent minderjarig, je mag niet stemmen.");
            }
            Console.WriteLine(
                "Druk op een toets om af te sluiten..."
            );
            Console.ReadKey();
            Console.WriteLine(
                "Bedankt voor het gebruiken van dit programma!"
            );
        }
    }
}
