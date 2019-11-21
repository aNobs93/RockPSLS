using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Game
    {
        public string player;
        //players 1 or 2

        public Game()
        {

        }

        public void MainMenu()
        {
            Console.WriteLine("Please enter who you would like to play against.\n-Human\n-Computer");

            player = Console.ReadLine().ToLower();

            switch (player)
            {
                case "human":

                    break;
                case "computer":

                    break;
                default:
                    Console.WriteLine("Whoops! Try again!");
                    break;

            }
        }

        
    }
}
