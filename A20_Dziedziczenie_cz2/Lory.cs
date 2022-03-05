using System;

namespace A20_Dziedziczenie_cz2
{
    public class Lory
    {
        public Lory(string paliwo, int ile_paliwa)
        {
            this.paliwo = paliwo;
            this.ile_paliwa = ile_paliwa;
        }
        public virtual void Ruch()
        {
            Console.WriteLine("Jazda");
        }
        public string paliwo;
        public int ile_paliwa;
    }
}
