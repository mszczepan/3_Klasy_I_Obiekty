using System;
using System.Collections.Generic;
using System.Linq;


namespace _3_KartaOcenFilmow
{
    class Program
    {
        static void Main(string[] args)
        {

            Karta karta=new Karta();
            karta.DodajOcene(6);
            karta.DodajOcene(8);
            karta.DodajOcene(3);
            karta.DodajOcene(4.4f);
            karta.DodajOcene(3.7f);

            var srednia=karta.ObliczSrednia();
            float max = karta.NajwyzszaWartosc();
            float min= karta.NajnizszaOcena();


            
        }
    }
}
