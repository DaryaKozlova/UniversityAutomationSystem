using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using UniversityAutomationSystem.DataAccess.Models.Interfaces;
using UniversityAutomationSystem.DataAccess.Repositories.Interfaces;

namespace UniversityAutomationSystem.DataAccess.Repositories
{
    public abstract class CommonRepository<T> : IRepository<T> where T : class, IEntity
    {
        protected readonly DatabaseContext _context;
        protected DbSet<T> Collection;

        protected abstract IQueryable<T> CollectionWithIncludes { get; }

        protected CommonRepository(DatabaseContext databaseContext)
        {
            _context = databaseContext;
            Collection = databaseContext.Set<T>();
        }

        public virtual List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return (filter == null ? CollectionWithIncludes.ToList() : CollectionWithIncludes.Where(filter).ToList());
        }

        public T Find(Expression<Func<T, bool>> filter)
        {
            return CollectionWithIncludes.FirstOrDefault(filter);
        }

        public T First()
        {
            return CollectionWithIncludes.FirstOrDefault();
        }

        public virtual T FindById(Guid id)
        {
            return CollectionWithIncludes.FirstOrDefault(cart => cart.Id == id);
        }

        public virtual T Create(T item)
        {
            Collection.Add(item);

            var savedAmount = _context.SaveChanges();

            if (savedAmount > 0)
            {
                return item;
            }

            return null;
        }

        public virtual bool Delete(Guid id)
        {
            var entity = Collection.FirstOrDefault(e => e.Id == id);

            if (entity == null)
            {
                return false;
            }

            Collection.Remove(entity);

            var isAnyUpdated = _context.SaveChanges() > 0;

            return isAnyUpdated;

        }

        public virtual bool Update(T item)
        {
            Collection.Update(item);

            var isAnyUpdated = _context.SaveChanges() > 0;

            return isAnyUpdated;
        }
    }
}