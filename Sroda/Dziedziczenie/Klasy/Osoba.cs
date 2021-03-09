using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie.Klasy
{
    class Osoba
    {
        public static int IloscOsob;

        public string Imie;
        public string Nazwisko;

        public Osoba(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            IloscOsob++;
        }

        public override string ToString()
        {
            return Imie + " " + Nazwisko + $", Ilość osób: {IloscOsob}";
        }
    }
}
