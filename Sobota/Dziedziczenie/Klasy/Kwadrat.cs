using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie.Klasy
{
    class Kwadrat : Prostokat
    {
        public double Bok;

        public Kwadrat(string nazwa, string kolor, double bok) : base(nazwa, kolor, bok, bok)
        {
            Bok = bok;
        }
    }
}
