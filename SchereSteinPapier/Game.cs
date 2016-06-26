using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchereSteinPapier
{
    class Game
    {
        public static Mitspieler PickWinner()
        {
            bool GewinnerGefunden = false;
            Mitspieler Gewinner = Spieler.Instance;

            while (!GewinnerGefunden)
            {
                Computer.Instance.RandomHand();
                Spieler.Instance.ChooseHand();

                if (Spieler.Instance.ausgabeHand.Equals(Computer.Instance.ausgabeHand))
                {
                    Console.WriteLine("Gleichstand!");
                    continue;
                }

                if (Spieler.Instance.ausgabeHand.Schlägt.Contains(Computer.Instance.ausgabeHand.ThisHandType))
                {
                    Console.WriteLine("Spieler Gewinnt!");
                    Gewinner = Spieler.Instance;
                    GewinnerGefunden = true;
                    
                }

                else
                {
                    Console.WriteLine("Computer Gewinnt!");
                    Gewinner = Computer.Instance;
                    GewinnerGefunden = true;
                }

            }

            return Gewinner;
        }
        
    }
}
