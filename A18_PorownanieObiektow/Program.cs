// Equals; Compare;
using System;
using System.Collections.Generic;

namespace A18_PorownanieObiektow
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. porównaie zmiennych tekstowych
            string s1 = "C#";
            String s2 = new string(s1.ToString());
            Console.WriteLine(s1 == s2);  //sposób pierwszy
            Console.WriteLine(s1.Equals(s2)); //sposób drugi
            Console.WriteLine(s1.CompareTo(s2)); //sposób trzeci - równy
            //2. porównanie zmiennych liczbowych
            int a, b;
            a = 10;  b = -5;
            Console.WriteLine(a == b);
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.CompareTo(b)); //a jest większe od b
            Console.WriteLine(b.CompareTo(a)); //b jest większe od a
            // tworzymy obiekty =====================
            //2. Porównaie obiektów
            Auto auto1 = new Auto("Fiat", 2000);
            Auto auto2 = new Auto("Fiat", 2000);
            Auto auto3 = new Auto("Opel", 2020);
            Auto auto4 = new Auto("Audi", 2023);
            Auto auto5 = new Auto("Opel", 1987);
            Auto auto6 = new Auto("Opel", 2005);
            Console.WriteLine(auto1 == auto2); //porównuje czy to ten sam obiekt
            Console.WriteLine(auto1.Equals(auto2)); //porównanie właściwości obiektu
            Console.WriteLine(auto1.CompareTo(auto3)); 
            //3. Użycie listy
            List<Auto> listaAut = new List<Auto>();
            listaAut.Add(auto1);
            listaAut.Add(auto2);
            listaAut.Add(auto3);
            listaAut.Add(auto4);
            listaAut.Add(auto5);
            listaAut.Add(auto6);
            foreach(var item in listaAut)
            {
                Console.WriteLine(item.Model + " " + item.Rocznik);
            }
            Console.WriteLine();
            //sortowanie według rocznika
            listaAut.Sort();
            foreach (var item in listaAut)
            {
                Console.WriteLine(item.Model + " " + item.Rocznik);
            }
            // sotowanie według nazwy
            Console.WriteLine();
            listaAut.Sort(new AutoPorownywacz());
            foreach (var item in listaAut)
            {
                Console.WriteLine(item.Model + " " + item.Rocznik);
            }
        }
    }
}