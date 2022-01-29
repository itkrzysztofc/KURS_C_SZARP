using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A16_Kolekcje
{
    public class Auto
    {
        public string Nazwa { get; set; }
        public Auto(string marka)
        {
            //Console.WriteLine(marka);
            Nazwa = marka;
        }
        //dodatkowa metoda pbsługująca nowe obiekty i zamieniająca wartości na tekst
        public override string ToString()
        {
            return Nazwa;
        }
        //metoda typu boolowskiego dot. pkt.2.
        internal bool PomalujPojazd(Auto auto) { return true; }
        internal int Cena(Auto auto) { return 1000; }
    }
}
