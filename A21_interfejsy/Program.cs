using System;
namespace A21_interfejsy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Lory L1 = new Lory("MAN", 500);
            iTrasa cel = (iTrasa)L1;
            cel.Jazda(256);
            cel.Jazda("Do celu");
            cel.Tankowanie(500);
            cel.Powrot(30);
            L1.nazwa_pojazdu();
        }
    }
}
