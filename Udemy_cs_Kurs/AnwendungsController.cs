using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_cs_Kurs
{
    class AnwendungsController
    {
        private ConsoleView view;
        private RechnerModel model;

        public AnwendungsController(ConsoleView view, RechnerModel model)
        {
            this.view = view;
            this.model = model;
        }

        public void Ausfuehren()
        {
            string ersteZahlAlsString = view.HoleZahlVonBenutzer();
            string operation = view.HoleOperatorVonBenutzer();
            string zweiteZahlAlsString = view.HoleZahlVonBenutzer();

            double ersteZahl = KonvertierungStringInDouble(ersteZahlAlsString);
            double zweiteZahl = KonvertierungStringInDouble(zweiteZahlAlsString);

            model.FuehreRechnungAus(ersteZahl, zweiteZahl, operation);
            view.GebeErgebnisAus(operation);
            view.WarteAufEndeVonBenutzer();
        }

        static double KonvertierungStringInDouble(string zahl)
        {
            return Convert.ToDouble(zahl);
        }
    }
}
