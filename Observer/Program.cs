using System;
using System.Threading;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();

            while (true)
            {

                if (dog.ObjectFound is Sprinkler)
                {
                    throw new Exception("Oh no the dog ate the sprinkler again!");
                }

                dog.Run();

                Thread.Sleep(new TimeSpan(0, 1, 0));
            }
        }
    }
}
