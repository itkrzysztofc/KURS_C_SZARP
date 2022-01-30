// Praktyczny przykład użycia kolekcji
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
            List<Auto> lista2 = new List<Auto>(); //konstruktor listy
            Console.Clear();
            int wybor;
            wybor = 0;
            while (wybor != 5)
            {
                Console.WriteLine("Praktyczne użycie kolekcji listy - przykład");
                Console.WriteLine("MENU:\n======================");
                Console.WriteLine("1. Dodaj element listy");
                Console.WriteLine("2. Usuń element listy");
                Console.WriteLine("3. Pokaż listę");
                Console.WriteLine("4. Wyczyść całą listę");
                Console.WriteLine("5. Koniec");
                Console.WriteLine("======================");
                Console.Write("Twój wybór: ");
                wybor = Convert.ToInt32(Console.ReadLine());
                switch (wybor)
                {
                    case 1: //dodaje element listy
                        Console.Write("Podaj nazwę pojazdu: ");
                        string tekst = Console.In.ReadLine();
                        lista2.Add(new Auto(tekst));
                        Console.Clear();
                        break;
                    case 2: //usuwa element listy
                        Console.Write("Który element chcesz usunąć? Podaj: ");
                        String numer = Console.In.ReadLine();
                        int x = int.Parse(numer);
                        lista2.RemoveAt(x);
                        Console.Clear();
                        break;
                    case 3: //pokazuje listę
                        int licznik = lista2.Count;
                        if (licznik == 0)
                        {
                            Console.WriteLine("Twoja lista jest pusta.");
                        }
                        else
                        {
                            foreach (var item in lista2)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        System.Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4: //usuwa całą listę
                        lista2.Clear();
                        Console.Clear();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}