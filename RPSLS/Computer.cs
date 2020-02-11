using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Computer : Player
    {
        int intGesturePick;
        public Computer()
            :base("ROBOPLAYER")
        {
            intGesturePick = 0;
        }
        //Assign logic to PickGesture method from player.
        //Use Random Next function to generate a random number with which to pick a gesture from list.
        public override Gesture PickGesture()
        {
            //Pick a random number from among the valid indices for the list of gestures.
            intGesturePick = new Random().Next(gestures.Count);
            return gestures[intGesturePick];
        }
    }
}
