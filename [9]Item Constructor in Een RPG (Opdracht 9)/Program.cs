using System;
using System.Collections.Generic;

namespace _9_Item_Constructor_in_Een_RPG__Opdracht_9_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item sword = new Item("Excalibur", 50, "Sword");
            Item bow = new Item("Longbow", 30, "Bow");
            Item staff = new Item("Wizard's Staff", 40, "Staff");
            List<Item> inventory = new List<Item>();
            inventory.Add(sword);
            inventory.Add(bow);
            inventory.Add(staff);
            Console.WriteLine("---Player Inventory---");
            foreach (Item Item in inventory)
            {
                Item.ShowStats();
            }
            Console.WriteLine("\n---Upgrading Items---");
            foreach (Item Item in inventory)
            {
                Item.UpgradeItem(10);
            }
            Console.WriteLine("\n---Upgraded Inventory---");
            foreach (Item Item in inventory)
            {
                Item.ShowStats();
            }
        }
        class Item
        {
            public string Name;
            public int Damage;
            public string Type;
            public void ShowStats()
            {
                Console.WriteLine($"Item: {Name}, Damage: {Damage}");
                Console.WriteLine($"Type: {Type}");
            }
            public void UpgradeItem(int damageToAdd)
            {
                Damage += damageToAdd;
            }
            public Item(string name, int damage, string type)
            {
                Name = name;
                Damage = damage;
                Type = type;
            }
        }
    }
}
