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
            RechnerModel model = new RechnerModel();
            ConsoleView view = new ConsoleView(model);
            string ersteZahlAlsString = view.HoleZahlVonBenutzer();
            string operation = view.HoleOperatorVonBenutzer();
            string zweiteZahlAlsString = view.HoleZahlVonBenutzer();
            

            double ersteZahl = KonvertierungStringInDouble(ersteZahlAlsString);
            double zweiteZahl = KonvertierungStringInDouble(zweiteZahlAlsString);

            
            model.FuehreRechnungAus(ersteZahl, zweiteZahl, operation);
            view.GebeErgebnisAus(operation);
            view.WarteAufEndeVonBenutzer();
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
