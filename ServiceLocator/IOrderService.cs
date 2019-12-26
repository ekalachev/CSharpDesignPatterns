namespace ServiceLocator
{
    internal interface IOrderService : IService
    {
        void Save(Order order);
    }
}