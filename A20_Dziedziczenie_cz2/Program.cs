using System;

namespace A20_Dziedziczenie_cz2
{
    class Program
    {
        static void Main(string[] args)
        {
            Lory L1 = new Lory("MAN", 560);
            Console.WriteLine(L1.paliwo + " " + L1.ile_paliwa + " litrów.");
            //nowy obiekt korzystający z klasy Cysterna
            Cysterna C1 = new Cysterna("DAF", 600, 2000);
            Console.WriteLine(C1.paliwo + " " + C1.ile_paliwa + " litrów.");
            Console.WriteLine(C1.paliwo + " " + C1.ile_paliwa + " litrów " + C1.pojemnosc);
            L1.Ruch();
            C1.Ruch();
        }
    }
}