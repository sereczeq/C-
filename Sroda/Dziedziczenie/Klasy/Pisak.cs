using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie.Klasy
{
    class Pisak
    {
        private string Kolor = "Domyślny";
        private float Grubosc = 0.5f;
        private decimal Cena = 2.99m;

        public Pisak(string kolor, float grubosc, decimal cena)
        {
            Kolor = kolor;
            Grubosc = grubosc;
            Cena = cena;
            Console.WriteLine("konstruktor z 3 argumentami");
        }

        public Pisak(string kolor, float grubosc)
        {
            Kolor = kolor;
            Grubosc = grubosc;
            Console.WriteLine("konstruktor z 2 argumentami");
        }

        public Pisak(float grubosc, decimal cena)
        {
            Grubosc = grubosc;
            Cena = cena;
        }

        public void WypiszInformacje()
        {
            // "\n" to inaczej Enter (n - new line)
            Console.WriteLine($"Pisak:\nKolor: {Kolor},\nGrubość: {Grubosc},\nCena: {Cena}\n");
            //Console.WriteLine("Informacje o pisaku:");
            //Console.WriteLine($" Kolor: {Kolor}");
            //Console.WriteLine($" Grubosc: {Grubosc}");
            //Console.WriteLine($" Cena: {Cena} zł");
            //Console.WriteLine();
        }
    }
}
