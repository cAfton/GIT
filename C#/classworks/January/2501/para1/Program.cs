using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace para1
{
    internal class Program
    {
        static int Parce(string line)
        {
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
            return num;
        }
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            int num = Parce(line);

            Console.WriteLine(num);

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
