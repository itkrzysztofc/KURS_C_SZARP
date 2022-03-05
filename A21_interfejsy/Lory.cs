using System;

namespace A21_interfejsy
{
    public class Lory : Object, iTrasa
    {
        public Lory(string nazwa, int ile_paliwe)
        {
            this.nazwa = nazwa;
            this.ile_paliwa = ile_paliwa;
        }
        public string nazwa;
        public int ile_paliwa;

        public void Jazda(int cel)
        {
            Console.WriteLine("Jazda do celu." + cel);
        }

        public void nazwa_pojazdu()
        {
            Console.WriteLine(nazwa);
        }

        public void Jazda(string cel)
        {
            Console.WriteLine(cel);
        }

        public void Tankowanie(int tankowanie)
        {
            Console.WriteLine("Tankowanie" + tankowanie);
        }

        public void Powrot(int doBazy)
        {
            Console.WriteLine("Do bazy" + doBazy);
        }
    }
}
