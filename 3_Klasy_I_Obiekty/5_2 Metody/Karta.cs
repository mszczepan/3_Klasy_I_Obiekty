using System;
using System.Collections.Generic;
using System.Linq;


namespace _5_2_Metody

{
    public class Karta
    {
        public Karta()
        {
            oceny = new List<float>();
            Licznik++;
        }
        public string Nazwa;
        //Stan (zmienne -pola)
        List<float> oceny;
        public static float MinOcena = 0;
        public static float MaxOcena = 20;
        public static long Licznik = 0;



        //Zachowania(metody)


        public KartaStatystki ObliczStatystki()
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
