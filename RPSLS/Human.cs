using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        bool userChoiceIsInteger;
        bool validSelection;
        public int intUserChoice;
        public Human(string name, Random Rng)
            :base (name, Rng)
        {
            userChoiceIsInteger = false;
        }
        //Assign logic to PickGesture method from player class
        public override void PickGesture()
        {
            string stringUserChoice;
            //Prompt user to pick a gesture from list based on index value
            Console.WriteLine("\n" + name + ", please choose your move by typing the number next to it and hitting enter");
            do
            {
                //Display list of gestures with index values.
                PrintGestureOptions();
                //Collect user input and save to variable
                stringUserChoice = Console.ReadLine();
                userChoiceIsInteger = int.TryParse(stringUserChoice, out intUserChoice);
                //If user input cannot be parsed to an int, or parses to an int which is not a valid index of this list, go back and repeat until valid input is given.
                validSelection = userChoiceIsInteger && intUserChoice >= 0 && intUserChoice < gestures.Count;
                PrintInvalidSelection(validSelection);
            } while (!validSelection);
            //Use that index value to pull gesture object from list

            gesture = gestures[intUserChoice];
            Console.WriteLine("\n" + name + " picked " + gesture.name);
        }
        private void PrintGestureOptions()
        {
            for (int i = 0; i < gestures.Count; i++)
            {
                Console.WriteLine(i + " " + gestures[i].name);
            }
        }
        private void PrintInvalidSelection(bool validselection)
        {
            if (!validSelection)
            {
                Console.WriteLine("Not a valid choice. Please try again.");
            }
        }
        public override void PickName()
        {
            do
            {
                if (name == "")
                {
                    Console.WriteLine("Name field cannot be left blank. Please type something.");
                }
                else
                {
                    Console.WriteLine("\n" + name + ", please type your name");
                }
                name = Console.ReadLine();
            } while (name == "");
            Console.WriteLine("Welcome, " + name + "!");
        }
    }
}
