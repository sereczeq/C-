using System;
using System.Data;

namespace ConsoleApp1
{
    partial class Powtorka
    {

        static void Main(String[] args)
        {
            exercise1();
            //exercise2();
            //exercise3();
        }

        private static void exercise1()
        {
            int liczba = 10;
            double dokładniejszyUłamek = 11.212687678797987782;
            float ułamek = 11.212687678797987782f;
            String tekst = "tekst";
            Boolean boolean = true;
            Char character = 'a';

            Kalkulator.Potega(2);
            Console.WriteLine(Kalkulator.Mnożenie(3, 4) + 3);
            int wynik = Kalkulator.Dzielenie(20, 5);
            Console.WriteLine(wynik);
        }

        class Kalkulator
        {
            public static void Potega(int liczbaDoPotegowania)
            {
                for (int i = 0, potega = liczbaDoPotegowania; i < 3; i++)
                {
                    potega *= liczbaDoPotegowania;
                    Console.WriteLine(potega);
                }

            }

            public static int Mnożenie(int liczba1, int liczba2)
            {
                int wynik = liczba1 * liczba2;

                return wynik;
            }

            public static int Dzielenie(int liczba1, int liczba2)
            {
                return liczba1 / liczba2;
            }
        }



        
        
        private static void exercise2()
        {
            for (int i = 0, potega = 4; i < 5; i++, potega *= 4)
            {
                Console.WriteLine(potega);
            }
        }

        private static void exercise3()
        {
            Console.WriteLine("Ile masz lat?");
            int wiek = int.Parse(Console.ReadLine());

            Console.WriteLine("Ile masz pieniędzy?");
            int pieniadze = int.Parse(Console.ReadLine());

            if(wiek > 18 && pieniadze > 30)
            {
                Console.WriteLine("jej, możesz obejrzeć piłę");
            }
            else if (wiek > 18)
            {
                Console.WriteLine("nie masz wystarczająco pieniędzy");
            }
            else if (pieniadze > 30)
            {
                Console.WriteLine("jesteś za młody");
            }
            else
            {
                Console.WriteLine("jesteś biedny i młody :')");
            }
        }
    }
}
