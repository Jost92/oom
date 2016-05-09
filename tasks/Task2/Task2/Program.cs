using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var Zimmer1 = new Hotelzimmer("Edelstein", 100);
                var Zimmer2 = new Hotelzimmer("Saphir", 250);
                var Zimmer3 = new Hotelzimmer("Opal", 400);
                Zimmer1.ZeigePreisName();
                Zimmer2.ZeigePreisName();
                Zimmer3.ZeigePreisName();
                Zimmer3.Preis = 350;
                Zimmer3.ZeigePreisName();
            }

            /*Wenn Fehler im Try passiert, springt er in den catch Zweig*/
            catch (Exception ex)
            {

                Console.WriteLine($"ERROR: {ex}");
            }

        }
    }
}
