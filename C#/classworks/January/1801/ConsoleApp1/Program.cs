using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{ 
    public class Program
    {

        static double f(double i)
        {
            double y = Math.Pow(i, 2);
            return y;
        }
        static void Main(string[] args)
        {

            double[] name = new double[5];

        

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Enter X1, X2, DX");
            double X1, X2, DX;
            X1 = double.Parse(Console.ReadLine());
            X2 = double.Parse(Console.ReadLine());
            DX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (X2 < X1)
            {
                double tmp = X1;
                X1 = X2;
                X2 = tmp;
            }
            double i = X1;
            double Sum = 0;
            while (i <= X2)
            {
                double S = DX * f(i);
                Sum += S;
                i += DX;
            }
            Console.WriteLine(Sum);
            Console.ReadLine();
        }
    }
}
