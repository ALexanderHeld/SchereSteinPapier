﻿using System;
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
        private string Name { get; set; }

        public void ChooseHand()
        {
            // "Willkommens" String bauen und in Konsole Schreiben
            StringBuilder myString = new StringBuilder();
            myString.Append("Such dir bitte eine Hand aus!\n");
            foreach (Handarten.HandartEnum hand in Enum.GetValues(typeof(Handarten.HandartEnum)))
            {
                myString.Append(hand + " ");
            }
            Console.WriteLine(myString);

            // Eingabe + Validierung
            bool eingabeRichtig = false;
            while (!eingabeRichtig)
            {
                string eingabe = Console.ReadLine();
                eingabe = eingabe.ToLower();

                if (String.IsNullOrEmpty(eingabe) || String.IsNullOrWhiteSpace(eingabe))
                {
                    // Es wurde nichts eingegeben..
                    Console.WriteLine("Gib etwas ein!!");
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
                        {
                            ausgabeHand = new Schere();
                        }
                        if (eingabe == Handarten.HandartEnum.Papier.ToString().ToLower())
                        {
                            ausgabeHand = new Papier();
                        }
                        if (eingabe == Handarten.HandartEnum.Stein.ToString().ToLower())
                        {
                            ausgabeHand = new Stein();
                        }
                        if (eingabe == Handarten.HandartEnum.Echse.ToString().ToLower())
                        {
                            ausgabeHand = new Echse();
                        }
                        if (eingabe == Handarten.HandartEnum.Spock.ToString().ToLower())
                        {
                            ausgabeHand = new Spock();
                        }
                        eingabeRichtig = true;
                    }
                    else
                        Console.WriteLine("Du tust nie was man dir sagt!");
                }
            }
        }

        public void SetName(string name)
        {
            bool nameFound = false;
            while (!nameFound)
            {
                if (!(String.IsNullOrEmpty(name) || String.IsNullOrWhiteSpace(name)))
                {
                    Name = name;
                    nameFound = true;
                }

                else
                    Console.WriteLine("Gib bitte den Namen richtig ein.");
            }
            
        }
    }
}
