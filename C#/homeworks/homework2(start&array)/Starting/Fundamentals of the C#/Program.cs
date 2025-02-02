using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Fundamentals_of_the_C_
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("Write number between 1 and 100:");
            int number = int.Parse(Console.ReadLine());
            if (1 <= number && number <= 100)
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("Wrong number!");
            }
            Console.ReadLine();
        }

        static void Task4()
        {
            Console.WriteLine("Number:");
            int number = int.Parse(Console.ReadLine());
            if(100000 <= number && number <= 999999)
            {
                Console.WriteLine("First mark:");
                int firstMark = int.Parse(Console.ReadLine());
                Console.WriteLine("Second mark:");
                int secondMark = int.Parse(Console.ReadLine());
                string numberToChenge = number.ToString();
                char[] charArray = numberToChenge.ToCharArray();
                (charArray[firstMark - 1], charArray[secondMark - 1]) = (charArray[secondMark - 1], charArray[firstMark - 1]);
                string result = new string(charArray);
                Console.WriteLine(result);
            }
            else { Console.WriteLine("Error"); }
            Console.ReadLine();
        }

        static void Task7()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                int tmp = firstNumber;
                firstNumber = secondNumber;
                secondNumber = tmp;
            }
            int firstNumberForEven = firstNumber;
            int secondNumberForEven = secondNumber;
            if (firstNumber % 2 != 0) {
                firstNumberForEven++;
            }
            if(secondNumber % 2 != 0)
            {
                secondNumberForEven++;
            }

            for (int i = firstNumberForEven; i <= secondNumberForEven; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();

            int firstNumberForNotEven = firstNumber;
            int secondNumberNotForEven = secondNumber;
            if (firstNumber % 2 == 0)
            {
                firstNumberForEven++;
            }
            if (secondNumber % 2 == 0)
            {
                secondNumberForEven--;
            }
            for (int i = firstNumberForNotEven; i < secondNumberNotForEven; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Task1();

            Task4();

            Task7();
        }
    }
}
