using System;
using System.Collections.Generic;
using System.Text;

namespace GraRpgMateusz.KlasyBohaterow
{
    class Wlucznik : Lucznik
    {
        public Wlucznik(int hp, string nazwa, int atak, int obrona, int krwawienie): base(hp, nazwa, atak, obrona, krwawienie)
        {
        }
        public override void OdejmijHp(int atak)
        {
            Hp -= (atak - Obrona / 3);
        }
    }
}
