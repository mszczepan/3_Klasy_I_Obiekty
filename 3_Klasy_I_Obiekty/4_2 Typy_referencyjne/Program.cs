using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_Parametry_metody
{
    class Program
    {
        static void Main(string[] args)
        {
            //Karta karta1 = new Karta();
            //Karta karta2 = karta1;

            //karta1 = new Karta();
            //karta1.Nazwa = "Karta Marcina";

            //Karta karta3 = karta2;

            //Console.WriteLine(karta2.Nazwa);

            int x1 = 6;
            int x2 = x1;

            x1 = 10;

            Console.WriteLine(x2);
        }
    }
}
