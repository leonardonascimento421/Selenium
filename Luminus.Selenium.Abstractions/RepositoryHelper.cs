using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luminus.Selenium.Abstractions
{
    public static class RepositoryHelper
    {
        private static Dictionary<Type, object> _dicRepositories = new Dictionary<Type, object>();

        public static T GetRepository<T>()
            where T: IRepository
        {
            return (T)_dicRepositories[typeof(T)];
        }

        public static void Register<TInterface,T>(T instance)
            where TInterface : IRepository
            where T : IRepository
        {
            Type type = typeof(TInterface);

            if (_dicRepositories.ContainsKey(type))
                _dicRepositories.Remove(type);

            _dicRepositories.Add(type, instance);
        }
    }
}
