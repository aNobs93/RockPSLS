using System;

namespace RPSLS
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Game game = new Game();
            game.Intro();
        }
    }
}
