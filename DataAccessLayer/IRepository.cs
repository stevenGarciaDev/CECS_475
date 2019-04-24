using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessLayer
{
    public interface IRepository<T> : IDisposable
    {
        void Insert(T entity);

        void Delete(T entity);

        void Update(T entity);

        T GetById(int id);

        IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate);

        IEnumerable<T> GetAll();

        T GetSingle(Func<T, bool> where, params Expression<Func<T, object>>[] navigationProperties);
    }
}