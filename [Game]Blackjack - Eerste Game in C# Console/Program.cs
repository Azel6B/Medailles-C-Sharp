using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackjackSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Welkom bij The Golden Casino ---");
            int wallet = 500;

            while (wallet > 0)
            {
                Console.WriteLine($"\nJe hebt momenteel USD {wallet}");
                Console.Write("Hoeveel wil je inzetten? ");

                if (!int.TryParse(Console.ReadLine(), out int inzet) || inzet > wallet || inzet <= 0)
                {
                    Console.WriteLine("Ongeldige inzet. Probeer het opnieuw.");
                    continue;
                }

                SpeelRonde(ref wallet, inzet);

                if (wallet <= 0)
                {
                    Console.WriteLine("\nJe bent blut! Game over.");
                    break;
                }

                Console.Write("\nWil je nog een ronde spelen? (j/n): ");
                if (Console.ReadLine().ToLower() != "j") break;
            }
        }

        static void SpeelRonde(ref int wallet, int inzet)
        {
            Deck deck = new Deck();
            Hand spelerHand = new Hand();
            Hand dealerHand = new Hand();

            spelerHand.VoegToe(deck.TrekKaart());
            dealerHand.VoegToe(deck.TrekKaart());
            spelerHand.VoegToe(deck.TrekKaart());
            dealerHand.VoegToe(deck.TrekKaart());

            while (true)
            {
                Console.WriteLine($"\nDealer toont: {dealerHand.Kaarten[0]}");
                Console.WriteLine($"Jouw hand: {spelerHand} (Score: {spelerHand.BerekenScore()})");

                if (spelerHand.BerekenScore() > 21) break;

                Console.Write("Hit of Stand? (h/s): ");
                string keuze = Console.ReadLine().ToLower();

                if (keuze == "h")
                {
                    spelerHand.VoegToe(deck.TrekKaart());
                }
                else break;
            }

            int spelerScore = spelerHand.BerekenScore();

            if (spelerScore > 21)
            {
                Console.WriteLine($"\nBust! Je score is {spelerScore}. Je verliest USD {inzet}.");
                wallet -= inzet;
                return;
            }

            Console.WriteLine($"\nDealer opent: {dealerHand} (Score: {dealerHand.BerekenScore()})");
            while (dealerHand.BerekenScore() < 17)
            {
                dealerHand.VoegToe(deck.TrekKaart());
                Console.WriteLine($"Dealer trekt: {dealerHand.Kaarten.Last()} (Nieuwe score: {dealerHand.BerekenScore()})");
            }

            int dealerScore = dealerHand.BerekenScore();

            if (dealerScore > 21 || spelerScore > dealerScore)
            {
                Console.WriteLine("Gefeliciteerd, je wint!");
                wallet += inzet;
            }
            else if (spelerScore < dealerScore)
            {
                Console.WriteLine("Dealer wint.");
                wallet -= inzet;
            }
            else
            {
                Console.WriteLine("Gelijkspel (Push).");
            }
        }
    }

    class Kaart
    {
        public string Rank { get; }
        public string Suit { get; }
        public int Waarde { get; }

        public Kaart(string rank, string suit, int waarde)
        {
            Rank = rank;
            Suit = suit;
            Waarde = waarde;
        }

        public override string ToString() => $"[{Suit} {Rank}]";
    }

    class Deck
    {
        private List<Kaart> kaarten = new List<Kaart>();
        private Random rnd = new Random();

        public Deck()
        {
            string[] suits = { "Harten", "Ruiten", "Schoppen", "Klaver" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Boer", "Vrouw", "Koning", "Aas" };

            foreach (var suit in suits)
            {
                for (int i = 0; i < ranks.Length; i++)
                {
                    int waarde = (i >= 9) ? 10 : i + 2;
                    if (ranks[i] == "Aas") waarde = 11;
                    kaarten.Add(new Kaart(ranks[i], suit, waarde));
                }
            }
            kaarten = kaarten.OrderBy(x => rnd.Next()).ToList();
        }

        public Kaart TrekKaart()
        {
            Kaart k = kaarten[0];
            kaarten.RemoveAt(0);
            return k;
        }
    }

    class Hand
    {
        public List<Kaart> Kaarten = new List<Kaart>();

        public void VoegToe(Kaart k) => Kaarten.Add(k);

        public int BerekenScore()
        {
            int score = Kaarten.Sum(k => k.Waarde);
            int azen = Kaarten.Count(k => k.Rank == "Aas");

            while (score > 21 && azen > 0)
            {
                score -= 10;
                azen--;
            }
            return score;
        }

        public override string ToString() => string.Join(", ", Kaarten);
    }
}
