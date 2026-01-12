using System;

namespace WoordOmkeren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een woord in:");
            string input = Console.ReadLine();

            string omgekeerd = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                omgekeerd += input[i];
            }

            string resultaat = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    resultaat += char.ToUpper(omgekeerd[i]);
                }
                else
                {
                    resultaat += char.ToLower(omgekeerd[i]);
                }
            }

            Console.WriteLine("Het omgekeerde woord is: " + resultaat);

            if (input.ToLower() == omgekeerd.ToLower())
            {
                Console.WriteLine("Het is een palindroom!");
            }
            else
            {
                Console.WriteLine("Het is geen palindroom.");
            }

            Console.ReadKey();
        }
    }
}
