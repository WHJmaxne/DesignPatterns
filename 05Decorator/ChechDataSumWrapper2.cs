using System;
using System.Collections.Generic;
using System.Text;

namespace _05Decorator
{
    public class ChechDataSumWrapper2 : ChechDataSumWrapper
    {
        public ChechDataSumWrapper2(AbstractSum abstractSum) : base(abstractSum)
        {

        }

        public override decimal Sum(Model md)
        {
            if (md.D2 > 0)
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
