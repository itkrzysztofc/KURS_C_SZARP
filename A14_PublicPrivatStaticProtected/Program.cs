// A14_PublicPrivatStaticProtected
using System;

namespace A14_PublicPrivatStaticProtected
{
    class Program : A
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Komis.stanKomisu);//no problem - static
            //Console.WriteLine(Pojazd.kolor);//problem - no static - nie zadziałą
            Pojazd pojazd = new Pojazd();
            Console.WriteLine(pojazd.kolor);
            Komis.stanKomisu = 100;
            Console.WriteLine(Komis.stanKomisu);
            // privat
            Box box1 = new Box();
            //Console.WriteLine(box1.dlugosc);//to nie zadziała
            box1.PodajDlugosc(5.5);
            box1.PodajSzerokosc(4.3);
            box1.PodajWyskosc(2.1);
            double obj1 = box1.Objetosc();
            Console.WriteLine(box1.Objetosc());
            Console.WriteLine(obj1);
            Console.ReadKey();//oczekiwanie na dowolny klawisz
            //protected ???
            A a = new A();
            //Console.WriteLine(A.x);
            Console.ReadKey();  
        }
        internal class A
        {
            protected int x = 773;
        }
    }
}
