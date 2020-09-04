using System;
using System.Collections.Generic;
using System.Text;

namespace _05Decorator.DofactoryDemo.Demo2
{
    public class Decorator : LibraryItem
    {
        protected LibraryItem libraryItem;
        public Decorator(LibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }
        public override void Display()
        {
            this.libraryItem.Display();
        }
    }
}
