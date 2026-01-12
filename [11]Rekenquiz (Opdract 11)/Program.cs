using System;

namespace Rekenquiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int score = 0;
            int aantalVragen = 5;
            string[] types = { "+", "-", "*", "/" };

            Console.WriteLine("--- Welkom bij de Rekenquiz! ---");

            //loop om 5 vragen te stellen
            for (int i = 1; i <= aantalVragen; i++)
            {
                int g1 = rnd.Next(1, 11); // Getal tussen 1 en 10
                int g2 = rnd.Next(1, 11);
                string gekozenType = types[rnd.Next(0, 4)];

                Som huidigeSom = new Som(g1, g2, gekozenType);

                Console.WriteLine("\nVraag " + i + ": Hoeveel is " + g1 + " " + gekozenType + " " + g2 + "?");
                if (gekozenType == "/")
                {
                    Console.WriteLine("(Rond af op 2 decimalen)");
                }

                string antwoordVanGebruiker = Console.ReadLine();

                if (huidigeSom.CheckAwnser(antwoordVanGebruiker))
                {
                    Console.WriteLine("Goed gedaan!");
                    score = score + 1;
                }
                else
                {
                    Console.WriteLine("Helaas, het juiste antwoord was: " + huidigeSom.correctAntwoord);
                }
            }

            //results
            Console.WriteLine("\n--- Quiz Klaar ---");
            Console.WriteLine("Je score: " + score + " van de 5");

            if (score == 5)
            {
                Console.WriteLine("Beoordeling: Goud! Alles goed.");
            }
            else if (score >= 3)
            {
                Console.WriteLine("Beoordeling: Goed gedaan!");
            }
            else
            {
                Console.WriteLine("Beoordeling: Volgende keer beter!");
            }
        }
    }

    class Som
    {
        //class variables
        public int getal1;
        public int getal2;
        public string type;
        public double correctAntwoord;

        //Constructor
        public Som(int g1, int g2, string t)
        {
            getal1 = g1;
            getal2 = g2;
            type = t;

            if (type == "+")
            {
                correctAntwoord = getal1 + getal2;
            }
            else if (type == "-")
            {
                correctAntwoord = getal1 - getal2;
            }
            else if (type == "*")
            {
                correctAntwoord = getal1 * getal2;
            }
            else if (type == "/")
            {
                //double voor decimaal
                double deling = (double)getal1 / (double)getal2;
                correctAntwoord = Math.Round(deling, 2);
            }
        }

        //answer control function
        public bool CheckAwnser(string input)
        {
            double getalInput = Convert.ToDouble(input);

            if (getalInput == correctAntwoord)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
