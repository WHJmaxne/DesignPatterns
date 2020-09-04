using System;
using System.Collections.Generic;
using System.Text;

namespace _05Decorator.DofactoryDemo.Demo1
{
    public class ConcreteDecoratorA : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA.Operation()");
        }
    }
}
