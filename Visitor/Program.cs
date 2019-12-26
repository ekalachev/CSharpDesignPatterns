using System;
using System.Collections.Generic;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogs = new List<Dog>();
            dogs.Add(new Dog { BirthDate = DateTime.Parse("1984-01-01"), DatePassed = DateTime.Parse("1990-12-12") });
            dogs.Add(new Dog { BirthDate = DateTime.Parse("1990-01-01"), DatePassed = DateTime.Parse("2001-12-12") });
            dogs.Add(new Dog { BirthDate = DateTime.Parse("1992-01-01"), DatePassed = DateTime.Parse("2004-12-12") });

            var visitor = new CalculateDogAge();
            foreach (var dog in dogs)
            {
                dog.Accept(visitor);

                Console.WriteLine(dog.Age);
            }
        }
    }
}
