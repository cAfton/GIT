using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Program_matirials.Users
{
    public static class UsersData
    {
        private static bool isAdmin;
        public static List<User> Users = new List<User>();
        public static User user { get; private set; }

        //public static bool IsAdmin(string login, string password)
        //{
        //    if(admin.IsLoggedIn(login) && admin.IsCorrectPassword(password))
        //        return true;
        //    return false;
        //}
        public static bool IsLoggedIn(string login, string password)
        {
            foreach (var item in Users)
            {
                if (item.IsLoggedIn(login))
                {
                    if(item.IsCorrectPassword(password))
                    {
                        user = item;

                        return true;
                    }
                    Console.WriteLine("Incorrect password");
                    return false;
                }
            }
            return false;
        }
        private static bool IsLoggedLogin(string login) {
            foreach (var item in Users)
            {
                if (item.IsLoggedIn(login))
                {
                    Console.WriteLine("A user with this login already exists.");
                    return true;
                }
            }
            return false;
        }
        public static bool CreateNewAccount(string login, string password, string dateOfBirth)
        {
            if (DateTime.TryParseExact(dateOfBirth, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthDate))
            {
                if (IsLoggedLogin(login))
                {
                    return false;
                }
                Users.Add(new User(login, password, birthDate));
                Console.WriteLine("The user is registered");
                return true;
            }
            Console.WriteLine("Incorrect time entered");
            return false;
        }
    }
}
