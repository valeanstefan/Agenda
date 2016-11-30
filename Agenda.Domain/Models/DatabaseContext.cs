namespace Agenda.Domain.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public DatabaseContext(IConnectionFactory connectionFactory)
            : base(connectionFactory.ConnectionString)
        {
        }

        public virtual DbSet<Eveniment> Eveniments { get; set; }
        public virtual DbSet<Pacient> Pacients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Eveniment>()
                .Property(e => e.evt_name)
                .IsUnicode(false);

            modelBuilder.Entity<Pacient>()
                .Property(e => e.pac_name)
                .IsUnicode(false);

            modelBuilder.Entity<Pacient>()
                .Property(e => e.pac_mail)
                .IsUnicode(false);
        }
    }
}
