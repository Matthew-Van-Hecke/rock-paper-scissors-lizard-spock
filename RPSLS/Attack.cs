using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Gesture
    {
        string winner;
        string loser1;
        string loser2;

        public Gesture(string winner, string loser1, string loser2)
        {
            this.winner = winner;
            this.loser1 = loser1;
            this.loser2 = loser2;
        }
    }
}
