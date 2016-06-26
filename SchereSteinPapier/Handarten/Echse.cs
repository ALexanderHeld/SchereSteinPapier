using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchereSteinPapier
{
    class Echse : Handarten
    {
        public Handarten.HandartEnum ThisHandType = HandartEnum.Echse;
        public List<HandartEnum> Schlägt = new List<HandartEnum> { HandartEnum.Papier, HandartEnum.Spock };
        public List<HandartEnum> WirdGeschlagen = new List<HandartEnum> { HandartEnum.Schere, HandartEnum.Stein };
    }
}
