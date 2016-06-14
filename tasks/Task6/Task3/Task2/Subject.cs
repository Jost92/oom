using System; 
using System.Collections.Generic; 
using System.Drawing; 
using System.Linq; 
using System.Reactive.Linq; 
using System.Reactive.Subjects; 
using System.Text; 
using System.Threading; 
using System.Threading.Tasks; 
using static System.Console;
using Task4;


namespace Task2
{
    public static class Subject
    {

        /*Object wurde genommen da IUnterkunft weniger zugriffbar war als die Run Methode*/
         public static void Run(object myUnterkuenfte)
         {
            /*Gibt eine Meldung bei einem nicht erwarteten Datentyp aus*/
            if (!(myUnterkuenfte.GetType() == typeof(IUnterkunft[])))
            {
                throw new ArgumentException("Erwartet wurde: IUnterkunft[]");
            }

            var myArray = (IUnterkunft[])myUnterkuenfte;
            var source = new Subject<IUnterkunft>();

            /*Gibt den Preis der Unterkunft aus*/
            source
                .Sample(TimeSpan.FromSeconds(1.0))
                .Subscribe(x => Console.WriteLine($"Preis {x.Preis}"))
                ;


            var t = new Thread(() =>
            {
                var i = 0;
                /*Gibt alle 2,5 sek den Hotelzimmer bzw. Bungalow Namen aus*/
                while (i<myArray.Length)
                {
                    Thread.Sleep(2500);
                    source.OnNext(myArray[i]);
                    Console.Write($"Name: {myArray[i].Name} \t");
                    i++;
                }
            });
            t.Start();
        } 
     } 

}
