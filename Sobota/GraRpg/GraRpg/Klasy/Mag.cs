namespace GraRpg.Klasy
{
   public class Mag : Hero
   {
      public int Moc;

      public Mag(string nazwa, int hp, int atak, int moc)
         : base(nazwa, hp, atak)
      {
         Moc = moc;
      }

      public override int PobierzSileAtaku()
      {
         return Atak + (Moc / 5);
      }
   }
}
