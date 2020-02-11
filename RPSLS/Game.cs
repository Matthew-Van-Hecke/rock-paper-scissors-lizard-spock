using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //Member Variables
        Player playerOne;
        Player playerTwo;
        Gesture playerOneGesture;
        //Contructor
        public Game()
        {
            playerOne = new Human("Bob");
            playerTwo = new Computer();
        }
        //Member Methods

        public void PlayGame()
        {
            //Let user choose if they want to play against another human, or against the computer.
            //Let user(s) choose which gesture they want to use.
            //Create method to compare gestures and determine which one wins.
            
            //Repeat these steps until one player reaches three points.
            //Display victory message.
        }
        public void Battle(Gesture playerOneGesture, Gesture playerTwoGesture)
        {
            //Get gestures from both players.
            //Look at gestures to see if either contains the other as one of its loser string variables.
            //If one contains the name of the other, it wins. Increment that players score.
            if (playerOneGesture.name == playerTwoGesture.beats1 || playerOneGesture.name == playerTwoGesture.beats2)
            {
                playerOne.score += 1;
            }
            else if (playerTwoGesture.name == playerOneGesture.beats1 || playerTwoGesture.name == playerOneGesture.beats2)
            {
                playerTwo.score += 1;
            }
            //If both players picked the same object, they tie and nothing happens.
        }
    }
}
