using System;
using System.Collections.Generic;

namespace UniversityAutomationSystem.DataAccess.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        T Create(T entity);
        
        T Update(T entity);

        bool Delete(T entity);
        
        T FindById(Guid id);
        
        T Find(Func<T, bool> filter);
        
        List<T> GetAll(Func<T, bool> filter);
    }
}