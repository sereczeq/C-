using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie.Klasy
{
    class Prostokat : Figura
    {
        public double BokA;
        public double BokB;

        public Prostokat(string nazwa, string kolor, double bokA, double bokB) : base(nazwa, kolor)
        {
            BokA = bokA;
            BokB = bokB;
        }

        public double Pole()
        {
            return BokA * BokB;
        }
    }
}
