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

            KartaStatystki stat = karta1.ObliczStatystki();

            WypiszWynik("Srednia: ", stat.SredniaOcena);
            WypiszWynik("Min: ", stat.NajnizszaOcena);
            WypiszWynik("Max: ", stat.NajwyzszaOcena);
           
        }

        static void WypiszWynik(string opis, float wynik)
        {
            Console.WriteLine(opis + ":" +wynik);
        }

        static void WypiszWynik(string opis, int wynik)
        {
            Console.WriteLine(opis + ":" + wynik);
        }

        static void WypiszWynik(string opis, long wynik)
        {
            Console.WriteLine(opis + ":" + wynik);
        }

    }
}
