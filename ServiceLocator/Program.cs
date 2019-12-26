namespace ServiceLocator
{
    class Program
    {
        static void Main(string[] args)
        {
            RunServiceLocator();
        }

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
    }
}
