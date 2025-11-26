using System;

namespace Kamer_Keuze_Tekst_Game
{
    public class player
    {
        public string name;
        public int health;
        public int damage;
        public bool weapon;
        public inventory playerInventory;
        public player(string name, int health, int damage, bool weapon)
        {
            this.name = name;
            this.health = health;
            this.damage = damage;
            this.weapon = weapon;
            this.playerInventory = new inventory(false, false, 0, 0);
        }
    }
    public class inventory
    {
        public bool scissors;
        public bool medkit;
        public int bandage;
        public int keys;
        public inventory(bool scissors, bool medkit, int bandage, int keys)
        {
            this.scissors = scissors;
            this.medkit = medkit;
            this.bandage = bandage;
            this.keys = keys;
        }
    }
    public class enemy
    {
        public string name;
        public string description;
        public int health;
        public int damage;
        public enemy(string name, string description, int health, int damage)
        {
            this.name = name;
            this.description = description;
            this.health = health;
            this.damage = damage;
        }

    }
    public class room
    {
        public string name;
        public string description;
        public bool locked;
        public room(string name, string description, bool locked)
        {
            this.name = name;
            this.description = description;
            this.locked = locked;
        }

    }
    internal class Program
    {
        static void Main(string[] args)

        {
            player player1 = new player("Player", 100, 10, false);
            room room1 = new room("Patient's Room", " A dreary run down room, its where you woke up", false);
            room room2 = new room("Bathroom", "A neat bathroom, what youd expect from a hospital", false);
            room room3 = new room("Hallway", "A long hallway with several doors on either side", true);
            room room4 = new room("Window", "Nice window? not much to say about it", true);
            Console.Write("Name: ");
            string playerName = Console.ReadLine();
            player1.name = playerName;
            Console.WriteLine($"Your name is {playerName}");
            if (player1.weapon == false)
            {
                Console.WriteLine("You have no weapon");
            }
            else
            {
                Console.WriteLine($"You have a weapon");
            }
            Console.WriteLine("There are 2 doors in your room, along with a window to the side.");
            Console.WriteLine("Do you want to go through the 'left door', 'right door' or look through the 'window?'");
            string choice1 = Console.ReadLine();
            if (choice1.ToLower() == "left door")
            {
                Console.WriteLine("You go through the left door");
            }
            else if (choice1.ToLower() == "right door")
            {
                Console.WriteLine("You go through the right door");
            }
            else if (choice1.ToLower() == "window")
            {
                Console.WriteLine("You look through the window and see a garden outside");
            }
            else
            {
                Console.WriteLine("Invalid choice, please choose again.");
            }


        }
    }
}
