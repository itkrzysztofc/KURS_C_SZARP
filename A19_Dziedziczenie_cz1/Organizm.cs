using System;

namespace A19_Dziedziczenie_cz1
{
    abstract class Organizm
    {
        public string Organ { get; set; }
        public void Stan()
        {
            Console.WriteLine("Organizm zbudowany jest z organów.");
        }
    }
}
