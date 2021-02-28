using Dziedziczenie.Klasy;
using System;

namespace Dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pisak pisak1 = new Pisak("Czerwony", 0.4f, 12.49m);

            //Pisak pisak2 = new Pisak(0.6f, 2.99m);

            //Pisak pisak3 = new Pisak("Różowy", 1f);

            //pisak1.WypiszInformacje();
            //pisak2.WypiszInformacje();
            //pisak3.WypiszInformacje();

            //Pistolet pistolet = new Pistolet("Pistolet",10, 500, 5);
            //Miecz miecz = new Miecz("Miecz", 200, 3, true);

            //pistolet.WypiszInformacje();
            //miecz.WypiszInformacje();

            //int hpPrzeciwnika = 50;
            //hpPrzeciwnika = pistolet.Atak(hpPrzeciwnika);
            //Console.WriteLine(hpPrzeciwnika);
            //hpPrzeciwnika = miecz.Atak(hpPrzeciwnika);
            //Console.WriteLine(hpPrzeciwnika);

            int przeciwnik = 100;
            Miecz miecz = new Miecz("Miecz", 30, 3, true);

            //pętla gry
            while(true)
            {
                Console.WriteLine("HP przeciwnika to: " + przeciwnik);
                Console.WriteLine("Czy chcesz atakować? (T/N)");
                string odpowiedz = Console.ReadLine();
                if(odpowiedz == "T")
                {
                    przeciwnik = miecz.Atak(przeciwnik);
                    Console.WriteLine("Zaatakowałes zaatakowałeś");
                }
                else if(odpowiedz == "N")
                {
                    Console.WriteLine("Nie zaatakowałeś");
                }
                else if(odpowiedz == "esc")
                {
                    break;
                }

                if(przeciwnik < 0)
                {
                    Console.WriteLine("przciwnik pokonany");
                    break;
                }

            }
            Console.WriteLine("Koniec Gry");


        }
    }
}
