using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchereSteinPapier
{
    class Schere : Handarten
    {
        public Handarten.HandartEnum ThisHandType = HandartEnum.Schere;
        public List<HandartEnum> Schlägt = new List<HandartEnum> { HandartEnum.Papier, HandartEnum.Echse };
        public List<HandartEnum> WirdGeschlagen = new List<HandartEnum> { HandartEnum.Stein, HandartEnum.Spock };
    }
}
