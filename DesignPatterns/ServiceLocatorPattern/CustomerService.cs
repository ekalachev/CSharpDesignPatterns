using DesignPatterns.ServiceLocatorPattern;

namespace DesignPatterns.ServiceLocatorPattern
{
    internal class CustomerService : ICustomerService
    {
        public Order CreateOrder(Customer customer)
        {
            return new Order();
        }

        public Customer GetCurrent()
        {
            return new Customer();
        }
    }
}