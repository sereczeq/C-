using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logowanie.Klasy
{
    class Uzytkownik
    {
        string Login;
        string Haslo;
        int Wiek;
        string Imie;

        string PrzedstawSie()
        {
            return $"Użytkownik {Login} ma {Wiek} lat i nazywa się {Imie}";
        }
    }
}
