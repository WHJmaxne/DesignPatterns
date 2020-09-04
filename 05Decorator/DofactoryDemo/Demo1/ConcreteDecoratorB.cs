using System;
using System.Collections.Generic;
using System.Text;

namespace _05Decorator.DofactoryDemo.Demo1
{
    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
            Console.WriteLine("ConcreteDecoratorB.Operation()");
        }

        void AddedBehavior()
        {
            Console.WriteLine("ConcreteDecoratorB.AddedBehavior()");
        }
    }
}
