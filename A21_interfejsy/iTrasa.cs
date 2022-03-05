using System;

namespace A21_interfejsy
{
    public interface iTrasa
    {
        void Jazda(int cel);
        void Jazda(string cel);
        void Tankowanie(int tankowanie);
        void Powrot(int doBazy);
    }
}
