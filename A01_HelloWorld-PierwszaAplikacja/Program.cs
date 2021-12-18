// Beginier A01 

using System;

namespace A01_HelloWorld{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // c++ cout << "Hello World!" << endl;
            Console.WriteLine("Podaj swoje imie");
            string imie;
            imie = Console.In.ReadLine();
            if(imie.Length == 0)
            {
                Console.Error.WriteLine("Nie wprowadzono żadnego imienia!!!");
                return;
            }
            Console.WriteLine("Podałeś/łaś swoje imie: " + imie + " o długości "+ "Podałeś/łaś swoje imie: " + imie.Length);
            /* cout << "Podałeś/łaś swoje imie: " << imie; */
        }
    }
}