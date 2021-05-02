using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luminus.Selenium.Abstractions
{
    public interface IRepository
    {
    }

    public interface IRepository<T> : IRepository
        where T : IEntity
    {
        T Get(string id);
        void Save(T entity);
    }
}
