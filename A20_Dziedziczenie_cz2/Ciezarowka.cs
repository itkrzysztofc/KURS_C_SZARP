//Dziedziczenie po klasie Cysterna
using System;

namespace A20_Dziedziczenie_cz2
{
    /*public class Ciezarowka : Cysterna
    {
        //nie potrafi dziedziczyć z klasy Cysterna
    }
    */

    public class Ciezarowka : Lory
    {
        public Ciezarowka(string paliwo, int ile_paliwa) : base(paliwo, ile_paliwa)
        {
        }
    }
}
