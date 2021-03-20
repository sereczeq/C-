using GraRpgMateusz.KlasyBroni;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraRpgMateusz.KlasyBohaterow
    {        //4
        class Hero
        {
            public int Hp;
            public string Nazwa;
            public int Atak;
        public int Obrona;
            public int Lvl;
            public int Pieniadze;
            public int PotkiNaLeczenie;
        public Bron Bron = new Bron("def", 0, 0, 0);

            //5
            public Hero(int hp, string nazwa, int atak, int obrona)
            {
                Hp = hp;
                Nazwa = nazwa;
                Atak = atak;
            Obrona = obrona;
            Lvl = Pieniadze = PotkiNaLeczenie = 0;
            }
            //6
            //public void Wyswietlstatystyki()
            //{
            //    Console.WriteLine(Hp);
            //    Console.WriteLine(Nazwa);
            //    Console.WriteLine(Atak);

            //}
            public virtual string Statystyki()
        {
            return $"{this.GetType().Name} {Nazwa}: \n" +
                $"{Hp}\t punktów życia \n" +
                $"{Atak} + {Bron.Atak}\t ataku \n" +
                $"{Obrona}\t obrony \n" +
                $"{Lvl}\t punktów doświadczenia \n" +
                $"{Pieniadze}\t pieniedzy \n" +
                $"{PotkiNaLeczenie}\t eliksirów leczenia";
        }
            //7
            public virtual void OdejmijHp(int atak)
            {
                Hp -= atak;
            }
            public virtual int PobierzSileAtaku()
            {
                return Atak + Bron.Atak;
            }

        public void DodajBron(Bron bron)
        {
            Bron = bron;

        }

        public void WypijPotke()
        {
            PotkiNaLeczenie--;
            Hp += 50;
        }
        }
    }