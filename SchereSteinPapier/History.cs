using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchereSteinPapier
{
    class History
    {
        private static History instance = null;

        private History() { }
        public static History Instance
        {
            get
            {
                if (instance == null)
                    instance = new History();
                return instance;
            }
        }

        private List<string> SpielerName = new List<string>();
        private List<string> Datum = new List<string>();
        private List<string> HandGewonnen = new List<string>();
        private List<string> HandVerloren = new List<string>();

        public void SetData(Handarten.HandartEnum win, Handarten.HandartEnum lost)
        {
            SpielerName.Add(Spieler.Instance.Name);
            Datum.Add(DateTime.Now.ToString());
            HandGewonnen.Add(win.ToString());
            HandVerloren.Add(lost.ToString());
        }

        // Überladen für erstes loading vom CSV-File
        public void SetData(string[] y, string[] x, string[] c, string[] v)
        {
            foreach (string sY in y)
            {
                SpielerName.Add(sY);
            }
            foreach (string sX in x)
            {
                Datum.Add(sX);
            }
            foreach (string sC in c)
            {
                HandGewonnen.Add(sC);
            }
            foreach (string sV in v)
            {
                HandVerloren.Add(sV);
            }
        }

        public void SaveData()
        {
            /* Mit Hilfe von:
             * http://stackoverflow.com/questions/18757097/writing-data-into-csv-file
             */
            
            var csv = new StringBuilder();
            for (int i = 0; i < Datum.Count; i++)
            {
                var newLine = $"{SpielerName[i]},{Datum[i]},{HandGewonnen[i]},{HandVerloren[i]}";
                csv.AppendLine(newLine);
            }
            csv.Remove(csv.Length - 1, 1);
            File.WriteAllText("data.csv", csv.ToString());
        }

        public static void LoadData()
        {
            var wholeFile = System.IO.File.ReadAllText("data.csv");
            // in einzelne lines splitten
            wholeFile.Replace('\n', '\r');
            string[] lines = wholeFile.Split('\n');
            if (wholeFile.Length > 2)
            {
                string[] name = new string[lines.Length];
                string[] date = new string[lines.Length];
                string[] win = new string[lines.Length];
                string[] lost = new string[lines.Length];
                // durchitterieren und string[] füllen anschließend übergeben
                for (int i = 0; i < lines.Count(); i++)
                {
                    name[i] = lines[i].Split(',')[0];
                    date[i] = lines[i].Split(',')[1];
                    win[i] = lines[i].Split(',')[2];
                    lost[i] = lines[i].Split(',')[3];
                }
                History.Instance.SetData(name, date, win, lost);
            }
            
        }
    }
}
