using System;

namespace A22_Struktury
{
    public struct Odcinek
    {
        public Odcinek(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int x;
        public int y;
        public double odcinek()
        {
            return Math.Round(Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2)), 2);
        }
    }
}
