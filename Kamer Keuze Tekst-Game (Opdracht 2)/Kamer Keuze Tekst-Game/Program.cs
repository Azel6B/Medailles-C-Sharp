using System;

namespace TextAdventureGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine($"\nWelcome, {playerName}. You find yourself in a dimly lit Entry Hall.");

            string currentRoom = "Entry Hall";
            bool gameOver = false;

            while (!gameOver)
            {
                Console.WriteLine($"\n--- You are in the {currentRoom} ---");

                if (currentRoom == "Entry Hall")
                {
                    Console.WriteLine("You see a 'left door', a 'right door', and a path 'straight ahead'.");
                    Console.Write("What do you do? ");
                    string choice = Console.ReadLine().ToLower();

                    if (choice == "left door")
                    {
                        Console.WriteLine("You cautiously open the left door and step into a dirty Kitchen.");
                        currentRoom = "Kitchen";
                    }
                    else if (choice == "right door")
                    {
                        Console.WriteLine("You push open the right door into a dusty Living Room.");
                        currentRoom = "Living Room";
                    }
                    else if (choice == "straight ahead")
                    {
                        Console.WriteLine("You walk straight ahead and discover an unexpected exit! The fresh air hits you.");
                        Console.WriteLine("You've escaped! You Win!");
                        gameOver = true;
                    }
                    else
                    {
                        Console.WriteLine("You hesitate, that way give you a bad feeling. Try a different direction.");
                    }
                }
                else if (currentRoom == "Kitchen")
                {
                    Console.WriteLine("The Kitchen is dark and smells of decay. You see a 'pantry', an 'exit window', or you can 'back to entry hall'.");
                    Console.Write("What do you do? ");
                    string choice = Console.ReadLine().ToLower();

                    if (choice == "pantry")
                    {
                        Console.WriteLine("You open the pantry door, and a swarm of rats rushes out, biting at your ankles!");
                        Console.WriteLine("You're overwhelmed by the creatures. You Lose!");
                        gameOver = true;
                    }
                    else if (choice == "exit window")
                    {
                        Console.WriteLine("You manage to pry open the old window and crawl outside into a dense, dark forest.");
                        Console.WriteLine("You've found an escape route! You Win!");
                        gameOver = true;
                    }
                    else if (choice == "back to entry hall")
                    {
                        Console.WriteLine("You return to the Entry Hall.");
                        currentRoom = "Entry Hall";
                    }
                    else
                    {
                        Console.WriteLine("That's not an option here. The darkness presses in.");
                    }
                }
                else if (currentRoom == "Living Room")
                {
                    Console.WriteLine("The Living Room is grand but eerily quiet. There's a 'fireplace', a 'staircase', and you can go 'back to entry hall'.");
                    Console.Write("What do you do? ");
                    string choice = Console.ReadLine().ToLower();

                    if (choice == "fireplace")
                    {
                        Console.WriteLine("You peer into the cold fireplace. Suddenly, a hidden trapdoor opens beneath you, dropping you into a dark pit!");
                        Console.WriteLine("You fall to your doom. You Lose!");
                        gameOver = true;
                    }
                    else if (choice == "staircase")
                    {
                        Console.WriteLine("You ascend the creaking staircase, leading to a shadowy Bedroom.");
                        currentRoom = "Bedroom";
                    }
                    else if (choice == "back to entry hall")
                    {
                        Console.WriteLine("You head back to the Entry Hall.");
                        currentRoom = "Entry Hall";
                    }
                    else
                    {
                        Console.WriteLine("The silence makes you uneasy. Choose a path.");
                    }
                }
                else if (currentRoom == "Bedroom")
                {
                    Console.WriteLine("The Bedroom is unsettlingly neat. There's a 'closet', a 'balcony', and you can go 'back to living room'.");
                    Console.Write("What do you do? ");
                    string choice = Console.ReadLine().ToLower();

                    if (choice == "closet")
                    {
                        Console.WriteLine("You open the closet, and a withered hand grabs you from within, pulling you into the darkness!");
                        Console.WriteLine("You're trapped forever. You Lose!");
                        gameOver = true;
                    }
                    else if (choice == "balcony")
                    {
                        Console.WriteLine("You step out onto the balcony and, with a daring leap, make it to a nearby rooftop, finding your way to safety!");
                        Console.WriteLine("You've found freedom! You Win!");
                        gameOver = true;
                    }
                    else if (choice == "back to living room")
                    {
                        Console.WriteLine("You descend the staircase back to the Living Room.");
                        currentRoom = "Living Room";
                    }
                    else
                    {
                        Console.WriteLine("A chill permeates the room. Make a decision.");
                    }
                }
                if (gameOver)
                {
                    Console.WriteLine("\nEnter 'R' to restart, or any other key to exit.");
                    string restartChoice = Console.ReadLine().ToLower();
                    if (restartChoice == "r")
                    {
                        
                        currentRoom = "Entry Hall";
                        gameOver = false; 
                        Console.Clear(); 
                        Console.WriteLine($"\nWelcome back, {playerName}. You find yourself once again in the dimly lit Entry Hall.");
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine("\nPress any key to go forward.");
            Console.ReadKey();
        }
    }
}
