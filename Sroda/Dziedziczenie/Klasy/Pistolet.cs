using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie.Klasy
{
    class Pistolet : Bron
    {
        public int Magazynek = 18;

        public Pistolet(string nazwa, int damage, int zasieg, int magazynek) : base(nazwa, damage, zasieg)
        {
            Magazynek = magazynek;
        }
        public void WypiszInformacje()
        {
            Console.WriteLine($"Nazwa: {Nazwa}, Damage: {Damage}, Zagieg: {Zasieg}, Magazynek: {Magazynek}");
        }
    }
}
