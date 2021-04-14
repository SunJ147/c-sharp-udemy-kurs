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
            BenutzerWillBeenden = false;
        }
        public bool BenutzerWillBeenden { get; private set; }

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

        public void HoleEingabenFuerErsteBerechnungVomBenutzer()
        {
            model.ErsteZahl = HoleZahlVonBenutzer();
            model.Operation = HoleOperatorVonBenutzer();
            model.ZweiteZahl = HoleZahlVonBenutzer();
        }

        public void HoleEingabenFuerFortlaufendeBerechnung()
        {
            string eingabe = HoleNaechsteAktionVomBenutzer();

            if (eingabe.ToUpper() == "FERTIG")
            {
                BenutzerWillBeenden = true;
            }
            else
            {
                model.ErsteZahl = model.Resultat;
                model.ZweiteZahl = Convert.ToDouble(eingabe);
            }
        }

        private string HoleNaechsteAktionVomBenutzer()
        {
            Console.Write("Bitte gib eine weitere Zahl ein (FERTIG zum Beenden): ");
            return Console.ReadLine();
        }

        private double HoleZahlVonBenutzer()        //kontrolliert ob Konsoleneingabe eine double Zahl ist
        {                                           //und im Intervall [-10, 100] liegt.
            string eingabe;
            double zahl;
            Console.Write("Bitte gib eine Zahl ein (FERTIG zum Beenden): ");
            eingabe = Console.ReadLine();
            EingabeKontrollieren:
            while (!double.TryParse(eingabe, out zahl))
            {
                Console.Write("Gebe eine gültige Gleitkommazahl ein:");
                eingabe = Console.ReadLine();
            }
            if(!model.ZulaessigeZahl(zahl))
            {
                Console.Write("Es sind nur Zahlen zwischen -10 und 100 zulässig! Bitte gebe eine zulässige Zahl ein: ");
                eingabe = Console.ReadLine();
                goto EingabeKontrollieren;
            }
            return zahl;

        }

        private string HoleOperatorVonBenutzer()
        {
            Console.Write("Bitte gib eine Operation ein (+, -, * oder /): ");
            return Console.ReadLine();
        }

    }
}
