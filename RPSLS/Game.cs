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
            //Print game instructions
            PrintInstructions();
            //Let user choose if they want to play against another human, or against the computer.
            //Begin first round of play.
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
        private void PrintInstructions()
        {
            Console.WriteLine("Welcome to Rock-Paper-Scissors-Lizard-Spock! \n");
            Console.WriteLine("The rules are simple. You and your opponent will each choose a play (Rock, Paper, Scissors, Lizard, or Spock), and the player with the winning play gains a point. \n");
            Console.WriteLine("The hierarchy of plays is as follows: \n Rock crushes Scissors \n Scissors cuts Paper \n Paper covers Rock \n Rock crushes Lizard \n Lizard poisons Spock \n Spock smashes Scissors \n Scissors decapitates Lizard \n Lizard eats Paper \n Paper disproves Spock \n Spock vaporizes Rock \n");
            Console.WriteLine("The first player to " + winningScore + " points wins the game. Good luck! \n");
        }
        private void Battle(Gesture playerOneGesture, Gesture playerTwoGesture)
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
