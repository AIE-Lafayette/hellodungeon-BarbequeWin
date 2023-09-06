using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Reflection.Metadata.Ecma335;

namespace HelloDungeon
{
    class Game
    {
        //The stats of the character.
        string playerName = "";
        string playerChoice = "";
        int currentScene = 0;
        bool playerIsAlive = true;
        bool gameOver = false;
        float maxPlayerHealth = 100.00f;
        float maxPlayerDamage = 50.00f;
        float maxIronSwordDamage = 50.00f;
        float maxIronAxeDamage = 50.00f;
        float maxIronSpearDamage = 50.00f;
        float maxGrasslandDemonHealth = 50.00f;
        float maxGrasslandDemonDamage = 5.00f;
        float maxRoyalGuardDemonHealth = 100.00f;
        float maxRoyalGuardDemonDamage = 12.50f;
        float maxDemonKingHealth = 200.00f;
        float maxDemonKingDamage = 20.00f;

        //Print out name for first exercise.
        //Console.WriteLine("Kenneth");
        //Console.WriteLine("Jackson");

        //First and last name.
        //string firstname = Console.ReadLine();
        //string lastname = Console.ReadLine();
        //playerName = firstname + lastname;

        //playerName = Console.ReadLine();

        //Console.WriteLine(playerName);

        //playerChoice = Console.ReadLine();

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


        float StartBattle(float maxPlayerHealth, float maxEnemyHealth, float maxEnemyDamage, float maxPlayerDamage)
        {
            string playerChoice = "";

            while (maxPlayerHealth > 0 && maxEnemyHealth > 0)
            {
                Console.WriteLine("Player's Turn");
                Console.WriteLine("Player Health " + maxPlayerHealth + ". Enemy Health " + maxEnemyHealth + " .");
                Console.WriteLine("1. Attack");

                playerChoice = Console.ReadLine();

                if (playerChoice == "1")
                {
                    maxEnemyHealth -= maxPlayerDamage;
                    Console.WriteLine("You dealt " + maxPlayerDamage + " damage!");
                }

                if (maxEnemyHealth > 0)
                {
                    Console.WriteLine("Enemy's Turn");
                    Console.WriteLine("Player Health " + maxPlayerHealth + ". Enemy Health " + maxEnemyHealth + " .");

                    maxPlayerHealth -= maxEnemyDamage;
                    Console.WriteLine("Enemy dealt " + maxEnemyDamage + " damage");

                    Console.Write("> ");

                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey(true);

                    Console.Clear();
                }
            }

            return maxPlayerHealth;
        }

        void DisplayStats(string name, float health, float damage)
        {
            Console.WriteLine("Name" + name);
            Console.WriteLine("Health" + health);
            Console.WriteLine("Damage" + damage);
        }

        void DisplayMainMenu()
        {

            //Redeciding on a name.
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
                    Console.WriteLine("I see. It's nice to meet you," + playerName + ". My name is Willy, the Sorcerer.");
                }
                else if (playerChoice == "2")
                {
                    Console.WriteLine("Sorry about that.");
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

                Console.WriteLine("Welcome to the world of Marif!");

                Console.Write("> ");

                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);

                Console.Clear();
            }

            currentScene++;
        }

        void DisplayWelcomeScene()
        {
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

            Console.WriteLine("You are probably wondering, 'Why do I have to risk my life to fight the Demon King?'");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            Console.WriteLine("On your journey, you will learn all and know all.");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            Console.WriteLine("This about sums it up. I wish you luck on your journey.");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            currentScene++;
        }
        
        void DisplayBeginningAdventureScene()
        {
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

            Console.WriteLine("In the distance, there is the Demon King's castle.");

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

            currentScene++;
        }

        void DisplayEnterVillageScene()
        {
            Console.WriteLine("As you walk through the village, you encounter someone on the side of the road who walked up to you to make you buy something.");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            Console.WriteLine("The person offers you a potion of unknown origin.");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            //Meeting someone trying to offer you a potion.
            playerChoice = "";

            while (playerChoice != "1")
            {
                Console.WriteLine("Do you want the potion?");

                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");

                Console.Write("> ");
                playerChoice = Console.ReadLine();

                Console.Clear();
                if (playerChoice == "1")
                {
                    Console.WriteLine("You drank the potion, which mad you increase max health.");

                    maxPlayerHealth *= 2;
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
            
            currentScene++;
        }
        
        void DisplayOpenStatsScene()
        {
            Console.WriteLine("Before you continue on your way. You should check your stats.");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);
            Console.Clear();

            DisplayStats(playerName, maxPlayerHealth, maxPlayerDamage);

            Console.WriteLine("It's time to go to the armory.");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            currentScene++;
        }

        void DisplayArmoryScene()
        {
            Console.WriteLine("You enter the armory.");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            //Choose your weapon.
            playerChoice = DisplayMenu("Choose your weapon", "Iron Sword", "Iron Axe", "Iron Spear");

            if (playerChoice == "1")
            {
                maxPlayerDamage = maxIronSwordDamage;
            }
            else if (playerChoice == "2")
            {
                maxPlayerDamage = maxIronAxeDamage;
            }
            else if (playerChoice == "3")
            {
                maxPlayerDamage = maxIronSpearDamage;
            }

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            Console.WriteLine("Now that you are prepared, it's time to fight the Demon King and his underlings.");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            currentScene++;
        }

        void DisplayGrasslandsFightScene()
        {
            Console.WriteLine("You enter the grasslands as you began the fight with the weak demon.");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            maxPlayerHealth = StartBattle(maxPlayerHealth, maxGrasslandDemonHealth, maxGrasslandDemonDamage, maxPlayerDamage);

            Console.WriteLine("With the win, you make your way to the Demon King's castle.");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            currentScene++;
        }

        void DisplayRoyalGuardFightScene()
        {
            //The Demon King's castle. Fighting the royal guard.
            Console.WriteLine("You now enter the Demon King's castle as you meet his royal guard.");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            maxPlayerHealth = StartBattle(maxPlayerHealth, maxRoyalGuardDemonHealth, maxRoyalGuardDemonDamage, maxPlayerDamage);

            Console.WriteLine("With this win, you reach the Demon King's Throne Room.");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            currentScene++;
        }

        void DisplayDemonKingFightScene()
        {
            //Final Showdown! You vs. the Demon King!
            Console.WriteLine("You come face to face with the Demon King. Time for the last fight!");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            maxPlayerHealth = StartBattle(maxPlayerHealth, maxDemonKingHealth, maxDemonKingDamage, maxPlayerDamage);

            //The End.
            Console.WriteLine("You beat the game! Congratulations!");

            Console.Write("> ");

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(true);

            Console.Clear();

            currentScene++;
        }

        void DisplayGameOverScene()
        {
            //Play again?
            playerChoice = "";

            while (playerChoice != "1" && playerChoice != "2")
            {
                Console.WriteLine("Thank you for playing! Do you want to play again?");

                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                Console.Write("> ");

                playerChoice = Console.ReadLine();

                if (playerChoice == "2")
                {
                    gameOver = true;
                }
                else if (playerChoice == "1")
                {
                    currentScene = 1;
                    return;
                }
                Console.Clear();
            }
            
        }
        

        public void Run()
        {
            while (gameOver == false)
            {
                if (currentScene == 0)
                {
                    DisplayMainMenu();
                }
                else if (currentScene == 1)
                {
                    DisplayWelcomeScene();
                }
                else if (currentScene == 2)
                {
                    DisplayBeginningAdventureScene();
                }
                else if (currentScene == 3)
                {
                    DisplayEnterVillageScene();
                }
                else if (currentScene == 4)
                {
                    DisplayOpenStatsScene();
                }
                else if (currentScene == 5)
                {
                    DisplayArmoryScene();
                }
                else if (currentScene == 6)
                {
                    DisplayGrasslandsFightScene();
                }
                else if (currentScene == 7)
                {
                    DisplayRoyalGuardFightScene();
                }
                else if (currentScene == 8)
                {
                    DisplayDemonKingFightScene();
                }
                else if (currentScene == 9)
                {
                    DisplayGameOverScene();
                }
            }
        }
    }
}
