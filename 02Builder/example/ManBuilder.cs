using System;
using System.Collections.Generic;
using System.Text;

namespace _02Builder.example
{
    public class ManBuilder : IPersonBuilder
    {
        private Person _person = null;
        public ManBuilder()
        {
            _person = new Man();
        }
        public void Body()
        {
            _person.Body = "Body";
        }

        public Person BuilderPerson()
        {
            return _person;
        }

        public void Foot()
        {
            _person.Foot = "Foot";
        }

        public void Head()
        {
            _person.Head = "Head";
        }
    }
}
