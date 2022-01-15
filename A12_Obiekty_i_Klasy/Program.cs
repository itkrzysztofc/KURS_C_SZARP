// A12_Obiekty_i_Klasy
using System;

namespace A12_Obiekty_i_Klasy
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. tworzymy obiekt
            Osoba osoba = new Osoba();
            //3. możemy używaż metod obiektu/właściwości klasy
            Console.WriteLine(osoba.name);
            Console.WriteLine(osoba.surname);
            Console.WriteLine(osoba.age);
            osoba.age = 91;
            Console.WriteLine(osoba.age);
            osoba.name = "Cristoph";
            Console.WriteLine(osoba.name);
            Osoba osoba2 = new Osoba();
            Console.WriteLine(osoba2.name);
            //użycie funkcji z klasy
            osoba.Czlowiek();
            //osoba.wzrost;//błąd
        }
        //1. tworzymy klasę
        class Osoba
        {
            public string name = "Kris";
            public string surname = "Czyz";
            public int age = 191;
            private string wzrost = "Wysoki";
            //wewn.. klasy możemy tworzyć funkcje
            public void Czlowiek()
            {
                Console.WriteLine(wzrost);
            }
        }
        //tu może być kolejna klasa
        //.....
    }
}
