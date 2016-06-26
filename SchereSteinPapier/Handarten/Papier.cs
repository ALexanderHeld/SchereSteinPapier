using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchereSteinPapier
{
    class  Papier : Handarten
    {
        public Handarten.HandartEnum ThisHandType = HandartEnum.Papier;
        public List<HandartEnum> Schlägt = new List<HandartEnum> { HandartEnum.Stein, HandartEnum.Spock };
        public List<HandartEnum> WirdGeschlagen = new List<HandartEnum> { HandartEnum.Schere, HandartEnum.Echse};
    }
}
