using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_cs_Kurs
{
    class ConsoleView
    {
        private RechnerModel model;

        public ConsoleView(RechnerModel model)
        {
            //this. weil das attribut und das argument beide model heißen
            this.model = model;
        }

        /*public double HoleBenutzereingabe(string konsolenAusgabe)
        {
            string zahl;
            Console.Write(konsolenAusgabe);
            zahl = Console.ReadLine();
            return Convert.ToDouble(zahl);
        }*/

        public void GebeErgebnisAus()
        {
            switch (model.Operation)
            {
                case "+":
                    Console.WriteLine($"Die Summe ist: {model.Resultat}");
                    break;
                case "-":
                    Console.WriteLine($"Die Differenz ist: {model.Resultat}");
                    break;
                case "*":
                    Console.WriteLine($"Die Multiplikation ergibt: {model.Resultat}");
                    break;
                case "/":
                    Console.WriteLine($"Die Division ergibt: {model.Resultat}");
                    break;
            }
            return;
        }
        public double HoleZahlVonBenutzer()
        {
            string zahl;
            Console.Write("Bitte gib eine Zahl ein: ");
            zahl = Console.ReadLine();
            return Convert.ToDouble(zahl);
        }

        public string HoleOperatorVonBenutzer()
        {
            Console.Write("Bitte gib eine Operation ein (+, -, * oder /): ");
            return Console.ReadLine();
        }

        public string WarteAufEndeVonBenutzer()
        {
            Console.Write("Zum Beenden bitte Return drücken! ");
            return Console.ReadLine();
        }
    }
}
