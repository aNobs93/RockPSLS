using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public abstract class Player
    {
        public List<string> choices = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        public string gesture;
        public int score;
        public string name;

        public abstract void ChooseGesture();

        public abstract void ChooseName();
    }
}
