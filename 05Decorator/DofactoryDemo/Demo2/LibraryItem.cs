using System;
using System.Collections.Generic;
using System.Text;

namespace _05Decorator.DofactoryDemo.Demo2
{
    public abstract class LibraryItem
    {
        private int _numCopies;
        public int NumCopies
        {
            get
            {
                return _numCopies;
            }
            set
            {
                _numCopies = value;
            }
        }

        public abstract void Display();
    }
}
