using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_4_Konstruktor
{
    class Program
    {
        static void Main(string[] args)
        {
            var osoba1 = new Osoba();
            var osoba2 = new Osoba("Jan","Kowal");
            var osoba3 = new Osoba("Tomek","Kowal","Katowice");
            var osoba4 = new Osoba("Adam", "Kowal", "Katowice","Mila 15",18);
        }
    }
}
