using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logowanie.Klasy
{
    class Uzytkownik
    {
        public string Login = "Gigant";
        public string Haslo = "Gigant123";
        public string Imie = "Jan";
        public int Wiek = 20;

        public string PrzedstawSie()
        {
            return $"Użytkownik {Login} ma {Wiek} lat i ma na imię {Imie}";
        }

    }



}
