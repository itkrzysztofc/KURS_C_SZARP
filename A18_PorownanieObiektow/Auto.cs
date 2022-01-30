using System;

namespace A18_PorownanieObiektow
{
    public class Auto : IComparable
    {
        public string Model { get; set; }
        public int Rocznik { get; set; }
        public Auto(string Model, int Rocznik)
        {
            this.Model = Model;
            this.Rocznik = Rocznik;
        }
        //rozbudowa klasy w celu porównania włąściwości abiektów
        /*
        public bool Equals(Auto auto) 
        { 
            return auto.Model == this.Model && auto.Rocznik == this.Rocznik; 
        }
        */
        public int CompareTo(object obj)
        {
            var argumentSortowany = (Auto)obj;
            if (Rocznik < argumentSortowany.Rocznik) return 1;
            else if (Rocznik == argumentSortowany.Rocznik) return 0;
            else return -1;
        }

    }
}
