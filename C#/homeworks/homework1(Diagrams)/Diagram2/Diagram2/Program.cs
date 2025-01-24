using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagram2
{
    internal class Program
    {

        static double D(double a, double b, double c)
        {
            return Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
        }

        static double Root(double a, double b, double D)
        {
            return (-b + D) / (2 * a);
        }

        static void Main(string[] args)
        {
            double a, b, c;

            Console.WriteLine("Введіть параметри a, b та c");

            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            double Discriminator = D(a, b, c);

            if (Discriminator == 0)
            {
                Console.Write("Root = ");
                Console.WriteLine(Root(a, b, 0));
            }
            else if (Discriminator > 0)
            {
                Console.Write("Root1 = ");
                Console.WriteLine(Root(a, b, Discriminator));
                Console.Write("Root2 = ");
                Console.WriteLine(Root(a, b, -Discriminator));
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.ReadLine();
        }
    }
}