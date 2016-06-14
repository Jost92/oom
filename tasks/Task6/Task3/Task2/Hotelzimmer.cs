using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Hotelzimmer : IUnterkunft
    {
        private double m_preis;

        public string Name { get; }

        public Hotelzimmer(string name, double betrag)

        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Dem Hotelzimmer muss ein Name vergeben werden.", nameof(name));

            Name = name;
            Preis = betrag;

        }


        public double Preis
        {
            get { return m_preis; }
            set
            {
                if (value < 0) throw new Exception("Negativer Preis");
                m_preis = value;
            }
        }
        /*zu zahlende Stornogebuehren*/
        public void stornieren(double betrag)
        {
            Preis = betrag * 0.1;
        }

    }
}

