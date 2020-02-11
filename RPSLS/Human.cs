using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        public Human(string name)
        {
            this.name = name;
        }
        //Assign logic to PickGesture method from player class
            //Prompt user to pick a gesture from list based on index value
            //Use that index value to pull gesture object from list
    }
}
