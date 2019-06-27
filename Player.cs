using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
        //member variables 
        public string choice;
        public List<string> gestures = new List<string>() { "rock", "paper", "scissors", "Spock", "Lizard" };

        public Player()
        {

        }

        internal void ChooseGesture()
        {
            throw new NotImplementedException();
        }

        //constructor 
        public Player(string Choice)
        {
            this.choice = Choice;

        }

        //member methods 
        
    }
}
