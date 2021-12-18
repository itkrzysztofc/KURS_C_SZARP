// A03 Pętle Lekcja 3
using System;
namespace A03_instrukcjeSterujacew
{
    class Program
    {
        static void Main(string[] args)
        {
            //////1. IF
            Console.WriteLine("Podaj liczbe");
            string liczba;
            liczba = Console.ReadLine();
            //Console.WriteLine(liczba);
            int a = int.Parse(liczba);//konwersja typu string na int
            float b = float.Parse(liczba);//konwersja typu string na float
            System.Console.WriteLine(a*2 + " " + b*2 );
            //warunek bool
            bool c = a > 0;
            if (c)
            {
                System.Console.WriteLine("a jest dodatnie");
            }
            //////2. IF.. ELSE
            if (c)
            {
                System.Console.WriteLine("a jest dodatnie");
            } else
            {
                System.Console.WriteLine("a nie jest dodatnie. Jest ujemne.");
            }
            ///////3. IF..ELSE IF..ELSE
            if (c)
            {
                System.Console.WriteLine("a jest dodatnie");
            }
            else if (a<b)
            {
                System.Console.WriteLine("a nie jest dodatnie. Jest ujemne.");
            }
            else
            {
                System.Console.WriteLine("Są takie same");
            }
            //////4. WHILE
            int n = 10;
            int[] tab1 = new int[n]; //konstruktor tablicy
            int[] tab2 = new int[n];
            int i = 0;
            int j = n-1;
            while (i < n)
            {
                tab1[i] = i;
                tab2[j] = j;
                Console.WriteLine(tab1[i] + " " + tab2[j]);
                i++;
                j--;
            }
            //////5. Do..While
            i = 0;
            do
            {
                Console.WriteLine("Kris");
                i++;
            } while (false);
            ///////6. FOR
            for (i = 0; i < n; i++)
            {
                Console.Write(i + " ");
            }
            ////7. Switch..Case
            switch (a)
            {
                case 0: 
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("Jedynka");
                    break;
                default: 
                    Console.WriteLine("To nie 1 ani nie 0");
                    break;
            }
        }
    }
}