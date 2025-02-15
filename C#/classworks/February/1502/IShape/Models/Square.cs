using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IShapeProject.Interfaces;

namespace IShapeProject.Models
{
    public class Square : IShapeCalculate
    {
        public double Side {  get; set; }
        public double CalculateArea()
        {
            return Side * Side;
        }

        public double CalculatePerimeter()
        {
            return Side * 4;
        }
    }
}
