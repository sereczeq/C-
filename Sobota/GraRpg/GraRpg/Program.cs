using GraRpg.Klasy;
using System;

namespace GraRpg
{
   class Program
   {
      static void Main(string[] args)
        {
            //Gra();
            GraAdvanced();

        }



        private static void Gra()
        {
            Random random = new Random();

            Console.WriteLine("Witaj w grze Wojownik vs Magowie");
            Console.WriteLine("Podaj imie Twojego bohatera:");
            string imie = Console.ReadLine();

            // tworzymy gracza i przeciwnika
            Wojownik gracz = new Wojownik(imie, random.Next(150, 300), random.Next(5, 15), 5);
            Mag przeciwnik = new Mag("Super czarodziej", random.Next(150, 300), random.Next(5, 15), 10);

            Console.WriteLine("Na swojej drodze spotkałeś przeciwnika.");
            przeciwnik.WyswietlStatystyki();

            // walka toczy się dopóki zycie któregoś z graczy nie spadnie poniżej zera
            while (gracz.Hp >= 0 && przeciwnik.Hp >= 0)
            {
                // przeciwnik atakuje
                Console.WriteLine($"Gracz {przeciwnik.Nazwa} atakuje.");
                int atakPrzeciwnika = przeciwnik.PobierzSileAtaku();
                gracz.OdejmijHp(atakPrzeciwnika);
                Console.WriteLine($"Pozostało Ci {gracz.Hp} życia.\n");

                // sprawdzamy czy po ataku czasem nie zgineliśmy
                // jeżeli tak to kończymy walkę
                if (gracz.Hp <= 0)
                    break;

                // zatrzymujemy na pól sekundy program dla ciekawszego efektu
                System.Threading.Thread.Sleep(500);

                // my atakujemy
                Console.WriteLine($"Gracz {gracz.Nazwa} atakuje.");
                int atakGracza = gracz.PobierzSileAtaku();


                przeciwnik.OdejmijHp(atakGracza);


                Console.WriteLine($"Przeciwnikowi zostało {gracz.Hp} życia.\n");

                // sprawdzamy czy po ataku czasem nie pokonaliśmy wroga
                // jeżeli tak to kończymy walkę
                if (przeciwnik.Hp <= 0)
                    break;

                // zatrzymujemy na pól sekundy program dla ciekawszego efektu
                System.Threading.Thread.Sleep(500);
            }

            if (gracz.Hp <= 0)
            {
                Console.WriteLine($"Niestety zostałeś pokonany. Przeciwnik {przeciwnik.Nazwa} wygrał.");
            }
            else
            {
                Console.WriteLine($"Gratulację. Pokonałeś przeciwnika {przeciwnik.Nazwa}");
            }


            //zmniejszy hp przeciwnika o siłę ataku gracza
            przeciwnik.OdejmijHp(gracz.PobierzSileAtaku());




            Console.ReadKey();
        }

        private static void GraAdvanced()
        {
            Random random = new Random();

            Console.WriteLine("Witaj w grze Wojownik vs Magowie");
            Console.WriteLine("Podaj imie Twojego bohatera:");
            string imie = Console.ReadLine();

            // tworzymy gracza i przeciwników
            Wojownik gracz = new Wojownik(imie, random.Next(150, 300), random.Next(20, 60), 5);

            Mag[] przeciwnicy = new Mag[random.Next(1, 5)];

            for(int i = 0; i < przeciwnicy.Length; i++)
            {
                przeciwnicy[i] =  new Mag("Super czarodziej "+ i , random.Next(50, 150), random.Next(5, 15), 10);
            }

            Console.WriteLine("Na swojej drodze spotkałeś przeciwników.");
            foreach(Mag mag in przeciwnicy)
            {
                mag.WyswietlStatystyki();
            }

            // walka toczy się dopóki zycie któregoś z graczy nie spadnie poniżej zera
            while (true)
            {
                Console.WriteLine("Chcesz atakować [atak] czy blokować? [blok]?\n[esc] - wyjście z gry");
                string odpowiedź = Console.ReadLine();
                if(odpowiedź == "esc")
                {
                    Console.WriteLine("Wyjście z gry");
                    break;
                }
                else if(odpowiedź == "blok")
                {
                    gracz.BronSie();
                }
                else if (odpowiedź == "atak")
                {
                    Console.WriteLine("Którego przeciwnika chcesz atakować? [0-9]");
                    int index = Convert.ToInt32(Console.ReadLine());
                    if (index > przeciwnicy.Length || index < 0) index = 0;
                    przeciwnicy[index].OdejmijHp(gracz.PobierzSileAtaku());
                    Console.WriteLine($"Gracz {gracz.Nazwa} atakuje.");
                    Console.WriteLine($"Przeciwnikowi zostało { przeciwnicy[index].Hp} życia.");
                }
                else
                {
                    Console.WriteLine("Podałeś złą odpowiedź, spróbuj jeszcze raz");
                    //jeżeli odpowiedź jest niepoprawna to pytamy znowu
                    continue;
                }
                // przeciwnik atakuje
                foreach(Mag mag in przeciwnicy)
                {
                    if(mag.Hp > 0)
                    {
                        int poprzednieHP = gracz.Hp;
                        gracz.OdejmijHp(mag.PobierzSileAtaku());
                        Console.WriteLine($"Mag {mag.Nazwa} zaatakował, odjął {poprzednieHP - gracz.Hp} hp");
                        Console.WriteLine($"Pozostało Ci {gracz.Hp} życia.\n");
                    }
                }
                Console.WriteLine($"Koniec ataków!\nPozostało Ci {gracz.Hp} życia.\n");
                if (gracz.Hp <= 0)
                    break;

                bool magowieZyja = false;
                foreach(Mag mag in przeciwnicy)
                {
                    if(mag.Hp > 0)
                    {
                        magowieZyja = true;
                        break;
                    }
                    else
                    {
                        gracz.Atak++;
                    }
                }

                if(!magowieZyja)
                {
                    break;
                }
            }

            if (gracz.Hp <= 0)
            {
                Console.WriteLine($"Niestety zostałeś pokonany. Przeciwnicy wygrali.");
            }
            else
            {
                Console.WriteLine($"Gratulację. Pokonałeś przeciwników");
            }

            Console.ReadKey();
        }
    }
}
