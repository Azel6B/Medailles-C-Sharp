using System;
using System.Collections.Generic;
using System.Linq;

namespace _7_Dobbelsteen_Simulatie_Opdracht_7_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool herstarten = true;

            while (herstarten)
            {
                Console.Clear();
                int aantalWorpen = 1;
                int totaalAantalWorpen = 100;
                Random random = new Random();
                int[] tellingen = new int[7];

                //simulatie van 100 worpen
                while (aantalWorpen <= totaalAantalWorpen)
                {
                    int worp = random.Next(1, 7);
                    tellingen[worp]++;
                    aantalWorpen++;
                }

                //results
                Console.WriteLine("--- Resultaten van 100 worpen ---");
                for (int i = 1; i <= 6; i++)
                {
                    double percentage = (tellingen[i] / (double)totaalAantalWorpen) * 100;
                    Console.WriteLine("Nummer " + i + ": " + tellingen[i] + " keer (" + percentage + "%)");
                }

                int hoogsteAantal = tellingen.Max(); //hoogste getal in de array
                List<int> winnaars = new List<int>();

                for (int i = 1; i <= 6; i++)
                {
                    if (tellingen[i] == hoogsteAantal)
                    {
                        winnaars.Add(i);
                    }
                }

                Console.WriteLine("\nHet hoogste aantal worpen was: " + hoogsteAantal);
                Console.WriteLine("Meest gegooide nummer(s): " + string.Join(", ", winnaars));

                //restarten
                Console.WriteLine("\nDruk op 'R' om opnieuw te runnen of op een andere toets om te stoppen.");
                ConsoleKeyInfo input = Console.ReadKey();
                if (input.Key != ConsoleKey.R)
                {
                    herstarten = false;
                }
            }
        }
    }
}
