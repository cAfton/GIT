using ShapesProga.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapesProga.Model;

namespace ShapesProga.Factories
{
    internal class RectangleFactory : ShapeFactory
    {
        public override IShape CreateShape()
        {
            Console.WriteLine("Enter width: ");
            int W = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            int H = int.Parse(Console.ReadLine());

            return new Rectangle() { Height = H, Width = W };
        }
    }
}
