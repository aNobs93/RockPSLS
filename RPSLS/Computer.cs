using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Computer : Player
    {
        public Random rnd = new Random();

        public override void ChooseGesture()
        {
            int n = rnd.Next(0, 4);
            gesture = choices[n];

        }

        public override void ChooseName()
        {
            name = "Computer";

        }

    }
}
