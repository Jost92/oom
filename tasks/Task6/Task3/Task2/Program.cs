using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;
using Task2;

namespace Task4
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

                Task2.Subject.Run(unterkuenfte);

                ////alle erstellten Instanzen inkl Preis, Name und Stornokosten werden ausgegeben
                //foreach (var x in unterkuenfte)
                //{


                //    Console.WriteLine($"Name: {x.Name}      Preis: {x.Preis}");
                //    x.stornieren(x.Preis);
                //    Console.WriteLine($"Ihre Stornokosten betragen: {x.Preis}");

                //}

                //Console.WriteLine();
                //Console.WriteLine("Serialization Ausgabe:");
                //Serialization.Run(unterkuenfte);



               // MyTask.Run();
            }
            ///*Wenn Fehler im Try passiert, springt er in den catch Zweig
            catch (Exception ex)
            {

                Console.WriteLine($"ERROR: {ex}");
            }



        }
    }
}
