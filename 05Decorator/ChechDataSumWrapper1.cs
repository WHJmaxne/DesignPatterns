using System;
using System.Collections.Generic;
using System.Text;

namespace _05Decorator
{
    public class ChechDataSumWrapper1 : ChechDataSumWrapper
    {
        public ChechDataSumWrapper1(AbstractSum abstractSum) : base(abstractSum)
        {

        }

        public override decimal Sum(Model md)
        {
            if (md.D1 > 0)
            {
                return base.Sum(md);
            }
            else
            {
                return 0;
            }
        }
    }
}
