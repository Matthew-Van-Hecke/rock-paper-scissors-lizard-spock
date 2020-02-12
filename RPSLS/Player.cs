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
        public Gesture gesture;

        //Constructor
        public Player(string name)
        {
            this.name = name;
            score = 0;
            gestures = new List<Gesture>() { new Gesture("Rock", "Scissors", "Lizard"), new Gesture("Paper", "Spock", "Rock"), new Gesture("Scissors", "Paper", "Lizard"), new Gesture("Lizard", "Spock", "Paper"), new Gesture("Spock", "Scissors", "Rock") };
        }

        //Member Methods

        //Create universal portion of picking a gesture.
        public abstract void PickGesture();
        
    }
}
