using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A13_KonstruktoryDestruktory
{
    internal class Osoba
    {   //konstruktor musi być na początku klasy
        public Osoba() //musi mieć nazwę klasy w któej się znajduje
        {
        }
        public Osoba(string noweImie="", string noweNazwisko="")
        {
            imie = noweImie;
            nazwisko = noweNazwisko;
        }
        public string imie = "BRAK IMIENIA";
        public string nazwisko = "BRAK NAZWISKA";
        public void Czlowiek()
        {
            Console.WriteLine("I'm " + imie + " " + nazwisko);
        }
        //destruktor jest zawsze na koniec klasy
        ~Osoba() { }// DESTRUKTOR usuwa obiekt z pamięci po użyciw w programie
    }
}
