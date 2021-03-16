using Dziedziczenie.Klasy;
using System;
using System.Collections.Generic;

namespace Dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            //PisakTest();
            //Dziedziczenie();
            //ToStringTest();
            //StatyczneTest();
            /*
             * Zadanie: Napisać program konsolowy, który będzie prosił użytkownika o podawanie
                kolejno liczb całkowitych, zapisywał je w tablicy i wyświetlał za każdym razem
                zawartość tablicy i średnią podanych liczb. Dodać metodę ZamienNaTekst, która
                przyjmie tablicę i zwróci ją w postaci tekstu: [el1, el2, el3].
             */

            Wojownik gracz = new Wojownik("Jan", 100, 15, 5);
            Mag mag = new Mag("Gandalf", 50, 20, 3);
            Console.WriteLine(gracz.WyswietlStatystyki());
            Console.WriteLine(mag.WyswietlStatystyki());

            //gracz atakuje maga:
            mag.OdejmijHP(gracz.PobierzSileAtaku());
            // \/
            mag.OdejmijHP(15);
            // \/
            mag.Hp -= 15;

            //mag atakuje grazcz:
            gracz.OdejmijHP(mag.PobierzSileAtaku());
            // Damage + Moc
            // Atak - Obrona















            //Tablice();
            //Listy();

        }

        private static void Listy()
        {
            List<int> lista = new List<int>();
            for(int i = 0; i < 100; i++)
            {
                lista.Add(i);
            }
        }

        private static void Tablice()
        {
            int[] tablica = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Podaj {i + 1}-tą liczbę");
                tablica[i] = int.Parse(Console.ReadLine());
                Console.WriteLine(WypiszTablice(tablica));
                Console.WriteLine($"Średnia podanych liczb to: {PoliczSrednia(tablica)}");

            }
        }

        private static float PoliczSrednia(int[] tablica)
        {
            float suma = 0;
            for(int i = 0; i < 5; i++)
            {
                suma += tablica[i];
            }
            return suma / 5;
        }

        private static string WypiszTablice(int[] tablica)
        {
            string returnString = "[";
            for (int i = 0; i < 5; i++)
            {
                returnString += tablica[i] + ", ";
            }
            return returnString + "]";
        }

        private static void StatyczneTest()
        {
            Osoba jan = new Osoba("Jan", "Kowalski");
            Console.WriteLine(jan.ToString());

            Osoba kamil = new Osoba("Kamil", "Nowak");
            Console.WriteLine(kamil.ToString());

            Osoba adam = new Osoba("Adam", "Kwiatkowski");
            Console.WriteLine(adam.ToString());

            Console.WriteLine(adam.ToString());
            Console.WriteLine(kamil.ToString());
            Console.WriteLine(jan.ToString());
        }

        private static void ToStringTest()
        {
            Bron bron = new Bron("bla", 0, 0);
            Bron bron1 = new Bron("bla", 0, 0);
            if (bron.ToString() == bron1.ToString())
            {
                Console.WriteLine("Są takie same");
            }

            Pistolet pistolet = new Pistolet("Pistolet", 10, 500, 5);
            Miecz miecz = new Miecz("Miecz", 200, 3, true);
            Console.WriteLine(miecz.ToString());
            Console.WriteLine(pistolet.ToString());
        }

        private static void Dziedziczenie()
        {
            Pistolet pistolet = new Pistolet("Pistolet", 10, 500, 5);
            Miecz miecz = new Miecz("Miecz", 200, 3, true);

            pistolet.WypiszInformacje();

            int hpPrzeciwnika = 50;
            hpPrzeciwnika = pistolet.Atak(hpPrzeciwnika);
            Console.WriteLine(hpPrzeciwnika);
            hpPrzeciwnika = miecz.Atak(hpPrzeciwnika);
            Console.WriteLine(hpPrzeciwnika);
        }

        private static void PisakTest()
        {
            Pisak pisak1 = new Pisak("Czerwony", 0.4f, 12.49m);

            Pisak pisak2 = new Pisak(0.6f, 2.99m);

            Pisak pisak3 = new Pisak("Różowy", 1f);

            pisak1.WypiszInformacje();
            pisak2.WypiszInformacje();
            pisak3.WypiszInformacje();
        }
    }
}
