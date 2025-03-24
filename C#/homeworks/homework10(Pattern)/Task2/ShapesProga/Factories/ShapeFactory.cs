using ShapesProga.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesProga.Factories
{
    public abstract class ShapeFactory
    {
        public abstract IShape CreateShape();
    }
}
