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
            string playerName = "Player";
            int maxEnemies = 10;
            bool playerIsAlive = true;
            float maxPlayerHealth = 100.00f;
            float maxPlayerStamina = 100.00f;

            //Print out name for first exercise.
            Console.WriteLine("Kenneth");
            Console.WriteLine("Jackson");

            playerName = Console.ReadLine();

            Console.WriteLine(playerName);

            //First and last name.
            string firstname = Console.ReadLine();
            string lastname = Console.ReadLine();
            playerName = firstname + lastname;

            //Meeting your first familar face and indroducing yourself.
            Console.WriteLine("Welcome to the world of Marif!");
            Console.WriteLine("My name is Willerd Willy, the Sorcerer, but you can just call me Willy.");
            Console.WriteLine("What is your name?");
            Console.WriteLine("I see. It's nice to meet you," + playerName + "." );
            
        }
    }
}
