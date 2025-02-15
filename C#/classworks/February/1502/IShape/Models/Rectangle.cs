using IShapeProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IShapeProject.Models
{
    public class Rectangle : IShapeCalculate
    {
        public double Side1 {  get; set; }
        public double Side2 {  get; set; }
        public double CalculateArea()
        {
            return Side1 * Side2;
        }

        public double CalculatePerimeter()
        {
            return (Side1 + Side2) * 2;
        }
    }
}
