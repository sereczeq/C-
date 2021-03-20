using GraRpgMateusz.KlasyBroni.Lucznik;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraRpgMateusz.KlasyBohaterow
{
    class Lucznik : Hero
    {
        public int Krwawienie;
        public Lucznik(int hp, string nazwa, int atak, int obrona, int krwawienie) : base(hp, nazwa, atak, obrona)
        {
            Krwawienie = krwawienie;
        }
        public override int PobierzSileAtaku()
        {
            return Atak + Bron.Atak + (Krwawienie + Bron.Krwawienie) / 2;
        }
        public override void OdejmijHp(int atak)
        {
            Hp -= atak;
        }
        public override string Statystyki()
        {
            int przebiciePancerza = 0;
            if(Bron is BronLucznika)
            {
                przebiciePancerza = (Bron as BronLucznika).PrzebiciePancerza;
            }
            return base.Statystyki() + "\n" +
                $"{Krwawienie} + {Bron.Krwawienie}\t zadawanego krwawienia \n" +
                $"{przebiciePancerza}\t przebicia pancerza";
        }
    }
}
