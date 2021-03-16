using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie.Klasy
{
    class Mag : Hero
    {
        public int Power;
        public Mag(string nazwa, int hp, int damage, int moc) : base(nazwa, hp, damage)
        {
            Power = moc;
        }

        //override po to żeby uwzględnić moc maga, domyślnie zwraca po prostu damage
        public override int PobierzSileAtaku()
        {
            //obie linijki robią to samo
            return Damage + Power;
            //return base.PobierzSileAtaku() + Power;
        }

        public override string WyswietlStatystyki()
        {
            return base.WyswietlStatystyki() + $", Moc: {Power}";
        }
    }
}
