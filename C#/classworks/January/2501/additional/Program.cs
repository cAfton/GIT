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
        static void Main(string[] args)
        {

            printBjarneStroustrup();

            flip();

            printNumbers();

            printPalidroms();

            Console.ReadLine();
        }
    }
}
