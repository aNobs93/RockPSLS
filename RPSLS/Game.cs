using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Game
    {
        Player player1;
        Player player2;

        public string GetNumberPlayer()
        {
            Console.WriteLine("Please enter the number of players.");
            string numberPlayers = Console.ReadLine();
            switch (numberPlayers)
            {
                case "1":
                    return numberPlayers;
                    break;
                case "2":
                    return numberPlayers;
                    break;
                default:
                    Console.WriteLine("Please enter a valid number");
                    return GetNumberPlayer();
                    break;
            }
        }

        public void CreatePlayer(string numberPlayers)
        {
            if(numberPlayers == "1")
            {
                player1 = new Human();
                player2 = new Computer();
            }
            else if(numberPlayers == "2")
            {
                player1 = new Human();
                player2 = new Human();
            }
        }

        public void RuneGame()
        {
            string input = GetNumberPlayer();
            CreatePlayer(input);
            player1.ChooseName();
            player2.ChooseName();
            Console.Clear();
            player1.ChooseGesture();
            player2.ChooseGesture();
            Console.WriteLine(player1.name + " has chosen " + player1.gesture);
            Console.WriteLine(player2.name + " has chosen " + player2.gesture);
        }
        
        
    }
}
