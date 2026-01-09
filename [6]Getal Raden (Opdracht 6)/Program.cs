using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Getal_Raden__Opdracht_6_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tot hoe hoog mag het getal gaan?");
            string input = Console.ReadLine();
            int maxGetal;

            while (!int.TryParse(input, out maxGetal))
            {
                Console.WriteLine("Dat is geen geldig nummer, probeer het opnieuw:");
                input = Console.ReadLine();
            }

            Random generator = new Random();
            int geheimGetal = generator.Next(1, maxGetal + 1);
            int gok = 0;
            int pogingen = 0;

            while (gok != geheimGetal)
            {
                Console.WriteLine($"Doe een gok (1-{maxGetal}):");
                if (int.TryParse(Console.ReadLine(), out gok))
                {
                    pogingen++;

                    if (gok == geheimGetal)
                    {
                        Console.WriteLine($"Lekker gedaan! Geraden in {pogingen} pogingen.");
                    }
                    else if (gok < geheimGetal)
                    {
                        Console.WriteLine("Hoger!");
                    }
                    else
                    {
                        Console.WriteLine("Lager!");
                    }
                }
            }
        }
    }
}
