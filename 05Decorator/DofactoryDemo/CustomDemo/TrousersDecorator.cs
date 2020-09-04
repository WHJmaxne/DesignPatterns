using System;
using System.Collections.Generic;
using System.Text;

namespace _05Decorator.DofactoryDemo.CustomDemo
{
    public class TrousersDecorator : PersonDecorator
    {
        public override void Show()
        {
            base.Show();
            Console.WriteLine("===穿长裤===");
        }
    }
}
