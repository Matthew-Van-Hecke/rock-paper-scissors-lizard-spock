using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Gesture
    {
        public string name;
        public string beats1;
        public string beats2;

        public Gesture(string name, string beats1, string beats2)
        {
            this.name = name;
            this.beats1 = beats1;
            this.beats2 = beats2;
        }
    }
}
