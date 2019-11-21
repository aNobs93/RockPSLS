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
            string input = GetNumberPlayer();
            CreatePlayer(input);
            p1.ChooseName();
            p2.ChooseName();
            Console.Clear();
            p1.ChooseGesture();
            p2.ChooseGesture();
            Console.WriteLine(p1.name + " has chosen " + p1.gesture);
            Console.WriteLine(p2.name + " has chosen " + p2.gesture);
            GameRules();
            Console.Clear();
        }

        public void GameRules()
        {
            string a = p1.gesture;
            string b = p2.gesture;
            if (a == b)
            {
                Console.WriteLine(a + " VS " + b + " Doesn't do much! Try Again!");
                int player1 = 0;
                int player2 = 0;
                Points(player1, player2);
            }
            else
            {
                if (a == p1.choices[0] && b == p2.choices[2])
                {
                    Console.WriteLine(a + " Crushes " + b);
                    int player1 = 1;
                    int player2 = 0;
                    Points(player1, player2);
                }
                else if (a == p1.choices[2] && b == p2.choices[1])
                {
                    Console.WriteLine(a + " Cuts " + b);
                    int player1 = 1;
                    int player2 = 0;
                    Points(player1, player2);
                }
                else if (a == p1.choices[1] && b == p2.choices[0])
                {
                    Console.WriteLine(a + " Covers " + b);
                    int player1 = 1;
                    int player2 = 0;
                    Points(player1, player2);
                }
                else if (a == p1.choices[0] && b == p2.choices[3])
                {
                    Console.WriteLine(a + " Crushes " + b);
                    int player1 = 1;
                    int player2 = 0;
                    Points(player1, player2);
                }
                else if (a == p1.choices[3] && b == p2.choices[4])
                {
                    Console.WriteLine(a + " Poisons " + b);
                    int player1 = 1;
                    int player2 = 0;
                    Points(player1, player2);
                }
                else if (a == p1.choices[4] && b == p2.choices[2])
                {
                    Console.WriteLine(a + " Smashes " + b);
                    int player1 = 1;
                    int player2 = 0;
                    Points(player1, player2);
                }
                else if (a == p1.choices[2] && b == p2.choices[3])
                {
                    Console.WriteLine(a + " Decapitates " + b);
                    int player1 = 1;
                    int player2 = 0;
                    Points(player1, player2);
                }
                else if (a == p1.choices[3] && b == p2.choices[1])
                {
                    Console.WriteLine(a + " Eats " + b);
                    int player1 = 1;
                    int player2 = 0;
                    Points(player1, player2);
                }
                else if (a == p1.choices[1] && b == p2.choices[4])
                {
                    Console.WriteLine(a + " Disproves " + b);
                    int player1 = 1;
                    int player2 = 0;
                    Points(player1, player2);
                }
                else if (a == p1.choices[4] && a == p2.choices[0])
                {
                    Console.WriteLine(a + " Vaporizes " + b);
                    int player1 = 1;
                    int player2 = 0;
                    Points(player1, player2);
                }
                else if (b == p1.choices[0] && a == p2.choices[2])
                {
                    Console.WriteLine(b + " Crushes " + a);
                    int player1 = 0;
                    int player2 = 1;
                    Points(player1, player2);
                }
                else if (b == p1.choices[2] && a == p2.choices[1])
                {
                    Console.WriteLine(b + " Cuts " + a);
                    int player1 = 0;
                    int player2 = 1;
                    Points(player1, player2);
                }
                else if (b == p1.choices[1] && a == p2.choices[0])
                {
                    Console.WriteLine(b + " Covers " + a);
                    int player1 = 0;
                    int player2 = 1;
                    Points(player1, player2);
                }
                else if (b == p1.choices[0] && a == p2.choices[3])
                {
                    Console.WriteLine(b + " Crushes " + a);
                    int player1 = 0;
                    int player2 = 1;
                    Points(player1, player2);
                }
                else if (b == p1.choices[3] && a == p2.choices[4])
                {
                    Console.WriteLine(b + " Poisons " + a);
                    int player1 = 0;
                    int player2 = 1;
                    Points(player1, player2);
                }
                else if (b == p1.choices[4] && a == p2.choices[2])
                { 
                    Console.WriteLine(b + " Smashes " + a);
                    int player1 = 0;
                    int player2 = 1;
                    Points(player1, player2);
                }
                else if (b == p1.choices[2] && a == p2.choices[3])
                    {
                        Console.WriteLine(b + " Decapitates " + a);
                        int player1 = 0;
                        int player2 = 1;
                        Points(player1, player2);
                    }
                    else if (b == p1.choices[3] && a == p2.choices[1])
                {
                    Console.WriteLine(b + " Eats " + a);
                    int player1 = 0;
                    int player2 = 1;
                    Points(player1, player2);
                }
                else if (b == p1.choices[1] && a == p2.choices[4])
                {
                    Console.WriteLine(b + " Disproves " + a);
                    int player1 = 0;
                    int player2 = 1;
                    Points(player1, player2);
                }
                else if (b == p1.choices[4] && a == p2.choices[0])
                { 
                    Console.WriteLine(b + " Vaporizes " + a);
                    int player1 = 0;
                    int player2 = 1;
                    Points(player1, player2);
                }
            }
            

        }
        
        public void Points(int _player1, int _player2)
        {
            //p1.score = 0;
            //p2.score = 0;
            if(_player1 > _player2)
            {
                p1.score++;
            }
            else
            {
                p2.score++;
            }
            if(p1.score == 3)
            {
                Console.WriteLine(p1.name + " has won 3 times!");
            }
            if(p2.score == 3)
            {
                Console.WriteLine(p2.name + " has won 3 times!");
            }

        }
        
    }
}
