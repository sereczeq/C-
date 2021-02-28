using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie.Klasy
{
    class Kolo
    {
        public string Nazwa;
        public string Kolor;
        public double Promien;

        public Kolo(string nazwa, string kolor, double promien)
        {
            Nazwa = nazwa;
            Kolor = kolor;
            Promien = promien;
        }

        public double Pole()
        {
            return Promien * Promien * 3.14;
        }
    }
}
