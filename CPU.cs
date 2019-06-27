using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class CPU : Player
    {
        //member variables 


        string ChosenGesture;
        //constructor 

        //member methods 
        public void ChooseGesture()
        {
            Random rng = new Random();
            string gesture = gestures[rng.Next(6)];
        }
    }
}
