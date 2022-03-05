using System;

namespace A20_Dziedziczenie_cz2
{
    sealed class Cysterna : Lory //sealet pieczętuje kasle 
    {
        public Cysterna(string paliwo, int ile_paliwa, int pojemnosc) : base(paliwo, ile_paliwa)
        {
            this.pojemnosc = pojemnosc;
        }
        public override void Ruch() //przesłonięcie motody funkc. w klasie Lory
        {
            base.Ruch();
            Console.WriteLine("Jazda cysterny");
        }
        public int pojemnosc;
    }
}
