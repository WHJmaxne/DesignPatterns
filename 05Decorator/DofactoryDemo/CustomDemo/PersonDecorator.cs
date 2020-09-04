using System;
using System.Collections.Generic;
using System.Text;

namespace _05Decorator.DofactoryDemo.CustomDemo
{
    public class PersonDecorator : Person
    {
        protected Person _person;
        public void SetPerson(Person person)
        {
            _person = person;
        }

        public override void Show()
        {
            if (_person != null)
            {
                _person.Show();
            }
        }

    }
}
