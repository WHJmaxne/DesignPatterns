using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace _05Decorator.DofactoryDemo.Demo1
{
    public abstract class Decorator : Component
    {
        protected Component _component;
        public void SetComponent(Component component)
        {
            _component = component;
        }

        public override void Operation()
        {
            if (_component != null)
            {
                _component.Operation();
            }
        }
    }
}
