using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Domain.Models
{
    public interface IRepository<T> :IDisposable where T: class, new()
    {
        IQueryable<T> All();
        T Find(int id);
        void Delete(T entity);
        void Insert(T entity);
        void Update(T entity);
        void SaveChanges();
    }
}
