// A13 Konstruktory i destruktory
using System;

namespace A13_KonstruktoryDestruktory
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();//tworzymy obiekt - KONSTRUKTOR
            Console.WriteLine(osoba.imie + " " + osoba.nazwisko);
            osoba.Czlowiek(); //zastosowanie funkcji w klasie upraszcza kod Main()
            // wysłanie parametrów do klasy
            Osoba osoba2 = new Osoba("Jan");
            Osoba osoba3 = new Osoba("Jan","Niezbędny");
            Console.WriteLine(osoba2.imie + " " + osoba2.nazwisko);
            Console.WriteLine(osoba3.imie + " " + osoba3.nazwisko);
        }
    }
}