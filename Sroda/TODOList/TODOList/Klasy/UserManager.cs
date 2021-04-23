using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOList.Klasy
{
    // User Manager będzie mieć 3 funkcje:
    // 1. Logowanie użytkowników - sprawdza czy użytkownik z podanym loginem i hasłem
    // jest w bazie danych
    // 2. Sprawdzanie czy login jest wolny ( w momencie rejestracji )
    // 3. Dodanie nowego użytkownika do bazy danych
    class UserManager
    {
        // zmienna, lista użytkowników
        private List<User> users;

        public UserManager()
        {
            // tworzymy pustą listę
            users = new List<User>();
        }

        // 1. Logowanie użytkowników
        public User WyszukajUzytkownika(string login, string haslo)
        {
            // Iterujemy przez wszystkich użytkowników
                // Jeżeli istnieje użytkownik z podanym loginem i hasłem,
                // zwracamy tego użytkownika
            // Jeżeli nie istnieje, zwracamy null
            return null;
        }

        // 2. Sprawdzanie czy login jest wolny
        // Metoda do sprawdzania czy podany login jest wolny.
        // W aplikacji nie możemy mieć dwóch użytkowników
        // z tym samym loginem, więc zanim zapiszemy nowego użytkownika,
        // musimy sprawdzić czy już taki nie istnieje.
        public bool CzyLoginWolny(string login)
        {
            // Iterujemy przez listę użytkowników
            foreach(User user in users)
            {
                // Porównujemy podany login do loginu użytkownika.
                // Jeżeli loginy są takie same, zwracamy fałsz
                if (user.Login == login)
                {
                    return false;
                }
            }
            // Jeżeli nigdzie wcześniej nie zwróciliśmy fałszu, czyli
            // nie napotkaliśmy użytkownika z takim loginem, to zwracamy true,
            // czyli informację, że login jest wolny
            return true;
        }

        // 3. Dodanie nowego użytkownika do bazy
        // ponieważ lista użytkowników jest prywatna
        // dodajemy publiczną metodę do dodania nowego użytkownika
        public void AddUser(User user)
        {
            users.Add(user);
        }

    }
}
