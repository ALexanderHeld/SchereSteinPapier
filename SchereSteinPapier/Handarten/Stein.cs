using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchereSteinPapier
{
    class Stein : Handarten
    {
        public new Handarten.HandartEnum ThisHandType = HandartEnum.Stein;
        public new List<HandartEnum> Schlägt = new List<HandartEnum> { HandartEnum.Schere, HandartEnum.Echse };

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
