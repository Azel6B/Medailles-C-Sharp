using System;

namespace Tips_Voor_Het_Weer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string weer;
            int temperatuur;
            bool IsNummer;
            Console.WriteLine("Wat is het weer?");
            weer = Console.ReadLine();
            do
            {
                Console.WriteLine("Wat is de temperatuur?");
                IsNummer = int.TryParse(Console.ReadLine(), out temperatuur);
                if (!IsNummer)
                {
                    Console.WriteLine("Voer een geldig nummer in voor de temperatuur.");
                }
            } while (!IsNummer);
            if (weer == "zonnig" && temperatuur >= 20)
            {
                Console.WriteLine("Draag een zonnebril");
            }
            else if (weer == "zonnig" && temperatuur < 20)
            {
                Console.WriteLine("Draag een pet");
            }
            else if (weer == "regen" && temperatuur >= 15)
            {
                Console.WriteLine("Het is wel warm, Draag nogsteeds een regenjas");
            }
            else if (weer == "regen" && temperatuur < 15)
            {
                Console.WriteLine("Neem een paraplu mee");
            }
            else if (weer == "bewolkt" && temperatuur >= 15)
            {
                Console.WriteLine("Draag een licht jasje");
            }
            else if (weer == "bewolkt" && temperatuur < 15)
            {
                Console.WriteLine("Draag warme kleding");
            }
            else
            {
                Console.WriteLine("Oke");
            }

        }
    }
}//Brons & Zilver & Goud Klaar
