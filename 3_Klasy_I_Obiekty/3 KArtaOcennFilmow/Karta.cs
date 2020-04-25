using System;
using System.Collections.Generic;
using System.Linq;


namespace _3_KartaOcenFilmow
{
    class Karta
    {
        public Karta()
        {
            oceny = new List<float>();
        }
        //Stan (zmienne -pola)
        List<float> oceny;
        //Zachowania(metody)
       
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
            //float suma = 0;
            //float srednia = 0;

            //foreach (var ocena in oceny)
            //{
            //    suma += ocena;
            //    srednia = suma / oceny.Count();
            //}

            //return srednia;

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
