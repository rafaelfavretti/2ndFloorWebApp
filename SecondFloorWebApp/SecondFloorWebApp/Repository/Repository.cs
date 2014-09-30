using SecondFloorWebApp.DataAccess;
using SecondFloorWebApp.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecondFloorWebApp.Repository
{
    public abstract class Repository<T, K> : IRepository<T, K> where T : class
    {
        private SecondFloorContext _context;
        public Repository(SecondFloorContext context)
        {
            this._context = context;
        }
        public void insert(T entity)
        {
            this._context.Set<T>().Add(entity);
            _context.SaveChanges();
        }
        public void update(T entity)
        {
            this._context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public T findById(K id)
        {
            T entity = _context.Set<T>().Find(id);
            return entity;
        }

        public void remove(K id)
        {
            T entity = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }
    }
}