using DesignPatterns.ServiceLocatorPattern;

namespace DesignPatterns.ServiceLocatorPattern
{
    internal interface ICustomerService : IService
    {
        Customer GetCurrent();
        Order CreateOrder(Customer customer);
    }
}