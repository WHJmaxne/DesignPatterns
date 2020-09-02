using System;
using System.Collections.Generic;
using System.Text;

namespace _01AbstractFactory.Shape
{
    public class CircleProvider : IShapeProvider
    {
        public IShape GetShape()
        {
            return new Circle();
        }
    }

    public class RectangleProvider : IShapeProvider
    {
        public IShape GetShape()
        {
            return new Rectangle();
        }
    }
}
