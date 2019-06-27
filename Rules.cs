using System;
using System.Collections.Generic;

namespace RPSLS
{
    class Rules
    {
        //member variables 

        //constructor 

        //member methods 
        List<string> RulesOfTheGame = new List<string>();

        public void DisplayRules() 
        {
            RulesOfTheGame.Add("Scissors cuts paper");
            RulesOfTheGame.Add("paper covers rock");
            RulesOfTheGame.Add("rock crushes lizard");
            RulesOfTheGame.Add("lizard poisons Spock");
            RulesOfTheGame.Add("Spock smashes scissors");
            RulesOfTheGame.Add("scissors decapitates lizard");
            RulesOfTheGame.Add("lizard eats paper");
            RulesOfTheGame.Add("paper disproves Spock");
            RulesOfTheGame.Add("Spock vaporizes rock, and as it always has");
            RulesOfTheGame.Add("rock crushes scissors");



            foreach (string rule in RulesOfTheGame)
            {
                Console.WriteLine(rule);
                Console.ReadLine();
            }
        }
    }
    
    
    
    
   
}
