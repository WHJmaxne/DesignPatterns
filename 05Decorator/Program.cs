using _05Decorator.DofactoryDemo.CustomDemo;
using _05Decorator.DofactoryDemo.Demo1;
using _05Decorator.DofactoryDemo.Demo2;
using System;

namespace _05Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConcreteComponent component = new ConcreteComponent();
            //ConcreteDecoratorA decoratorA = new ConcreteDecoratorA();
            //ConcreteDecoratorB decoratorB = new ConcreteDecoratorB();

            //decoratorA.SetComponent(component);
            //decoratorB.SetComponent(decoratorA);

            //decoratorB.Operation();

            //BasicPerson person = new BasicPerson();
            //TShirtDecorator ts = new TShirtDecorator();
            //HeadDecorator hd = new HeadDecorator();
            //TrousersDecorator tr = new TrousersDecorator();

            //tr.SetPerson(person);
            //ts.SetPerson(tr);
            //hd.SetPerson(ts);

            //hd.Show();

            // Create book

            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            // Create video

            Video video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();

            // Make video borrowable, then borrow and display

            Console.WriteLine("\nMaking video borrowable:");

            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");

            borrowvideo.Display();

            Console.WriteLine("Hello World!");
        }
    }
}
