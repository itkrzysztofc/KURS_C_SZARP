// A26_rekurencja
using System;
using System.IO;
using System.Diagnostics;

namespace A26_rekurencja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj zakres dla obliczanego ciągu n = ");
            String zakres = Console.ReadLine();
            int n = Int32.Parse(zakres);
            //Console.WriteLine(n*2);
            string plik = @"rekurencja.txt";
            StreamWriter sw;
            if (!File.Exists(plik))
            {
                sw = File.CreateText(plik);
                Console.WriteLine("Plik został utworzony");
                sw.Close();
            }
            sw = new StreamWriter(plik, true);
            Console.WriteLine("Plik został otwarty do użycia");
            Stopwatch t = new Stopwatch();
            t.Start();
            // wywołanie zdarzenia
            SilniaRek(n);
            t.Stop();
            Console.WriteLine("!" + n + " = " + SilniaRek(n) + " Czas: " + t.ElapsedTicks);
            sw.WriteLine("!" + n + " = " + SilniaRek(n) + " Czas: " + t.ElapsedTicks);
            Stopwatch t2 = new Stopwatch();//można użyć ponownie 't' bez tworzenia nowej zmiennej
            t2.Start();
            Silnia(n);
            t2.Stop();
            Console.WriteLine("!" + n + " = " + Silnia(n) + " Czas: " + t2.ElapsedTicks);
            sw.WriteLine("!" + n + " = " + Silnia(n) + " Czas: " + t2.ElapsedTicks);
            sw.Close();

            static long Silnia(int n)
            {
                long wynik = 1;
                while (n > 1)
                {
                    wynik *= n;
                    n--;
                }
                return wynik;
            }
            static long SilniaRek(int n)
            {
                if (n <= 1)
                {
                    return 1;
                }
                else
                {
                    return SilniaRek(n - 1) * n;
                }
            }
        }
    }
}