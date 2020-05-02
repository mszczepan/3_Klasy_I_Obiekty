using System;
using _4_8_Złożenia;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool wartosc = true;

            Assert.IsTrue(wartosc);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Karta karta1 = new Karta();
            karta1 = null;
            Assert.IsNull(karta1);
          
        }

        [TestMethod]
        public void ObliczanieSredniejWartosci()
        {
            Karta karta1 = new Karta();

            karta1.DodajOcene(2);
            karta1.DodajOcene(4);
            KartaStatystki stat = karta1.ObliczStatystki();


            Assert.AreEqual(3,stat.SredniaOcena);

        }
    }
}
