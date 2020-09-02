using System;
using System.Collections.Generic;
using System.Text;

namespace _02Builder.example
{
    public class PersonDirector
    {
        public Person ConstructPerson(IPersonBuilder builder)
        {
            builder.Head();
            builder.Body();
            builder.Foot();
            return builder.BuilderPerson();
        }
    }
}
