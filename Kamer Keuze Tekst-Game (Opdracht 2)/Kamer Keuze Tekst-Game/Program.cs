using Kamer_Keuze_Tekst_Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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
            this.playerInventory = new inventory (false, false, 0, 0);
        }
    }
    public class inventory
    { 
    public bool scissors;
    public bool medkit;
    public int bandage;
    public int keys;
    public inventory (bool scissors, bool medkit, int bandage, int keys)
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
    public enemy (string name, string description, int health, int damage)
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
    public room (string name, string description, bool locked)
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
            Console.WriteLine("What's your name");
        }
    }
}
