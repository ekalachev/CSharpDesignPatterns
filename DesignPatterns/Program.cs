using System;
using System.Collections.Generic;
using System.Threading;
using DesignPatterns.ObserverPattern;
using DesignPatterns.ServiceLocatorPattern;
using DesignPatterns.VisitorPattern;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // ServiceLocator
            //RunServiceLocator();

            // Visitor
            //RunVisitor();

            // Observer
            //RunObserver();
        }

        #region Observer
        private static void RunObserver()
        {
            var dog = new DogForObserver();
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
        #endregion

        #region Visitor
        private static void RunVisitor()
        {
            var dogs = new List<Dog>();
            dogs.Add(new Dog { BirthDate = DateTime.Parse("1984-01-01"), DatePassed = DateTime.Parse("1990-12-12") });
            dogs.Add(new Dog { BirthDate = DateTime.Parse("1990-01-01"), DatePassed = DateTime.Parse("2001-12-12") });
            dogs.Add(new Dog { BirthDate = DateTime.Parse("1992-01-01"), DatePassed = DateTime.Parse("2004-12-12") });

            var visitor = new CalculateDogAge();
            foreach (var dog in dogs)
            {
                dog.Accept(visitor);
            }
        }
        #endregion

        #region ServiceLocator
        private static void RunServiceLocator()
        {
            var serviceLocator = Config();

            var orderService = serviceLocator.CreateService<IOrderService>();
            var customerService = serviceLocator.CreateService<ICustomerService>();

            var customer = customerService.GetCurrent();
            var order = customerService.CreateOrder(customer);
            orderService.Save(order);
        }

        private static ServiceLocator Config()
        {
            var sl = new ServiceLocator();
            sl.AddService<IOrderService, OrderService>();
            sl.AddService<ICustomerService, CustomerService>();

            return sl;
        }
        #endregion
    }
}
