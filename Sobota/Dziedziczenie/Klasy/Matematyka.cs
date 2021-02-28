using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie.Klasy
{
    class Matematyka
    {
        public static double pi = 3.14;
        public static double pierwiastekZDwóch = 1.41421356237;

        public static double Potega(double liczba, double potega)
        {
            double wynik = liczba;
            for(int i = 0; i < potega; i++)
            {
                wynik *= liczba;
            }
            return wynik;
        }

        public static double Dodawanie(double liczba1, double liczba2)
        {
            return liczba1 + liczba2;
        }
    }
}
