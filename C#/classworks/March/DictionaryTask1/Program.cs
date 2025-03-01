using System;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Text;

namespace DictionaryTask1
{
    
    public class Menegment
    {
        public Dictionary<string, string> LoginsAndPasss { get; set; } = new Dictionary<string, string>();

        static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public void Add(string login, string password)
        {
            if (!LoginsAndPasss.ContainsKey(login))
            {
                LoginsAndPasss.Add(login, ComputeSha256Hash(password));
            }
            else
            {
                Console.WriteLine("Banned");
            }
        }

        public void Delete(string login)
        {
            LoginsAndPasss.Remove(login);
        }

        public void EditPassword(string login, string password)
        {
            LoginsAndPasss[login] = ComputeSha256Hash(password);
        }

        public void EditLogin(string oldLogin, string newLogin)
        {
            string oldPass = LoginsAndPasss.FirstOrDefault(elem => elem.Key == oldLogin).Value;
            oldPass = LoginsAndPasss[oldLogin];
            LoginsAndPasss.Remove(oldLogin);
            LoginsAndPasss.Add(newLogin, oldPass);
        }

        public string FindByLogin(string login)
        {
            return LoginsAndPasss[login];
        }

        public bool IsLogged(string login, string pass)
        {
            if (LoginsAndPasss.ContainsKey(login))
            {
                return LoginsAndPasss[login] == ComputeSha256Hash(pass);
            }
            else { return false; }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Menegment menegment = new Menegment();

            menegment.Add("admin", "admin");
            menegment.Add("user2", "password1");
            menegment.Add("user2", "password2");

            Console.Write("Login: ");
            string login = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            if (menegment.IsLogged(login, password))
            {
                while (true)
                {

                    Console.WriteLine("1 - Add\n2 - Delete\n3 - Edit\n4 - Find");
                    int choise = int.Parse(Console.ReadLine());
                    switch (choise)
                    {
                        case 1:
                            Console.Write("Login: ");
                            login = Console.ReadLine();
                            Console.Write("Password: ");
                            password = Console.ReadLine();
                            menegment.Add(login, password); 
                            break;
                        case 2:
                            Console.Write("Login: ");
                            login = Console.ReadLine();
                            menegment.Delete(login);
                            break;
                        case 3:
                            Console.WriteLine("Edit: \n1 - Login\n2 - Password");
                            choise = int.Parse(Console.ReadLine());
                            switch (choise)
                            {
                                case 1:
                                    Console.Write("Login to change: ");
                                    login = Console.ReadLine();
                                    Console.Write("New login: ");
                                    menegment.EditLogin(login, Console.ReadLine());
                                    break;
                                case 2:
                                    Console.Write("Login to change: ");
                                    login = Console.ReadLine();
                                    Console.Write("New password: ");
                                    menegment.EditPassword(login, Console.ReadLine());
                                    break;
                                default:
                                    break;
                            }
                            break;
                        case 4:
                            Console.Write("Edit login to find: ");
                            menegment.FindByLogin(Console.ReadLine());
                            break;
                        default:
                            Console.WriteLine("Error");
                            break;
                    }
                }
            }
            else{
                Console.WriteLine("Banned");
            }

           

        }
    }
}
