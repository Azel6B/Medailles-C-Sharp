using System;
using System.Collections.Generic;

namespace _8_Game_Karakter_Met_Constructor__Opdracht_8_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameCharacter Player1 = new GameCharacter("Player1", 3, 5);
            GameCharacter Player2 = new GameCharacter("Player2", 5, 10);
            GameCharacter Player3 = new GameCharacter("Player3", 2, 7);
            List<GameCharacter> characters = new List<GameCharacter>();
            characters.Add(Player1);
            characters.Add(Player2);
            characters.Add(Player3);
            foreach (GameCharacter character in characters)
            {
                character.ShowStats();
            }
        }
        class GameCharacter
        {
            public string Name;
            public int Lives;
            public int Level;
            public void ShowStats()
            {
                Console.WriteLine("Name: " + Name);
                Console.WriteLine("Lives: " + Lives);
                Console.WriteLine("Level: " + Level);
                Console.WriteLine("");
            }
            // Constructor
            public GameCharacter(string name, int lives, int level)
            {
                Name = name;
                Lives = lives;
                Level = level;
            }
        }
    }
}
