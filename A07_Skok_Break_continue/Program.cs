// A07 skoki  i kontynuacje 

using System;

namespace A07_Skok_Break_continue
{
    class Program
    {
        static void Main(string[] args)
        {
             //BREAK
             int a = 1;
            while (true)
            {
                if(a > 10) break;
                Console.Write(a + " ");
                a++;
            }
            Console.WriteLine("");
            //CONTINUE
            for(int i = 0; i < 10; i++)
            {
                if (i % 3 == 1)
                {
                    Console.WriteLine();
                    continue;
                    Console.WriteLine("Tu się nic nie wypisze");
                }
                Console.Write(i + " ");
            }
            Console.WriteLine();
        //skok GOTO
        etykieta1:
            Console.WriteLine("Jesteś pod etykietą nr.1");
            goto etykieta3;
        etykieta2:
            Console.WriteLine("Jesteś pod etykietą nr.2");
            goto koniec;
        etykieta3:
            Console.WriteLine("Jesteś pod etykietą nr.3");
            goto etykieta2;
        koniec:
            Console.WriteLine("Jesteś pod etykietą 'koniec'");
            return;
        }  
    }
}