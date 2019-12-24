using System;
using System.Collections.Generic;

namespace DesignPatterns.ServiceLocatorPattern
{
    public class ServiceLocator
    {
        private IDictionary<Type, IService> _registry = new Dictionary<Type, IService>();

        // TServiceType (interface) => IService
        // TServiceClass (class) => TServiceType
        public void AddService<TServiceType, TServiceClass>()
            where TServiceType : IService
            where TServiceClass : TServiceType
        {
            _registry[typeof(TServiceType)] = Activator.CreateInstance<TServiceClass>();
        }

        public T CreateService<T>()
        {
            return (T)_registry[typeof(T)];
        }
    }
}
