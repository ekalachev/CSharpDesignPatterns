using ServiceLocator;

namespace ServiceLocator
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