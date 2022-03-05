using A19_Dziedziczenie_cz1;
using System;

namespace A_19_Dziedziczenie_cz1
{
    class Program
    {
        static void Main(string[] args)
        {
            //tworzymy obiekty i wykorzystujemy metody opisane w innyuch klasach
            //Organizm organizm = new Organizm();//nie zadziałą
            //organizm.Organ = "Płuca";
            //Console.WriteLine(organizm.Organ);
            //Human human = new Human(); //nie zadziałą
            Czynnik czynnik1 = new Czynnik();
            czynnik1.Stan();
            czynnik1.Oddychanie();
            czynnik1.Atmosfera();
            Morskie ryby = new Morskie();
            ryby.Stan();
            ryby.Woda();
            //ryby.Oddychanie();// nie zadziała
        }
    }
}
