using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tafels_Generator__Opdracht_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
                Console.WriteLine(i);
            Console.Clear(); //Brons

            for (int i = 0; i <= 50; i+=5)
                Console.WriteLine(i);
            Console.Clear(); //Zilver

            Console.WriteLine("Geef een getal in:");
            string invoerGetal = Console.ReadLine();
            Console.WriteLine("En hoe vaak je het wilt vermenigvuldigen");
            string vermenigvuldigingsGetal = Console.ReadLine();
            int getal = Convert.ToInt32(invoerGetal);
            int vermenigvuldig = Convert.ToInt32(vermenigvuldigingsGetal);
            for (int i = 1; i <= vermenigvuldig; i++)
                Console.WriteLine("" + getal + " x " + i + " = " + (getal * i));
            Console.ReadLine(); //Goud

        }
    }
}
