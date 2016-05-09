using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Hotelzimmer
    {

        private decimal m_preis;

        public Hotelzimmer(string name, decimal preis)

        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Dem Zimmer muss ein Name vergeben werden.", nameof(name));

            Name = name;
            Preis = preis;

        }

     
        /// <summary>
        /// zeigt alle Namen und Preise der Hotels an
        /// </summary>
        public void ZeigePreisName()
        {
            Console.WriteLine($"name: {Name}");
            Console.WriteLine($"preis: {Preis}");
            
        }

        public string Name { get; }

        public decimal Preis
        {
            get { return m_preis; }
            set
            {
                if (value < 0) throw new Exception("Negativer Preis");
                m_preis = value;
            }
        }
    }
}
