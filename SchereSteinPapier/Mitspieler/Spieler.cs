using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchereSteinPapier
{
    class Spieler : Mitspieler
    {
        private static Spieler instance = null;

        private Spieler() { }
        public static Spieler Instance
        {
            get
            {
                if (instance == null)
                    instance = new Spieler();
                return instance;
            }
        }

        public Handarten ausgabeHand { get; private set; }
        public string Name { get; private set; }

        public void ChooseHand()
        {
            

            // Eingabe + Validierung
            bool eingabeRichtig = false;
            while (!eingabeRichtig)
            {
                string eingabe = Console.ReadLine();
                eingabe = eingabe.ToLower();

                if (String.IsNullOrEmpty(eingabe) || String.IsNullOrWhiteSpace(eingabe))
                {
                    // Es wurde nichts eingegeben..
                    Game.PrintTextGameErrorColor("Die Eingabe war leer. Versuch es bitte noch einmal..");
                }
                else
                {
                    List<string> HandartenEnumAsListString = new List<string>();
                    foreach (Handarten.HandartEnum hand in Enum.GetValues(typeof(Handarten.HandartEnum)))
                    {
                        HandartenEnumAsListString.Add(hand.ToString().ToLower());
                    }

                    if (HandartenEnumAsListString.Contains(eingabe))
                    {
                        if (eingabe == Handarten.HandartEnum.Schere.ToString().ToLower())
                            ausgabeHand = new Schere();
                        if (eingabe == Handarten.HandartEnum.Papier.ToString().ToLower())
                            ausgabeHand = new Papier();
                        if (eingabe == Handarten.HandartEnum.Stein.ToString().ToLower())
                            ausgabeHand = new Stein();
                        if (eingabe == Handarten.HandartEnum.Echse.ToString().ToLower())
                            ausgabeHand = new Echse();
                        if (eingabe == Handarten.HandartEnum.Spock.ToString().ToLower())
                            ausgabeHand = new Spock();
                        if (eingabe == Handarten.HandartEnum.exit.ToString().ToLower())
                            ausgabeHand = new Exit();
                        if (eingabe == Handarten.HandartEnum.help.ToString().ToLower())
                            ausgabeHand = new Help();
                        eingabeRichtig = true;
                    }
                    else
                        Game.PrintTextGameErrorColor("Du tust nie was man dir sagt!");
                }
            }
        }

        public void SetName()
        {
            Game.PrintTextGameRuleColor("Gib bitte deinen Namen ein.");
            bool nameFound = false;
            while (!nameFound)
            {
                string name = Console.ReadLine();
                if (!(String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name)))
                {
                    Name = name;
                    nameFound = true;
                }
                else
                    Game.PrintTextGameErrorColor("Gib bitte einen richtigen Namen ein..");
            }
            
        }
    }
}
