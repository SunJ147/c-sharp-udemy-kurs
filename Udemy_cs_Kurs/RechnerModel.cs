using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_cs_Kurs
{
    class RechnerModel
    {
        public double Resultat { get; private set; }

        public RechnerModel()
        {
            Resultat = 0;
        }

        public void FuehreRechnungAus(double ersteZahl, double zweiteZahl, string operation)
        { 
            switch (operation)
            {
                case "+": Resultat = Addiere(ersteZahl, zweiteZahl); break;
                case "-": Resultat = Subtrahiere(ersteZahl, zweiteZahl); break;
                case "*": Resultat = Multipliziere(ersteZahl, zweiteZahl); break;
                case "/": Resultat = Dividiere(ersteZahl, zweiteZahl); break;
            }
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
