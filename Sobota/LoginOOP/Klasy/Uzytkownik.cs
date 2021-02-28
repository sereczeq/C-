using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginOOP.Klasy
{
    class Uzytkownik
    {
        public string Login;
        public string Haslo;
        public int Wiek;
        public string Email;
        public string PrzedstawSie()
        {
            string tekst = $"Użytkownik {Login} ma {Wiek} lat i adres mail: {Email}"; return tekst;
        }
    }
}
