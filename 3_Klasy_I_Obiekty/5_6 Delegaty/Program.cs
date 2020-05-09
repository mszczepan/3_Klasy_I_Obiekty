using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_6_Delegaty
{
    class Program
    {
        static void Main(string[] args)
        {

            Wiadomosc wiadomosc = new Wiadomosc();

            Wypisz wypisz = new Wypisz(wiadomosc.WypiszWiadomosc);

            wypisz("Witaj Marcin");
        }
    }
}
