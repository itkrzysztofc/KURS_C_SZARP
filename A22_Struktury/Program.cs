using System;
namespace A22_Struktury
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Użycie struktury
            //Odcinek dlugosciXY;
            //dlugosciXY.x = 1;
            //dlugosciXY.y = 1;

            //2. użycie konstruktora
            Odcinek odcinek = new Odcinek(2,5);
            Odcinek odcinek2;
            odcinek2 = odcinek;
            odcinek2.x = 8;
            Console.WriteLine("X = " + odcinek.x);
            Console.WriteLine("Y = " + odcinek.y);
            Console.WriteLine("a: " + odcinek.odcinek()) ;
            Console.WriteLine("X = " + odcinek2.x);
            Console.WriteLine("Y = " + odcinek2.y);
            Console.WriteLine("a: " + odcinek2.odcinek());
        }
    }
}
