using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                var unterkuenfte = new IUnterkunft[]
    {
              new Hotelzimmer("Edelstein", 100),
              new Hotelzimmer("Saphir", 250),
              new Hotelzimmer("Opal", 400),
              new Bungalow("Rot", 650),
              new Bungalow("Gelb", 790),
              new Bungalow("Blau", 900),
            };


                /*alle erstellten Instanzen inkl Preis, Name und Stornokosten werden ausgegeben*/
                foreach (var x in unterkuenfte)
                {


                    Console.WriteLine($"Name: {x.Name}      Preis: {x.Preis}");
                    x.stornieren(x.Preis);
                    Console.WriteLine($"Ihre Stornokosten betragen: {x.Preis}");

                }
            }

            /*Wenn Fehler im Try passiert, springt er in den catch Zweig*/
            catch (Exception ex)
            {

                Console.WriteLine($"ERROR: {ex}");
            }

        }
    }
}
