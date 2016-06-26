using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchereSteinPapier
{
    class Exit : Handarten
    {
        private new Handarten.HandartEnum ThisHandType = HandartEnum.exit;
        public new List<HandartEnum> Schlägt = new List<HandartEnum> { };

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
