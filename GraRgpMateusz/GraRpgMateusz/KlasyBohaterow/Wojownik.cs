using System;
using System.Collections.Generic;
using System.Text;

namespace GraRpgMateusz.KlasyBohaterow
{
    class Wojownik : Hero
    {
        //10

        public Wojownik(int hp, string nazwa, int atak, int obrona, int lvl) : base(hp, nazwa, atak, obrona) { }
        //11
        public override void OdejmijHp(int atak)
        {
            Hp -= (atak - Obrona / 3);
        }
    }
}
