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
        int winningScore;
        //Contructor
        public Game()
        {
            playerOne = new Human("Bob");
            playerTwo = new Computer();
            winningScore = 2;
        }
        //Member Methods

        public void PlayGame()
        {
            //Let user choose if they want to play against another human, or against the computer.
            while (playerOne.score < winningScore && playerTwo.score < winningScore)
            {
                //Let user(s) choose which gesture they want to use.
                playerOne.PickGesture();
                playerTwo.PickGesture();
                //Create method to compare gestures and determine which one wins.
                Battle(playerOne.gesture, playerTwo.gesture);
                //Repeat these steps until one player reaches three points.
            }
            //Display victory message.
            if (playerOne.score >= winningScore)
            {
                Console.WriteLine("Player one wins with a score of: " + playerOne.score);
            }
            else if (playerTwo.score >= winningScore)
            {
                Console.WriteLine("Player two wins with a score of: " + playerTwo.score);
            }
            else
            { 
                Console.WriteLine("error");
            }
        }
        public void Battle(Gesture playerOneGesture, Gesture playerTwoGesture)
        {
            //Get gestures from both players.
            //Look at gestures to see if either contains the other as one of its loser string variables.
            //If one contains the name of the other, it wins. Increment that players score.
            if (playerOneGesture.name == playerTwoGesture.beats1 || playerOneGesture.name == playerTwoGesture.beats2)
            {
                playerTwo.score += 1;
            }
            else if (playerTwoGesture.name == playerOneGesture.beats1 || playerTwoGesture.name == playerOneGesture.beats2)
            {
                playerOne.score += 1;
            }
            //If both players picked the same object, they tie and nothing happens.
        }
    }
}
