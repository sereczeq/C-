using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie.Klasy
{
    class Osoba
    {
        public static int LicznikOsób = 0;

        public string Imie;
        public string Nazwisko;

        public Osoba(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            LicznikOsób++;
            Console.WriteLine($"Stworzono osobę: {Imie}  {Nazwisko}.");
        }

        public static void WyswietlLicznikOsob()
        {
            Console.WriteLine($"Aktualnie stworzono {LicznikOsób} osób");
        }
    }
}
