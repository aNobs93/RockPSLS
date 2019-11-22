using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Game
    {
        public Player p1;
        public Player p2;

        public string GetNumberPlayer()
        {
            Console.WriteLine("Please enter the number of players.\n1 or 2");
            string numberPlayers = Console.ReadLine();
            switch (numberPlayers)
            {
                case "1":
                    return numberPlayers;
                case "2":
                    return numberPlayers;
                default:
                    Console.WriteLine("Please enter a valid number");
                    return GetNumberPlayer();
            }
        }

        public void CreatePlayer(string numberPlayers)
        {
            if(numberPlayers == "1")
            {
                p1 = new Human();
                p2 = new Computer();
            }
            else if(numberPlayers == "2")
            {
                p1 = new Human();
                p2 = new Human();
            }
        }

        public void RuneGame()
        {
            Console.Clear();
            string input = GetNumberPlayer();
            CreatePlayer(input);
            p1.ChooseName();
            p2.ChooseName();
            Console.Clear();
            while (p1.score < 2 || p2.score < 2)
            {
                p1.ChooseGesture();
                p2.ChooseGesture();
                Console.WriteLine(p1.name + " has chosen " + p1.gesture);
                Console.WriteLine(p2.name + " has chosen " + p2.gesture);
                Console.ReadLine();
                GameRules();
                Console.ReadLine();
                Console.Clear();
            }
        }
        
        public void GameRules()
        {
            if (p1.gesture == p2.gesture)
            {
                Console.WriteLine(p1.gesture + " VS " + p2.gesture + " Doesn't do much! Try Again!");
                Points(0, 0);
            }
            else
            {
                if (p1.gesture == p1.choices[0] && p2.gesture == p2.choices[2])
                {
                    Console.WriteLine(p1.gesture + " Crushes " + p2.gesture);
                    Points(1, 0);
                }
                else if (p1.gesture == p1.choices[2] && p2.gesture == p2.choices[1])
                {
                    Console.WriteLine(p1.gesture + " Cuts " + p2.gesture);
                    Points(1, 0);
                }
                else if (p1.gesture == p1.choices[1] && p2.gesture == p2.choices[0])
                {
                    Console.WriteLine(p1.gesture + " Covers " + p2.gesture);
                    Points(1, 0);
                }
                else if (p1.gesture == p1.choices[0] && p2.gesture == p2.choices[3])
                {
                    Console.WriteLine(p1.gesture + " Crushes " + p2.gesture);
                    Points(1, 0);
                }
                else if (p1.gesture == p1.choices[3] && p2.gesture == p2.choices[4])
                {
                    Console.WriteLine(p1.gesture + " Poisons " + p2.gesture);
                    Points(1, 0);
                }
                else if (p1.gesture == p1.choices[4] && p2.gesture == p2.choices[2])
                {
                    Console.WriteLine(p1.gesture + " Smashes " + p2.gesture);
                    Points(1, 0);
                }
                else if (p1.gesture == p1.choices[2] && p2.gesture == p2.choices[3])
                {
                    Console.WriteLine(p1.gesture + " Decapitates " + p2.gesture);
                    Points(1, 0);
                }
                else if (p1.gesture == p1.choices[3] && p2.gesture == p2.choices[1])
                {
                    Console.WriteLine(p1.gesture + " Eats " + p2.gesture);
                    Points(1, 0);
                }
                else if (p1.gesture == p1.choices[1] && p2.gesture == p2.choices[4])
                {
                    Console.WriteLine(p1.gesture + " Disproves " + p2.gesture);
                    Points(1, 0);
                }
                else if (p1.gesture == p1.choices[4] && p2.gesture == p2.choices[0])
                {
                    Console.WriteLine(p1.gesture + " Vaporizes " + p2.gesture);
                    Points(1, 0);
                }
                else if (p2.gesture == p1.choices[0] && p1.gesture == p2.choices[2])
                {
                    Console.WriteLine(p2.gesture + " Crushes " + p1.gesture);
                    Points(0, 1);
                }
                else if (p2.gesture == p1.choices[2] && p1.gesture == p2.choices[1])
                {
                    Console.WriteLine(p2.gesture + " Cuts " + p1.gesture);
                    Points(0, 1);
                }
                else if (p2.gesture == p1.choices[1] && p1.gesture == p2.choices[0])
                {
                    Console.WriteLine(p2.gesture + " Covers " + p1.gesture);
                    Points(0, 1);
                }
                else if (p2.gesture == p1.choices[0] && p1.gesture == p2.choices[3])
                {
                    Console.WriteLine(p2.gesture + " Crushes " + p1.gesture);
                    Points(0, 1);
                }
                else if (p2.gesture == p1.choices[3] && p1.gesture == p2.choices[4])
                {
                    Console.WriteLine(p2.gesture + " Poisons " + p1.gesture);
                    Points(0, 1);
                }
                else if (p2.gesture == p1.choices[4] && p1.gesture == p2.choices[2])
                { 
                    Console.WriteLine(p2.gesture + " Smashes " + p1.gesture);
                    Points(0, 1);
                }
                else if (p2.gesture == p1.choices[2] && p1.gesture == p2.choices[3])
                    {
                        Console.WriteLine(p2.gesture + " Decapitates " + p1.gesture);
                        Points(0, 1);
                    }
                    else if (p2.gesture == p1.choices[3] && p1.gesture == p2.choices[1])
                {
                    Console.WriteLine(p2.gesture + " Eats " + p1.gesture);
                    Points(0, 1);
                }
                else if (p2.gesture == p1.choices[1] && p1.gesture == p2.choices[4])
                {
                    Console.WriteLine(p2.gesture + " Disproves " + p1.gesture);
                    Points(0, 1);
                }
                else if (p2.gesture == p1.choices[4] && p1.gesture == p2.choices[0])
                { 
                    Console.WriteLine(p2.gesture + " Vaporizes " + p1.gesture);
                    Points(0,1);
                }
            }
            

        }
        
        public void Points(int _player1, int _player2)
        {
            string retry;
            if(_player1 > _player2)
            {
                p1.score++;
            }
            else if(_player2 > _player1)
            {
                p2.score++;
            }
            Console.WriteLine("Current score is:\n" + p1.name + ": " + p1.score + "\n" + p2.name + ": " + p2.score);

            if(p1.score == 2)
            {
                Console.WriteLine(p1.name + " has won 2 times!");
                Console.WriteLine("Would you like to play again?\nYes/No");
                retry = Console.ReadLine().ToLower().Trim();
                if(retry == "yes")
                {
                    RuneGame();
                }
                else
                {
                    Environment.Exit(0);
                }

            }
            else if(p2.score == 2)
            {
                Console.WriteLine(p2.name + " has won 2 times!");
                Console.WriteLine("Would you like to play again?\nYes/No");
                retry = Console.ReadLine().ToLower().Trim();
                if (retry == "yes")
                {
                    RuneGame();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);


        }

        public void Intro()
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine(".........................");
            Console.WriteLine("Are you ready for a good old game of Rock, Paper, Scissors, Lizard, Spock?");

        }
        
    }
}
