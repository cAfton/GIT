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
            int[] array = new int[5] {10, 3, 2, 7, 9 };

            int min = findMin(array);

            Console.Write("min number of this array is ");
            Console.WriteLine(min);
            Console.ReadLine();
            
        }
    }
}
