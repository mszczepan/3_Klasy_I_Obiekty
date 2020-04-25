using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4_Konstruktor
{
    class Osoba
    {
        String imie;
        String nazwisko;
        String miasto;
        String ulica;
        int wiek;

        public Osoba()
        {
            imie = "Default";
            nazwisko = "Default";
            miasto = "Default";
            ulica = "Default";
            wiek = 10;
            Console.WriteLine("Zadział konstruktor domyślny");
        }

        public Osoba(string imie , string nazwisko ,string miasto ,string ulica ,int wiek)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.miasto = miasto;
            this.ulica = ulica;
            this.wiek = wiek;
            Console.WriteLine("Zadział konstruktor pięcio parametrowy");
        }

        public Osoba(string imie, string nazwisko, string miasto)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.miasto = miasto;
            Console.WriteLine("Zadział konstruktor trój parametrowy");

        }

        public Osoba(string imie, string nazwisko ):this(imie,nazwisko, "Katowice","Mila 16",18)
        {
            Console.WriteLine("Zadział konstruktor dwu parametrowy");
        }
    }
}
