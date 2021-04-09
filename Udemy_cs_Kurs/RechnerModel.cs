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
        public string Operation { get; set; }
        public double ErsteZahl { get; set; }
        public double ZweiteZahl { get; set; }

        public RechnerModel()
        {
            Resultat = 0;
            Operation = "unbekannt";    
        }
        
        public bool ZulaessigeZahl(double zahl)
        {
            if(zahl<-10f || zahl > 100)
            {
                return false;
            }
            return true;
        }
        public void FuehreRechnungAus()
        {
            switch (Operation)
            {
                case "+": Resultat = Addiere(ErsteZahl, ZweiteZahl); break;
                case "-": Resultat = Subtrahiere(ErsteZahl, ZweiteZahl); break;
                case "*": Resultat = Multipliziere(ErsteZahl, ZweiteZahl); break;
                case "/": Resultat = Dividiere(ErsteZahl, ZweiteZahl); break;
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
