using System;
using System.Collections.Generic;
using System.Text;

namespace _03Prototype
{
    public abstract class Prototype
    {
        private string _id;

        public Prototype(string id)
        {
            this._id = id;
        }

        public string Id
        {
            get { return _id; }
        }

        public abstract Prototype Clone();
    }
}
