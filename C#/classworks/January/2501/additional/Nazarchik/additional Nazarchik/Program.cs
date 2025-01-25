using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace additional_Nazarchik
{
    internal class Program
    {
        ////////
        static double Sum(double[] arr)
        {
            double S = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                S += arr[i];
            }
            return S;
        }
        static double Max(double[] arr)
        {
            double M = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > M)
                    M = arr[i];
            }
            return M;
        }

        static double Min(double[] arr)
        {
            double M = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < M)
                    M = arr[i];
            }
            return M;
        }

        static double Mul(double[] arr)
        {
            double M = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                M *= arr[i];
            }
            return M;
        }

        static void Task2()
        {
            double[] arr = new double[5];
            Console.Write("Enter your 5 numbers:");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(Sum(arr));
            Console.WriteLine(Max(arr));
            Console.WriteLine(Min(arr));
            Console.WriteLine(Mul(arr));
            Console.ReadLine();
        }
        ////////
        /*Користувач вводить із клавіатури межі числового діапазону.Потрібно показати всі числа Фібоначчі з цього діапазону.
            Числа Фібоначчі — елементи числової послідовності, в якій перші два числа дорівнюють 0 і 1, а кожне наступне число
            дорівнює сумі двох попередніх чисел.Наприклад, якщо вказано діапазон 0-20, результат буде:

        0, 1, 1, 2, 3, 5, 8, 13*/

        // 0, 1, n1, n2
        static List<int> Fib(int n1, int n2, int last, List<int> arr)
        {
            if (n1 + n2 > last)
            {
                arr.Add(n2);
                return arr;
            }
            if (n1 == 0)
            {
                arr.Add(n1);
            }

            arr.Add(n2);
            
            return Fib(n2, n2 + n1, last, arr);

        }

        static void Task4()
        {
            Console.WriteLine("Enter first and last numbers:");
            int first = int.Parse(Console.ReadLine());
            int last = int.Parse(Console.ReadLine());


            List<int> list = new List<int>();

            list = Fib(0, 1, last, list);
            for (int i = 0;i < list.Count; i++)
            {
               if (!(list[i] < first))
                {
                    Console.WriteLine($"{list[i]} ");
                }
            }
            Console.ReadLine();
        }

        ///////////\n3)diagonally up\n4)diagonally down

        static void Task6()
        {
            Console.WriteLine("1)Horizontally\n2)vertically:");
            int choice1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Number:");
            int choice2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Char:");
            char choice3 = char.Parse(Console.ReadLine());

            if (choice1 == 1)
            {
                for (int i = 0; i < choice2; i++)
                {
                    Console.Write(choice3);
                }

            }
            else
            {
                for(int i = 0; i < choice2; i++)
                {
                    Console.WriteLine(choice3);
                }
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            //Task2();

            //Task4();

            Task6();
        }
    }
}
