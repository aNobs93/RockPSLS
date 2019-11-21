using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public abstract class Player
    {
        public List<string> choices = new List<string>() { "rock", "paper", "scissors", "lizard", "spock" };
        public string gesture;
        public int score;
        public string name;

        public abstract void ChooseGesture();

        public abstract void ChooseName();
    }
}
