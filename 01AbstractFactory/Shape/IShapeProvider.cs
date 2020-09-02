using System;
using System.Collections.Generic;
using System.Text;

namespace _01AbstractFactory.Shape
{
    public interface IShapeProvider
    {
        IShape GetShape();
    }
}
