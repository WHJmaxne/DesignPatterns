using System;
using System.Collections.Generic;
using System.Text;

namespace _05Decorator.DofactoryDemo.Demo1
{
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }
}
