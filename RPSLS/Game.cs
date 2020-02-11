using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        Player testPlayer = new Human("Bob");
        Player computer = new Computer();
        public void test()
        {
            Console.WriteLine(computer.name);
            Console.WriteLine(computer.PickGesture().name); ;
        }
        //Let user choose if they want to play against another human, or against the computer.
        //Let user(s) choose which gesture they want to use.
        //Compare player gestures side by side to determine which gesture wins the battle.
        //Intcrement the score of the player who won the battle.
        //Repeat these steps until one player reaches three points.
        //Display victory message.
    }
}
