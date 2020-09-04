using System;
using System.Collections.Generic;
using System.Text;

namespace _05Decorator.DofactoryDemo.Demo2
{
    public class Borrowable : Decorator
    {
        public Borrowable(LibraryItem libraryItem) : base(libraryItem)
        {
        }

        protected List<string> borrowers = new List<string>();

        public void BorrowItem(string name)
        {
            if (libraryItem.NumCopies <= 0)
            {
                Console.WriteLine("LibraryItem count 0");
            }
            {
                borrowers.Add(name);
                libraryItem.NumCopies--;
            }
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            libraryItem.NumCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (var borrower in borrowers)
            {
                Console.WriteLine(" borrower: " + borrower);
            }
        }
    }
}
