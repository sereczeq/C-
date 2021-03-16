using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie.Klasy
{
    abstract class Hero
    {
        public string Name;
        public int Hp;
        public int Damage;

        public Hero(string name, int hp, int damage)
        {
            Name = name;
            Hp = hp;
            Damage = damage;
        }

        public virtual string WyswietlStatystyki()
        {
            return $"Nazwa: {Name}, Punkty życia: {Hp}, Atak: {Damage}";
        }

        public virtual int PobierzSileAtaku()
        {
            return Damage;
        }

        public virtual void OdejmijHP(int Atak)
        {
            Hp -= Atak;
        }
    }
}
