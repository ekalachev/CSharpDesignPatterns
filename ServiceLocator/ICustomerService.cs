using ServiceLocator;

namespace ServiceLocator
{
    internal interface ICustomerService : IService
    {
        Customer GetCurrent();
        Order CreateOrder(Customer customer);
    }
}