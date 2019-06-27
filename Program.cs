using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Rules rule = new Rules();
            rule.DisplayRules();
            Player makeChoice = new Player();
            makeChoice.ChooseGesture();
            Game game = new Game();
            game.RunGame();
        }

    }
}
