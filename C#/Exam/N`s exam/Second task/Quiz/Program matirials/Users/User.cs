using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Quiz.Program_matirials.Users
{
    public class User
    {
        private string Login;
        private string Password;
        private DateTime DateOfBirth;

        public User(string login, string password, DateTime dateOfBirth)
        {
            this.Login = login;
            this.Password = password;
            this.DateOfBirth = dateOfBirth;
        }
        public bool IsLoggedIn(string login)
        {
            if (Login == login)
            {
                return true;
            }
            return false;
        }
        public bool IsCorrectPassword(string password)
        {
            if (Password == password)
            {
                return true;
            }
            return false;
        }
    }
}
