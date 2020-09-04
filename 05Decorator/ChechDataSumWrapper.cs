using System;
using System.Collections.Generic;
using System.Text;

namespace _05Decorator
{
    public class ChechDataSumWrapper : AbstractSum
    {
        private AbstractSum _abstractSum;
        public ChechDataSumWrapper(AbstractSum abstractSum)
        {
            _abstractSum = abstractSum;
        }
        public override decimal Sum(Model md)
        {
            return _abstractSum.Sum(md);
        }
    }
}
