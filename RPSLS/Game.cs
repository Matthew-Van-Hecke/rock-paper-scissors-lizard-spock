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
        List<string> gameLog;
        //Contructor
        public Game()
        {
            winningScore = 2;
        }
        //Member Methods

        public void PlayGame()
        {
            gameLog = new List<string>();
            string resultOfBattle;
            int roundCounter = 1;
            string roundResult;
            gameLog.Clear();
            //Print game instructions
            PrintScreen();
            PressKeyToContinue();
            //Let user choose if they want to play against another human, or against the computer.
            ChoosePlayMode();
            //Begin first round of play.
            while (playerOne.score < winningScore && playerTwo.score < winningScore)
            {
                //Let user(s) choose which gesture they want to use.
                playerOne.PickGesture();
                Console.Clear();
                PrintScreen();
                Console.WriteLine("\nThank you for making your choice, " + playerOne.name + ".");
                playerTwo.PickGesture();
                //Create method to compare gestures and determine which one wins.
                resultOfBattle = Battle(playerOne.gesture, playerTwo.gesture);
                //Print who just one the round.
                if (resultOfBattle == "tie")
                {
                    roundResult = "\nRound was a tie!";
                }
                else
                {
                    roundResult = "\n" + resultOfBattle + " wins the round";
                }
                roundResult = "\nRound " + roundCounter + ":\n" + playerOne.name + " picked " + playerOne.gesture.name + ".\n" + playerTwo.name + " picked " + playerTwo.gesture.name + "." + roundResult;
                gameLog.Add(roundResult);
                roundCounter++;
                //Repeat these steps until one player reaches three points.
                //Clear console, and reprint.
                Console.Clear();
                PrintScreen();
            }
            //Display victory message.
            if (playerOne.score >= winningScore)
            {
                Console.WriteLine("\n" + playerOne.name + " wins the game with a score of: " + playerOne.score + "!");
            }
            else
            {
                Console.WriteLine("\n" + playerTwo.name + " wins the game with a score of: " + playerTwo.score + "!");
            }
        }
        private void PrintInstructions()
        {
            Console.WriteLine("Welcome to Rock-Paper-Scissors-Lizard-Spock! \n");
            Console.WriteLine("The rules are simple. You and your opponent will each choose a play (Rock, Paper, Scissors, Lizard, or Spock), and the player with the winning play gains a point. \n");
            Console.WriteLine("The hierarchy of plays is as follows: \n Rock crushes Scissors \n Scissors cuts Paper \n Paper covers Rock \n Rock crushes Lizard \n Lizard poisons Spock \n Spock smashes Scissors \n Scissors decapitates Lizard \n Lizard eats Paper \n Paper disproves Spock \n Spock vaporizes Rock \n");
            Console.WriteLine("The first player to " + winningScore + " points wins the game. Good luck! \n");
        }
        private string Battle(Gesture playerOneGesture, Gesture playerTwoGesture)
        {
            //Get gestures from both players.
            //Look at gestures to see if either contains the other as one of its loser string variables.
            //If one contains the name of the other, it wins. Increment that players score.
            if (playerOneGesture.name == playerTwoGesture.beats1 || playerOneGesture.name == playerTwoGesture.beats2)
            {
                playerTwo.score += 1;
                return playerTwo.name;
            }
            else if (playerTwoGesture.name == playerOneGesture.beats1 || playerTwoGesture.name == playerOneGesture.beats2)
            {
                playerOne.score += 1;
                return playerOne.name;
            }
            //If both players picked the same object, they tie and nothing happens.
            return "tie";
        }
        private void ChoosePlayMode()
        {
            bool validSelection = true;
            do
            {
                if (!validSelection)
                {
                    Console.WriteLine("Not a valid selection. Please try again.");
                }
                Console.WriteLine("Which mode would you like to play?");
                Console.WriteLine("Human vs. Human (h) \nor Human vs. Computer (c)");
                ConsoleKeyInfo keyUserInput = Console.ReadKey();
                Console.WriteLine();
                switch (keyUserInput.Key)
                {
                    case (ConsoleKey.H):
                        Console.WriteLine("Human v Human");
                        playerOne = new Human("Bob");
                        playerTwo = new Human("Larry");
                        validSelection = true;
                        break;
                    case (ConsoleKey.C):
                        Console.WriteLine("Human v Computer");
                        validSelection = true;
                        playerOne = new Human("Bob");
                        playerTwo = new Computer();
                        break;
                    default:
                        validSelection = false;
                        break;
                }
            } while (!validSelection);
        }
        private void PressKeyToContinue()
        {
            Console.WriteLine("------------------------------------------");
            Console.Write("Press any key to continue: ");
            Console.ReadKey();
            Console.WriteLine("\n------------------------------------------");
        }
        private void PrintScreen()
        {
            PrintInstructions();
            foreach (string logItem in gameLog)
            {
                Console.WriteLine(logItem);
            }
            try
            {
                Console.WriteLine($"\nCurrent scores - {playerOne.name}: {playerOne.score} ---- {playerTwo.name}: {playerTwo.score}");
                Console.WriteLine("--------------------------------------------");
            }
            catch(Exception)
            { }
        }
    }
}
