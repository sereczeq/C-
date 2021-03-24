using GraRpgMateusz.KlasyBohaterow;
using GraRpgMateusz.KlasyBroni;
using System;

namespace GraRpgMateusz
{
    class Program
    {

        static void Main(string[] args)
        {

            Hero hero = StworzBohatera();
            Mag mag = StworzMaga();
            StworzBron(hero);

            //troszkę tekstu
            {
                Console.WriteLine(hero.Statystyki());
                Console.WriteLine($"Walczysz z magiem:\n{mag.Statystyki()}");
                Console.WriteLine("WALKA SIĘ ROZPOCZYNA");
                Console.WriteLine("naciśnij enter aby kontynuować");
                Console.ReadLine();
            }

            if (Walka(hero, mag))
            {
                DodajPieniadze(hero);
                OtworzSklep(hero);
            }
            else
            {
                KoniecGry(hero);
            }
            KoniecGry(hero);


        }

        private static void OtworzSklep(Hero hero)
        {
            if (hero.Pieniadze >= 10)
            {
                Console.WriteLine("jeśli chcesz otworzyć sklep naciśnij s");
                string aa = Console.ReadLine();
                if (aa == "s")
                {
                    Sklep(hero);
                }
            }
        }

        private static void Sklep(Hero hero)
        {
            Console.WriteLine("ilość twojego złota to {0}", hero.Pieniadze);
            Console.WriteLine("możesz kupić :");
            Console.WriteLine("1 - topór: atak + 4 , kosztuje 10 złota");
            Console.WriteLine("2 - tarcza: obrona + 9 , kosztuje 10 złota");
            Console.WriteLine("3 - potka na leczenie : od razu + 50 hp , kosztuje 10 złota");
            Console.WriteLine("4 - ulepszony topór: atak + 4 , obrona + 9,kosztuje 15 złota");
            Console.WriteLine("esc - wyjdź ze sklepu");
            string n = Console.ReadLine();
            if (n == "1" && hero.Pieniadze >= 10)
            {
                Console.WriteLine("Pomyślnie zakupiłeś topór");
                hero.Atak += 4;
                hero.Pieniadze -= 10;
                Console.WriteLine("");
                Console.WriteLine("Twoje statystyki :");
                Console.WriteLine("twoje hp wynosi {0}", hero.Hp);
                Console.WriteLine("twój atak wynosi {0}", hero.Atak);
                Console.WriteLine("twoja obrona wynosi {0}", hero.Obrona);
            }
            else if (n == "2" && hero.Pieniadze >= 10)
            {
                Console.WriteLine("Pomyślnie zakupiłeś tarcza");
                hero.Obrona += 9;
                hero.Pieniadze -= 10;
                Console.WriteLine("");
                Console.WriteLine("Twoje statystyki :");
                Console.WriteLine("twoje hp wynosi {0}", hero.Hp);
                Console.WriteLine("twój atak wynosi {0}", hero.Atak);
                Console.WriteLine("twoja obrona wynosi {0}", hero.Obrona);
            }
            else if (n == "3" && hero.Pieniadze >= 10)
            {
                Console.WriteLine("Pomyślnie zakupiłeś potkę na leczenie");
                hero.Hp += 50;
                hero.Pieniadze -= 10;
                Console.WriteLine("");
                Console.WriteLine("Twoje statystyki :");
                Console.WriteLine("twoje hp wynosi {0}", hero.Hp);
                Console.WriteLine("twój atak wynosi {0}", hero.Atak);
                Console.WriteLine("twoja obrona wynosi {0}", hero.Obrona);
            }
            else if (n == "4" && hero.Pieniadze >= 15)
            {
                Console.WriteLine("Pomyślnie zakupiłeś ulepszony topór");
                hero.Atak += 4;
                hero.Obrona += 9;
                hero.Pieniadze -= 15;
                Console.WriteLine("");
                Console.WriteLine("Twoje statystyki :");
                Console.WriteLine("twoje hp wynosi {0}", hero.Hp);
                Console.WriteLine("twój atak wynosi {0}", hero.Atak);
                Console.WriteLine("twoja obrona wynosi {0}", hero.Obrona);
            }
            else
            {

            }

        }

        private static void DodajPieniadze(Hero hero)
        {
            hero.Pieniadze += 2;
            hero.PotkiNaLeczenie++;
            Console.WriteLine("liczba twoich potek na leczenie to {0}", hero.PotkiNaLeczenie);
            Random statystyka = new Random();
            int g = statystyka.Next(1, 3);
            if (g == 1)
            {
                hero.Atak++;
            }
            else if (g == 2)
            {
                hero.Obrona += 3;
            }
            else
            {
                hero.Hp += 15;
            }
        }

        private static void StworzBron(Hero hero)
        {
            Console.WriteLine(hero.Statystyki());
            Console.WriteLine("Wybierz broń");
            Bron[] bronie = Bron.GenerujBronie(hero);
            for (int i = 0; i < bronie.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {bronie[i].Statystyki()}");
            }

            int odpowiedz = -1;
            while (odpowiedz < 0 || odpowiedz >= bronie.Length)
            {
                odpowiedz = Int32.Parse(Console.ReadLine());
            }

            hero.DodajBron(bronie[odpowiedz]);
        }

        private static Mag StworzMaga()
        {
            string[] nazwyMagow = new string[] { "Gandalf",
            "Saruman",
            "Sauron",
            "Yenefer",
            "Vilgefords"};

            Random random = new Random();

            Mag mag = new Mag(random.Next(10, 30),
                nazwyMagow[random.Next(0, nazwyMagow.Length)],
                random.Next(11, 14),
                random.Next(45, 60),
                0);
            return mag;
        }

        private static Hero StworzBohatera()
        {
            Console.WriteLine("Podaj imię bohatera: ");
            string imie = Console.ReadLine();
            Hero hero = null;
            bool poprawnyInput = false;
            while (!poprawnyInput)
            {
                poprawnyInput = true;

                // Prompt dla gracza
                {
                    Console.WriteLine("wybierz klasę bohatera : \n" +
                        "1 - wojownik : dużo hp,posiada obronę która zmniejsza \n" +
                        "obrażenia zadawane przez przeciwnika , lecz ma mały atak \n" +
                        "2 - łucznik  : duży atak , posiada krwawienie który zwiększa \n" +
                        "obrażenia, ale ma mało hp \n" +
                        "3 - włócznik: średni atak , średnie hp , ma obronę ,ale mniejszą niż u wojownika \n" +
                        "oraz krwawienie ,ale mniejsze niż u łucznika");
                }

                string v = Console.ReadLine();
                if (v == "1")
                {
                    hero = new Wojownik(100, imie, 1, 30, 0);
                    Console.WriteLine(hero.Statystyki());
                }
                else if (v == "2")
                {
                    hero = new Lucznik(30, imie, 10, 20, 0);
                }
                else if (v == "3")
                {
                    hero = new Wlucznik(50, imie, 5, 10, 15);
                }
                else
                {
                    Console.WriteLine("Podano nieprawidłową liczbę");
                    poprawnyInput = false;
                }
            }

            return hero;
        }

        private static bool Walka(Hero hero, Mag mag)
        {
            int odpowiedz = 0;
            while (true)
            {

                int iloscOdpowiedzi = 1;
                odpowiedz = 0;
                while (true)
                {
                    Console.WriteLine("Czy chcesz atakować? [1]");
                    if (hero.PotkiNaLeczenie > 0)
                    {
                        iloscOdpowiedzi = 2;
                        Console.WriteLine("Czy leczyć się? [2]");
                    }
                    odpowiedz = int.Parse(Console.ReadLine());

                    if (odpowiedz == 1 || (odpowiedz == 2 && iloscOdpowiedzi == 2)) break;
                    Console.WriteLine("Zła liczba");
                }

                if (odpowiedz == 1)
                {
                    mag.OdejmijHp(hero.PobierzSileAtaku());
                    Console.WriteLine("hp maga {0} wynosi {1}", mag.Nazwa, mag.Hp);
                }
                else
                {
                    hero.WypijPotke();
                }

                if (mag.Hp <= 0)
                {
                    Console.WriteLine("mag przegrał");
                    return true;
                }



                Console.WriteLine($"Mag atakuje za {mag.PobierzSileAtaku()} ataku");
                hero.OdejmijHp(mag.PobierzSileAtaku());
                Console.WriteLine("hp {0} wynosi {1}", hero.Nazwa, hero.Hp);

                if (hero.Hp <= 0)
                {
                    Console.WriteLine("mag wygrał");
                    return false;
                }


            }
        }

        private static void KoniecGry(Hero hero)
        {
            string a = "";
            for(int i = 0; i < 200; i++)
            {
                a += "-";
            }
            a += "\nKONIEC GRY\n";
            for (int i = 0; i < 200; i++)
            {
                a += "-";
            }
            Console.WriteLine(a);
            Console.WriteLine(hero.Statystyki());
        }
    }
}


