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
          //  Karta kartaUzytkownika = new Karta();
            karta.DodajOcene(6);
            karta.DodajOcene(8);
            karta.DodajOcene(3);
            karta.DodajOcene(4.4f);

            KartaStatystki  statystki = karta.ObliczStatystki();

            Console.WriteLine("Srednia ocena " + statystki.SredniaOcena);
            Console.WriteLine("Najwyższa ocena " + statystki.NajwyzszaOcena);
            Console.WriteLine("Najniższa ocena " + statystki.NajnizszaOcena);

            //karta.DodajOcene(4.4f);
            //karta.DodajOcene(3.7f);

            //var srednia=karta.ObliczSrednia();
            //float max = karta.NajwyzszaWartosc();
            //float min= karta.NajnizszaOcena();

            //for (; ; )
            //{

            //    Console.WriteLine("Podaj ocene z zakresu 1-10 ");
            //    float ocena;
            //    bool wynik =float.TryParse(Console.ReadLine(),out ocena);

            //    if (wynik)
            //    {
            //        if (ocena == 11)
            //        {
            //            break;
            //        }

            //        if (ocena > 0 && ocena <= 10)
            //        {
            //            kartaUzytkownika.DodajOcene(ocena);
            //        }
            //        else
            //        {
            //            Console.WriteLine("Liczba z poza zakresu ");
            //        }
            //    }

            //    else
            //    {
            //        Console.WriteLine("To nie jest liczba ");
            //    }

            //}

            //Console.WriteLine("Srednia ocena "+ kartaUzytkownika.ObliczSrednia());
            //Console.WriteLine("Najniższa ocena to " + kartaUzytkownika.NajnizszaOcena());
            //Console.WriteLine("Najwyzsza ocena to " + kartaUzytkownika.NajwyzszaWartosc());

            //Console.ReadKey();
        }
    }
}
