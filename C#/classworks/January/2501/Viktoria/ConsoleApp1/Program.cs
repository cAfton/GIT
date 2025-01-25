using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void t1()
        {
            Console.Write("Enter size of array: ");

            int sizeOfArr = int.Parse(Console.ReadLine());
            sizeOfArr = Math.Abs(sizeOfArr);

            int[] array = new int[sizeOfArr];
            for (int i = 0; i < sizeOfArr; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;

            Console.Write("Pair: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.Write("not pair: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.Write("unic: ");

            Console.Write(array.Distinct().Count());


        }

        static void t2()
        {
            Console.Write("Enter size of array: ");

            int sizeOfArr = int.Parse(Console.ReadLine());
            sizeOfArr = Math.Abs(sizeOfArr);

            int[] array = new int[sizeOfArr];
            for (int i = 0; i < sizeOfArr; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int min = int.Parse(Console.ReadLine());
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    c++;
                }
            }
            Console.WriteLine(c);
        }

        static void t3()
        {
            Console.Write("Enter size of array: ");

            int sizeOfArr = int.Parse(Console.ReadLine());
            sizeOfArr = Math.Abs(sizeOfArr);

            int[] array = new int[sizeOfArr];
            for (int i = 0; i < sizeOfArr; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }



            Console.Write("Enter size of same: ");

            int sizeOfnewArr = int.Parse(Console.ReadLine());
            sizeOfArr = Math.Abs(sizeOfnewArr);

            int[] arraySame = new int[sizeOfnewArr];

            for (int i = 0; i < sizeOfArr; i++)
            {
                arraySame[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == arraySame[0] && array[i + 1] == arraySame[1] && array[i + 2] == arraySame[2])
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        static void t4()
        {
            Console.Write("Enter size of array 1: ");

            int sizeOfArr1 = int.Parse(Console.ReadLine());
            sizeOfArr1 = Math.Abs(sizeOfArr1);

            int[] array1 = new int[sizeOfArr1];
            for (int i = 0; i < sizeOfArr1; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }


            Console.Write("Enter size of array 2: ");

            int sizeOfArr2 = int.Parse(Console.ReadLine());
            sizeOfArr2 = Math.Abs(sizeOfArr2);

            int[] array2 = new int[sizeOfArr2];
            for (int i = 0; i < sizeOfArr2; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

            List<int> unic = new List<int>();

            for (int i = 0;i < sizeOfArr1; i++)
            {
                if (!unic.Contains(array1[i]))
                {
                    unic.Add(array1[i]);
                }
            }
            for (int i = 0;i < sizeOfArr2; i++)
            {
                if (!unic.Contains(array2[i]))
                {
                    unic.Add(array2[i]);
                }
            }


            for (int i = 0; i < unic.Count; i++)
            {
                Console.Write($"{unic[i]} ");
            }

        }

        static void t5()
        {
            Console.Write("enter lenght: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("enter height: ");
            int B = int.Parse(Console.ReadLine());
            int[,] array = new int[A, B];

            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < B; j++)
                {
                    array[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int min = array[0, 0], max = array[0, 0];
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < B; j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
            }

            Console.WriteLine($"max = {max}, min = {min}");
        }

        static void t6()
        {
            string line = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < line.Length - 1; i++)
            {
                if (line[i] == ' ' && line[i + 1] != ' ')
                {
                    count++;
                }
            }

            Console.WriteLine(count + 1);
        }

        static void t7()
        {
            string line = Console.ReadLine();
            string[] arr = line.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                string reversed = new string(arr[i].Reverse().ToArray());
                Console.Write($"{reversed} ");
            }

        }

        static void t8()
        {
            string line = Console.ReadLine();
            line.ToLower();
            List<char> vowels = new List<char>() {'a', 'e', 'u', 'i', 'o'};
            int count = line
                .Where(elem =>
                    vowels.FirstOrDefault(vovel => elem == vovel) != '\0'
                )
                .Count();

            Console.WriteLine(count);
        }

        static void t9()
        {
            string line = Console.ReadLine().ToLower();

            string find = Console.ReadLine().ToLower();
            int count = 0;
            while (line.Contains(find))
            {
                int i = line.IndexOf(find);
                line = line.Remove(i, find.Length);
                count++;
            }

            Console.WriteLine(count);
        }
        static void GeneratePermutations(string str, int startIndex, int endIndex)
        {
            if (startIndex == endIndex)
            {
                Console.WriteLine(str);  // Виведення перестановки
            }
            else
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    // Перестановка символів
                    str = Swap(str, startIndex, i);
                    GeneratePermutations(str, startIndex + 1, endIndex);
                    // Повернення символів на місце (для інших перестановок)
                    str = Swap(str, startIndex, i);
                }
            }
        }

        // Функція для обміну символів
        static string Swap(string str, int i, int j)
        {
            char[] charArray = str.ToCharArray();
            char temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            return new string(charArray);
        }
        static void t10()
        {
            string line = Console.ReadLine();
            Console.WriteLine("enter: ");
            GeneratePermutations(line, 0, line.Length - 1);

        }

        static void t11()
        {
            string line = Console.ReadLine();
            char[] chars = line.ToCharArray();
            Dictionary<char, int> arr = new Dictionary<char, int>();

            foreach (var item in chars)
            {
                if (arr.ContainsKey(item))
                {
                    arr[item]++;
                }
                else
                {
                    arr.Add(item, 1);
                }
            }

            foreach (var para in arr)
            {
                Console.WriteLine($"{para.Key}: {para.Value}");
            }
        }
        static void Main(string[] args)
        {
            t11();

            
            Console.ReadLine();
        }
    }
}
