using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchereSteinPapier
{
    class Spock : Handarten
    {
        public Handarten.HandartEnum ThisHandType = HandartEnum.Spock;
        public List<HandartEnum> Schlägt = new List<HandartEnum> { HandartEnum.Stein, HandartEnum.Schere };
        public List<HandartEnum> WirdGeschlagen = new List<HandartEnum> { HandartEnum.Papier, HandartEnum.Echse };
    }
}
