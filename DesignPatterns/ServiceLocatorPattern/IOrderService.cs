namespace DesignPatterns.ServiceLocatorPattern
{
    internal interface IOrderService : IService
    {
        void Save(Order order);
    }
}