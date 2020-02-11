using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        //Member Variables
        public string name;
        public int score;
        public List<Gesture> gestures;

        //Constructor
        public Player(string name)
        {
            this.name = name;
            score = 0;
            gestures = new List<Gesture>() { new Gesture("rock", "scissors", "lizard"), new Gesture("paper", "spock", "rock"), new Gesture("scissors", "paper", "lizard"), new Gesture("lizard", "spock", "paper"), new Gesture("spock", "scissors", "rock") };
        }

        //Member Methods

        //Create universal portion of picking a gesture.
        public abstract Gesture PickGesture();
    }
}
