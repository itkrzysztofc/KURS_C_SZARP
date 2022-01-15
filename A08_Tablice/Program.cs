// A08 Tablice w C# 

using System;

namespace A08_Tablice
{
    class Program
    {
        static void Main(string[] args)
        {
            //tablica stała
            string[] tab1 = { "N", "Pn", "Wt", "Śr", "Cz", "Pt", "Sb" };
            Console.WriteLine(tab1[3]);
            for(int i=0; i<tab1.Length; i++) { Console.WriteLine(tab1[i]); }
            //tablica utworzona za  pomocą konstruktora
            int n = 10;
            int[] tab2 = new int[n]; //konstruktor 
            for(int i=0; i<n; i++)
            {
                tab2[i] = i*2;
                Console.Write(tab2[i] + " ");
            }
            //Console.WriteLine();
        }
    }
}