using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchereSteinPapier
{
    class Game
    {
        public static void Start()
        {
            Console.WriteLine("Gib deinen Namen ein!");
            Spieler.Instance.SetName(Console.ReadLine());
        }
        public static Mitspieler PickWinner()
        {
            bool GewinnerGefunden = false;
            Mitspieler Gewinner = Spieler.Instance;

            while (!GewinnerGefunden)
            {
                Spieler.Instance.ChooseHand();
                Computer.Instance.RandomHand();
                
                // Gleichstand
                if (Spieler.Instance.ausgabeHand.Equals(Computer.Instance.ausgabeHand))
                {
                    Console.WriteLine("Gleichstand!");
                    continue;
                }
                // Spieler Gewinnt
                if (Spieler.Instance.ausgabeHand.GetSchlägt().Contains(Computer.Instance.ausgabeHand.GetThisHandType()))
                {
                    Console.WriteLine("Spieler Gewinnt!");
                    Gewinner = Spieler.Instance;
                    GewinnerGefunden = true;
                }
                // Computer Gewinnt
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
