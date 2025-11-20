using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kamer_Keuze_Tekst_Game
{
    internal class Program
    {
        static void Main(string[] args)
          
        {
            bool scissor = false;
            Console.WriteLine("Je wordt wakker in een ziekenhuis, je hebt geen idee waarom je hier bent of wie je bent, zoek de uitgang");
            Console.WriteLine("Er zit nog een naald in je arm, je trekt hem eruit, Je Kamer heeft 3 deuren.");
            Console.WriteLine("1 = De deur rechts links van je bed, het lijkt niet op de uitgang  ");
            Console.WriteLine("2 = De deur dicht bij het voeten eind van je bed.");
            Console.WriteLine("3 = Je kijkt naar de raam recht van je bed, wil je naar buiten kijken ");
            string choice1 = Console.ReadLine();
            if (choice1 == "1")
            {
                Console.WriteLine("je kiest voor de deur rechts links van je bed, het lijdt naar een Badkamer");
            }
            else if (choice1 == "2")
            {
                Console.WriteLine("Je kiest voor de deur aan het eind van je voeten bed, Het leidt naar een lange hal, je ziet losse bedden op de grond liggen en de lichten flikkeren");
            }
            else if (choice1 == "3")
            {
                Console.WriteLine("Je kiest voor het raam rechts van je bed, je bent op de 3de verdieping en er zijn wat bosjes beneden");
            }
            else Console.WriteLine("Er zijn maar 3 deuren in de kamer");
        }
    }
}
