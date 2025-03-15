using System;
using System.Text.RegularExpressions;
namespace para1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task1
            if (false)
            {
                Console.WriteLine("Enter your ");
                string name = Console.ReadLine();
                string PIBCheck = @"^[a-zA-Z]+\s[a-zA-Z]+\s[a-zA-Z]+$";
                if (Regex.IsMatch(name, PIBCheck))
                {
                    Console.WriteLine("Print(Hallo World)");
                }
                else
                {
                    Console.WriteLine("Error");
                }
                Console.ReadLine();
            }
            #endregion

            #region task2
            if (false)
            {
                Console.WriteLine("Enter your age");
                string age = Console.ReadLine();
                string goodAge = @"^[1-9]\d{0,2}$";
                if (Regex.IsMatch(age, goodAge))
                {
                    Console.WriteLine("hi");
                }
                else
                {
                    Console.WriteLine("Error");
                }
                Console.ReadLine();
            }
            #endregion

            #region task3
            if (false)
            {
                Console.WriteLine("Enter your address");
                string address = Console.ReadLine();
                string addressValidation = @"^(Вул\.|Прк\.|Пл\.)\s[А-ЯІЇЄҐ][\u0400-\u04FF\u0500-\u052F\u0406\u0456\u0404\u0454\u0407\u0457]+\,[1-9]\d*[А-ЯІЇЄҐ]?$";
                if (Regex.IsMatch(address, addressValidation))
                {
                    Console.WriteLine(address);
                }
                else
                {
                    Console.WriteLine("Error");
                }
                Console.ReadLine();
            }
            #endregion

            #region task4
            if (false)
            {
                Console.WriteLine("Enter your Email");
                string gmail = Console.ReadLine();
                string emailValidation = @"^\w+[@][a-zA-Z]+\.[a-zA-Z]+$";
                if (Regex.IsMatch(gmail, emailValidation))
                {
                    Console.WriteLine(gmail);
                }
                else
                {
                    Console.WriteLine("Error");
                }
                Console.ReadLine();
            }
            #endregion  
        }
    }
}
