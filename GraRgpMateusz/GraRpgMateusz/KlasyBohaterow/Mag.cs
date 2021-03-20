using System;
using System.Collections.Generic;
using System.Text;

namespace GraRpgMateusz.KlasyBohaterow
{
    class Mag : Hero
    {
        public int Moc;

        //13
        public Mag(int hp, string nazwa, int atak, int moc, int lvl) : base(hp, nazwa, atak, 0)
        {
            Moc = moc;
        }
        public override int PobierzSileAtaku()
        {
            return Atak + (Moc / 5);
        }

        public override string Statystyki()
        {
            return base.Statystyki() + "\n" +
                $"{Moc}\t mocy";
        }
    }
}
