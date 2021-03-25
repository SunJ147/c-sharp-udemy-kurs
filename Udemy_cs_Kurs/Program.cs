﻿using System;
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
            string ersteZahlAlsString = HoleBenutzereingabe("Bitte schreibe die erste Zahl:");
            string zweiteZahlAlsString = HoleBenutzereingabe("Bitte schreibe die zweite Zahl:");
            string operation = HoleBenutzereingabe("Bitte gebe eine Operation ein (+, -, * oder /):");

            double ersteZahl = KonvertierungStringInDouble(ersteZahlAlsString);
            double zweiteZahl = KonvertierungStringInDouble(zweiteZahlAlsString);

            double ergebnis = FuehreRechnungAus(ersteZahl, zweiteZahl, operation);
            GebeErgebnisAus(ergebnis, operation);
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
        
        static double FuehreRechnungAus(double ersteZahl, double zweiteZahl, string operation)
        {
            double resultat = 0;

            switch (operation)
            {
                case "+": resultat = Addiere(ersteZahl, zweiteZahl); break;
                case "-": resultat = Subtrahiere(ersteZahl, zweiteZahl); break;
                case "*": resultat = Multipliziere(ersteZahl, zweiteZahl); break;
                case "/": resultat = Dividiere(ersteZahl, zweiteZahl); break;
            }
            return resultat;
        }

        static double Addiere(double ersteZahl, double zweiteZahl)
        {
            return ersteZahl + zweiteZahl;
        }

        static double Multipliziere(double ersteZahl, double zweiteZahl)
        {
            return ersteZahl * zweiteZahl;
        }

        static double Subtrahiere(double ersteZahl, double zweiteZahl)
        {
            return ersteZahl - zweiteZahl;
        }

        static double Dividiere(double ersteZahl, double zweiteZahl)
        {
            return ersteZahl / zweiteZahl;
        }
    }
}
