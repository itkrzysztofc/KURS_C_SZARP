using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A14_PublicPrivatStaticProtected
{
    internal class Box
    {
        private double dlugosc;//tylko wewn. klasy
        private double szerokosc;//tylko wewn. klasy
        private double wysokosc;//tylko wewn. klasy
        public void PodajDlugosc(double dl)
        {
            dlugosc = dl;
        }
        public void PodajSzerokosc(double sz)
        {
            szerokosc = sz;
        }
        public void PodajWyskosc(double wy)
        {
            wysokosc = wy;
        }
        public double Objetosc()
        {
            return dlugosc * szerokosc * wysokosc;
        }
    }
}
