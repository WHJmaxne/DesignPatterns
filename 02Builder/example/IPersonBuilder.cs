using System;
using System.Collections.Generic;
using System.Text;

namespace _02Builder.example
{
    public interface IPersonBuilder
    {
        Person BuilderPerson();
        void Body();
        void Foot();
        void Head();

    }
}
