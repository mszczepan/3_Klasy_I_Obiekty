using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_Parametry_metody
{
    class Program
    {

        static void UstawNazwe(out Karta karta)
        {
             karta = new Karta();
            karta.Nazwa = "Karta Marcina";
        }

        static void ZwiekszNumer(out int numer)
        {
            numer=42;

        }
        static void Main(string[] args)
        {
            Karta karta1 = new Karta();
            Karta karta2 = karta1;

            UstawNazwe(out karta1);

            Console.WriteLine(karta2.Nazwa);

            int x1 = 6;
             ZwiekszNumer(out x1);
            Console.WriteLine(x1);

        }
    }
}
