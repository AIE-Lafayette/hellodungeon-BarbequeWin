using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        public void Run()
        {
            //The stats of the character.
            string playerName = "";
            string playerChoice = "";
            int areaNumber = 0;
            bool playerIsAlive = true;
            float maxPlayerHealth = 100.00f;
            float maxPlayerStamina = 100.00f;
            float maxPlayerMagic = 100.00f;

            //Print out name for first exercise.
            Console.WriteLine("Kenneth");
            Console.WriteLine("Jackson");

            //First and last name.
            string firstname = Console.ReadLine();
            string lastname = Console.ReadLine();
            playerName = firstname + lastname;

            playerName = Console.ReadLine();

            Console.WriteLine(playerName);

            playerChoice = Console.ReadLine();

            //Meeting your first familar face.
            Console.WriteLine("Welcome to the world of Marif!");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            Console.WriteLine("My name is Willerd Willy, the Sorcerer, but you can just call me Willy.");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            //First Loop, "Redeciding on a name".
            while (playerChoice != "1")
            {
                Console.WriteLine("What is your name?");

                Console.Write("> ");

                playerName = Console.ReadLine();

                Console.WriteLine("Ah," + playerName + "! Am I hearing that clearly?");

                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");

                Console.Write("> ");
                playerChoice = Console.ReadLine();

                Console.Clear();
                if (playerChoice == "1")
                {
                    Console.WriteLine("I see. It's nice to meet you," + playerName + ".");
                }
                else if (playerChoice == "2")
                {
                    Console.WriteLine("Sorry about that.");
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }

            Console.WriteLine("Again, welcome to Marif!");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            Console.WriteLine("In this world, you will under go a journey and defeat the infamous Demon King.");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            Console.WriteLine("You will have to fight the Demon King's underlings. But watch out! The Demon King's underlings get stronger as you progress!");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            Console.WriteLine("You are probably wondering, 'How did I get here?' or 'Why do I have to risk my life to fight the Demon King?'");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            Console.WriteLine("On your journey, you will learn all and know all. You will also meet other faces along the way.");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            Console.WriteLine("This about sums it up. I wish you luck on your journey.");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            areaNumber = 1;

            //The Beginning of the Adventure.
            Console.WriteLine("You find yourself waking up on an open field of grass.");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            Console.WriteLine("You look around. But as you look around, you see creatures that must be the weak ones based on what Willy was talking about.");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            Console.WriteLine("There seems to be a village nearby.");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            //A loop inside of a loop to let you redecide on your decision.
            bool decisionMade = false;

            while (decisionMade == false)
            {
                Console.WriteLine("Do you want to go to the village?");

                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");

                Console.Write("> ");
                playerChoice = Console.ReadLine();

                Console.Clear();

                if (playerChoice == "1")
                {
                    Console.WriteLine("You walk towards the village.");

                }
                else if (playerChoice == "2")
                {

                }

                playerChoice = "";

                while (playerChoice != "1" && playerChoice != "2")
                {
                    Console.WriteLine("Are you sure?");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");

                    Console.WriteLine("> ");
                    playerChoice = Console.ReadLine();

                    if (playerChoice == "1")
                    {
                        decisionMade = true;
                    }
                }
            }

            Console.WriteLine("");
        }
    }
}
