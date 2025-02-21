using CalculateHW.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateHW
{
    public class Array: ICalc
    {
        public List<int> ints { get; set; }

        public void Add(int value) {
            ints.Add(value);
        }

        public int CountDistinct()
        {
            int count = 0;
            for (int i = 0; i < ints.Count; i++)
            {
                bool isSingle = true;
                for (int j = 0; j < ints.Count; j++)
                {
                    if (ints[i] == ints[j] && i != j)
                    {
                        isSingle = false;
                    }
                }
                if (isSingle)
                {
                    count++;
                }
            }

            return count;
        }

        public int EqualToValue(int valueToCompare)
        {
            int count = 0;
            foreach (var item in ints)
            {
                if (item == valueToCompare)
                {
                    count++;
                }
            }

            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (var item in ints)
            {
                if (item > valueToCompare)
                {
                    count++;
                }
            }

            return count;
        }

        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (var item in ints)
            {
                if (item < valueToCompare)
                {
                    count++;
                }
            }

            return count;
        }
    }   
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Array array = new Array() { ints = new List<int> {1, 2, 3, 4, 5, 3, 2, 2} };
            Console.WriteLine(array.CountDistinct());
            Console.WriteLine(array.EqualToValue(2));
            Console.WriteLine(array.Greater(3));
            Console.WriteLine(array.Less(3));

            Console.ReadLine();
        }
    }
}
