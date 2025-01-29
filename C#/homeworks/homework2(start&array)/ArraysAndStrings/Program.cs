using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStrings
{
    internal class Program
    {
        static void sumFromMinToMax()
        {
            Random rnd = new Random();
            int size = 5;

            int[,] array = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array[i, j] = rnd.Next(-100, 100 + 1);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            int minI = 0, maxI = 0;
            int min = array[0, 0], max = array[0, 0], indexMin = 0, indexMax = 0;
            int[] arr = new int[size * size];
            int index = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    arr[index] = array[i, j];

                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        indexMax = index;
                    }
                    else if (array[i, j] < min)
                    {
                        min = array[i, j];
                        indexMin = index;
                    }
                    index++;
                }
            }
            if (indexMax < indexMin)
            {
                int t = indexMax;
                indexMax = indexMin;
                indexMin = t;
            }
            int sum = 0;
            Console.WriteLine($"{min}; {max}");
            for (int i = indexMin; i <= indexMax; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine($"{sum} is sum of range from min to max");
        }

        static string CesarCode(string line, int num)
        {
            string ret = "";
            while (num > 26)
            {
                num -= 26;
            }
            for (int i = 0; i < line.Length; i++)
            {
                ret += (char)(line[i] + num);
            }
            Console.WriteLine(ret);
            return ret;
        }

        static string CesarDecode(string line, int num)
        {
            string ret = "";
            while (num > 26)
            {
                num -= 26;
            }
            for (int i = 0; i < line.Length; i++)
            {
                ret += (char)(line[i] - num);
            }
            Console.WriteLine(ret);
            return ret;
        }

        static string toUpperStart(string line)
        {
            bool doIf = false;
            string ret = "";
            int go = 0;
            while (char.IsWhiteSpace(line[go]))
            {
                go++;
            }
            if (char.IsLower(line[go]))
            {
                ret += char.ToUpper(line[go]);
            }
            for (int i = go + 1; i < line.Length; i++)
            { 
                if (doIf && char.IsLetter(line[i]))
                {
                    ret += char.ToUpper(line[i]);
                    doIf = false;
                    continue;
                }
                else if (line[i] == '.')
                {
                    ret += line[i];
                    doIf = true;
                    continue;
                }
                ret += line[i];

            }

            Console.WriteLine(ret);
            return ret;
        }
    

        static void Main(string[] args)
        {
            //task 2
            sumFromMinToMax();


            //task 3
            Console.WriteLine("enter line: ");
            string firstLine = Console.ReadLine();
            Console.WriteLine("enter number: ");
            int number = int.Parse(Console.ReadLine());
            string reDoneLine = CesarCode(firstLine, number);
            CesarDecode(reDoneLine, number);


            //task 6
            Console.WriteLine("enter line: ");
            string Line = Console.ReadLine();
            toUpperStart(Line);

            Console.ReadLine();
        }
    }
}
