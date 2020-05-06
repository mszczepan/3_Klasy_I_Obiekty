using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_Metody
{
    class Program
    {
        static void Main(string[] args)
        {



            Karta karta1 = new Karta();
            karta1.DodajOcene(4);
            karta1.DodajOcene(8);
            karta1.DodajOcene(6);

            karta1.Nazwa = "karta Marcina";
            karta1.Nazwa = null;
            Console.WriteLine(karta1.Nazwa);
            //    KartaStatystki stat = karta1.ObliczStatystki();

            //    WypiszWynik("Srednia: ", stat.SredniaOcena);
            //    WypiszWynik("Min: ", stat.NajnizszaOcena);
            //    WypiszWynik("Max: ", stat.NajwyzszaOcena);
            //    WypiszWynik("Test" , 55,4,5);
            //    WypiszWynik("Params", 3, 5, 6,8);
            //}

            //static void WypiszWynik(string opis, float wynik)
            //{
            //    Console.WriteLine(opis + ":" +wynik);
            //}

            //static void WypiszWynik(string opis, int wynik)
            //{
            //    Console.WriteLine(opis + ":" + wynik);
            //}

            //static void WypiszWynik(string opis, long wynik)
            //{
            //    Console.WriteLine(opis + ":" + wynik);
            //}

            //static void WypiszWynik(string opis, long wynik,int test,int test2)
            //{
            //    Console.WriteLine(opis + ":" + wynik);
            //}

            //static void WypiszWynik(string opis, params float[] wynik)
            //{
            //    Console.WriteLine(opis + ":" + wynik[0] +" - " +wynik[1]);
            //}

        }
    }
}
