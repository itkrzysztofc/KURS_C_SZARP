//sytuacja 4.
using System;

namespace A23_wyjatki
{
    public class DividedByEightException : Exception
    {
        public DividedByEightException(string message) : base(message)
        {
            Console.WriteLine("Osiem to nie jest właściwa liczba. ");
        }
    }
}
