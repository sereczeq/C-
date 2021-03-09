namespace GraRpg.Klasy
{
   public class Wojownik : Hero
   {
      public int Obrona;
      public bool broniSie = false;

      public Wojownik(string nazwa, int hp, int atak, int obrona)
         : base(nazwa, hp, atak)
      {
         Obrona = obrona;
      }

        //ile hp mam odjąc sobie
      public override void OdejmijHp(int atak)
      {
         if (broniSie) atak = atak / Obrona;
         else Hp -= atak;
      }

      public void BronSie()
        {
            broniSie = true;
        }
        public void NieBronSie()
        {
            broniSie = false;
        }
   }
}
