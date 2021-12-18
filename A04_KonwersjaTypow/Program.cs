// 04. konwersja danych/typow
using System;
namespace A04_KonwersjaTypow
{
    class Program
    {
        static void Main(string[] args)
        {
            //liczby całkowite
            int i = int.MaxValue; Console.WriteLine(i);
            short s = short.MaxValue; Console.WriteLine(s);
            int j = s+1; Console.WriteLine(j);
            short k = (short)i; //duża wartość nie może być wpisana do mniejszego typu - rzutowanie jawne = przekroczenie zakresu
            Console.WriteLine(k);
            //liczby zmiennoprzecinkowe
            float x = float.MaxValue;
            Console.WriteLine(x);
            double y = x;
            Console.WriteLine(y);
            //float z = double.MaxValue; //niewykonalne
            float z = (float)double.MaxValue; //rzutowanie jawne
            Console.WriteLine(z);
            float w = 8.8f;
            int a = (int)w; Console.WriteLine(a);
            //stringi => int oraz int => string
            string zmienna = "10";
            Console.WriteLine(zmienna); //to jest tekst
            int b = int.Parse(zmienna)*2;
            Console.WriteLine(b);
            string c = b.ToString(); Console.WriteLine(c);
            //przykłady
            Console.WriteLine((int)(b*5.67f));
            Console.WriteLine(b*5.67f);
            Console.WriteLine((float)b*5.67f);
            Console.WriteLine((b*5.67f).ToString());
            //przykład 2
            string tekst = Console.In.ReadLine();
            Console.WriteLine(tekst);
            //int d = int.Parse(tekst);
            float d = float.Parse(tekst);
            Console.WriteLine(d);
        }
    }
}
