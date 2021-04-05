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
            view.HoleEingabenVomBenutzer();
            model.FuehreRechnungAus();
            view.GebeErgebnisAus();
            view.WarteAufEndeVonBenutzer();
        }
    }
}
