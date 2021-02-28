using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie.Klasy
{
    class Trojkat
    {
        public string Nazwa;
        public string Kolor;
        public double Bok;
        public double Wysokosc;

        public Trojkat(string nazwa, string kolor, double bok, double wysokosc)
        {
            Nazwa = nazwa;
            Kolor = kolor;
            Bok = bok;
            Wysokosc = wysokosc;
        }

        public double Pole()
        {
            return Bok * Wysokosc / 2;
        }
    }
}
