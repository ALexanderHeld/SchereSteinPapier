using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchereSteinPapier
{
    class Papier : Handarten
    {
        private new Handarten.HandartEnum ThisHandType = HandartEnum.Papier;
        private new List<HandartEnum> Schlägt = new List<HandartEnum> { HandartEnum.Stein, HandartEnum.Spock };

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
