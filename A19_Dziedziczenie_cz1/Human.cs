using System;
namespace A19_Dziedziczenie_cz1
{
    abstract class Human : Organizm
    {
        public void Oddychanie()
        {
            Console.WriteLine("Do oddychania używa płuc.");
        }
    }
}
