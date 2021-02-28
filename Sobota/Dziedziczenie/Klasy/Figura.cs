using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie.Klasy
{
    abstract class Figura
    {
        public string Nazwa;
        public string Kolor;
        // alt + enter → generuj konstruktor → enter
        public Figura(string nazwa, string kolor)
        {
            Nazwa = nazwa;
            Kolor = kolor;
        }

        //override - nadpisywanie
        public override string ToString()
        {
            return $"{Nazwa} jest koloru {Kolor}";
        }
    }
}
