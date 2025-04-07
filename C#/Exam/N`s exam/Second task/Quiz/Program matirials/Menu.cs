using Quiz.Program_matirials.Quiz_matirials;
using Quiz.Program_matirials.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Program_matirials
{
    public static class Menu
    {
        public static void MeinMenu()
        {
            while (true)
            {
                Console.Write("Would you like to log in, register, or exit?(1-log in, 2-register, 3-exit)");
                int tmpChoice = int.Parse(Console.ReadLine());
                switch (tmpChoice)
                {
                    case 1:
                        LogIn();
                        break;
                    case 2:
                        RegIn();
                        break;
                    case 3:
                        return;
                    default:
                        break;
                }

                

            }
        }
        public static void RegIn()
        {
            while (true)
            {
                Console.Write("Enter your login:");
                string tmpLogin = Console.ReadLine();
                Console.Write("Enter your password:");
                string tmpPassword = Console.ReadLine();
                Console.Write("Enter your date of birth(dd.mm.yyyy):");
                string tmpDateOfBirth = Console.ReadLine();
                if (UsersData.CreateNewAccount(tmpLogin, tmpPassword, tmpDateOfBirth))
                {
                    break;
                }
                Console.Clear();
            }
            MenuLoggedIn();
        }
        public static void LogIn()
        {
            while (true)
            {
                Console.Write("Enter your login:");
                string tmpLogin = Console.ReadLine();
                Console.Write("Enter your password:");
                string tmpPassword = Console.ReadLine();
                if (UsersData.IsLoggedIn(tmpLogin, tmpPassword))
                {
                    Console.WriteLine("You`re logged in!");
                    MenuLoggedIn();
                }
                else
                {
                    Console.WriteLine("Login failed.");
                    Console.Write("Do you want to register or try again?(Write register/try again):");
                    string choice = Console.ReadLine();
                    if (choice == "register")
                    {
                        while (true)
                        {
                            Console.Write($"Continue with existing data (Login: {tmpLogin}, password: {tmpPassword}) or enter other?(Enter other to enter new data. Press Enter to continue:");
                            choice = Console.ReadLine();
                            if (choice == "other")
                            {
                                Console.Write("Enter your login:");
                                tmpLogin = Console.ReadLine();
                                Console.Write("Enter your password:");
                                tmpPassword = Console.ReadLine();
                            }
                            Console.Write("Enter your date of birth(dd.mm.yyyy):");
                            string tmpDateOfBirth = Console.ReadLine();
                            if (UsersData.CreateNewAccount(tmpLogin, tmpPassword, tmpDateOfBirth))
                            {
                                break;
                            }
                            Console.Clear();
                        }
                    }
                }
            }
        }
        public static void MenuLoggedIn()
        {
            Console.WriteLine("1)start a new quiz\n2)view the results of your past quizzes\n3)view the Top 20 from a specific quiz\n4)change settings: you can change your password and date of birth\n5)log out");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    QuizMenu.MeinMenu();
                    break;
                default:
                    break;
            }
        }

    }
}
