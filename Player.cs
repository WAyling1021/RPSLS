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
        internal string gesture;
        string playerName;
        string selectedGesture;
        public int score;
        

        public Player() 
        {
            
        }
        //constructor 
        public Player(string Choice)
        {
            this.choice = Choice;

        }

        //member methods 
        public virtual void ChooseGesture()
        {
            Console.WriteLine("What gesture do you want?");
            var thing = Console.ReadLine();
        }


    }
}
