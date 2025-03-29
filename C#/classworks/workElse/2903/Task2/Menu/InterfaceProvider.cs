using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Menu
{
    public static class InterfaceProvider
    {
        private static (double, double, double) CountCredit() {
            Console.WriteLine("enter sum of credit: ");
            double sum = double.Parse(Console.ReadLine());

            Console.WriteLine("enter procent: ");
            double procent = double.Parse(Console.ReadLine()) / 100;

            Console.WriteLine("enter monthes: ");
            int monthes = int.Parse(Console.ReadLine());


            double countUp = procent * Math.Pow((1 + procent), monthes);
            double countDown = Math.Pow((1 + procent), monthes) - 1;

            double countMonthly = sum * (countUp / countDown);


            Console.Write("Pay monthly: ");
            Console.WriteLine(countMonthly);

            Console.Write("All sum: ");
            double AllSum = countMonthly * monthes;
            Console.WriteLine(AllSum);

            Console.Write("Credit overpay: ");
            double Overpay = (countMonthly * monthes) - sum;
            Console.WriteLine(Overpay);


            Logger.getLogger.Log($"Credit counted. Result: Monthly: {countMonthly}; All sum: {AllSum}; Overpay: {Overpay}");

            return (countMonthly, AllSum, Overpay); //!!!!!
        }
        private static void Convert() {
            Console.WriteLine("Enter amount of money: ");
            double money = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter course: ");
            double course = double.Parse(Console.ReadLine());

            Console.WriteLine("Sum after conversation: ");
            double count = money * course;
            Console.WriteLine(count);

            Logger.getLogger.Log($"Convert done. Result: Amount of money: {money}; Course: {course}; Convertor: {count}");
        }
        private static void CalculateDeposite()
        {
            Console.WriteLine("enter sum of deposite: ");
            double sum = double.Parse(Console.ReadLine());

            Console.WriteLine("enter period: ");
            int period = int.Parse(Console.ReadLine());

            Console.WriteLine("enter procent: ");
            double procent = double.Parse(Console.ReadLine()) / 100;

            Console.WriteLine("Procents are \n1 - monthly\n2 - yearly");

            int countMonth;
            if (Console.ReadLine() == "1")
            {
                countMonth = 12;
            }
            else{
                countMonth = 1;
            }

            double countDeposite = sum * Math.Pow((1 + (procent / (countMonth * 100))), countMonth * period);
            Console.WriteLine(countDeposite);

            Logger.getLogger.Log($"Calculate deposite. Result: Sum: {sum}; period: {(countMonth == 1 ? $"{period} years" : $"{period * countMonth} monthes")}; Procent: {procent}%; Deposite: {countDeposite}");
        }
        public static void Menu()
        {
            while (true)
            {
                Console.WriteLine("1 - Count credit\n2 - Converter\n3 - Calculate deposite\n4 - exit");
                switch (Console.ReadLine())
                {
                    case "1":
                        CountCredit();
                        break;
                    case "2":
                        Convert();
                        break;
                    case "3":
                        CalculateDeposite();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Wrong option");
                        break;
                }
            }
        }
    }
}
