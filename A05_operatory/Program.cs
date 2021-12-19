// Operatory
using System;
namespace A05_operatory
{
    class Program
    {
        static void Main(string[] args)
        {
            ////// operatory arytmetyczne
            int i = -8;
            i++; //inkrementacja i=i+1  i+=1
            Console.WriteLine(i);
            i--; //dekrementracj i=i-1  i-=1
            Console.WriteLine(i);
            float f = 2.4f;
            Console.WriteLine(f+i);// +
            Console.WriteLine(f-i);// -
            Console.WriteLine(f*i);// *
            Console.WriteLine(f/i);// /
            Console.WriteLine(f%i);// % reszta z dzielenia całkowityego
            for (int j=i; j>0;j--)
            {
                Console.WriteLine(f % j);
            }
            //////kolejność wykjonywania operatorów
            Console.WriteLine(2+2*2); //6
            Console.WriteLine((2+2)*2); //8
            //Console.WriteLine((2+2)/0); //nie wolno dzielić przez 0
            
            /////operatory porównania
            Console.WriteLine(7.0f < 8.0);
            Console.WriteLine(7.0f > 8.0);
            Console.WriteLine(7.0f == 8.0);
            Console.WriteLine(7.0f <= 8.0);
            Console.WriteLine(7.0f <= 8.0);

            /////operatory logiczne
            bool b = false;
            Console.WriteLine(!b); //negacja
            Console.WriteLine(!true); //negacja
            bool c = true;
            Console.WriteLine(c & b); //AND - false
            Console.WriteLine(c ^ b); //OR  - true
            Console.WriteLine(c | b); //OR  - true
            Console.WriteLine(c && b); //AND
            Console.WriteLine(c || b); //OR

            //////// operatory bitowe
            uint d = 8;
            Console.WriteLine(Convert.ToString(~d));//dopełnienie nbitowe do max.uint
            Console.WriteLine(d<<1);//przesunięcie bitowe w lewo
            Console.WriteLine(d>>1);//przesunięcie bitowe w prawo
        }
    }
}
