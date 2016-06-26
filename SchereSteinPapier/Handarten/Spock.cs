using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchereSteinPapier
{
    class Spock : Handarten
    {
        public new Handarten.HandartEnum ThisHandType = HandartEnum.Spock;
        public new List<HandartEnum> Schlägt = new List<HandartEnum> { HandartEnum.Stein, HandartEnum.Schere };

        public override Handarten.HandartEnum GetThisHandType()
        {
            return this.ThisHandType;
        }

        public override List<HandartEnum> GetSchlägt()
        {
            return this.Schlägt;
        }
    }
}
