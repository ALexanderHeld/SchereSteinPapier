using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchereSteinPapier
{
    class Handarten
    {
        public enum HandartEnum
        {
            Papier = 0,
            Schere,
            Stein,
            Echse,
            Spock
        }

        public Handarten.HandartEnum ThisHandType;
        public List<HandartEnum> Schlägt;
        public List<HandartEnum> WirdGeschlagen;
    }
}
