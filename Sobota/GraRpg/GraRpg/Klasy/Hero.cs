using System;

namespace GraRpg.Klasy
{
    public abstract class Hero
    {
        public int Hp;

        public string Nazwa;

        public int Atak;

        public Hero(string nazwa, int hp, int atak)
        {
            Nazwa = nazwa;
            Hp = hp;
            Atak = atak;
        }

        public virtual void OdejmijHp(int atak)
        {
            Hp -= atak;
        }

        public virtual int PobierzSileAtaku()
        {
            return Atak;
        }

        public void WyswietlStatystyki()
        {
            Console.WriteLine($"Postać {Nazwa} posiada {Hp} życia i {Atak} ataku.");
            Console.WriteLine();
        }
    }
}
