using Dziedziczenie.Klasy; //możemy to wpisać ręcznie lub dodać używając ikonki żarówki lub alt + enter
using System;

namespace Dziedziczenie
{

    class Program
    {
        static void Main(string[] args)
        {
            //PisakTest();
            //FiguryTest();
            //StatyczneTest();

            /*
             * Zrobić parę broni m.in Pistolet, Karabin, Miecz
             * Klasy: Bron, Bron Palna, Bron Biała, Bron Palna
             * Wszystkie metody powinny być zoptymalizowane -
             * - jeżeli jakaś metoda w Pistolecie może być w broni, to ma być w broni
             * każda ma mieć toString
             * przykład - AK47 : BronAutomatyczna : BronPalna : BronDystansowa: Bron
             * /tutaj miałem problem
             */
        }

        private static void PisakTest()
        {
            Pisak pisak1 = new Pisak("Czerwony", 0.4f);

            Pisak pisak2 = new Pisak("Niebieski", 0.4f, 9.99m);

            Pisak pisak3 = new Pisak("Czarny", 0.8f, 2.50m);
            //dalej możemy zmieniać wartości zmiennych, ale teraz już nie musimy
            pisak3.Kolor = "Różowy";
            pisak3.Grubosc = 0.8f;
            pisak3.Cena = 2.50m;

            pisak1.WypiszInformacje();
            pisak2.WypiszInformacje();
            pisak3.WypiszInformacje();
        }

        private static void FiguryTest()
        {
            Kwadrat kwadrat = new Kwadrat("Kwadracik", "Niebieski", 2);
            Kolo kolo = new Kolo("Kółeczko", "Różowe", 1);
            Trojkat trojkat = new Trojkat("Trójkącik", "Zielony", 2, 4);
            Prostokat prostokat = new Prostokat("Prostokącik", "Pomarańczowy", 2, 4);

            Console.WriteLine(kwadrat.Pole());
            Console.WriteLine(kolo.Pole());
            Console.WriteLine(trojkat.Pole());
            Console.WriteLine(prostokat.Pole());
        }

        private static void StatyczneTest()
        {
            Osoba.WyswietlLicznikOsob();
            Osoba osoba1 = new Osoba("Jan", "Kowalski");
            Osoba.WyswietlLicznikOsob();
            Osoba osoba2 = new Osoba("John", "Smith");
            Osoba.WyswietlLicznikOsob();
            Osoba osoba3 = new Osoba("Kamil", "Nowak");
            Osoba.WyswietlLicznikOsob();

            Osoba.LicznikOsób = 0;
            Osoba.WyswietlLicznikOsob();

            Console.WriteLine(Matematyka.Potega(3, Matematyka.pi));
        }
    }
}
