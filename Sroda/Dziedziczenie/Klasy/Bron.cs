using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie.Klasy
{
    class Bron
    {
        public string Nazwa = "Bron";
        public int Damage = 0;
        public int Zasieg = 0;
        public int Zuzycie = 100;

        public Bron(string nazwa, int damage, int zasieg)
        {
            Nazwa = nazwa;
            Damage = damage;
            Zasieg = zasieg;
        }

        public int Atak(int hp)
        {
            Zuzycie--;
            if(Zuzycie < 0)
            {
                Console.WriteLine($"Bron {Nazwa} zepsuta");
            }
            return hp - Damage;
        }

        public virtual void NapiszKlasę()
        {
            Console.WriteLine("Jestem klasy Bron");
        }

        public override string ToString()
        {
            return $"Nazwa: {Nazwa}, Damage: {Damage}, Zasieg: {Zasieg}";
        }
    }
}
