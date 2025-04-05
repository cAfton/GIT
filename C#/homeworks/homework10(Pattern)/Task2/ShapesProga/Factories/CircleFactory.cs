using ShapesProga.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapesProga.Model;

namespace ShapesProga.Factories
{
    internal class CircleFactory : ShapeFactory
    {
        public override IShape CreateShape()
        {
            Console.WriteLine("Enter radius: ");
            int R = int.Parse(Console.ReadLine());

            return new Circle() { Radius = R };
        }
    }
}
