using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IFinanztransfer
    {
        void einbezahlen(double betrag);
        bool ausbezahlen(double betrag);
    }
}
