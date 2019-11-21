using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Human : Player
    {
        string newGesture;
        public override void ChooseGesture()
        {
            Console.WriteLine("Please Choose one of the following");
            Console.WriteLine("Rock, Paper, Scissors, Lizard, Spock");
            gesture = Console.ReadLine().Trim().ToLower();
            Console.Clear();
        }

        public override void ChooseName()
        {

            Console.WriteLine("Please enter your name!");
            name = Console.ReadLine();

        }

    }
}
