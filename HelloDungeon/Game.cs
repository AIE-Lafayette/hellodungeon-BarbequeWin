using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        float Add(float a, float b)
        {
            float result = a + b;
            return result;
        }

        int GetGreaterNumber(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        void CountTo(int end)
        {
            int count = 0;

            while (count <= end)
            {
                Console.WriteLine(count);
                count++;
            }
        }

        string DisplayMenu(string prompt, string option1, string option2, string option3)
        {
            string playerChoice = "";

            while (playerChoice != "1" && playerChoice != "2" && playerChoice != "3")
            {
                //Display prompt.
                Console.Clear();
                Console.WriteLine(prompt);
                
                //Display all options.
                Console.WriteLine("1." + option1);
                Console.WriteLine("2." + option2);
                Console.WriteLine("3." + option3);

                //Get player input.
                Console.Write("> ");
                playerChoice = Console.ReadLine();
                
                //if the player input is not one of the available options...
                if (playerChoice != "1" && playerChoice != "2" && playerChoice != "3")
                {
                    //...display the error message.
                    Console.Clear();
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey(true);
                }
            }

            return playerChoice;
        }

        public void Run()
        {
            //The stats of the character.
            string playerName = "";
            string playerChoice = "";
            int areaNumber = 0;
            bool playerIsAlive = true;
            bool gameOver = false;
            float maxPlayerHealth = 100.00f;
            float maxPlayerStamina = 100.00f;
            float maxPlayerMagic = 100.00f;
            float playerMoney = 2000.00f;

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

            Console.WriteLine("You realize that you don't have any equipment, so you go to the village for safety.");
            
            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            Console.WriteLine("As you walk through the village, you encounter someone on the side of the road who walked up to you to make you buy something.");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            Console.WriteLine("The person offers you a potion of unknown origin that costs 500 credits.");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            //Meeting someone trying to offer you a potion.
            playerChoice = "";

            while (playerChoice != "1")
            {
                Console.WriteLine("You have 2,000 credits. Do you want to buy the potion?");

                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");

                Console.Write("> ");
                playerChoice = Console.ReadLine();

                Console.Clear();
                if (playerChoice == "1")
                {
                    Console.WriteLine("You obtained a health potion.");
                }
                else if (playerChoice == "2")
                {
                    Console.WriteLine("You declined the offer.");
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }

            Console.WriteLine("Before you continue on your way. You should check your stats.");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            void displayStats(string name, float health, float stamina, float magic, float money)
            {
                Console.WriteLine("Name" + name);
                Console.WriteLine("Health" + health);
                Console.WriteLine("Stamina" + stamina);
                Console.WriteLine("Magic" + magic);
                Console.WriteLine("Money" + money);
            }

            Console.WriteLine("");










            playerChoice = "";

            while (playerChoice != "1" && playerChoice != "2")
            {
                Console.WriteLine("Thank you for playing! Do you want to play again?");

                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                Console.Write("> ");

                playerChoice= Console.ReadLine();

                if (playerChoice == "2")
                {
                    gameOver = true;
                }
                else if (playerChoice != "1")
                {
                    Console.WriteLine("Invalid Input");
                }
                Console.Clear();
            }
        }
    }
}
