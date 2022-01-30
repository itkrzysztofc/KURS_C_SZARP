// Lekcja 16. kolekcje, czyli zbiory danych nie wymagają deklartacji długości
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Collections.Immutable;

namespace A16_Kolekcje
{
    class Program
    {
        private const string Marka = "FIAT";

        static void Main(string[] args)
        {
            { /* ARRAY-LIST
            ArrayList  lista = new ArrayList();
            // dodajemy obiekt do listy
            lista.Add(8); //dodajemy liczbę do listy
            lista.Add("Kris"); //dodajemy stringa do listy
            lista.Add(-100); //dodajemy stringa do listy
            lista.Add("Kris G"); //dodajemy stringa do listy
            Auto pojazd = new(marka: Marka);
            lista.Add(pojazd);
            //wyświetlanie elementów listy
            Console.WriteLine(lista[0]);
            Console.WriteLine(lista[1]);
            Console.WriteLine(lista.Count);//spawdza ilość elementów w liście
            Console.WriteLine(lista[2]);
            //konstrukcja foreach
            foreach(var item in lista)
            {
                Console.WriteLine(item);
            }
            //modyfikacja listy
            lista.RemoveAt(1);// usuwanie elemntu listy
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            lista.Insert(1,"Krzysztof");//podmienia
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            lista.Clear();
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            */
            }
            //2. Kolekcja list
            List<Auto> lista2 = new List<Auto>(); //konstruktor listy
            lista2.Add(new Auto("Fiat"));
            lista2.Add(new Auto("Opel"));
            lista2.Add(new Auto("Audi 80"));
            lista2.Add(new Auto("Audi A4"));
            lista2.Add(new Auto("Audi Q"));
            foreach(Auto auto in lista2)
            {
                Console.WriteLine(auto);
                
                Console.WriteLine(auto.Cena(auto));
            }
            //wyświetlenie pojedyńczego elementu z listy
            Console.WriteLine(lista2[3].PomalujPojazd(lista2[3]));
            System.Console.ReadLine();//oczekiwanie na <ENTER>
            System.Console.ReadLine();

        }
    }
}