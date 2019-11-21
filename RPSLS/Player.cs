using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Player
    {
        //List<string> gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
        public string gesture;
        public int score;
        public string name;
        public Player()
        {

        }
        public void EnterName()
        {
            Console.WriteLine("Please enter your name.");
            name = Console.ReadLine();
        }

        public virtual void EnterGesture()
        {
            Console.WriteLine("Please enter either \nRock!\nPaper!\nScissors!\nLizard!\nSpock!");
            gesture = Console.ReadLine().ToLower();

        }
        //methods - choose gesture, choose name, 
    }
}
