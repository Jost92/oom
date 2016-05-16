using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    interface IUnterkunft
    {
        double Preis { get; set; }
        string Name { get; }
        void stornieren(double betrag);
    }
}
