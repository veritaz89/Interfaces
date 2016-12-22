using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Giro : Konto
    {
        private double disporahm;
        private double sollzins;

        public Giro (double betrag,double habenzins,double sollzins, double disporahmen):base(betrag,habenzins)
        {
            this.disporahm = disporahmen;
            this.sollzins = sollzins;
        }
    }
}
