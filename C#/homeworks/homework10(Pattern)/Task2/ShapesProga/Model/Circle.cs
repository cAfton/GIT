using ShapesProga.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesProga.Model
{
    public class Circle: IShape
    {
        public double Radius { get; set; }

        public void Draw()
        {
            Console.WriteLine("Drawing a circle...");
            for (double i = 0; i < Radius * 2 + 1; i++)
            {
                for (double j = 0; j < Radius * 2 + 1; j++)
                {
                    bool condition1 = (i - Radius) * (i - Radius) + (j - Radius) * (j - Radius) >= (Radius - 0.5) * (Radius - 0.5);
                    bool condotion2 = (i - Radius) * (i - Radius) + (j - Radius) * (j - Radius) <= (Radius + 0.5) * (Radius + 0.5);
                    if (condition1 && condotion2)
                    {
                        Console.Write(" * ");
                        continue;
                    }
                    Console.Write("   ");
                }
                Console.WriteLine();
            }
        }
    }
}
