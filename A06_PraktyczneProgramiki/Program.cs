// A06 Proste przykłady zastosowania wcześniejszych lekcji 

using System;

namespace A06_Programiki
{
    class Program
    {
        static void Main(string[] args)
        {
            string x, y;
            int wynik;
            string symbol;
            ////// 1. Wyświetlenie znaków
            Console.WriteLine("Podaj dwie liczby rozdzielone klawiszem <ENTER>");
            Console.Write("X = ");
            x = Console.ReadLine();
            Console.Write("Y = ");
            y = Console.ReadLine();
            Console.Write("Podaj symbol z lawiatury: ");
            symbol = Console.ReadLine();
            int x_i = int.Parse(x);
            int y_i = int.Parse(y);
            wynik = x_i * y_i;
            for(int i = 1; i <= wynik; i++)
            {
                Console.Write(symbol);
                if (i%x_i==0)
                {
                    Console.Write("\n");
                }
            }
            ///////2. Program zgadywanka
            //losowanie liczby
            Random los = new Random(); //obiekt stworzony konstruktorem na podstawie klasy Random
            int los1 = los.Next();//losowa
            Console.WriteLine(los1);
            int los2 = los.Next(1,101);
            Console.WriteLine(los2);
            int moja, licznik = 1;
            do
            {
                Console.Write("Podaj liczbę z zakresu: 1 .. 100: ");
                moja = int.Parse(Console.ReadLine());
                licznik++;
                Console.Clear();
                if(moja < los2)
                {
                    Console.WriteLine(moja + "to za mało.");
                } else if (moja > los2)
                {
                    Console.WriteLine(moja + "to za dużo.");
                }
            } while (los2 != moja);
            Console.WriteLine("Wylosowana liczba to: " + los2 + " została odgadnięta za: " + (licznik - 1) + " razem");
        }
    }
}