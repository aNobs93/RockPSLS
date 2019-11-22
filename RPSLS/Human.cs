using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPSLS
{
    public class Human : Player
    {
        
        public override void ChooseGesture()
        {
            Console.WriteLine("Please Choose one of the following");
            Console.WriteLine("Rock, Paper, Scissors, Lizard, Spock");
            gesture = Console.ReadLine().Trim().ToLower();
            if (gesture == "rock" || gesture == "paper" || gesture == "scissors" || gesture == "lizard" || gesture == "spock")
            {
                char[] letters = gesture.ToCharArray();
                letters[0] = Convert.ToChar(letters[0].ToString().ToUpper());
                gesture = string.Join("", letters); //David wrote the code to cap first letter in string. Everything worked before just an eye sore with it being lower and the hard coded stuff being upper
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Please enter a valid action!");
                ChooseGesture();
            }
        }

        public override void ChooseName()
        {

            Console.WriteLine("Please enter your name!");
            name = Console.ReadLine();

        }

    }
}
