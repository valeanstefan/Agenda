using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Agenda.Domain.Models
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private IDatabaseContext _context;
        public Repository(IDatabaseContext context)
        {
            this._context = context;
        }
        public IQueryable<T> All()
        {
            return _context.Set<T>();
        }

        public void Delete(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
                _context.Set<T>().Attach(entity);

            _context.Set<T>().Remove(entity);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public T Find(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}