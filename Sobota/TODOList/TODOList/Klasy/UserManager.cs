using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOList.Klasy
{

   
    class UserManager
    {
        private List<User> Users;

        public UserManager()
        {
            Users = new List<User>();

            Users.Add(new User(Guid.NewGuid(), "test", "test", "test"));
            Users.Add(new User(Guid.NewGuid(), "test1", "test1", "test1"));
        }

        public User WyszukajUzytkownika(string login, string haslo)
        {
            // sprawdzimy po kolei każdy element listy "Users"
            foreach(User user in Users)
            {
                // jeżeli istnieje użytkownik z podanym loginem i hasłem
                if(user.Login == login && user.Haslo == haslo)
                {
                    return user;
                }
            }
            return null;
        }

    }
}
