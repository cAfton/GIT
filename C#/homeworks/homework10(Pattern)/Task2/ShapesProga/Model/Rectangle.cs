using ShapesProga.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesProga.Model
{
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public void Draw()
        {
            Console.WriteLine("Drawing a rectangle...");

            for (double i = 0; i < Width; i++)
            {
                Console.Write("* ");
            }

            for (double i = 1; i <= Height - 2; i++)
            {
                Console.WriteLine();

                Console.Write("* ");
                for (double j = 1; j < Width - 1; j++)
                {
                    Console.Write("  ");
                }
                Console.Write("* ");

            }
            Console.WriteLine();

            for (double i = 0; i < Width; i++)
            {
                Console.Write("* ");
            }
        }
    }
}
