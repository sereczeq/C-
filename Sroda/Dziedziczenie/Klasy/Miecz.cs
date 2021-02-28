using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie.Klasy
{
    class Miecz : Bron
    {
        public bool JednoReczny = true;

        public Miecz(string nazwa, int damage, int zasieg, bool jednoReczny) : base(nazwa, damage, zasieg)
        {
            JednoReczny = jednoReczny;
        }

        public void WypiszInformacje()
        {
            Console.WriteLine($"Nazwa: {Nazwa}, Damage: {Damage}, Zagieg: {Zasieg}, Jednoreczny: {JednoReczny}");
        }
    }
}
