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
        public List<string> beats;

        public Gesture(string name, string beats1, string beats2)
        {
            this.name = name;
            beats = new List<string>() { beats1, beats2 };
        }
    }
}
