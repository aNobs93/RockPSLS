using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Computer : Player
    {
        public List<string> computerNames = new List<string>() {"Spock", "James T. Kirk", "Nyota Uhura", "Scotty", "Leonard McCoy", "Hikaru Sulu"};
        public Random rnd = new Random();

        public override void ChooseGesture()
        {
            int n = rnd.Next(0, 4);
            gesture = choices[n];

        }

        public override void ChooseName()
        {
            int cN = rnd.Next(0,5);
            name = computerNames[cN];

        }

    }
}
