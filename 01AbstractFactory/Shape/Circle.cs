using System;
using System.Collections.Generic;
using System.Text;

namespace _01AbstractFactory.Shape
{
    public class Circle : IShape
    {
        public string Area()
        {
            return "Circle";
        }
    }

    public class Rectangle : IShape
    {
        public string Area()
        {
            return "Rectangle";
        }
    }
}
