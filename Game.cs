using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //member variables 
        List<string> gestures = new List<string>() { "rock", "paper", "scissors", "Spock", "Lizard" };
        Player player1;
        Player player2;
        private string choice;


        //constructor 


        //member methods 
        public void RunGame()
        {

        }
        public void ChooseGesture()
        {
            Random rng = new Random();
            string gesture = gestures[rng.Next(6)];
        }
        public void ChooseGameMode()
        {
            Console.WriteLine("Pick your game mode, SINGLE PLAYER, CPU, MULTIPLAYER");
            choice = Console.ReadLine();
        }
        public void RoundWinner()
        {

        }
        public void DisplayWinner()
        {

        }
        public void PlayAgain()
        {

        }
    }
}
