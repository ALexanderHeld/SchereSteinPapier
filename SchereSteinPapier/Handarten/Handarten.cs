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
            help = -2,
            exit = -1,
            Papier = 0,
            Schere,
            Stein,
            Echse,
            Spock
        }

        public virtual HandartEnum ThisHandType { get; set; }
        public virtual List<HandartEnum> Schlägt { get; set; }

        public virtual Handarten.HandartEnum GetThisHandType()
        {
            throw new NotImplementedException();
        }

        public virtual List<HandartEnum> GetSchlägt()
        {
            throw new NotImplementedException();
        }
    }
}
