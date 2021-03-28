using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_cs_Kurs
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleView view = new ConsoleView();
            string ersteZahlAlsString = view.HoleBenutzereingabe("Bitte schreibe die erste Zahl:");
            string zweiteZahlAlsString = view.HoleBenutzereingabe("Bitte schreibe die zweite Zahl:");
            string operation = view.HoleBenutzereingabe("Bitte gebe eine Operation ein (+, -, * oder /):");

            double ersteZahl = KonvertierungStringInDouble(ersteZahlAlsString);
            double zweiteZahl = KonvertierungStringInDouble(zweiteZahlAlsString);

            RechnerModel model = new RechnerModel();
            model.FuehreRechnungAus(ersteZahl, zweiteZahl, operation);
            GebeErgebnisAus(model.Resultat, operation);
        }

        static void GebeErgebnisAus(double ergebnis, string operation)
        {
            switch (operation)
            {
                case "+": 
                    Console.WriteLine($"Die Summe ist: {ergebnis}"); 
                    Console.ReadLine();
                    break;
                case "-": 
                    Console.WriteLine($"Die Differenz ist: {ergebnis}"); 
                    Console.ReadLine();
                    break;
                case "*": 
                    Console.WriteLine($"Die Multiplikation ergibt: {ergebnis}"); 
                    Console.ReadLine();
                    break;
                case "/": 
                    Console.WriteLine($"Die Division ergibt: {ergebnis}"); 
                    Console.ReadLine();
                    break;
            }
            return;
        }

        static double KonvertierungStringInDouble(string zahl)
        {
            return Convert.ToDouble(zahl);
        }

        static string HoleBenutzereingabe(string konsolenAusgabe)
        {
            Console.Write(konsolenAusgabe);
            return Console.ReadLine();
        }
        
    }
}
