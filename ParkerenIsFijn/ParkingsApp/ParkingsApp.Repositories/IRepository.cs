using ParkingsApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingsApp.Repositories
{
    public interface IRepository<T> where T: BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        void Update(T entity);
        void Delete(T entity);
        T Create(T entity);
    }
}
