// A10_WstepDoFunkcji
using System;

namespace A10_WstepDoFunkcji
{
    class Program
    {
        static void Main(string[] args)
        {
            Powitanie();
            Dodawanie(3,4);
            Dodawanie(8,9);
            Dodawanie(8,9,20);
            Sumuj();
            Sumuj(1);
            Sumuj(7,3);
            Sumuj(7,7,3);
            Sumuj(7,7,3,3);
            iloczyn();
            iloczyn(2);
            iloczyn(7.1,3.7);
            iloczyn(2,7,8.1);
        }
        //funkcja bez argumentów
        static void Powitanie() // to jest funcja
        {
            Console.WriteLine("Witaj w programie funkcje cz.1");
        }
        // funkcja z argumentami
        static void Dodawanie(int a, int b)
        {
            Console.WriteLine("Wynik dodawanaia liczb: "+ a + " + " + b + " = "+ (a+b) );
        }
        //Mechanizm przeciążania funcji
        static void Dodawanie(int a, int b, int c)
        {
            Console.WriteLine("Wynik dodawanaia liczb: " + a + " + " + b + " + " + c + " = " + (a + b + c));
        }
        //zmienna ilość argumentów
        static void Sumuj(int a = 0, int b = 0, int c= 0, int d = 0)
        {
            Console.WriteLine("Suma = " + (a + b + c + d));
        }
        static void iloczyn(double x = 1, double y = 1, double z = 1)
        {
            double wynik = x * y * z;
            Console.WriteLine("Mnożenie = " + wynik);
        }
    }
}