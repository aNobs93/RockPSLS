using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Computer : Player
    {
        public Random rnd = new Random();
        public List<string> gestures = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
        public Computer()
        {

        }

        public override void EnterGesture()
        {
            int n = rnd.Next(0, 4);
            Console.WriteLine("Computer: " + gestures[n]);

        }

    }
}
