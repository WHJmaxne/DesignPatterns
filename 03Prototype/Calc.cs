using System;
using System.Collections.Generic;
using System.Text;

namespace _03Prototype
{
    public class Calc
    {
        public int V1 { get; set; }
        public int V2 { get; set; }

        public int Add()
        {
            return V1 + V2;
        }

        public int Sub()
        {
            return V1 - V2;
        }
    }
}
