using GraRpgMateusz.KlasyBohaterow;
using GraRpgMateusz.KlasyBroni;
using GraRpgMateusz.KlasyBroni.Lucznik;
using GraRpgMateusz.KlasyBroni.Wlucznik;
using GraRpgMateusz.KlasyBroni.Wojownik;
using System;

namespace GraRpgMateusz
{
    class Program
    {

        private static Bron[] GenerujBronie(Hero hero)
        {
            Bron[] bronie = new Bron[4];
            if (hero.ToString().Contains("Wojownik"))
            {
                bronie[0] = new BronWojownika("topór", 4, 0);
                bronie[1] = new BronWojownika("miecz", 2, 3);
                bronie[2] = new BronWojownika("topór z tarczą", 3, 3);
                bronie[3] = new BronWojownika("miecz z tarczą", 1, 6);
            }
            else if (hero.ToString().Contains("Wlucznik"))
            {
                bronie[0] = new BronWlucznika("pika", 4, 0, 0, 2);
                bronie[1] = new BronWlucznika("włócznia", 3, 3, 2, 0);
                bronie[2] = new BronWlucznika("młot bojowy", 3, 0, 3, 0);
                bronie[3] = new BronWlucznika("halabarda", 1, 0, 6, 0);
            }
            else if (hero.ToString().Contains("Lucznik"))
            {
                bronie[0] = new BronLucznika("łuk długi", 4, 0, 0, 3);
                bronie[1] = new BronLucznika("łuk krótki", 2, 0, 0, 3);
                bronie[2] = new BronLucznika("długi łuk ze strzałami przebijającymi zbroję", 3, 0, 3, 0);
                bronie[3] = new BronLucznika("krótki łuk ze strzałami przebijającymi zbronę", 1, 0, 6, 0);

            }
            return bronie;
        }

        static void Main(string[] args)
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

            Console.WriteLine(hero.Statystyki());
            Console.WriteLine("Wybierz broń");
            Bron[] bronie = GenerujBronie(hero);
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
            Console.WriteLine(hero.Statystyki());

            Console.WriteLine($"Walczysz z magiem:\n{mag.Statystyki()}");
            Console.WriteLine("WALKA SIĘ ROZPOCZYNA");
            Console.WriteLine("naciśnij enter aby kontynuować");
            Console.ReadLine();

            while (mag.Hp > 0 && hero.Hp > 0)
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
                    dodajPieniadze();
                    wygrana();

                    if (hero.Pieniadze >= 10)
                    {
                        Console.WriteLine("jeśli chcesz otworzyć sklep naciśnij s");
                        string aa = Console.ReadLine();
                        if (aa == "s")
                        {
                            sklep();
                        }
                        else
                        {

                        }
                    }

                    break;
                }


                Console.WriteLine($"Mag atakuje za {mag.PobierzSileAtaku()} ataku");
                hero.OdejmijHp(mag.PobierzSileAtaku());
                Console.WriteLine("hp {0} wynosi {1}", hero.Nazwa, hero.Hp);

                if (hero.Hp <= 0)
                {
                    Console.WriteLine("koniec gry");
                    break;
                }


            }
            void dodajPieniadze()
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
            void sklep()
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

            void wygrana()
            {
                if (mag.Hp <= 0)
                {
                    Console.WriteLine("{0} wygrywa", hero.Nazwa);
                    Console.WriteLine("");
                }
                else if (hero.Hp <= 0)
                {
                    Console.WriteLine("{0} wygrywa", mag.Nazwa);
                    Console.WriteLine("Przegrałeś");
                    Console.ReadLine();
                }
            }
        }
    }
}


