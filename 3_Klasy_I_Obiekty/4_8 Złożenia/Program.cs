using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace _4_8_Złożenia
{
    class Program
    {
        static void Main(string[] args)
        {

            //SpeechSynthesizer synt = new SpeechSynthesizer();
            //synt.Speak("Cześć Marcin");

            Karta karta1 = new Karta();
            karta1.DodajOcene(4);
            karta1.DodajOcene(8);

            KartaStatystki stat = karta1.ObliczStatystki();

            Console.WriteLine(stat.SredniaOcena);



        }
    }
}
