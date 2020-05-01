using System;
using System.Collections.Generic;
using System.Linq;


namespace _4_4_Parametry_metody
{
    class Karta
    {
        public Karta()
        {
            oceny = new List<float>();
        }
        //Stan (zmienne -pola)
        List<float> oceny;
        public string Nazwa;
      



        //Zachowania(metody)


        internal KartaStatystki ObliczStatystki()
        {

            KartaStatystki stat = new KartaStatystki();
            stat.SredniaOcena=oceny.Average();
            stat.NajnizszaOcena= oceny.Min();
            stat.NajwyzszaOcena=oceny.Max();

            return stat;
        }

        /// <summary>
        /// Dodaje nową ocenę do listy ocen
        /// </summary>
        /// <param name="ocena">nowa ocena</param>
        public void DodajOcene(float ocena) 
        {
            oceny.Add(ocena);
        }

        /// <summary>
        /// Obliczanie średniej z listy ocen
        /// </summary>
        /// <returns>Średnia ocena</returns>
        public float ObliczSrednia()
        {
            return oceny.Average();
        }

        /// <summary>
        /// Znajduje najniższą ocenę
        /// </summary>
        /// <returns>Najniższa ocena</returns>
        public float NajnizszaOcena()
        {
            return oceny.Min();
        }

        /// <summary>
        /// Oblicza najwyższą ocenę 
        /// </summary>
        /// <returns>Najwyższa ocena</returns>
        public float NajwyzszaWartosc()
        {
            return oceny.Max();
        }
    }
}
