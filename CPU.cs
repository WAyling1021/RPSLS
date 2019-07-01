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


        //constructor 

        //member methods 
        public override void ChooseGesture()
        {
            Random rng = new Random();
            choice = gestures[rng.Next(6) - 1];
        }
    }
}
