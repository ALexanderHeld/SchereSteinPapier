﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchereSteinPapier
{
    class Computer : Mitspieler
    {
        // Singleton
        private static Computer obj;
        private Computer() { }
        public static Computer Instance { get { return obj; } }

        public Handarten ausgabeHand { get; private set; } // von außen nur lesen

        public void RandomHand()
        {
            Random rnd = new Random();
            Handarten.HandartEnum Ziel = (Handarten.HandartEnum)rnd.Next(0, Enum.GetValues(typeof(Handarten.HandartEnum)).Length);

            switch (Ziel)
            {
                case Handarten.HandartEnum.Papier:
                    ausgabeHand = new Papier();
                    break;
                case Handarten.HandartEnum.Schere:
                    ausgabeHand = new Schere();
                    break;
                case Handarten.HandartEnum.Stein:
                    ausgabeHand = new Stein();
                    break;
                case Handarten.HandartEnum.Echse:
                    ausgabeHand = new Echse();
                    break;
                case Handarten.HandartEnum.Spock:
                    ausgabeHand = new Spock();
                    break;
            }
        }
    }
}
