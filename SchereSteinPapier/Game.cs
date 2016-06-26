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
            Spieler.Instance.SetName();
            Game.PrintHelp();
            History.LoadData();
        }
        public static void PickWinner()
        {
            bool GewinnerGefunden = false;

            while (!GewinnerGefunden)
            {
                Spieler.Instance.ChooseHand();
                Computer.Instance.RandomHand();

                // Gleichstand
                if (Spieler.Instance.ausgabeHand.GetThisHandType() == Handarten.HandartEnum.exit)
                    break;
                if (Spieler.Instance.ausgabeHand.GetThisHandType() == Handarten.HandartEnum.help)
                {
                    Game.PrintHelp();
                    break;
                }

                if (Spieler.Instance.ausgabeHand.GetThisHandType() == Computer.Instance.ausgabeHand.GetThisHandType())
                {
                    Game.PrintTextGameSpielerColor("Gleichstand!");
                    continue;
                }
                // Spieler Gewinnt
                if (Spieler.Instance.ausgabeHand.GetSchlägt().Contains(Computer.Instance.ausgabeHand.GetThisHandType()))
                {
                    Game.PrintTextGameSpielerColor($"Spieler Gewinnt! {Spieler.Instance.ausgabeHand.GetThisHandType()} schlägt {Computer.Instance.ausgabeHand.GetThisHandType()}");
                    History.Instance.SetData(Spieler.Instance.ausgabeHand.GetThisHandType(), Computer.Instance.ausgabeHand.GetThisHandType()); // History
                    GewinnerGefunden = true;
                }
                // Computer Gewinnt
                else
                {
                    Game.PrintTextGameComputerWinnerColor($"Computer Gewinnt! {Computer.Instance.ausgabeHand.GetThisHandType()} schlägt {Spieler.Instance.ausgabeHand.GetThisHandType()}");
                    History.Instance.SetData(Computer.Instance.ausgabeHand.GetThisHandType(), Spieler.Instance.ausgabeHand.GetThisHandType()); // History
                    GewinnerGefunden = true;
                }

            }
        }

        public static void Running()
        {
            bool stop = false;
            do
            {
                PickWinner();
                if (Spieler.Instance.ausgabeHand.GetThisHandType() == Handarten.HandartEnum.exit)
                {
                    Game.PrintTextGameRuleColor("Wird beendet");
                    History.Instance.SaveData();
                    stop = true;
                }
            } while (!stop);

        }

        public static void PrintTextGameRuleColor(string s)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(s);
            Console.ResetColor();
        }

        public static void PrintTextGameErrorColor(string s)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(s);
            Console.ResetColor();
        }

        public static void PrintTextGameComputerWinnerColor(string s)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(s);
            Console.ResetColor();
        }

        public static void PrintTextGameSpielerColor(string s)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        public static void PrintHelp()
        {
            Game.PrintTextGameRuleColor("### SPIELREGELN ###\nZum Beenden 'exit' schreiben");
            // Hände zusammenbauen
            StringBuilder myString = new StringBuilder();
            myString.Append("Such dir bitte eine Hand aus!\n\n");
            foreach (Handarten.HandartEnum hand in Enum.GetValues(typeof(Handarten.HandartEnum)))
            {
                myString.Append(hand + " | ");
            }
            Game.PrintTextGameRuleColor(myString.ToString());
        }
    
    }
}
