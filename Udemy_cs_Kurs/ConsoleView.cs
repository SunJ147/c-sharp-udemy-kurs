using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_cs_Kurs
{
    class ConsoleView
    {

        public string HoleBenutzereingabe(string konsolenAusgabe)
        {
            Console.Write(konsolenAusgabe);
            return Console.ReadLine();
        }

        public void GebeErgebnisAus(double ergebnis, string operation)
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
    }
}
