using _02Builder.example;
using System;

namespace _02Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonDirector personDirector = new PersonDirector();
            var person = personDirector.ConstructPerson(new ManBuilder());
            Console.WriteLine(person.Head);
            Console.WriteLine(person.Body);
            Console.WriteLine(person.Foot);
            Console.WriteLine("Hello World!");
        }
    }
}
