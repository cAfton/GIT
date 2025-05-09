using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagram1
{
    internal class Program
    {

        static int findMin(int[] array)
        {
            int minRet = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minRet)
                {
                    minRet = array[i];
                }
            }
            return minRet;
        }
        static void Main(string[] args)
        {
            Console.Write("Size of array: ");
            int size = int.Parse(Console.ReadLine());

            
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("new number: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int min = findMin(array);

            Console.Write("min number of this array is ");
            Console.WriteLine(min);
            Console.ReadLine();
            
        }
    }
}
