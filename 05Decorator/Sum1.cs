using System;
using System.Collections.Generic;
using System.Text;

namespace _05Decorator
{
    public class Sum1 : AbstractSum
    {

        public override decimal Sum(Model md)
        {
            return md.D1 + md.D2;
        }
    }
}
