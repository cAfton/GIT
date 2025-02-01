using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Para_1
{
    internal class Program
    {
        static List<int> NumbersFromConsole()
        {
            Console.WriteLine("Enter your numbers:");
            string numbersInString = Console.ReadLine();

            string[] numbersInArray = numbersInString.Split(' ');

            List<int> numbers = new List<int>();

            

            for (int i = 0; i < numbersInArray.Length; i++)
            {
                
                try
                {
                    numbers.Add(int.Parse(numbersInArray[i]));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong number");

                }
            }


            return numbers;
        }

        static int BinaryToNurmal()
        {
            Console.WriteLine("Enter your 1 and 0 number:");
            string BiN = Console.ReadLine();
            List<int> Bi = new List<int>();

            for (int i = 0;i < BiN.Length ;i++)
            {
                int? tmp = null;
                try
                {
                    tmp = int.Parse(BiN[i].ToString());
                }
                catch (FormatException)
                {
                    Console.WriteLine(BiN[i].ToString());
                    Console.WriteLine("Wrong argument for number");
                }
                if (tmp != null && tmp <= 1)
                {
                    Bi.Add((int)tmp);
                }
            }
            int finalNumber = 0;
            for (int i = 0; i < Bi.Count; i++)
            {
                if (Bi[i] == 1)
                {
                    finalNumber += (int)Math.Pow(2, i);
                }
            }
            if (finalNumber < 0)
            {
                throw new ArgumentOutOfRangeException("Olecshii loh");
            }
            return finalNumber;
        }

        static void SortN(List<int> array, bool toBigger)
        {
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array.Count; j++)
                {
                    if (toBigger)
                    {
                        if (array[i] > array[j])
                        {
                            int tmp = array[i];
                            array[i] = array[j];
                            array[j] = tmp;
                        }
                    }
                    else
                    {
                        if (array[i] < array[j])
                        {
                            int tmp = array[i];
                            array[i] = array[j];
                            array[j] = tmp;
                        }
                    }

                }

            }

        }

        static void Main(string[] args)
        {
            #region First
            List<int> numbers = NumbersFromConsole();

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
            #endregion

            #region Second
            try
            {
                Console.WriteLine(BinaryToNurmal());
            }
            catch (ArgumentOutOfRangeException exp)
            {
                Console.WriteLine(exp.Message);
            }
            

            Console.ReadLine();
            #endregion

            #region Third
            bool choiceToBigger = true;
            bool wonderCindSafe = true;
            while (wonderCindSafe)
            {
                Console.WriteLine("Enter numbers. How\'d you like to sort?\nTo smaller < (false)\nTo bigger > (true)\nEnter:");
                try
                {
                    choiceToBigger = bool.Parse(Console.ReadLine());

                    wonderCindSafe = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong value");
                }
            }



            List<int> Array = NumbersFromConsole();
            SortN(Array, choiceToBigger);

            for (int i = 0; i < Array.Count; i++)
            {
                Console.WriteLine(Array[i]);
            }
            Console.ReadLine();
            #endregion
        }
    }
}
