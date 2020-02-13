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
        public Computer(Random Rng)
            :base("ROBOPLAYER", Rng)
        {
            intGesturePick = 0;
        }
        //Assign logic to PickGesture method from player.
        //Use Random Next function to generate a random number with which to pick a gesture from list.
        public override void PickGesture()
        {
            //Pick a random number from among the valid indices for the list of gestures.
            intGesturePick = Rng.Next(gestures.Count);
            gesture = gestures[intGesturePick];
            Console.WriteLine("\n" + name + " picked " + gesture.name);
        }
        public override void PickName()
        {
            List<string> names = new List<string>() { "R2D2", "C3PO", "BB8", "D-0", "Omnidroid Nine Thousand", "Marvin", "Jarvis" };
            int randomNumber = Rng.Next(names.Count);
            name = names[randomNumber];
        }
    }
}
