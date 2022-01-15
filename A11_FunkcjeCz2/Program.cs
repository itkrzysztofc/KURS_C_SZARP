// A11_FunkcjeCz2
using System;

namespace A11_FunkcjeCz2
{
    class Program
    {
        static void Main(string[] args)
        {
            int z = Dodaj();
            int w = Dodaj (7);
            Console.WriteLine(z);
            Console.WriteLine(w+w);
            Console.WriteLine(Dodaj(3, 7));
            // przekazywanie zmiennych jako referencje
            int a = 6;
            Console.WriteLine("Stara wartość a = " + a);
            Console.WriteLine(Suma(ref a, 7));
            Console.WriteLine("Nowa wartość a = " + a); // to 'a' to nie jest wartość z linii 16
            Console.WriteLine(Suma(ref a));// użyta nowa wartość 'a'
            Console.WriteLine("Nowa wartość a = " + a); // to 'a' to nie jest wartość z linii 16
            //tablice
            int[] tab = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(tab[4]);
            TestTablicy(ref tab);
            Console.WriteLine("Po wywołaniu: " + tab[1] + " " + tab[4]);
            // przekazywanie zmiennych za pomocą 'out'
            int c;
            Console.WriteLine(PodajLiczbe(out c));
        } 
        static int Dodaj(int a = 0, int b = 0)
        {
            int wynik = a + b;
            return wynik;
        }
        static int Suma(ref int a, int b = 0)
        {
            int wynik = a + b;
            a += a;
            return wynik;
        }
        static int TestTablicy(ref int[] tab)
        {
            //tab = new int[5];
            tab[0] = 888;
            tab[1] = 555;
            return 0;
        }
        static int PodajLiczbe(out int c) // nie przekazujemy do funkcji żadnej wartości int tylko zmienną
        {
            c = Dodaj(4,7);
            return c;
        }
    }
}