//Przykład do lekcji A24
using System;
using System.IO;

namespace A25_przykladObslugiPlikow
{
    class Program
    {
        static void Main(string[] args)
        {
            string doPliku = @"plik.txt";
            StreamWriter sw;
            if (!File.Exists(doPliku))
            {
                sw = File.CreateText(doPliku);
            } else
            {
                sw = new StreamWriter(doPliku, true);
                sw.Close();
            }
            StreamReader sr;
            sr = File.OpenText(doPliku);
            //1. wypisanie zawartości całego pliku
            //Console.WriteLine(sr.ReadToEnd());//wypisuje zawartość pliku
            //2. wczytujemy linie z pliku
            string linia = "";
            int counter = 0;
            int x = 0;
            int counter2 = 0;
            string nowaLinia = "";
            while ((linia = sr.ReadLine()) != null)
            {
                //1. ile długich linii
                //if (linia.Length >= 38)
                //{
                //    counter++;
                //    Console.WriteLine(linia);
                //}
                //2. Najdłuższa linia
                //if (linia.Length > x) { x = linia.Length; }
                //3. ile jest literak " " ?
                //for (int i = 0; i < linia.Length; i++)
                //{
                //    if((linia[i]) == ' ')
                //    {
                //        counter2++;
                //    }
                //}
                //4. Wypisz liczby z początku pomijając resztę linii
                for (int i = 0; i < linia.Length; i++)
                {
                    if (linia[i] != ' ')
                    {
                        nowaLinia = nowaLinia + linia[i];
                    } else
                    {
                        nowaLinia = "";
                    }
                }
                if(nowaLinia.Length > 0)
                {
                    Console.WriteLine(nowaLinia + " " + float.Parse(nowaLinia)*2);
                }
                
                nowaLinia = "";
            }
            sr.Close();
            //Console.WriteLine("\n" + counter + "\n");// 1. ilość długich linii
            //Console.WriteLine(x + "\n");//2.
            //Console.WriteLine(counter2 + "\n");//3.
            Console.Write(nowaLinia + "\n");//4.
        }
    }
}