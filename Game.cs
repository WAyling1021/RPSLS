using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        //member variables 
        List<string> gestures = new List<string>() { "rock", "paper", "scissors", "Spock", "Lizard" };
        Player player1;
        Player player2;
        private string choice;
        Rules rules;


        //constructor 
        public Game()
        {
            rules = new Rules();
        }

        //member methods 
        public void RunGame()
        {
            rules.DisplayRules();
            ChooseGameMode();

        }

        public void ChooseGameMode()
        {
            Console.WriteLine("Pick your game mode, SINGLE PLAYER, MULTIPLAYER");
            choice = Console.ReadLine();
            
            player1 = new Human();

            if (choice == "SINGLE PLAYER")
            {
                player2 = new CPU();
            }
            else if (choice == "MULTIPLAYER") 
            {
                player2 = new Human();
            }
            else
            {
                Console.WriteLine("You didn't enter either 'SINGLE PLAYER' or 'MULTIPLAYER'.");
                Console.WriteLine("Starting a SINGLE PLAYER game.");
                player2 = new CPU();
            }
        }
        public void ChooseGestures()
        {
            player1.ChooseGesture();
            player2.ChooseGesture();

        }
        public void GamePlay()
        {
            while (player1.score <= 2 && player2 - Score <== 2)
            {
                player1.MakeChoice();
                player2.MakeChoice();
                CheckForRoundWinner();
                AddScores();
            }

            
            
        }

        public void CheckForRoundWinner()
        {
            if (player1.gesture == player2.gesture)
            {
                Console.WriteLine("Tie!");
            }
            else if (player1.gesture == "Rock" && player2.gesture == "paper")
            {
                Console.WriteLine("player2 wins");
            }
        }

        public void RoundWinner()
        {
            Console.WriteLine("Player1 or Player2 wins");
            Console.ReadLine();
        }
        public void DisplayWinner()
        {
            Console.WriteLine("");
            Console.ReadLine();
        }
        public void PlayAgain()
        {
            Console.WriteLine("Do you want to play again?");
            Console.ReadLine();
        }
    }
}
