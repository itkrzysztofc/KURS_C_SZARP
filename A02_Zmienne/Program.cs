// Lekcja 2 Zmienne
using System;
namespace A02_zmienne{
    static class Konst
    {
        public const double Pi = 3.14159;
    }
    public static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zmienne w C#");
            Console.WriteLine(Konst.Pi);
            // zmienna boolowska
            bool zm1 = true; Console.WriteLine(zm1);
            bool zm2 = false; Console.WriteLine(zm2);
            //zmienne całkowite
            byte zm3 = byte.MaxValue; Console.WriteLine(zm3);
            int zm4 = int.MaxValue; Console.WriteLine(zm4);
            uint zm5 = uint.MaxValue; Console.WriteLine(zm5);            
            short zm7 = short.MaxValue; Console.WriteLine(zm7);
            ushort zm8 = ushort.MaxValue; Console.WriteLine(zm8);
            long zm6 = long.MaxValue; Console.WriteLine(zm6);
            ulong zm9 = ulong.MaxValue; Console.WriteLine(zm9);
            //zmiennoprzecinkowe
            float zm10 = 1.5f; Console.WriteLine(zm10);
            double zm11 = 1.5; Console.WriteLine(zm11);
            Console.WriteLine("float-min: "+ float.MinValue);
            Console.WriteLine("float-max: "+ float.MaxValue);
            Console.WriteLine("double-min: " + double.MinValue);
            Console.WriteLine("double-max: " + double.MaxValue);
            //zmienne znakowe
            char zm12 = '#'; Console.WriteLine(zm12);
            string zm13 = "To jest napis."; Console.WriteLine(zm13);
            //zmenna tablicowa
            int[] zm14 = { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine(zm14[5]);
            for(int i=0; i<zm14.Length; i++)
            {
                Console.Write(zm14[i] + " ");
            }
        }
    }
}

