using System;
using System.Collections.Generic;
using System.Text;

namespace _05Decorator.DofactoryDemo.CustomDemo
{
    public class HeadDecorator : PersonDecorator
    {
        public override void Show()
        {
            base.Show();
            AddScarf();
            Console.WriteLine("===戴帽子===");
        }

        void AddScarf()
        {
            Console.WriteLine("===戴头巾===");
        }
    }
}
