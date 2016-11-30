using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
namespace Agenda.Domain.Models
{
    public interface IDatabaseContext:IDisposable
    {
        DbSet<T> Set<T>() where T : class;
        DbEntityEntry Entry(object entry);
        int SaveChanges();
    }
}
