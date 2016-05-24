using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task4;

namespace Task4
{

    /*Tests für die Klasse Hotelzimmer*/

    [TestFixture]
    public class HotelzimmerTests
    {
        [Test]
        public void CanCreateHotelzimmer()
        {
            var x = new Hotelzimmer("Diamant", 200);

            Assert.IsTrue(x.Name == "Diamant");
            Assert.IsTrue(x.Preis == 200);

        }

        [Test]
        public void CannotCreateHotelzimmerWithEmptyName1()
        {
            Assert.Catch(() =>
            {
                var x = new Hotelzimmer(null, 400);
            });
        }

        [Test]
        public void CannotCreateHotelzimmerWithEmptyName2()
        {
            Assert.Catch(() =>
            {
                var x = new Hotelzimmer("", 400);
            });
        }


        [Test]
        public void CannotCreateHotelzimmerWithNegativePrice()
        {
            Assert.Catch(() =>
            {
                var x = new Hotelzimmer("Diamant", -1);
            });
        }

        [Test]
        public void CanCalculateStornoHotelzimmer()
        {
            var x = new Hotelzimmer("Diamant", 400);
            x.stornieren(x.Preis);
            Assert.IsTrue(x.Preis == 40);
        }



        /*Tests für die Klasse Bungalow*/

        public class BungalowTests
        {

            [Test]
            public void CanCreateBungalow()
            {
                var x = new Bungalow("Gelb", 920);

                Assert.IsTrue(x.Name == "Gelb");
                Assert.IsTrue(x.Preis == 920);

            }

            [Test]
            public void CannotCreateBungalowWithEmptyName1()
            {
                Assert.Catch(() =>
                {
                    var x = new Bungalow(null, 700);
                });
            }

            [Test]
            public void CannotCreateHotelzimmerWithEmptyName2()
            {
                Assert.Catch(() =>
                {
                    var x = new Bungalow("", 888);
                });
            }


            [Test]
            public void CannotCreateBungalowWithNegativePrice()
            {
                Assert.Catch(() =>
                {
                    var x = new Bungalow("Gelb", -1);
                });
            }

            [Test]
            public void CanCalculateBungalow()
            {
                var x = new Bungalow("Gelb", 1000);
                x.stornieren(x.Preis);
                Assert.IsTrue(x.Preis == 150);
            }
        }
    }
}