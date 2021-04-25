using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace UniversityAutomationSystem.DataAccess.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        T First();

        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        T Find(Expression<Func<T, bool>> filter);

        T FindById(Guid id);

        T Create(T item);

        bool Delete(Guid id);

        bool Update(T item);
    }
}