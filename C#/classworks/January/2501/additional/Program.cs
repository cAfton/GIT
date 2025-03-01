using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace additional
{
    internal class Program
    {
        static void printBjarneStroustrup()
        {
            Console.Write("It's easy");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" to ");
            Console.ResetColor();
            Console.Write("win forgiveness");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" for ");
            Console.ResetColor();
            Console.WriteLine("being wrong;");
            Console.Write("\tbeing right ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("is "); 
            Console.ResetColor();
            Console.Write("what gets you ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("into ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("real ");
            Console.ResetColor();
            Console.WriteLine("trouble.");
            

            Console.WriteLine("Bjarne Stroustrup");

        }

        static void flip()
        {
            Console.Write("Print new 6-numbers number: ");

            string num = Console.ReadLine();
            while (num.Length != 6)
            {
                Console.Write("Print new 6-numbers number: ");
                num = Console.ReadLine();

            }
            int retNum = int.Parse(num);

            string line = "";
            for (int i = 0; i < 6; i++)
            {
                int temp = retNum % 10;
                line += temp.ToString();
                retNum /= 10;
            }
            retNum = int.Parse(line);

            Console.Write($">> {retNum}");
        }

        static void printNumbers()
        {
            Console.Write("print A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("print B: ");
            int B = int.Parse(Console.ReadLine());
            if (A > B) {
                int t = A;
                A = B;
                B = t;
            }

            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (j != 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write($"{i} ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write($"{i} ");
                    }
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }

        static void printPalidroms()
        {
            Console.Write("print number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                bool isPar = true;
                if (i < 10)
                {
                    Console.Write($"{i} ");
                    continue;
                }
                for (int j = 0; j < (i.ToString()).Length / 2; j++)
                {
                    string str = i.ToString();
                    if (str[j] != str[str.Length - j - 1])
                    {
                        isPar = false;
                    }
                }
                if (isPar)
                {
                    Console.Write($"{i} ");
                }
            }
        }

        static void taskSix()
        {
            Console.WriteLine("1 - vertical\n2 - horizont");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            if (a == 1)
            {
                for (int i = 0; i < b; i++)
                {
                    Console.WriteLine(c);
                }
            }
            else if (a == 2)
            {
                for (int i = 0; i < b; i++)
                {
                    Console.Write(c);
                }
            }
        }

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
            for (int i = 0; i < list.Count; i++)
            {
                if (!(list[i] < first))
                {
                    Console.WriteLine($"{list[i]} ");
                }
            }
            Console.ReadLine();
        }


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
                for (int i = 0; i < choice2; i++)
                {
                    Console.WriteLine(choice3);
                }
            }
            Console.ReadLine();
        }

        static void Parce()
        {
            string line = Console.ReadLine();

            int num = 0;
            for (int i = 0; i < line.Length; i++)
            {
                switch (line[i])
                {
                    case '0':
                        num += 0;
                        break;
                    case '1':
                        num += 1;
                        break;
                    case '2':
                        num += 2;
                        break;
                    case '3':
                        num += 3;
                        break;
                    case '4':
                        num += 4;
                        break;
                    case '5':
                        num += 5;
                        break;
                    case '6':
                        num += 6;
                        break;
                    case '7':
                        num += 7;
                        break;
                    case '8':
                        num += 8;
                        break;
                    case '9':
                        num += 9;
                        break;
                    case ' ':
                        continue;
                    default:
                        break;
                }
                num *= 10;
            }
            num /= 10;

            Console.WriteLine(num);

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");

                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //Parce();

            //Console.WriteLine();

            //printBjarneStroustrup();

            //Console.WriteLine();

            //flip();

            //Console.WriteLine();

            //printNumbers();

            //Console.WriteLine();

            //printPalidroms();

            //Console.WriteLine();

            //Task2();

            //Console.WriteLine();

            //Task4();

            //Console.WriteLine();

            //Task6();

            //Console.ReadLine();

            taskSix();

            Console.ReadLine();
;        }
    }
}
