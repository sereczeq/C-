using System;
using System.Collections.Generic;
using System.Text;

namespace Dziedziczenie.Klasy
{
    class Wojownik : Hero
    {
        public int Obrona;
        public Wojownik(string nazwa, int hp, int damage, int obrona) : base(nazwa, hp, damage)
        {
            Obrona = obrona;
        }

        //override po to żeby uwzględnić obronę wojownika
        public override void OdejmijHP(int Atak)
        {
            //obie linijki robią to samo
            base.OdejmijHP(Atak - Obrona);
            //Hp -= Atak - Obrona;
        }

        public override string WyswietlStatystyki()
        {
            return base.WyswietlStatystyki() + $", Obrona: {Obrona}";
        }
    }
}
