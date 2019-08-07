using System;
using System.Collections.Generic;
using System.Text;

namespace Elmosify.Repositories
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(Guid id);
        void Update(T a);
        void Delete(T a);
        T Create(T a);
    }
}
