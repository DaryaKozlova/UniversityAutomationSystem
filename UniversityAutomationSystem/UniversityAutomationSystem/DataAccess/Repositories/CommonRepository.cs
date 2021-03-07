using System;
using System.Collections.Generic;
using UniversityAutomationSystem.DataAccess.Repositories.Interfaces;

namespace UniversityAutomationSystem.DataAccess.Repositories
{
    public class CommonRepository<T> : IRepository<T>
    {
        public T Create(T entity)
        {
            throw new NotImplementedException();
        }

        public T Update(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T FindById(Guid id)
        {
            throw new NotImplementedException();
        }

        public T Find(Func<T, bool> filter)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll(Func<T, bool> filter)
        {
            throw new NotImplementedException();
        }
    }
}