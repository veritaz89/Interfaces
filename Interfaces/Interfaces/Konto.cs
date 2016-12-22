using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Konto :IFinanztransfer
    {
        protected double kontostand;
        protected double habenzins;
        public const double Kontostand;

        public Konto (double betrag, double habenzins)
        {
            this.kontostand = betrag;
            this.habenzins = habenzins;
        }

        public void einbezahlen(double betrag)
        {
            this.kontostand += betrag;
        }
        public bool ausbezahlen(double betrag)
        {
            this.kontostand -= betrag;
            return true;
        }
        public void verzinsen()
        {

        }
    }
}
