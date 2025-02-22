using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public static class ExtensionMethod
    {
        public static bool isOdd(this Int32 elem) 
        {
            return (elem % 2) == 0;
        }


    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;

            Console.WriteLine(number.isOdd());
            Console.ReadLine();
        }
    }
}
