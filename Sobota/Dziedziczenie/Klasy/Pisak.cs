using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie.Klasy
{
    class Pisak
    {
        public string Kolor = "Czarny";
        public float Grubosc = 0.4f;
        public decimal Cena = 5.0m;


        //konstruktor - czyli metoda która przypisuje wartość w momencie tworzenia obiektu
        public Pisak(string kolor, float grubosc, decimal cena)
        {
            Kolor = kolor;
            Grubosc = grubosc;
            Cena = cena;
            Console.WriteLine("Konstruktor z 3 argumentami");
        }

        //overloading - przeciążanie
        public Pisak(string kolor, float grubosc)
        {
            Kolor = kolor;
            Grubosc = grubosc;
            Console.WriteLine("Konstruktor z 2 argumentami");
        }
        public Pisak(decimal cena)
        {
            Cena = cena;
            Console.WriteLine("Konstruktor z 1 argumentami");
        }

        public void WypiszInformacje()
        {
            // "\n" to inaczej po prostu Enter
            Console.WriteLine($"Informacje o pisaku:\nKolor {Kolor}\nGrubość {Grubosc}\nCena {Cena}\n");

            //Można też napisać w ten ↓ sposób, jak kto woli :D
            //Console.WriteLine("Informacje o pisaku:");
            //Console.WriteLine($" Kolor: {Kolor}");
            //Console.WriteLine($" Grubosc: {Grubosc}");
            //Console.WriteLine($" Cena: {Cena} zł");
            //Console.WriteLine();
        }
    }
}
