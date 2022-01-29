// Operacje na stringach - czyli na tekście
using System;
// dodane w punkcie 3.
using System.Text;
//dodane w pkt. 4.
using System.Diagnostics;

namespace A15_OperacjeNaStringach
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            Console.WriteLine(MojTekst("Witaj #0 #1 #2 #3 #4", "nowy", "parametr:", 8, 22.2, "BRAWO!!!"));
            //2. 
            int ile = 50000; //liczba do porównania
            Console.WriteLine(DrugiTekst(ile));
            //3.
            Console.WriteLine(TrzeciTekst(ile));
            //4. Porównanie metod/funkcji
            Stopwatch czas = new Stopwatch();
            czas.Reset();
            czas.Start();
            DrugiTekst(ile);
            czas.Stop();
            Console.WriteLine("Czas zmierzony metodą z konkatenacją: {0} ms",czas.ElapsedMilliseconds);
            czas.Reset();
            czas.Start();
            TrzeciTekst(ile);
            czas.Stop();
            Console.WriteLine("Czas zmierzony metodą z buliderem: {0} ms", czas.ElapsedMilliseconds);

        }
        //1. Przekazywanie argumentów do funkcji
        public static string MojTekst(string tekst, params object[] args)
        {
            /* sprawdfzenie czy wszystkie dane są przekazane do funkcji
                Console.WriteLine(tekst);
                Console.WriteLine(args[0].ToString());
                Console.WriteLine(args[1].ToString());
                Console.WriteLine(args[2].ToString());
                Console.WriteLine(args[3].ToString());
                Console.WriteLine(args.Length);//sprawdzenie ilości argumentów
            */
            for (int i = 0; i < args.Length;i++)
            {
                tekst = tekst.Replace("#"+i,args[i].ToString());
            }
            return tekst;
        }
        //2. Tradycyjna funkcja
        public static string DrugiTekst(int ile)
        {
            string tekst = "";
            for(int i=0; i < ile; i++)
            {
                tekst += i+" ";
            }
            return tekst;
        }
        //3. Przy użyciu konstruktora buildera
        public static string TrzeciTekst(int ile)
        {
            string tekst = "";
            StringBuilder budowanyString = new StringBuilder();
            for(int i = 0; i < ile; i++)
            {
                budowanyString.Append(i + " ");
            }
            tekst = budowanyString.ToString();
            return tekst;
        }
    }
}
