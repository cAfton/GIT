using ShapesProga.Factories;
using ShapesProga.Interface;
using ShapesProga.Model;

namespace ShapesProga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory circleFactory = new CircleFactory();
            IShape circle = circleFactory.CreateShape();
            circle.Draw();

            ShapeFactory rectangleFactory = new RectangleFactory();
            IShape rectangle = rectangleFactory.CreateShape();
            rectangle.Draw();

        }
    }
}
