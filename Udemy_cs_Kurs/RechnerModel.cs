using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_cs_Kurs
{
    class RechnerModel
    {
        public double FuehreRechnungAus(double ersteZahl, double zweiteZahl, string operation)
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

        private double Addiere(double ersteZahl, double zweiteZahl)
        {
            return ersteZahl + zweiteZahl;
        }

        private double Multipliziere(double ersteZahl, double zweiteZahl)
        {
            return ersteZahl * zweiteZahl;
        }

        private double Subtrahiere(double ersteZahl, double zweiteZahl)
        {
            return ersteZahl - zweiteZahl;
        }

        private double Dividiere(double ersteZahl, double zweiteZahl)
        {
            return ersteZahl / zweiteZahl;
        }
    }
}
